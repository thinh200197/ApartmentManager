namespace ApartmentManager
{
    partial class frmBlock
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
            Infragistics.Win.Appearance appearance42 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance43 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance44 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance45 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance46 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance47 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance48 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance49 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance50 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance51 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance76 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance77 = new Infragistics.Win.Appearance();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtBlockName = new System.Windows.Forms.TextBox();
            this.cbBlockCode = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.grvBlock = new Infragistics.Win.UltraWinGrid.UltraGrid();
            this.dBQLCCDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dB_QLCCDataSet = new ApartmentManager.DB_QLCCDataSet();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grvBlock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBQLCCDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_QLCCDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtBlockName);
            this.groupBox1.Controls.Add(this.cbBlockCode);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(291, 113);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // txtBlockName
            // 
            this.txtBlockName.Location = new System.Drawing.Point(121, 51);
            this.txtBlockName.Name = "txtBlockName";
            this.txtBlockName.Size = new System.Drawing.Size(121, 20);
            this.txtBlockName.TabIndex = 2;
            // 
            // cbBlockCode
            // 
            this.cbBlockCode.FormattingEnabled = true;
            this.cbBlockCode.Location = new System.Drawing.Point(121, 24);
            this.cbBlockCode.Name = "cbBlockCode";
            this.cbBlockCode.Size = new System.Drawing.Size(121, 21);
            this.cbBlockCode.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(39, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tên toà nhà";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(39, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã toà nhà";
            // 
            // grvBlock
            // 
            appearance42.BackColor = System.Drawing.SystemColors.Window;
            appearance42.BorderColor = System.Drawing.SystemColors.InactiveCaption;
            this.grvBlock.DisplayLayout.Appearance = appearance42;
            this.grvBlock.DisplayLayout.AutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.ExtendLastColumn;
            this.grvBlock.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Rounded3;
            this.grvBlock.DisplayLayout.BorderStyleCaption = Infragistics.Win.UIElementBorderStyle.Rounded3;
            this.grvBlock.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.False;
            this.grvBlock.DisplayLayout.DefaultSelectedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            appearance43.BackColor = System.Drawing.SystemColors.ActiveBorder;
            appearance43.BackColor2 = System.Drawing.SystemColors.ControlDark;
            appearance43.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            appearance43.BorderColor = System.Drawing.SystemColors.Window;
            this.grvBlock.DisplayLayout.GroupByBox.Appearance = appearance43;
            appearance44.ForeColor = System.Drawing.SystemColors.GrayText;
            this.grvBlock.DisplayLayout.GroupByBox.BandLabelAppearance = appearance44;
            this.grvBlock.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid;
            appearance45.BackColor = System.Drawing.SystemColors.ControlLightLight;
            appearance45.BackColor2 = System.Drawing.SystemColors.Control;
            appearance45.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal;
            appearance45.ForeColor = System.Drawing.SystemColors.GrayText;
            this.grvBlock.DisplayLayout.GroupByBox.PromptAppearance = appearance45;
            this.grvBlock.DisplayLayout.MaxColScrollRegions = 1;
            this.grvBlock.DisplayLayout.MaxRowScrollRegions = 1;
            appearance46.BackColor = System.Drawing.SystemColors.Window;
            appearance46.ForeColor = System.Drawing.SystemColors.ControlText;
            this.grvBlock.DisplayLayout.Override.ActiveCellAppearance = appearance46;
            appearance47.BackColor = System.Drawing.SystemColors.Highlight;
            appearance47.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.grvBlock.DisplayLayout.Override.ActiveRowAppearance = appearance47;
            this.grvBlock.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Dotted;
            this.grvBlock.DisplayLayout.Override.BorderStyleRow = Infragistics.Win.UIElementBorderStyle.Dotted;
            appearance48.BackColor = System.Drawing.SystemColors.Window;
            this.grvBlock.DisplayLayout.Override.CardAreaAppearance = appearance48;
            appearance49.BorderColor = System.Drawing.Color.Silver;
            appearance49.TextTrimming = Infragistics.Win.TextTrimming.EllipsisCharacter;
            this.grvBlock.DisplayLayout.Override.CellAppearance = appearance49;
            this.grvBlock.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect;
            this.grvBlock.DisplayLayout.Override.CellPadding = 0;
            appearance50.BackColor = System.Drawing.SystemColors.Control;
            appearance50.BackColor2 = System.Drawing.SystemColors.ControlDark;
            appearance50.BackGradientAlignment = Infragistics.Win.GradientAlignment.Element;
            appearance50.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal;
            appearance50.BorderColor = System.Drawing.SystemColors.Window;
            this.grvBlock.DisplayLayout.Override.GroupByRowAppearance = appearance50;
            appearance51.TextHAlignAsString = "Left";
            this.grvBlock.DisplayLayout.Override.HeaderAppearance = appearance51;
            this.grvBlock.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti;
            this.grvBlock.DisplayLayout.Override.HeaderStyle = Infragistics.Win.HeaderStyle.WindowsXPCommand;
            appearance76.BackColor = System.Drawing.SystemColors.Window;
            appearance76.BorderColor = System.Drawing.Color.Silver;
            this.grvBlock.DisplayLayout.Override.RowAppearance = appearance76;
            this.grvBlock.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.ExtendFirstColumn;
            this.grvBlock.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.False;
            appearance77.BackColor = System.Drawing.SystemColors.ControlLight;
            this.grvBlock.DisplayLayout.Override.TemplateAddRowAppearance = appearance77;
            this.grvBlock.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill;
            this.grvBlock.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate;
            this.grvBlock.DisplayLayout.SelectionOverlayBorderColor = System.Drawing.Color.Yellow;
            this.grvBlock.DisplayLayout.SelectionOverlayBorderThickness = 1;
            this.grvBlock.DisplayLayout.SelectionOverlayColor = System.Drawing.Color.Yellow;
            this.grvBlock.DisplayLayout.UseFixedHeaders = true;
            this.grvBlock.DisplayLayout.ViewStyle = Infragistics.Win.UltraWinGrid.ViewStyle.SingleBand;
            this.grvBlock.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.grvBlock.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grvBlock.Location = new System.Drawing.Point(0, 133);
            this.grvBlock.Margin = new System.Windows.Forms.Padding(5);
            this.grvBlock.Name = "grvBlock";
            this.grvBlock.Size = new System.Drawing.Size(333, 274);
            this.grvBlock.TabIndex = 19;
            this.grvBlock.ClickCell += new Infragistics.Win.UltraWinGrid.ClickCellEventHandler(this.grvBlock_ClickCell);
            // 
            // dBQLCCDataSetBindingSource
            // 
            this.dBQLCCDataSetBindingSource.DataSource = this.dB_QLCCDataSet;
            this.dBQLCCDataSetBindingSource.Position = 0;
            // 
            // dB_QLCCDataSet
            // 
            this.dB_QLCCDataSet.DataSetName = "DB_QLCCDataSet";
            this.dB_QLCCDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // frmBlock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(333, 407);
            this.Controls.Add(this.grvBlock);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmBlock";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Toà nhà";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grvBlock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBQLCCDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_QLCCDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbBlockCode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBlockName;
        private System.Windows.Forms.Label label2;
        private Infragistics.Win.UltraWinGrid.UltraGrid grvBlock;
        private System.Windows.Forms.BindingSource dBQLCCDataSetBindingSource;
        private DB_QLCCDataSet dB_QLCCDataSet;
    }
}