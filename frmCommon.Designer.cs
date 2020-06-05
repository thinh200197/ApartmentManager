namespace ApartmentManager
{
    partial class frmCommon
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
            this.plControl = new System.Windows.Forms.Panel();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.plGridview = new System.Windows.Forms.Panel();
            this.grView = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbTitleMethod = new System.Windows.Forms.Label();
            this.plControl.SuspendLayout();
            this.plGridview.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grView)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // plControl
            // 
            this.plControl.Controls.Add(this.button5);
            this.plControl.Controls.Add(this.button4);
            this.plControl.Controls.Add(this.button3);
            this.plControl.Controls.Add(this.btnDelete);
            this.plControl.Controls.Add(this.btnAdd);
            this.plControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.plControl.Location = new System.Drawing.Point(0, 0);
            this.plControl.Name = "plControl";
            this.plControl.Size = new System.Drawing.Size(873, 154);
            this.plControl.TabIndex = 0;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(118, 12);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(82, 56);
            this.button5.TabIndex = 0;
            this.button5.Text = "Sửa";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(118, 74);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(82, 56);
            this.button4.TabIndex = 0;
            this.button4.Text = "Xuất Excel";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(12, 74);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(82, 56);
            this.button3.TabIndex = 0;
            this.button3.Text = "Thêm bằng Excel";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(225, 12);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(82, 56);
            this.btnDelete.TabIndex = 0;
            this.btnDelete.Text = "Xoá";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(13, 12);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(82, 56);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Location = new System.Drawing.Point(568, 43);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(209, 20);
            this.textBox1.TabIndex = 1;
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearch.Location = new System.Drawing.Point(784, 40);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(82, 25);
            this.btnSearch.TabIndex = 0;
            this.btnSearch.Text = "Tìm kiếm";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // plGridview
            // 
            this.plGridview.Controls.Add(this.textBox1);
            this.plGridview.Controls.Add(this.btnSearch);
            this.plGridview.Controls.Add(this.grView);
            this.plGridview.Controls.Add(this.panel1);
            this.plGridview.Dock = System.Windows.Forms.DockStyle.Fill;
            this.plGridview.Location = new System.Drawing.Point(0, 154);
            this.plGridview.Name = "plGridview";
            this.plGridview.Size = new System.Drawing.Size(873, 378);
            this.plGridview.TabIndex = 0;
            // 
            // grView
            // 
            this.grView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.grView.Location = new System.Drawing.Point(0, 103);
            this.grView.Name = "grView";
            this.grView.Size = new System.Drawing.Size(873, 275);
            this.grView.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(114)))), ((int)(((byte)(172)))));
            this.panel1.Controls.Add(this.lbTitleMethod);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(873, 31);
            this.panel1.TabIndex = 2;
            // 
            // lbTitleMethod
            // 
            this.lbTitleMethod.AutoSize = true;
            this.lbTitleMethod.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitleMethod.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbTitleMethod.Location = new System.Drawing.Point(49, 3);
            this.lbTitleMethod.Name = "lbTitleMethod";
            this.lbTitleMethod.Size = new System.Drawing.Size(109, 24);
            this.lbTitleMethod.TabIndex = 1;
            this.lbTitleMethod.Text = "TitleMethod";
            // 
            // frmCommon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(873, 532);
            this.Controls.Add(this.plGridview);
            this.Controls.Add(this.plControl);
            this.Name = "frmCommon";
            this.Text = "frmCommon";
            this.plControl.ResumeLayout(false);
            this.plGridview.ResumeLayout(false);
            this.plGridview.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel plControl;
        private System.Windows.Forms.Panel plGridview;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbTitleMethod;
        private System.Windows.Forms.DataGridView grView;
    }
}