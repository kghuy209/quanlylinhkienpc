namespace quanlylinhkienpc
{
    partial class FtkAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FtkAdmin));
            this.dgvtaikhoan = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvtaikhoan)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvtaikhoan
            // 
            this.dgvtaikhoan.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvtaikhoan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvtaikhoan.Location = new System.Drawing.Point(14, 14);
            this.dgvtaikhoan.Name = "dgvtaikhoan";
            this.dgvtaikhoan.Size = new System.Drawing.Size(614, 340);
            this.dgvtaikhoan.TabIndex = 0;
            this.dgvtaikhoan.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.dgvtaikhoan_CellBeginEdit);
            this.dgvtaikhoan.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvtaikhoan_CellContentClick);
            this.dgvtaikhoan.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvtaikhoan_CellValueChanged);
            this.dgvtaikhoan.UserAddedRow += new System.Windows.Forms.DataGridViewRowEventHandler(this.dgvtaikhoan_UserAddedRow);
            // 
            // FtkAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(642, 368);
            this.Controls.Add(this.dgvtaikhoan);
            this.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FtkAdmin";
            this.Text = "Quản Lý Tài Khoản";
            ((System.ComponentModel.ISupportInitialize)(this.dgvtaikhoan)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvtaikhoan;
    }
}