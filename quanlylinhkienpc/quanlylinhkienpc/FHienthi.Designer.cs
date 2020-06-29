namespace quanlylinhkienpc
{
    partial class FHienthi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FHienthi));
            this.cbbhienthi = new System.Windows.Forms.ComboBox();
            this.dgvtaikhoan = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvtaikhoan)).BeginInit();
            this.SuspendLayout();
            // 
            // cbbhienthi
            // 
            this.cbbhienthi.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cbbhienthi.FormattingEnabled = true;
            this.cbbhienthi.Location = new System.Drawing.Point(18, 32);
            this.cbbhienthi.Margin = new System.Windows.Forms.Padding(4);
            this.cbbhienthi.Name = "cbbhienthi";
            this.cbbhienthi.Size = new System.Drawing.Size(726, 27);
            this.cbbhienthi.TabIndex = 0;
            this.cbbhienthi.SelectedIndexChanged += new System.EventHandler(this.cbbhienthi_SelectedIndexChanged);
            // 
            // dgvtaikhoan
            // 
            this.dgvtaikhoan.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvtaikhoan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvtaikhoan.Location = new System.Drawing.Point(13, 84);
            this.dgvtaikhoan.Margin = new System.Windows.Forms.Padding(4);
            this.dgvtaikhoan.Name = "dgvtaikhoan";
            this.dgvtaikhoan.Size = new System.Drawing.Size(1335, 649);
            this.dgvtaikhoan.TabIndex = 1;
            // 
            // FHienthi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1368, 748);
            this.Controls.Add(this.dgvtaikhoan);
            this.Controls.Add(this.cbbhienthi);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FHienthi";
            this.Text = "Thông Tin Linh Kiện";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FHienthi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvtaikhoan)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cbbhienthi;
        private System.Windows.Forms.DataGridView dgvtaikhoan;
    }
}