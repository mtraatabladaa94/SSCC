namespace SSCC.Views.vProduct
{
    partial class PruebaMVVM
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
            this.customerCollectionView1 = new SSCC.Views.vProduct.Views.CustomerCollectionView.CustomerCollectionView();
            this.SuspendLayout();
            // 
            // customerCollectionView1
            // 
            this.customerCollectionView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.customerCollectionView1.Location = new System.Drawing.Point(0, 0);
            this.customerCollectionView1.Name = "customerCollectionView1";
            this.customerCollectionView1.Size = new System.Drawing.Size(652, 578);
            this.customerCollectionView1.TabIndex = 0;
            // 
            // PruebaMVVM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(652, 578);
            this.Controls.Add(this.customerCollectionView1);
            this.Name = "PruebaMVVM";
            this.Text = "PruebaMVVM";
            this.ResumeLayout(false);

        }

        #endregion

        private Views.CustomerCollectionView.CustomerCollectionView customerCollectionView1;
    }
}