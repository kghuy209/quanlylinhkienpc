namespace quanlylinhkienpc
{
    partial class FLichsuMuaban
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FLichsuMuaban));
            this.dgvNguoimua = new System.Windows.Forms.DataGridView();
            this.dgvDamua = new System.Windows.Forms.DataGridView();
            this.txbten = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txbsdt = new System.Windows.Forms.TextBox();
            this.dttngay = new System.Windows.Forms.DateTimePicker();
            this.btnTim = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnXuatBan = new System.Windows.Forms.Button();
            this.btnXuatNhap = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNguoimua)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDamua)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvNguoimua
            // 
            this.dgvNguoimua.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvNguoimua.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNguoimua.Location = new System.Drawing.Point(18, 106);
            this.dgvNguoimua.Margin = new System.Windows.Forms.Padding(4);
            this.dgvNguoimua.Name = "dgvNguoimua";
            this.dgvNguoimua.Size = new System.Drawing.Size(1356, 293);
            this.dgvNguoimua.TabIndex = 0;
            this.dgvNguoimua.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvNguoimua_CellClick);
            // 
            // dgvDamua
            // 
            this.dgvDamua.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDamua.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDamua.Location = new System.Drawing.Point(18, 426);
            this.dgvDamua.Margin = new System.Windows.Forms.Padding(4);
            this.dgvDamua.Name = "dgvDamua";
            this.dgvDamua.Size = new System.Drawing.Size(1356, 254);
            this.dgvDamua.TabIndex = 1;
            // 
            // txbten
            // 
            this.txbten.Location = new System.Drawing.Point(155, 17);
            this.txbten.Margin = new System.Windows.Forms.Padding(4);
            this.txbten.Name = "txbten";
            this.txbten.Size = new System.Drawing.Size(212, 26);
            this.txbten.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 21);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 19);
            this.label1.TabIndex = 3;
            this.label1.Text = "Tên khách hàng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(388, 22);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 19);
            this.label2.TabIndex = 5;
            this.label2.Text = "Số điện thoại";
            // 
            // txbsdt
            // 
            this.txbsdt.Location = new System.Drawing.Point(494, 19);
            this.txbsdt.Margin = new System.Windows.Forms.Padding(4);
            this.txbsdt.Name = "txbsdt";
            this.txbsdt.Size = new System.Drawing.Size(212, 26);
            this.txbsdt.TabIndex = 4;
            // 
            // dttngay
            // 
            this.dttngay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dttngay.Location = new System.Drawing.Point(920, 21);
            this.dttngay.Margin = new System.Windows.Forms.Padding(4);
            this.dttngay.Name = "dttngay";
            this.dttngay.Size = new System.Drawing.Size(192, 26);
            this.dttngay.TabIndex = 6;
            this.dttngay.ValueChanged += new System.EventHandler(this.dttngay_ValueChanged);
            // 
            // btnTim
            // 
            this.btnTim.Location = new System.Drawing.Point(763, 15);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(75, 32);
            this.btnTim.TabIndex = 7;
            this.btnTim.Text = "Tìm";
            this.btnTim.UseVisualStyleBackColor = true;
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(211, 19);
            this.label3.TabIndex = 8;
            this.label3.Text = "Lịch sử khách hàng đã thanh toán";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 403);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(184, 19);
            this.label4.TabIndex = 9;
            this.label4.Text = "Linh kiện khách hàng đã mua";
            // 
            // btnXuatBan
            // 
            this.btnXuatBan.Location = new System.Drawing.Point(650, 56);
            this.btnXuatBan.Name = "btnXuatBan";
            this.btnXuatBan.Size = new System.Drawing.Size(143, 34);
            this.btnXuatBan.TabIndex = 10;
            this.btnXuatBan.Text = "Xuất lịch sử bán";
            this.btnXuatBan.UseVisualStyleBackColor = true;
            this.btnXuatBan.Click += new System.EventHandler(this.btnXuatBan_Click);
            // 
            // btnXuatNhap
            // 
            this.btnXuatNhap.Location = new System.Drawing.Point(826, 56);
            this.btnXuatNhap.Name = "btnXuatNhap";
            this.btnXuatNhap.Size = new System.Drawing.Size(143, 34);
            this.btnXuatNhap.TabIndex = 11;
            this.btnXuatNhap.Text = "Xuất lịch sử nhập";
            this.btnXuatNhap.UseVisualStyleBackColor = true;
            this.btnXuatNhap.Click += new System.EventHandler(this.btnXuatNhap_Click);
            // 
            // FLichsuMuaban
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 693);
            this.Controls.Add(this.btnXuatNhap);
            this.Controls.Add(this.btnXuatBan);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnTim);
            this.Controls.Add(this.dttngay);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txbsdt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txbten);
            this.Controls.Add(this.dgvDamua);
            this.Controls.Add(this.dgvNguoimua);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FLichsuMuaban";
            this.Text = "Lịch Sử Mua Bán";
            this.Load += new System.EventHandler(this.FLichsuMuaban_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNguoimua)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDamua)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvNguoimua;
        private System.Windows.Forms.DataGridView dgvDamua;
        private System.Windows.Forms.TextBox txbten;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbsdt;
        private System.Windows.Forms.DateTimePicker dttngay;
        private System.Windows.Forms.Button btnTim;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnXuatBan;
        private System.Windows.Forms.Button btnXuatNhap;
    }
}