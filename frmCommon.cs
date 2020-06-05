using DevExpress.Utils.VisualEffects;
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
    public partial class frmCommon : Form
    {
        public frmCommon()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            MessageBox.Show(this, "This is messege ");
            
        }
    }

}
