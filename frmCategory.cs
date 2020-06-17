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
    public partial class frmCategory : Form
    {
        public frmCategory()
        {
            InitializeComponent();
        }

        private void frmCategory_Load(object sender, EventArgs e)
        {
            gv_ToaNha.DataSource = BlockDAO.Instance.GetAllBlock();
            gv_Tang.DataSource = FloorDAO.Instance.GetAllFloor();
            gv_CanHo.DataSource = ApartmentDAO.Instance.GetAllApartment();
            gv_CuDan.DataSource = ResidentDAO.Instance.GetAllResident(); ;

        }
    }
}
