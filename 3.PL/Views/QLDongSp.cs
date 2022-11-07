using _1.DAL.Repositories.Models;
using _2.BUS.IService;
using _2.BUS.Services;
using _2.BUS.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3.PL.Views
{
    public partial class QLDongSp : Form
    {
        private IQLDongSpService _iqLDongSpService = new QLDongSPService();
        private readonly List<DongSp> _lstDongSp;
        public Guid SelectID { get; set; }
        public QLDongSp()
        {
            InitializeComponent();
            _lstDongSp = new List<DongSp>();
            loadData();
        }
        public void loadData()
        {
            int i = 1;
            dtg_showdongsp.ColumnCount = 4;
            dtg_showdongsp.Columns[1].Name = "Id";
            dtg_showdongsp.Columns[1].Visible = false;
            dtg_showdongsp.Columns[0].Name = "Số thứ tự";
            dtg_showdongsp.Columns[2].Name = "Mã";
            dtg_showdongsp.Columns[3].Name = "Tên màu";
            dtg_showdongsp.Rows.Clear();
            var lstdongsp = _iqLDongSpService.GetAllDongSp();
            if (tb_timkiem.Text != "")
            {
                lstdongsp = lstdongsp.Where(x => x.Ma.ToLower().Contains(tb_timkiem.Text.ToLower()) || x.Ten.ToLower().Contains(tb_timkiem.Text.ToLower())).ToList();
            }
            foreach (var x in lstdongsp)
            {
                dtg_showdongsp.Rows.Add(i++, x.Id, x.Ma, x.Ten);
            }

        }
        private void bt_themdong_Click(object sender, EventArgs e)
        {
            if (tb_madong.Text == "")
            {
                MessageBox.Show("Vui lòng nhập mã màu");
            }
            else if (_iqLDongSpService.GetAllDongSp().Any(x => x.Ma == tb_madong.Text))
            {
                MessageBox.Show("Mã màu đã tồn tại");
            }
            else
            {
                DongSpView dongspview = new DongSpView();
                dongspview.Id = new Guid();
                dongspview.Ma = tb_madong.Text;
                dongspview.Ten = tb_tendong.Text;
               MessageBox.Show(_iqLDongSpService.addDongSpc(dongspview));
                loadData();
            }
        }

        private void dtg_showdongsp_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tb_madong.Text = dtg_showdongsp.CurrentRow.Cells[2].Value.ToString();
            tb_tendong.Text = dtg_showdongsp.CurrentRow.Cells[3].Value.ToString();
            SelectID = Guid.Parse(Convert.ToString(dtg_showdongsp.CurrentRow.Cells[1].Value));
        }

        private void bt_suadong_Click(object sender, EventArgs e)
        {

            DongSpView dongspview = new DongSpView();
            dongspview.Id = new Guid();
            dongspview.Ma = tb_madong.Text;
            dongspview.Ten = tb_tendong.Text;
            MessageBox.Show(_iqLDongSpService.updateDongSp(dongspview));
            loadData();
        }

        private void bt_xoadong_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn có chắc chắn muốn xoa dòng sản phẩm không", "Thông báo", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                DongSpView dongspview = new DongSpView();
                dongspview.Id = new Guid();               
                MessageBox.Show(_iqLDongSpService.deleteDongSp(dongspview));
                loadData();
            }
        }

        private void tb_timkiem_TextChanged(object sender, EventArgs e)
        {
            loadData();
        }

        private void dtg_showdongsp_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
