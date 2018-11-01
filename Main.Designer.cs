
namespace CSVGraph
{
    partial class Main
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.sfButton4 = new Syncfusion.WinForms.Controls.SfButton();
            this.sfButton3 = new Syncfusion.WinForms.Controls.SfButton();
            this.sfButton2 = new Syncfusion.WinForms.Controls.SfButton();
            this.sfButton1 = new Syncfusion.WinForms.Controls.SfButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.sfButton4);
            this.panel1.Controls.Add(this.sfButton3);
            this.panel1.Controls.Add(this.sfButton2);
            this.panel1.Controls.Add(this.sfButton1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 502);
            this.panel1.TabIndex = 4;
            // 
            // sfButton4
            // 
            this.sfButton4.AccessibleName = "Button";
            this.sfButton4.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.sfButton4.Location = new System.Drawing.Point(0, 165);
            this.sfButton4.Name = "sfButton4";
            this.sfButton4.Size = new System.Drawing.Size(197, 48);
            this.sfButton4.TabIndex = 3;
            this.sfButton4.Text = "Chart";
            this.sfButton4.Click += new System.EventHandler(this.sfButton4_Click);
            // 
            // sfButton3
            // 
            this.sfButton3.AccessibleName = "Button";
            this.sfButton3.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.sfButton3.Location = new System.Drawing.Point(0, 111);
            this.sfButton3.Name = "sfButton3";
            this.sfButton3.Size = new System.Drawing.Size(197, 48);
            this.sfButton3.TabIndex = 2;
            this.sfButton3.Text = "Grid";
            this.sfButton3.Click += new System.EventHandler(this.sfButton3_Click);
            // 
            // sfButton2
            // 
            this.sfButton2.AccessibleName = "Button";
            this.sfButton2.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.sfButton2.Location = new System.Drawing.Point(0, 57);
            this.sfButton2.Name = "sfButton2";
            this.sfButton2.Size = new System.Drawing.Size(197, 48);
            this.sfButton2.TabIndex = 1;
            this.sfButton2.Text = "Connection";
            this.sfButton2.Click += new System.EventHandler(this.sfButton2_Click);
            // 
            // sfButton1
            // 
            this.sfButton1.AccessibleName = "Button";
            this.sfButton1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.sfButton1.Location = new System.Drawing.Point(0, 3);
            this.sfButton1.Name = "sfButton1";
            this.sfButton1.Size = new System.Drawing.Size(197, 48);
            this.sfButton1.TabIndex = 0;
            this.sfButton1.Text = "CSV Import";
            this.sfButton1.Click += new System.EventHandler(this.sfButton1_Click);
            // 
            // panel2
            // 
            this.panel2.AutoSize = true;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(202, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1103, 502);
            this.panel2.TabIndex = 5;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(1307, 506);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Main";
            this.Style.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Text = "CSV Graph";
            this.Load += new System.EventHandler(this.Main_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private Syncfusion.WinForms.Controls.SfButton sfButton4;
        private Syncfusion.WinForms.Controls.SfButton sfButton3;
        private Syncfusion.WinForms.Controls.SfButton sfButton2;
        private Syncfusion.WinForms.Controls.SfButton sfButton1;
        private System.Windows.Forms.Panel panel2;
    }
}