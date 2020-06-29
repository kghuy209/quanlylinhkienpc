namespace quanlylinhkienpc
{
    partial class Fnhapvao
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Fnhapvao));
            this.label2 = new System.Windows.Forms.Label();
            this.txbTongtien = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txbThoigian = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txbSdt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txbDiachi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txbTenkhachhang = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btntinhtien = new System.Windows.Forms.Button();
            this.dgvban = new System.Windows.Forms.DataGridView();
            this.btnban = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvban)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(412, 9);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(353, 31);
            this.label2.TabIndex = 8;
            this.label2.Text = "Thông tin linh kiện nhập vào";
            // 
            // txbTongtien
            // 
            this.txbTongtien.Enabled = false;
            this.txbTongtien.Location = new System.Drawing.Point(604, 424);
            this.txbTongtien.Name = "txbTongtien";
            this.txbTongtien.Size = new System.Drawing.Size(236, 29);
            this.txbTongtien.TabIndex = 36;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(432, 427);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(141, 21);
            this.label5.TabIndex = 35;
            this.label5.Text = "Tổng tiền phải trả";
            // 
            // txbThoigian
            // 
            this.txbThoigian.Enabled = false;
            this.txbThoigian.Location = new System.Drawing.Point(604, 380);
            this.txbThoigian.Name = "txbThoigian";
            this.txbThoigian.Size = new System.Drawing.Size(236, 29);
            this.txbThoigian.TabIndex = 34;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(432, 383);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(162, 21);
            this.label6.TabIndex = 33;
            this.label6.Text = "Thời gian thanh toán";
            // 
            // txbSdt
            // 
            this.txbSdt.Location = new System.Drawing.Point(214, 466);
            this.txbSdt.Name = "txbSdt";
            this.txbSdt.Size = new System.Drawing.Size(156, 29);
            this.txbSdt.TabIndex = 32;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(63, 469);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 21);
            this.label4.TabIndex = 31;
            this.label4.Text = "Số điện thoại";
            // 
            // txbDiachi
            // 
            this.txbDiachi.Location = new System.Drawing.Point(214, 422);
            this.txbDiachi.Name = "txbDiachi";
            this.txbDiachi.Size = new System.Drawing.Size(156, 29);
            this.txbDiachi.TabIndex = 30;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(63, 425);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 21);
            this.label1.TabIndex = 29;
            this.label1.Text = "Địa chỉ";
            // 
            // txbTenkhachhang
            // 
            this.txbTenkhachhang.Location = new System.Drawing.Point(214, 377);
            this.txbTenkhachhang.Name = "txbTenkhachhang";
            this.txbTenkhachhang.Size = new System.Drawing.Size(156, 29);
            this.txbTenkhachhang.TabIndex = 28;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(63, 380);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(143, 21);
            this.label3.TabIndex = 27;
            this.label3.Text = "Tên nhà cung cấp";
            // 
            // btntinhtien
            // 
            this.btntinhtien.Location = new System.Drawing.Point(894, 383);
            this.btntinhtien.Name = "btntinhtien";
            this.btntinhtien.Size = new System.Drawing.Size(104, 32);
            this.btntinhtien.TabIndex = 26;
            this.btntinhtien.Text = "Tính tiền";
            this.btntinhtien.UseVisualStyleBackColor = true;
            this.btntinhtien.Click += new System.EventHandler(this.btntinhtien_Click);
            // 
            // dgvban
            // 
            this.dgvban.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvban.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvban.Location = new System.Drawing.Point(31, 43);
            this.dgvban.Name = "dgvban";
            this.dgvban.Size = new System.Drawing.Size(1170, 313);
            this.dgvban.TabIndex = 25;
            // 
            // btnban
            // 
            this.btnban.BackColor = System.Drawing.Color.Transparent;
            this.btnban.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnban.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnban.Location = new System.Drawing.Point(894, 427);
            this.btnban.Margin = new System.Windows.Forms.Padding(4);
            this.btnban.Name = "btnban";
            this.btnban.Size = new System.Drawing.Size(104, 32);
            this.btnban.TabIndex = 23;
            this.btnban.Text = "Nhập vào";
            this.btnban.UseVisualStyleBackColor = false;
            this.btnban.Click += new System.EventHandler(this.btnban_Click);
            // 
            // Fnhapvao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1254, 510);
            this.Controls.Add(this.txbTongtien);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txbThoigian);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txbSdt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txbDiachi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txbTenkhachhang);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btntinhtien);
            this.Controls.Add(this.dgvban);
            this.Controls.Add(this.btnban);
            this.Controls.Add(this.label2);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Fnhapvao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nhập Thêm Linh Kiện";
            ((System.ComponentModel.ISupportInitialize)(this.dgvban)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbTongtien;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txbThoigian;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txbSdt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txbDiachi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbTenkhachhang;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btntinhtien;
        private System.Windows.Forms.DataGridView dgvban;
        private System.Windows.Forms.Button btnban;
    }
}