using System;
using System.Drawing;
using System.Windows.Forms;

namespace ApartmentManager
{
    public partial class Layout : Form
    {
        private Button currentButton;
        public Layout()
        {
            InitializeComponent();
        }
        private void ActivateButton(object btnSender)
        {
            if (btnSender != null)
            {
                if (currentButton != (Button)btnSender)
                {
                    DisableButton();
                    currentButton = (Button)btnSender;
                    lbTextMenu.Text = currentButton.Text;
                    currentButton.BackColor = Color.FromArgb(33, 150, 243);
                    currentButton.ForeColor = SystemColors.ButtonHighlight;
                    currentButton.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
                }
            }
        }
        private void DisableButton()
        {
            foreach (Control previousBtn in plMenu.Controls)
            {
                if (previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = Color.FromArgb(42, 114, 172);
                    previousBtn.ForeColor = SystemColors.ButtonHighlight;
                    previousBtn.Font = new Font("Microsoft Sans Serif", 8.5F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
                }
            }
        }
        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                subMenu.Visible = true;
            }
            else
            {
                subMenu.Visible = false;
            }
        }

        private void AddForm(Form frmCurrent)
        {
            plContainer.Controls.Clear();
            frmCurrent.TopLevel = false;
            plContainer.Controls.Add(frmCurrent);
            frmCurrent.FormBorderStyle = FormBorderStyle.None;
            frmCurrent.Dock = DockStyle.Fill;
            frmCurrent.Show();
        }

        private void btnSystem_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);           
        }
        private void btnService_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            AddForm(new frmRecurringService());
        }

        private void btnBlock_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            AddForm(new frmApartment());
        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Logo_Paint(object sender, PaintEventArgs e)
        {
            lbTextMenu.Text = "Trang chủ";
            
        }

        private void label2_Click(object sender, EventArgs e)
        {
            lbTextMenu.Text = "Trang chủ";
            plContainer.Controls.Clear();
        }
    }
}
