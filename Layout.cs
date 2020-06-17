using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace ApartmentManager
{
    public partial class frmLayout : Form
    {
        public frmLayout()
        {
            InitializeComponent();


            lbLogin.Text = $"User: { LoggedUser.UserName}";
        }

        private bool IsNeedOpen(Type f)
        {
            return !this.MdiChildren?.Any(child => child.Name == f.Name) ?? false;
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void quảnLýChungCưToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (IsNeedOpen(typeof(frmCategory)))
            {
                frmCategory child = new frmCategory();
                child.MdiParent = this;
                child.Show();
            }
            else
            {
                var f = this.MdiChildren.FirstOrDefault(child => child.GetType() == typeof(frmCategory));
                f.Activate();
            }
        }

        private void showFormActive(Form f)
        {
            var frmType = f.GetType();
            if (IsNeedOpen(frmType))
            {
                frmCategory child = new frmCategory();
                child.MdiParent = this;
                child.Show();
            }
            else
            {
                var frm = this.MdiChildren.FirstOrDefault(child => child.GetType() == frmType);
                frm.Activate();
            }
        }

        private void tìmKiếmCưDânToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (IsNeedOpen(typeof(frmRegisteredResident)))
            {
                frmRegisteredResident child = new frmRegisteredResident();
                child.MdiParent = this;
                child.Show();
            }
            else
            {
                var f = this.MdiChildren.FirstOrDefault(child => child.GetType() == typeof(frmRegisteredResident));
                f.Activate();
            }            
        }

        private void ultraPictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
