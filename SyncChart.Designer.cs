namespace CSVGraph
{
    partial class SyncChart
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
            this.chartControl1 = new Syncfusion.Windows.Forms.Chart.ChartControl();
            this.panel1 = new System.Windows.Forms.Panel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.dateTimePickerAdv2 = new Syncfusion.Windows.Forms.Tools.DateTimePickerAdv();
            this.dateTimePickerAdv1 = new Syncfusion.Windows.Forms.Tools.DateTimePickerAdv();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dateTimePickerAdv2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateTimePickerAdv1)).BeginInit();
            this.SuspendLayout();
            // 
            // chartControl1
            // 
            this.chartControl1.AllowUserEditStyles = true;
            this.chartControl1.BackInterior = new Syncfusion.Drawing.BrushInfo(System.Drawing.SystemColors.ControlLightLight);
            this.chartControl1.ChartArea.BackInterior = new Syncfusion.Drawing.BrushInfo(System.Drawing.Color.Transparent);
            this.chartControl1.ChartArea.CursorLocation = new System.Drawing.Point(0, 0);
            this.chartControl1.ChartArea.CursorReDraw = false;
            this.chartControl1.ChartInterior = new Syncfusion.Drawing.BrushInfo(System.Drawing.Color.Transparent);
            this.chartControl1.ColumnFixedWidth = 10;
            this.chartControl1.ColumnWidthMode = Syncfusion.Windows.Forms.Chart.ChartColumnWidthMode.RelativeWidthMode;
            this.chartControl1.CustomPalette = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(196)))), ((int)(((byte)(223))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(72)))), ((int)(((byte)(90))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(94)))), ((int)(((byte)(123))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(79)))), ((int)(((byte)(158))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(195)))), ((int)(((byte)(130))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(97)))), ((int)(((byte)(38)))))};
            this.chartControl1.DataSourceName = "[none]";
            this.chartControl1.EnableXZooming = true;
            this.chartControl1.EnableYZooming = true;
            this.chartControl1.IsWindowLess = false;
            // 
            // 
            // 
            this.chartControl1.Legend.Location = new System.Drawing.Point(801, 103);
            this.chartControl1.Legend.Margin = new System.Windows.Forms.Padding(2);
            this.chartControl1.Localize = null;
            this.chartControl1.Location = new System.Drawing.Point(0, 10);
            this.chartControl1.Margin = new System.Windows.Forms.Padding(2);
            this.chartControl1.Name = "chartControl1";
            this.chartControl1.PrimaryXAxis.LogLabelsDisplayMode = Syncfusion.Windows.Forms.Chart.LogLabelsDisplayMode.Default;
            this.chartControl1.PrimaryXAxis.Margin = true;
            this.chartControl1.PrimaryXAxis.Range = new Syncfusion.Windows.Forms.Chart.MinMaxInfo(0D, 200D, 10D);
            this.chartControl1.PrimaryXAxis.RangePaddingType = Syncfusion.Windows.Forms.Chart.ChartAxisRangePaddingType.None;
            this.chartControl1.PrimaryXAxis.RangeType = Syncfusion.Windows.Forms.Chart.ChartAxisRangeType.Set;
            this.chartControl1.PrimaryXAxis.TitleColor = System.Drawing.SystemColors.ControlText;
            this.chartControl1.PrimaryYAxis.AutoValueType = true;
            this.chartControl1.PrimaryYAxis.LogLabelsDisplayMode = Syncfusion.Windows.Forms.Chart.LogLabelsDisplayMode.Default;
            this.chartControl1.PrimaryYAxis.Margin = true;
            this.chartControl1.PrimaryYAxis.TitleColor = System.Drawing.SystemColors.ControlText;
            this.chartControl1.ShowToolbar = true;
            this.chartControl1.Size = new System.Drawing.Size(910, 525);
            this.chartControl1.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.chartControl1.StyleDialogOptions.ShowBorderTab = false;
            this.chartControl1.TabIndex = 0;
            this.chartControl1.Text = "Profilometro";
            // 
            // 
            // 
            this.chartControl1.Title.Name = "Default";
            this.chartControl1.Titles.Add(this.chartControl1.Title);
            this.chartControl1.ToolBar.Visible = true;
            this.chartControl1.VisualTheme = "";
            this.chartControl1.ZoomIn = System.Windows.Forms.Keys.W;
            this.chartControl1.ZoomOut = System.Windows.Forms.Keys.S;
            this.chartControl1.ZoomType = Syncfusion.Windows.Forms.Chart.ZoomType.MouseWheelZooming;
            this.chartControl1.Click += new System.EventHandler(this.chartControl1_Click);
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.dateTimePickerAdv2);
            this.panel1.Controls.Add(this.dateTimePickerAdv1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(914, 10);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(79, 128);
            this.panel1.TabIndex = 1;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(5, 105);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(72, 21);
            this.comboBox1.TabIndex = 6;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.chartControl1_Click);
            // 
            // dateTimePickerAdv2
            // 
            this.dateTimePickerAdv2.BorderColor = System.Drawing.Color.Empty;
            this.dateTimePickerAdv2.CalendarSize = new System.Drawing.Size(189, 176);
            this.dateTimePickerAdv2.DropDownImage = null;
            this.dateTimePickerAdv2.DropDownNormalColor = System.Drawing.SystemColors.Control;
            this.dateTimePickerAdv2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerAdv2.Location = new System.Drawing.Point(5, 62);
            this.dateTimePickerAdv2.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimePickerAdv2.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(165)))), ((int)(((byte)(220)))));
            this.dateTimePickerAdv2.MinValue = new System.DateTime(((long)(0)));
            this.dateTimePickerAdv2.Name = "dateTimePickerAdv2";
            this.dateTimePickerAdv2.Size = new System.Drawing.Size(72, 17);
            this.dateTimePickerAdv2.TabIndex = 4;
            this.dateTimePickerAdv2.Value = new System.DateTime(2018, 10, 31, 17, 16, 33, 224);
            // 
            // dateTimePickerAdv1
            // 
            this.dateTimePickerAdv1.BorderColor = System.Drawing.Color.Empty;
            this.dateTimePickerAdv1.CalendarSize = new System.Drawing.Size(189, 176);
            this.dateTimePickerAdv1.DropDownImage = null;
            this.dateTimePickerAdv1.DropDownNormalColor = System.Drawing.SystemColors.Control;
            this.dateTimePickerAdv1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerAdv1.Location = new System.Drawing.Point(5, 19);
            this.dateTimePickerAdv1.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimePickerAdv1.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(165)))), ((int)(((byte)(220)))));
            this.dateTimePickerAdv1.MinValue = new System.DateTime(((long)(0)));
            this.dateTimePickerAdv1.Name = "dateTimePickerAdv1";
            this.dateTimePickerAdv1.Size = new System.Drawing.Size(72, 17);
            this.dateTimePickerAdv1.TabIndex = 3;
            this.dateTimePickerAdv1.Value = new System.DateTime(2018, 10, 31, 17, 16, 33, 224);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(2, 89);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nome Set";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(2, 46);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "End";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(2, 3);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Start";
            // 
            // SyncChart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1004, 546);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.chartControl1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "SyncChart";
            this.Text = "Chart";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dateTimePickerAdv2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateTimePickerAdv1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Syncfusion.Windows.Forms.Chart.ChartControl chartControl1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Syncfusion.Windows.Forms.Tools.DateTimePickerAdv dateTimePickerAdv2;
        private Syncfusion.Windows.Forms.Tools.DateTimePickerAdv dateTimePickerAdv1;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}