using Syncfusion.Windows.Forms.Grid.Grouping;

namespace CSVGraph
{
    partial class Grid
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
            this._gridGroupingControl2 = new Syncfusion.Windows.Forms.Grid.Grouping.GridGroupingControl();
            this.sfButton1 = new Syncfusion.WinForms.Controls.SfButton();
            ((System.ComponentModel.ISupportInitialize)(this._gridGroupingControl2)).BeginInit();
            this.SuspendLayout();
            // 
            // _gridGroupingControl2
            // 
            this._gridGroupingControl2.AccessibilityEnabled = true;
            this._gridGroupingControl2.AlphaBlendSelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this._gridGroupingControl2.Appearance.AnyCell.AutoSize = true;
            this._gridGroupingControl2.Appearance.AnyCell.HorizontalAlignment = Syncfusion.Windows.Forms.Grid.GridHorizontalAlignment.Center;
            this._gridGroupingControl2.ApplyVisualStyles = false;
            this._gridGroupingControl2.BackColor = System.Drawing.SystemColors.Window;
            this._gridGroupingControl2.BlinkTime = 700;
            this._gridGroupingControl2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this._gridGroupingControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this._gridGroupingControl2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._gridGroupingControl2.GridOfficeScrollBars = Syncfusion.Windows.Forms.OfficeScrollBars.Office2016;
            this._gridGroupingControl2.GridVisualStyles = Syncfusion.Windows.Forms.GridVisualStyles.Office2016White;
            this._gridGroupingControl2.Location = new System.Drawing.Point(0, 0);
            this._gridGroupingControl2.MarkColHeader = true;
            this._gridGroupingControl2.MarkRowHeader = true;
            this._gridGroupingControl2.Name = "_gridGroupingControl2";
            this._gridGroupingControl2.Office2016ScrollBarsColorScheme = Syncfusion.Windows.Forms.ScrollBarOffice2016ColorScheme.White;
            this._gridGroupingControl2.ShowCurrentCellBorderBehavior = Syncfusion.Windows.Forms.Grid.GridShowCurrentCellBorder.GrayWhenLostFocus;
            this._gridGroupingControl2.Size = new System.Drawing.Size(1262, 675);
            this._gridGroupingControl2.TabIndex = 0;
            this._gridGroupingControl2.TableDescriptor.AllowNew = false;
            this._gridGroupingControl2.TableDescriptor.TableOptions.CaptionRowHeight = 100;
            this._gridGroupingControl2.TableDescriptor.TableOptions.ColumnHeaderRowHeight = 28;
            this._gridGroupingControl2.TableDescriptor.TableOptions.RecordRowHeight = 28;
            this._gridGroupingControl2.TableDirtyOnSourceListReset = true;
            this._gridGroupingControl2.TableOptions.AllowSelection = ((Syncfusion.Windows.Forms.Grid.GridSelectionFlags)(((Syncfusion.Windows.Forms.Grid.GridSelectionFlags.Row | Syncfusion.Windows.Forms.Grid.GridSelectionFlags.Column) 
            | Syncfusion.Windows.Forms.Grid.GridSelectionFlags.Cell)));
            this._gridGroupingControl2.TableOptions.CaptionRowHeight = 100;
            this._gridGroupingControl2.TableOptions.IndentWidth = 100;
            this._gridGroupingControl2.TableOptions.RowHeaderWidth = 100;
            this._gridGroupingControl2.TableOptions.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this._gridGroupingControl2.TableOptions.SelectionTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this._gridGroupingControl2.Text = "gridGroupingControl2";
            this._gridGroupingControl2.TopLevelGroupOptions.ShowFilterBar = true;
            this._gridGroupingControl2.UseRightToLeftCompatibleTextBox = true;
            this._gridGroupingControl2.VersionInfo = "10.404.0.53";
            // 
            // sfButton1
            // 
            this.sfButton1.AccessibleName = "Button";
            this.sfButton1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.sfButton1.Dock = System.Windows.Forms.DockStyle.Right;
            this.sfButton1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.sfButton1.Location = new System.Drawing.Point(1166, 0);
            this.sfButton1.Name = "sfButton1";
            this.sfButton1.Size = new System.Drawing.Size(96, 675);
            this.sfButton1.Style.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.sfButton1.TabIndex = 1;
            this.sfButton1.Text = "Update";
            this.sfButton1.UseVisualStyleBackColor = false;
            this.sfButton1.Click += new System.EventHandler(this.sfButton1_Click);
            // 
            // Grid
            // 
            this.ClientSize = new System.Drawing.Size(1262, 675);
            this.Controls.Add(this.sfButton1);
            this.Controls.Add(this._gridGroupingControl2);
            this.Name = "Grid";
            this.Load += new System.EventHandler(this.Grid_Load);
            ((System.ComponentModel.ISupportInitialize)(this._gridGroupingControl2)).EndInit();
            this.ResumeLayout(false);

        }
        private GridGroupingControl _gridGroupingControl2;
        #endregion

        private Syncfusion.WinForms.Controls.SfButton sfButton1;
    }
}