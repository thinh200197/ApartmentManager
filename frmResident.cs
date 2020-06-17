using ApartmentManager.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ApartmentManager
{
    public partial class frmResident : Form
    {
        public frmResident()
        {
            InitializeComponent();
        }
        private void frmCustomer_Load(object sender, EventArgs e)
        {
            gv_Resident.DataSource = ResidentDAO.Instance.GetAllResident();
        }

        private void btn_Luu_Click(object sender, EventArgs e)
        {
            var maCuDan = txt_MaCuDan.Text;
            var tenCuDan = txt_TenCuDan.Text;
            var sdt = txt_SDT.Text;
            var cmnd = txt_CMND.Text;
            var ngaySinh = dtb_NgaySinh.DateTime.Date;


        }

        private void gv_Resident_AfterRowActivate(object sender, EventArgs e)
        {
            txt_MaCuDan.Text = "d";
            var tenCuDan = txt_TenCuDan.Text;
            var sdt = txt_SDT.Text;
            var cmnd = txt_CMND.Text;
            var ngaySinh = dtb_NgaySinh.DateTime.Date;
        }

        private void gv_Resident_FilterRow(object sender, Infragistics.Win.UltraWinGrid.FilterRowEventArgs e)
        {
        }
    }
}
