using ApartmentManager.DAO;
using Microsoft.VisualBasic;
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
    public partial class frmRegisteredResident : frmCommon
    {
        public frmRegisteredResident()
        {
            InitializeComponent();
        }

        private void frmRegisteredResident_Load(object sender, EventArgs e)
        {
            gv_RegisteredResident.DataSource = ResidentApartmentDAO.Instance.GetAllResidentApartment();
        }


        private void gv_RegisteredResident_ClickCell(object sender, Infragistics.Win.UltraWinGrid.ClickCellEventArgs e)
        {
            var activeRow = gv_RegisteredResident.ActiveRow;
            if (activeRow == null)
                return;
            txt_ID.Text = activeRow.GetCellValue("ID").ToString();
            txt_MaCuDan.Text = activeRow.GetCellValue("MACUDAN").ToString();
            txt_MaCanHo.Text = activeRow.GetCellValue("MACANHO").ToString();
            txt_NgayVaoO.Text = activeRow.GetCellValue("NGAYBATDAUO").ToString();
            txt_NgayHetO.Text = activeRow.GetCellValue("NGAYHETO").ToString();
        }
        public override void Insert()
        {
            var maCuDan = txt_MaCuDan.Text;
            var maCanHo = txt_MaCanHo.Text;

            if (string.IsNullOrEmpty(maCuDan) || string.IsNullOrEmpty(maCanHo))
            {
                return;
            }

            var insert = ResidentApartmentDAO.Instance.Insert(maCanHo, maCuDan);

            if (insert)
            {
                gv_RegisteredResident.DataSource = ResidentApartmentDAO.Instance.GetAllResidentApartment();
                MessageBox.Show("Thêm dữ liệu thành công.", "Thông báo", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("Thêm dữ liệu thất bại.", "Thông báo", MessageBoxButtons.OK);
            }
        }

        public override void Update()
        {
            int id = txt_ID.Text == "" ? -1 : int.Parse(txt_ID.Text);
            var maCuDan = txt_MaCuDan.Text;
            var maCanHo = txt_MaCanHo.Text;
            var ngayVaoO = DateTime.Parse(txt_NgayVaoO.Text);
            var ngayHetO = DateTime.Parse(txt_NgayHetO.Text);

            if (id == -1)
            {
                return;
            }
            try
            {
                var update = ResidentApartmentDAO.Instance.Update(id, maCanHo, maCuDan, ngayVaoO, ngayHetO);

                if (update)
                {
                    gv_RegisteredResident.DataSource = ResidentApartmentDAO.Instance.GetAllResidentApartment();
                    MessageBox.Show("Cập nhật dữ liệu thành công.", "Thông báo", MessageBoxButtons.OK);
                }
                else
                {
                    MessageBox.Show("Cập nhật dữ liệu thất bại.", "Thông báo", MessageBoxButtons.OK);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Cập nhật dữ liệu thất bại.", "Thông báo", MessageBoxButtons.OK);
            }
           
        }

        public override void Delete()
        {
            var id = txt_ID.Text == "" ? -1 : int.Parse(txt_ID.Text);

            if (MessageBox.Show("Bạn có muốn xoá nhân khẩu ?","Thông báo",MessageBoxButtons.YesNo) == DialogResult.No)
            {
                return;
            }

            MessageBox.Show("Chưa có chức năng xoá.", "Thông báo", MessageBoxButtons.OK);
            //var update = ResidentApartmentDAO.Instance.de(id, maCanHo, maCuDan, ngayVaoO, ngayHetO);

            //if (update)
            //{
            //    gv_RegisteredResident.DataSource = ResidentApartmentDAO.Instance.GetAllResidentApartment();
            //    MessageBox.Show("Cập nhật dữ liệu thành công.", "Thông báo", MessageBoxButtons.OK);
            //}
            //else
            //{
            //    MessageBox.Show("Cập nhật dữ liệu thất bại.", "Thông báo", MessageBoxButtons.OK);
            //}
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Update();
        }
    }
}
