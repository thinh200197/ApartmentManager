namespace ApartmentManager
{
    partial class frmRegisteredResident
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
            this.components = new System.ComponentModel.Container();
            Infragistics.Win.Appearance appearance1 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridBand ultraGridBand1 = new Infragistics.Win.UltraWinGrid.UltraGridBand("CUDAN-CANHO", -1);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn1 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("MACUDAN");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn2 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("MACANHO");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn3 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("NGAYVAOO");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn4 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("NGAYHETO");
            Infragistics.Win.Appearance appearance2 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance4 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance3 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance7 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance10 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance12 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance8 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance6 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance5 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance11 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance9 = new Infragistics.Win.Appearance();
            this.gv_RegisteredResident = new Infragistics.Win.UltraWinGrid.UltraGrid();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_MaCuDan = new Infragistics.Win.UltraWinEditors.UltraTextEditor();
            this.dB_QLCCDataSet = new ApartmentManager.DB_QLCCDataSet();
            this.cUDANCANHOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cUDAN_CANHOTableAdapter = new ApartmentManager.DB_QLCCDataSetTableAdapters.CUDAN_CANHOTableAdapter();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_MaCanHo = new Infragistics.Win.UltraWinEditors.UltraTextEditor();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_NgayVaoO = new Infragistics.Win.UltraWinEditors.UltraTextEditor();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_NgayHetO = new Infragistics.Win.UltraWinEditors.UltraTextEditor();
            ((System.ComponentModel.ISupportInitialize)(this.gv_RegisteredResident)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_MaCuDan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_QLCCDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cUDANCANHOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_MaCanHo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_NgayVaoO)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_NgayHetO)).BeginInit();
            this.SuspendLayout();
            // 
            // gv_RegisteredResident
            // 
            this.gv_RegisteredResident.DataSource = this.cUDANCANHOBindingSource;
            appearance1.BackColor = System.Drawing.SystemColors.Window;
            appearance1.BorderColor = System.Drawing.SystemColors.InactiveCaption;
            this.gv_RegisteredResident.DisplayLayout.Appearance = appearance1;
            ultraGridColumn1.Header.VisiblePosition = 0;
            ultraGridColumn2.Header.VisiblePosition = 1;
            ultraGridColumn3.Header.VisiblePosition = 2;
            ultraGridColumn4.Header.VisiblePosition = 3;
            ultraGridBand1.Columns.AddRange(new object[] {
            ultraGridColumn1,
            ultraGridColumn2,
            ultraGridColumn3,
            ultraGridColumn4});
            this.gv_RegisteredResident.DisplayLayout.BandsSerializer.Add(ultraGridBand1);
            this.gv_RegisteredResident.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid;
            this.gv_RegisteredResident.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.False;
            appearance2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            appearance2.BackColor2 = System.Drawing.SystemColors.ControlDark;
            appearance2.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            appearance2.BorderColor = System.Drawing.SystemColors.Window;
            this.gv_RegisteredResident.DisplayLayout.GroupByBox.Appearance = appearance2;
            appearance4.ForeColor = System.Drawing.SystemColors.GrayText;
            this.gv_RegisteredResident.DisplayLayout.GroupByBox.BandLabelAppearance = appearance4;
            this.gv_RegisteredResident.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid;
            appearance3.BackColor = System.Drawing.SystemColors.ControlLightLight;
            appearance3.BackColor2 = System.Drawing.SystemColors.Control;
            appearance3.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal;
            appearance3.ForeColor = System.Drawing.SystemColors.GrayText;
            this.gv_RegisteredResident.DisplayLayout.GroupByBox.PromptAppearance = appearance3;
            this.gv_RegisteredResident.DisplayLayout.MaxColScrollRegions = 1;
            this.gv_RegisteredResident.DisplayLayout.MaxRowScrollRegions = 1;
            appearance7.BackColor = System.Drawing.SystemColors.Window;
            appearance7.ForeColor = System.Drawing.SystemColors.ControlText;
            this.gv_RegisteredResident.DisplayLayout.Override.ActiveCellAppearance = appearance7;
            appearance10.BackColor = System.Drawing.SystemColors.Highlight;
            appearance10.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.gv_RegisteredResident.DisplayLayout.Override.ActiveRowAppearance = appearance10;
            this.gv_RegisteredResident.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.True;
            this.gv_RegisteredResident.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Dotted;
            this.gv_RegisteredResident.DisplayLayout.Override.BorderStyleRow = Infragistics.Win.UIElementBorderStyle.Dotted;
            appearance12.BackColor = System.Drawing.SystemColors.Window;
            this.gv_RegisteredResident.DisplayLayout.Override.CardAreaAppearance = appearance12;
            appearance8.BorderColor = System.Drawing.Color.Silver;
            appearance8.TextTrimming = Infragistics.Win.TextTrimming.EllipsisCharacter;
            this.gv_RegisteredResident.DisplayLayout.Override.CellAppearance = appearance8;
            this.gv_RegisteredResident.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText;
            this.gv_RegisteredResident.DisplayLayout.Override.CellPadding = 0;
            appearance6.BackColor = System.Drawing.SystemColors.Control;
            appearance6.BackColor2 = System.Drawing.SystemColors.ControlDark;
            appearance6.BackGradientAlignment = Infragistics.Win.GradientAlignment.Element;
            appearance6.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal;
            appearance6.BorderColor = System.Drawing.SystemColors.Window;
            this.gv_RegisteredResident.DisplayLayout.Override.GroupByRowAppearance = appearance6;
            appearance5.TextHAlignAsString = "Left";
            this.gv_RegisteredResident.DisplayLayout.Override.HeaderAppearance = appearance5;
            this.gv_RegisteredResident.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti;
            this.gv_RegisteredResident.DisplayLayout.Override.HeaderStyle = Infragistics.Win.HeaderStyle.WindowsXPCommand;
            appearance11.BackColor = System.Drawing.SystemColors.Window;
            appearance11.BorderColor = System.Drawing.Color.Silver;
            this.gv_RegisteredResident.DisplayLayout.Override.RowAppearance = appearance11;
            this.gv_RegisteredResident.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.False;
            appearance9.BackColor = System.Drawing.SystemColors.ControlLight;
            this.gv_RegisteredResident.DisplayLayout.Override.TemplateAddRowAppearance = appearance9;
            this.gv_RegisteredResident.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill;
            this.gv_RegisteredResident.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate;
            this.gv_RegisteredResident.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gv_RegisteredResident.Location = new System.Drawing.Point(0, 123);
            this.gv_RegisteredResident.Name = "gv_RegisteredResident";
            this.gv_RegisteredResident.Size = new System.Drawing.Size(514, 282);
            this.gv_RegisteredResident.TabIndex = 0;
            this.gv_RegisteredResident.Text = "ultraGrid1";
            this.gv_RegisteredResident.ClickCell += new Infragistics.Win.UltraWinGrid.ClickCellEventHandler(this.gv_RegisteredResident_ClickCell);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã Cư Dân";
            // 
            // txt_MaCuDan
            // 
            this.txt_MaCuDan.Location = new System.Drawing.Point(94, 35);
            this.txt_MaCuDan.Name = "txt_MaCuDan";
            this.txt_MaCuDan.Size = new System.Drawing.Size(149, 21);
            this.txt_MaCuDan.TabIndex = 2;
            // 
            // dB_QLCCDataSet
            // 
            this.dB_QLCCDataSet.DataSetName = "DB_QLCCDataSet";
            this.dB_QLCCDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cUDANCANHOBindingSource
            // 
            this.cUDANCANHOBindingSource.DataMember = "CUDAN-CANHO";
            this.cUDANCANHOBindingSource.DataSource = this.dB_QLCCDataSet;
            // 
            // cUDAN_CANHOTableAdapter
            // 
            this.cUDAN_CANHOTableAdapter.ClearBeforeFill = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã Căn Hộ";
            // 
            // txt_MaCanHo
            // 
            this.txt_MaCanHo.Location = new System.Drawing.Point(94, 78);
            this.txt_MaCanHo.Name = "txt_MaCanHo";
            this.txt_MaCanHo.Size = new System.Drawing.Size(149, 21);
            this.txt_MaCanHo.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(266, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Ngày Vào Ở";
            // 
            // txt_NgayVaoO
            // 
            this.txt_NgayVaoO.Location = new System.Drawing.Point(339, 35);
            this.txt_NgayVaoO.Name = "txt_NgayVaoO";
            this.txt_NgayVaoO.Size = new System.Drawing.Size(149, 21);
            this.txt_NgayVaoO.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(266, 82);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Ngày Hết Ở";
            // 
            // txt_NgayHetO
            // 
            this.txt_NgayHetO.Location = new System.Drawing.Point(339, 78);
            this.txt_NgayHetO.Name = "txt_NgayHetO";
            this.txt_NgayHetO.Size = new System.Drawing.Size(149, 21);
            this.txt_NgayHetO.TabIndex = 2;
            // 
            // frmRegisteredResident
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 405);
            this.Controls.Add(this.txt_NgayHetO);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_NgayVaoO);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_MaCanHo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_MaCuDan);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gv_RegisteredResident);
            this.Name = "frmRegisteredResident";
            this.Text = "DANH SÁCH NHÂN KHẨU";
            this.Load += new System.EventHandler(this.frmRegisteredResident_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gv_RegisteredResident)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_MaCuDan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_QLCCDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cUDANCANHOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_MaCanHo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_NgayVaoO)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_NgayHetO)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Infragistics.Win.UltraWinGrid.UltraGrid gv_RegisteredResident;
        private System.Windows.Forms.Label label1;
        private Infragistics.Win.UltraWinEditors.UltraTextEditor txt_MaCuDan;
        private DB_QLCCDataSet dB_QLCCDataSet;
        private System.Windows.Forms.BindingSource cUDANCANHOBindingSource;
        private DB_QLCCDataSetTableAdapters.CUDAN_CANHOTableAdapter cUDAN_CANHOTableAdapter;
        private System.Windows.Forms.Label label2;
        private Infragistics.Win.UltraWinEditors.UltraTextEditor txt_MaCanHo;
        private System.Windows.Forms.Label label3;
        private Infragistics.Win.UltraWinEditors.UltraTextEditor txt_NgayVaoO;
        private System.Windows.Forms.Label label4;
        private Infragistics.Win.UltraWinEditors.UltraTextEditor txt_NgayHetO;
    }
}