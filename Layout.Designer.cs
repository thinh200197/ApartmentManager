namespace ApartmentManager
{
    partial class Layout
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.plMenu = new System.Windows.Forms.Panel();
            this.btnBlock = new System.Windows.Forms.Button();
            this.btnService = new System.Windows.Forms.Button();
            this.btnSystem = new System.Windows.Forms.Button();
            this.Logo = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbAccountName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbTextMenu = new System.Windows.Forms.Label();
            this.plContainer = new System.Windows.Forms.Panel();
            this.plMenu.SuspendLayout();
            this.Logo.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // plMenu
            // 
            this.plMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(114)))), ((int)(((byte)(172)))));
            this.plMenu.Controls.Add(this.btnBlock);
            this.plMenu.Controls.Add(this.btnService);
            this.plMenu.Controls.Add(this.btnSystem);
            this.plMenu.Controls.Add(this.Logo);
            this.plMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.plMenu.Location = new System.Drawing.Point(0, 0);
            this.plMenu.Name = "plMenu";
            this.plMenu.Size = new System.Drawing.Size(250, 661);
            this.plMenu.TabIndex = 0;
            // 
            // btnBlock
            // 
            this.btnBlock.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(114)))), ((int)(((byte)(172)))));
            this.btnBlock.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnBlock.FlatAppearance.BorderSize = 0;
            this.btnBlock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBlock.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBlock.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnBlock.Location = new System.Drawing.Point(0, 168);
            this.btnBlock.Name = "btnBlock";
            this.btnBlock.Size = new System.Drawing.Size(250, 43);
            this.btnBlock.TabIndex = 5;
            this.btnBlock.Text = "TÒA NHÀ";
            this.btnBlock.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBlock.UseVisualStyleBackColor = false;
            this.btnBlock.Click += new System.EventHandler(this.btnBlock_Click);
            // 
            // btnService
            // 
            this.btnService.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(114)))), ((int)(((byte)(172)))));
            this.btnService.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnService.FlatAppearance.BorderSize = 0;
            this.btnService.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnService.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnService.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnService.Location = new System.Drawing.Point(0, 125);
            this.btnService.Name = "btnService";
            this.btnService.Size = new System.Drawing.Size(250, 43);
            this.btnService.TabIndex = 3;
            this.btnService.Text = "DỊCH VỤ";
            this.btnService.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnService.UseVisualStyleBackColor = false;
            this.btnService.Click += new System.EventHandler(this.btnService_Click);
            // 
            // btnSystem
            // 
            this.btnSystem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(114)))), ((int)(((byte)(172)))));
            this.btnSystem.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSystem.FlatAppearance.BorderSize = 0;
            this.btnSystem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSystem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSystem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSystem.Location = new System.Drawing.Point(0, 82);
            this.btnSystem.Name = "btnSystem";
            this.btnSystem.Size = new System.Drawing.Size(250, 43);
            this.btnSystem.TabIndex = 1;
            this.btnSystem.Text = "DỊCH VỤ ĐỊNH KỲ";
            this.btnSystem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSystem.UseVisualStyleBackColor = false;
            this.btnSystem.Click += new System.EventHandler(this.btnSystem_Click);
            // 
            // Logo
            // 
            this.Logo.BackColor = System.Drawing.Color.DimGray;
            this.Logo.Controls.Add(this.label2);
            this.Logo.Dock = System.Windows.Forms.DockStyle.Top;
            this.Logo.Location = new System.Drawing.Point(0, 0);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(250, 82);
            this.Logo.TabIndex = 0;
            this.Logo.Paint += new System.Windows.Forms.PaintEventHandler(this.Logo_Paint);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(73, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 31);
            this.label2.TabIndex = 0;
            this.label2.Text = "Apartment";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(210)))));
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.lbTextMenu);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(250, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(814, 45);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lbAccountName);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(615, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(199, 45);
            this.panel2.TabIndex = 2;
            // 
            // lbAccountName
            // 
            this.lbAccountName.AutoSize = true;
            this.lbAccountName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAccountName.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbAccountName.Location = new System.Drawing.Point(83, 20);
            this.lbAccountName.Name = "lbAccountName";
            this.lbAccountName.Size = new System.Drawing.Size(105, 18);
            this.lbAccountName.TabIndex = 0;
            this.lbAccountName.Text = "Tài khoản chủ ";
            this.lbAccountName.Click += new System.EventHandler(this.label1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(3, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Xin chào :";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbTextMenu
            // 
            this.lbTextMenu.AutoSize = true;
            this.lbTextMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTextMenu.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbTextMenu.Location = new System.Drawing.Point(15, 9);
            this.lbTextMenu.Name = "lbTextMenu";
            this.lbTextMenu.Size = new System.Drawing.Size(136, 31);
            this.lbTextMenu.TabIndex = 0;
            this.lbTextMenu.Text = "Trang chủ";
            // 
            // plContainer
            // 
            this.plContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.plContainer.Location = new System.Drawing.Point(250, 45);
            this.plContainer.Name = "plContainer";
            this.plContainer.Size = new System.Drawing.Size(814, 616);
            this.plContainer.TabIndex = 2;
            // 
            // Layout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1064, 661);
            this.Controls.Add(this.plContainer);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.plMenu);
            this.Name = "Layout";
            this.Text = "Layout";
            this.plMenu.ResumeLayout(false);
            this.Logo.ResumeLayout(false);
            this.Logo.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel plMenu;
        private System.Windows.Forms.Button btnSystem;
        private System.Windows.Forms.Panel Logo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnService;
        private System.Windows.Forms.Button btnBlock;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbTextMenu;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbAccountName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel plContainer;
    }
}