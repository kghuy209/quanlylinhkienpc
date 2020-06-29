namespace quanlylinhkienpc
{
    partial class FThongke
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FThongke));
            this.dgvtaikhoan = new System.Windows.Forms.DataGridView();
            this.cbbhienthi = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnXuatExcel = new System.Windows.Forms.Button();
            this.btnxuatexcel12thang = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvtaikhoan)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvtaikhoan
            // 
            this.dgvtaikhoan.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvtaikhoan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvtaikhoan.Location = new System.Drawing.Point(11, 144);
            this.dgvtaikhoan.Margin = new System.Windows.Forms.Padding(4);
            this.dgvtaikhoan.Name = "dgvtaikhoan";
            this.dgvtaikhoan.Size = new System.Drawing.Size(1363, 571);
            this.dgvtaikhoan.TabIndex = 3;
            // 
            // cbbhienthi
            // 
            this.cbbhienthi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbhienthi.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cbbhienthi.FormattingEnabled = true;
            this.cbbhienthi.Location = new System.Drawing.Point(16, 24);
            this.cbbhienthi.Margin = new System.Windows.Forms.Padding(4);
            this.cbbhienthi.Name = "cbbhienthi";
            this.cbbhienthi.Size = new System.Drawing.Size(726, 27);
            this.cbbhienthi.TabIndex = 2;
            this.cbbhienthi.SelectedIndexChanged += new System.EventHandler(this.cbbhienthi_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.button1.Location = new System.Drawing.Point(853, 24);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(358, 34);
            this.button1.TabIndex = 4;
            this.button1.Text = "Kiểm tra đủ 10 linh kiện lắp loại A  để ráp máy tính";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(355, 93);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(288, 26);
            this.textBox1.TabIndex = 5;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(670, 88);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(109, 34);
            this.button2.TabIndex = 6;
            this.button2.Text = "Tìm kiếm";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.DarkGray;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(91, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(225, 19);
            this.label1.TabIndex = 7;
            this.label1.Text = "Tìm kiếm theo tên hoặc mã linh kiện";
            // 
            // btnXuatExcel
            // 
            this.btnXuatExcel.Location = new System.Drawing.Point(844, 93);
            this.btnXuatExcel.Name = "btnXuatExcel";
            this.btnXuatExcel.Size = new System.Drawing.Size(144, 30);
            this.btnXuatExcel.TabIndex = 8;
            this.btnXuatExcel.Text = "Xuất Tất cả ra Excel";
            this.btnXuatExcel.UseVisualStyleBackColor = true;
            this.btnXuatExcel.Click += new System.EventHandler(this.btnXuatExcel_Click);
            // 
            // btnxuatexcel12thang
            // 
            this.btnxuatexcel12thang.Location = new System.Drawing.Point(1021, 94);
            this.btnxuatexcel12thang.Name = "btnxuatexcel12thang";
            this.btnxuatexcel12thang.Size = new System.Drawing.Size(302, 30);
            this.btnxuatexcel12thang.TabIndex = 9;
            this.btnxuatexcel12thang.Text = "Xuất linh kiện bảo hành hơn 12 tháng ra Excel";
            this.btnxuatexcel12thang.UseVisualStyleBackColor = true;
            this.btnxuatexcel12thang.Click += new System.EventHandler(this.btnxuatexcel12thang_Click);
            // 
            // FThongke
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 719);
            this.Controls.Add(this.btnxuatexcel12thang);
            this.Controls.Add(this.btnXuatExcel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgvtaikhoan);
            this.Controls.Add(this.cbbhienthi);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FThongke";
            this.Text = "Thống Kê Linh Kiện";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FThongke_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvtaikhoan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvtaikhoan;
        private System.Windows.Forms.ComboBox cbbhienthi;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnXuatExcel;
        private System.Windows.Forms.Button btnxuatexcel12thang;
    }
}