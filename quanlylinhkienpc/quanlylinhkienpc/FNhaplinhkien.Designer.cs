namespace quanlylinhkienpc
{
    partial class FNhaplinhkien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FNhaplinhkien));
            this.dgvtaikhoan = new System.Windows.Forms.DataGridView();
            this.btnHuongdan = new System.Windows.Forms.Button();
            this.btnCapnhat = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvtaikhoan)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvtaikhoan
            // 
            this.dgvtaikhoan.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvtaikhoan.BackgroundColor = System.Drawing.Color.White;
            this.dgvtaikhoan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvtaikhoan.Location = new System.Drawing.Point(18, 100);
            this.dgvtaikhoan.Margin = new System.Windows.Forms.Padding(4);
            this.dgvtaikhoan.Name = "dgvtaikhoan";
            this.dgvtaikhoan.Size = new System.Drawing.Size(1315, 413);
            this.dgvtaikhoan.TabIndex = 0;
            this.dgvtaikhoan.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.dgvtaikhoan_CellBeginEdit);
            this.dgvtaikhoan.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvtaikhoan_CellContentClick);
            this.dgvtaikhoan.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvtaikhoan_CellValueChanged);
            this.dgvtaikhoan.UserAddedRow += new System.Windows.Forms.DataGridViewRowEventHandler(this.dgvtaikhoan_UserAddedRow);
            // 
            // btnHuongdan
            // 
            this.btnHuongdan.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnHuongdan.Location = new System.Drawing.Point(18, 18);
            this.btnHuongdan.Margin = new System.Windows.Forms.Padding(4);
            this.btnHuongdan.Name = "btnHuongdan";
            this.btnHuongdan.Size = new System.Drawing.Size(186, 50);
            this.btnHuongdan.TabIndex = 2;
            this.btnHuongdan.Text = "Hướng dẫn";
            this.btnHuongdan.UseVisualStyleBackColor = true;
            this.btnHuongdan.Click += new System.EventHandler(this.btnHuongdan_Click);
            // 
            // btnCapnhat
            // 
            this.btnCapnhat.Location = new System.Drawing.Point(264, 26);
            this.btnCapnhat.Name = "btnCapnhat";
            this.btnCapnhat.Size = new System.Drawing.Size(154, 35);
            this.btnCapnhat.TabIndex = 3;
            this.btnCapnhat.Text = "Cập nhật lại bảng";
            this.btnCapnhat.UseVisualStyleBackColor = true;
            this.btnCapnhat.Click += new System.EventHandler(this.btnCapnhat_Click);
            // 
            // FNhaplinhkien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1346, 543);
            this.Controls.Add(this.btnCapnhat);
            this.Controls.Add(this.btnHuongdan);
            this.Controls.Add(this.dgvtaikhoan);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FNhaplinhkien";
            this.Text = "Nhập Linh Kiện";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FNhaplinhkien_FormClosing);
            this.Load += new System.EventHandler(this.FNhaplinhkien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvtaikhoan)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvtaikhoan;
        private System.Windows.Forms.Button btnHuongdan;
        private System.Windows.Forms.Button btnCapnhat;
    }
}