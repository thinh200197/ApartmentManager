namespace ApartmentManager
{
    partial class frmResident
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
            Infragistics.Win.UltraWinGrid.UltraGridBand ultraGridBand1 = new Infragistics.Win.UltraWinGrid.UltraGridBand("CUDAN", -1);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn1 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("MACUDAN");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn2 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("TENCUDAN");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn3 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("NGAYSINH");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn4 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("SODIENTHOAI");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn5 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("CHUNGMINHNHANDAN");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn6 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("FK_BIENBANVIPHAM_CUDAN");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn7 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("FK_CUDAN-CANHO_CUDAN");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn8 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("FK_HOADON_DVCC_CUDAN");
            Infragistics.Win.UltraWinGrid.UltraGridBand ultraGridBand2 = new Infragistics.Win.UltraWinGrid.UltraGridBand("FK_BIENBANVIPHAM_CUDAN", 0);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn9 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("MABIENBAN");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn10 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("TENBIENBAN");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn11 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("MACUDAN");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn12 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("FK_CHITIET_VIPHAM_BIENBANVIPHAM");
            Infragistics.Win.UltraWinGrid.UltraGridBand ultraGridBand3 = new Infragistics.Win.UltraWinGrid.UltraGridBand("FK_CHITIET_VIPHAM_BIENBANVIPHAM", 1);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn13 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("MABIENBAN");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn14 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("MAVIPHAM");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn15 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("THOIGIAN_VIPHAM");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn16 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("SOLANVIPHAM");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn17 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("NOIDUNG_VIPHAM");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn18 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("HINHTHUCXULY");
            Infragistics.Win.UltraWinGrid.UltraGridBand ultraGridBand4 = new Infragistics.Win.UltraWinGrid.UltraGridBand("FK_CUDAN-CANHO_CUDAN", 0);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn19 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("MACUDAN");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn20 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("MACANHO");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn21 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("NGAYVAOO");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn22 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("NGAYHETO");
            Infragistics.Win.UltraWinGrid.UltraGridBand ultraGridBand5 = new Infragistics.Win.UltraWinGrid.UltraGridBand("FK_HOADON_DVCC_CUDAN", 0);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn23 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("MAHOADON_DVCC");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn24 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("TENHOADON_DVCC");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn25 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("TONGTIEN");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn26 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("NGAYLAP");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn27 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("MACUDAN");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn28 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("MANHANVIEN");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn29 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("FK_CHITIETHOADON_DVCC_HOADON_DVCC");
            Infragistics.Win.UltraWinGrid.UltraGridBand ultraGridBand6 = new Infragistics.Win.UltraWinGrid.UltraGridBand("FK_CHITIETHOADON_DVCC_HOADON_DVCC", 4);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn30 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("MAHOADON_DVCC");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn31 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("MAGIA_DVCC");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn32 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("MA_DVCC");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn33 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("NGAYBATDAU");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn34 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("NGAYKETTHUC");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn35 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("SOLUONG_DV");
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
            this.gv_Resident = new Infragistics.Win.UltraWinGrid.UltraGrid();
            this.cUDANBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dB_QLCCDataSet = new ApartmentManager.DB_QLCCDataSet();
            this.txt_MaCuDan = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_TenCuDan = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_SDT = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_CMND = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cUDANTableAdapter = new ApartmentManager.DB_QLCCDataSetTableAdapters.CUDANTableAdapter();
            this.dtb_NgaySinh = new Infragistics.Win.UltraWinEditors.UltraDateTimeEditor();
            this.btn_Luu = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gv_Resident)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cUDANBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_QLCCDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtb_NgaySinh)).BeginInit();
            this.SuspendLayout();
            // 
            // gv_Resident
            // 
            this.gv_Resident.DataSource = this.cUDANBindingSource;
            appearance1.BackColor = System.Drawing.SystemColors.Window;
            appearance1.BorderColor = System.Drawing.SystemColors.InactiveCaption;
            this.gv_Resident.DisplayLayout.Appearance = appearance1;
            ultraGridColumn1.Header.VisiblePosition = 0;
            ultraGridColumn2.Header.VisiblePosition = 1;
            ultraGridColumn3.Header.VisiblePosition = 2;
            ultraGridColumn4.Header.VisiblePosition = 3;
            ultraGridColumn5.Header.VisiblePosition = 4;
            ultraGridColumn6.Header.VisiblePosition = 5;
            ultraGridColumn7.Header.VisiblePosition = 6;
            ultraGridColumn8.Header.VisiblePosition = 7;
            ultraGridBand1.Columns.AddRange(new object[] {
            ultraGridColumn1,
            ultraGridColumn2,
            ultraGridColumn3,
            ultraGridColumn4,
            ultraGridColumn5,
            ultraGridColumn6,
            ultraGridColumn7,
            ultraGridColumn8});
            ultraGridColumn9.Header.VisiblePosition = 0;
            ultraGridColumn10.Header.VisiblePosition = 1;
            ultraGridColumn11.Header.VisiblePosition = 2;
            ultraGridColumn12.Header.VisiblePosition = 3;
            ultraGridBand2.Columns.AddRange(new object[] {
            ultraGridColumn9,
            ultraGridColumn10,
            ultraGridColumn11,
            ultraGridColumn12});
            ultraGridColumn13.Header.VisiblePosition = 0;
            ultraGridColumn14.Header.VisiblePosition = 1;
            ultraGridColumn15.Header.VisiblePosition = 2;
            ultraGridColumn16.Header.VisiblePosition = 3;
            ultraGridColumn17.Header.VisiblePosition = 4;
            ultraGridColumn18.Header.VisiblePosition = 5;
            ultraGridBand3.Columns.AddRange(new object[] {
            ultraGridColumn13,
            ultraGridColumn14,
            ultraGridColumn15,
            ultraGridColumn16,
            ultraGridColumn17,
            ultraGridColumn18});
            ultraGridColumn19.Header.VisiblePosition = 0;
            ultraGridColumn20.Header.VisiblePosition = 1;
            ultraGridColumn21.Header.VisiblePosition = 2;
            ultraGridColumn22.Header.VisiblePosition = 3;
            ultraGridBand4.Columns.AddRange(new object[] {
            ultraGridColumn19,
            ultraGridColumn20,
            ultraGridColumn21,
            ultraGridColumn22});
            ultraGridColumn23.Header.VisiblePosition = 0;
            ultraGridColumn24.Header.VisiblePosition = 1;
            ultraGridColumn25.Header.VisiblePosition = 2;
            ultraGridColumn26.Header.VisiblePosition = 3;
            ultraGridColumn27.Header.VisiblePosition = 4;
            ultraGridColumn28.Header.VisiblePosition = 5;
            ultraGridColumn29.Header.VisiblePosition = 6;
            ultraGridBand5.Columns.AddRange(new object[] {
            ultraGridColumn23,
            ultraGridColumn24,
            ultraGridColumn25,
            ultraGridColumn26,
            ultraGridColumn27,
            ultraGridColumn28,
            ultraGridColumn29});
            ultraGridColumn30.Header.VisiblePosition = 0;
            ultraGridColumn31.Header.VisiblePosition = 1;
            ultraGridColumn32.Header.VisiblePosition = 2;
            ultraGridColumn33.Header.VisiblePosition = 3;
            ultraGridColumn34.Header.VisiblePosition = 4;
            ultraGridColumn35.Header.VisiblePosition = 5;
            ultraGridBand6.Columns.AddRange(new object[] {
            ultraGridColumn30,
            ultraGridColumn31,
            ultraGridColumn32,
            ultraGridColumn33,
            ultraGridColumn34,
            ultraGridColumn35});
            this.gv_Resident.DisplayLayout.BandsSerializer.Add(ultraGridBand1);
            this.gv_Resident.DisplayLayout.BandsSerializer.Add(ultraGridBand2);
            this.gv_Resident.DisplayLayout.BandsSerializer.Add(ultraGridBand3);
            this.gv_Resident.DisplayLayout.BandsSerializer.Add(ultraGridBand4);
            this.gv_Resident.DisplayLayout.BandsSerializer.Add(ultraGridBand5);
            this.gv_Resident.DisplayLayout.BandsSerializer.Add(ultraGridBand6);
            this.gv_Resident.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid;
            this.gv_Resident.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.False;
            appearance2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            appearance2.BackColor2 = System.Drawing.SystemColors.ControlDark;
            appearance2.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            appearance2.BorderColor = System.Drawing.SystemColors.Window;
            this.gv_Resident.DisplayLayout.GroupByBox.Appearance = appearance2;
            appearance4.ForeColor = System.Drawing.SystemColors.GrayText;
            this.gv_Resident.DisplayLayout.GroupByBox.BandLabelAppearance = appearance4;
            this.gv_Resident.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid;
            appearance3.BackColor = System.Drawing.SystemColors.ControlLightLight;
            appearance3.BackColor2 = System.Drawing.SystemColors.Control;
            appearance3.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal;
            appearance3.ForeColor = System.Drawing.SystemColors.GrayText;
            this.gv_Resident.DisplayLayout.GroupByBox.PromptAppearance = appearance3;
            this.gv_Resident.DisplayLayout.MaxColScrollRegions = 1;
            this.gv_Resident.DisplayLayout.MaxRowScrollRegions = 1;
            appearance7.BackColor = System.Drawing.SystemColors.Window;
            appearance7.ForeColor = System.Drawing.SystemColors.ControlText;
            this.gv_Resident.DisplayLayout.Override.ActiveCellAppearance = appearance7;
            appearance10.BackColor = System.Drawing.SystemColors.Highlight;
            appearance10.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.gv_Resident.DisplayLayout.Override.ActiveRowAppearance = appearance10;
            this.gv_Resident.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Dotted;
            this.gv_Resident.DisplayLayout.Override.BorderStyleRow = Infragistics.Win.UIElementBorderStyle.Dotted;
            appearance12.BackColor = System.Drawing.SystemColors.Window;
            this.gv_Resident.DisplayLayout.Override.CardAreaAppearance = appearance12;
            appearance8.BorderColor = System.Drawing.Color.Silver;
            appearance8.TextTrimming = Infragistics.Win.TextTrimming.EllipsisCharacter;
            this.gv_Resident.DisplayLayout.Override.CellAppearance = appearance8;
            this.gv_Resident.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText;
            this.gv_Resident.DisplayLayout.Override.CellPadding = 0;
            appearance6.BackColor = System.Drawing.SystemColors.Control;
            appearance6.BackColor2 = System.Drawing.SystemColors.ControlDark;
            appearance6.BackGradientAlignment = Infragistics.Win.GradientAlignment.Element;
            appearance6.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal;
            appearance6.BorderColor = System.Drawing.SystemColors.Window;
            this.gv_Resident.DisplayLayout.Override.GroupByRowAppearance = appearance6;
            appearance5.TextHAlignAsString = "Left";
            this.gv_Resident.DisplayLayout.Override.HeaderAppearance = appearance5;
            this.gv_Resident.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti;
            this.gv_Resident.DisplayLayout.Override.HeaderStyle = Infragistics.Win.HeaderStyle.WindowsXPCommand;
            appearance11.BackColor = System.Drawing.SystemColors.Window;
            appearance11.BorderColor = System.Drawing.Color.Silver;
            this.gv_Resident.DisplayLayout.Override.RowAppearance = appearance11;
            this.gv_Resident.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.False;
            appearance9.BackColor = System.Drawing.SystemColors.ControlLight;
            this.gv_Resident.DisplayLayout.Override.TemplateAddRowAppearance = appearance9;
            this.gv_Resident.DisplayLayout.Override.WrapHeaderText = Infragistics.Win.DefaultableBoolean.False;
            this.gv_Resident.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill;
            this.gv_Resident.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate;
            this.gv_Resident.DisplayLayout.ViewStyle = Infragistics.Win.UltraWinGrid.ViewStyle.SingleBand;
            this.gv_Resident.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy;
            this.gv_Resident.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gv_Resident.Location = new System.Drawing.Point(0, 137);
            this.gv_Resident.Name = "gv_Resident";
            this.gv_Resident.Size = new System.Drawing.Size(552, 313);
            this.gv_Resident.TabIndex = 0;
            this.gv_Resident.Text = "ultraGrid1";
            this.gv_Resident.AfterRowActivate += new System.EventHandler(this.gv_Resident_AfterRowActivate);
            this.gv_Resident.FilterRow += new Infragistics.Win.UltraWinGrid.FilterRowEventHandler(this.gv_Resident_FilterRow);
            // 
            // cUDANBindingSource
            // 
            this.cUDANBindingSource.DataMember = "CUDAN";
            this.cUDANBindingSource.DataSource = this.dB_QLCCDataSet;
            // 
            // dB_QLCCDataSet
            // 
            this.dB_QLCCDataSet.DataSetName = "DB_QLCCDataSet";
            this.dB_QLCCDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txt_MaCuDan
            // 
            this.txt_MaCuDan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_MaCuDan.Location = new System.Drawing.Point(91, 23);
            this.txt_MaCuDan.Name = "txt_MaCuDan";
            this.txt_MaCuDan.Size = new System.Drawing.Size(134, 22);
            this.txt_MaCuDan.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Mã cư dân";
            // 
            // txt_TenCuDan
            // 
            this.txt_TenCuDan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_TenCuDan.Location = new System.Drawing.Point(91, 56);
            this.txt_TenCuDan.Name = "txt_TenCuDan";
            this.txt_TenCuDan.Size = new System.Drawing.Size(134, 22);
            this.txt_TenCuDan.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tên cư dân";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(260, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ngày sinh";
            // 
            // txt_SDT
            // 
            this.txt_SDT.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_SDT.Location = new System.Drawing.Point(360, 57);
            this.txt_SDT.Name = "txt_SDT";
            this.txt_SDT.Size = new System.Drawing.Size(144, 22);
            this.txt_SDT.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(260, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 16);
            this.label4.TabIndex = 2;
            this.label4.Text = "Số điện thoại";
            // 
            // txt_CMND
            // 
            this.txt_CMND.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_CMND.Location = new System.Drawing.Point(91, 91);
            this.txt_CMND.Name = "txt_CMND";
            this.txt_CMND.Size = new System.Drawing.Size(134, 22);
            this.txt_CMND.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 94);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 16);
            this.label5.TabIndex = 2;
            this.label5.Text = "CMND";
            // 
            // cUDANTableAdapter
            // 
            this.cUDANTableAdapter.ClearBeforeFill = true;
            // 
            // dtb_NgaySinh
            // 
            this.dtb_NgaySinh.Location = new System.Drawing.Point(360, 23);
            this.dtb_NgaySinh.Name = "dtb_NgaySinh";
            this.dtb_NgaySinh.Size = new System.Drawing.Size(144, 21);
            this.dtb_NgaySinh.TabIndex = 3;
            // 
            // btn_Luu
            // 
            this.btn_Luu.Location = new System.Drawing.Point(277, 94);
            this.btn_Luu.Name = "btn_Luu";
            this.btn_Luu.Size = new System.Drawing.Size(69, 34);
            this.btn_Luu.TabIndex = 4;
            this.btn_Luu.Text = "Lưu";
            this.btn_Luu.UseVisualStyleBackColor = true;
            this.btn_Luu.Click += new System.EventHandler(this.btn_Luu_Click);
            // 
            // frmResident
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(552, 450);
            this.Controls.Add(this.btn_Luu);
            this.Controls.Add(this.dtb_NgaySinh);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_CMND);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_SDT);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_TenCuDan);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_MaCuDan);
            this.Controls.Add(this.gv_Resident);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "frmResident";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "THÔNG TIN CƯ DÂN";
            this.Load += new System.EventHandler(this.frmCustomer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gv_Resident)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cUDANBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_QLCCDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtb_NgaySinh)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Infragistics.Win.UltraWinGrid.UltraGrid gv_Resident;
        private System.Windows.Forms.TextBox txt_MaCuDan;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_TenCuDan;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_SDT;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_CMND;
        private System.Windows.Forms.Label label5;
        private DB_QLCCDataSet dB_QLCCDataSet;
        private System.Windows.Forms.BindingSource cUDANBindingSource;
        private DB_QLCCDataSetTableAdapters.CUDANTableAdapter cUDANTableAdapter;
        private Infragistics.Win.UltraWinEditors.UltraDateTimeEditor dtb_NgaySinh;
        private System.Windows.Forms.Button btn_Luu;
    }
}