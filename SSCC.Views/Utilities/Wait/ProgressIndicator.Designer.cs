namespace SSCC.Views.Utilities.Wait
{
    partial class ProgressIndicator
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
            this.prWaitInfo = new DevExpress.XtraWaitForm.ProgressPanel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // prWaitInfo
            // 
            this.prWaitInfo.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.prWaitInfo.Appearance.Options.UseBackColor = true;
            this.prWaitInfo.AppearanceCaption.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.prWaitInfo.AppearanceCaption.Options.UseFont = true;
            this.prWaitInfo.AppearanceDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.prWaitInfo.AppearanceDescription.Options.UseFont = true;
            this.prWaitInfo.BarAnimationElementThickness = 2;
            this.prWaitInfo.Caption = "Por favor, Espere";
            this.prWaitInfo.Description = "Cargando ...";
            this.prWaitInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.prWaitInfo.ImageHorzOffset = 20;
            this.prWaitInfo.Location = new System.Drawing.Point(0, 17);
            this.prWaitInfo.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.prWaitInfo.Name = "prWaitInfo";
            this.prWaitInfo.Size = new System.Drawing.Size(246, 39);
            this.prWaitInfo.TabIndex = 0;
            this.prWaitInfo.Text = "progressPanel1";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.prWaitInfo, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.Padding = new System.Windows.Forms.Padding(0, 14, 0, 14);
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(246, 73);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // ProgressIndicator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(246, 73);
            this.Controls.Add(this.tableLayoutPanel1);
            this.DoubleBuffered = true;
            this.Name = "ProgressIndicator";
            this.Text = "Cargando ...";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraWaitForm.ProgressPanel prWaitInfo;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}
