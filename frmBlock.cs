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
    public partial class frmBlock : frmCommon
    {
        public frmBlock()
        {
            InitializeComponent();
            LoadDataInit();
        }
        private void LoadDataInit()
        {
            var data = BlockDAO.Instance.GetAllBlock();
            grvBlock.DataSource = data;
            cbBlockCode.DataSource = data;
            cbBlockCode.DisplayMember = "MABLOCK";
            cbBlockCode.ValueMember = "MABLOCK";            
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
