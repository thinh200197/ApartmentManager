using System;
using System.Drawing;
using System.Windows.Forms;

namespace ApartmentManager
{
    public partial class frmLayout : Form
    {
        public frmLayout()
        {
            InitializeComponent();
        }

        private void AddForm(Form frmCurrent)
        {
            //plContainer.Controls.Clear();
            frmCurrent.TopLevel = false;
            //frmLayout..Controls.Add(frmCurrent);
            frmCurrent.FormBorderStyle = FormBorderStyle.None;
            frmCurrent.Dock = DockStyle.Fill;
            frmCurrent.Show();
        }
        private void chungCưToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBlock child = new frmBlock();
            child.MdiParent = this;
            child.Show();

        }
    }
}
