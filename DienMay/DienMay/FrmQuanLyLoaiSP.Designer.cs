namespace DienMay
{
    partial class FrmQuanLyLoaiSP
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmQuanLyLoaiSP));
            this.button1 = new System.Windows.Forms.Button();
            this.dtgvSP = new System.Windows.Forms.DataGridView();
            this.pbHinh = new System.Windows.Forms.PictureBox();
            this.btnCapNhat = new System.Windows.Forms.Button();
            this.btnXOa = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.txtTenSP = new System.Windows.Forms.TextBox();
            this.txtMaSP = new System.Windows.Forms.TextBox();
            this.lblTenSP = new System.Windows.Forms.Label();
            this.lblMaSP = new System.Windows.Forms.Label();
            this.MaLoai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenLoai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Hinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvSP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbHinh)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.button1.Location = new System.Drawing.Point(64, 265);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 29);
            this.button1.TabIndex = 163;
            this.button1.Text = "Chọn Ảnh";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // dtgvSP
            // 
            this.dtgvSP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvSP.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaLoai,
            this.TenLoai,
            this.Hinh});
            this.dtgvSP.Location = new System.Drawing.Point(563, 12);
            this.dtgvSP.Name = "dtgvSP";
            this.dtgvSP.ReadOnly = true;
            this.dtgvSP.Size = new System.Drawing.Size(345, 352);
            this.dtgvSP.TabIndex = 161;
            this.dtgvSP.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvSP_CellContentClick);
            // 
            // pbHinh
            // 
            this.pbHinh.Image = ((System.Drawing.Image)(resources.GetObject("pbHinh.Image")));
            this.pbHinh.Location = new System.Drawing.Point(183, 176);
            this.pbHinh.Name = "pbHinh";
            this.pbHinh.Size = new System.Drawing.Size(182, 158);
            this.pbHinh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbHinh.TabIndex = 160;
            this.pbHinh.TabStop = false;
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.btnCapNhat.Image = ((System.Drawing.Image)(resources.GetObject("btnCapNhat.Image")));
            this.btnCapNhat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCapNhat.Location = new System.Drawing.Point(160, 393);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(119, 42);
            this.btnCapNhat.TabIndex = 158;
            this.btnCapNhat.Text = "Cập Nhật";
            this.btnCapNhat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCapNhat.UseVisualStyleBackColor = true;
            // 
            // btnXOa
            // 
            this.btnXOa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.btnXOa.Image = ((System.Drawing.Image)(resources.GetObject("btnXOa.Image")));
            this.btnXOa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXOa.Location = new System.Drawing.Point(786, 429);
            this.btnXOa.Name = "btnXOa";
            this.btnXOa.Size = new System.Drawing.Size(97, 42);
            this.btnXOa.TabIndex = 157;
            this.btnXOa.Text = "Xóa";
            this.btnXOa.UseVisualStyleBackColor = true;
            // 
            // btnThem
            // 
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.btnThem.Image = ((System.Drawing.Image)(resources.GetObject("btnThem.Image")));
            this.btnThem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThem.Location = new System.Drawing.Point(579, 429);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(102, 42);
            this.btnThem.TabIndex = 156;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.txtTimKiem.Location = new System.Drawing.Point(591, 381);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(266, 26);
            this.txtTimKiem.TabIndex = 155;
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.btnTimKiem.Image = ((System.Drawing.Image)(resources.GetObject("btnTimKiem.Image")));
            this.btnTimKiem.Location = new System.Drawing.Point(881, 375);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(41, 38);
            this.btnTimKiem.TabIndex = 154;
            this.btnTimKiem.UseVisualStyleBackColor = true;
            // 
            // txtTenSP
            // 
            this.txtTenSP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.txtTenSP.Location = new System.Drawing.Point(151, 135);
            this.txtTenSP.Name = "txtTenSP";
            this.txtTenSP.Size = new System.Drawing.Size(266, 26);
            this.txtTenSP.TabIndex = 145;
            // 
            // txtMaSP
            // 
            this.txtMaSP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.txtMaSP.Location = new System.Drawing.Point(151, 71);
            this.txtMaSP.Name = "txtMaSP";
            this.txtMaSP.Size = new System.Drawing.Size(266, 26);
            this.txtMaSP.TabIndex = 144;
            // 
            // lblTenSP
            // 
            this.lblTenSP.AutoSize = true;
            this.lblTenSP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.lblTenSP.Location = new System.Drawing.Point(60, 138);
            this.lblTenSP.Name = "lblTenSP";
            this.lblTenSP.Size = new System.Drawing.Size(64, 20);
            this.lblTenSP.TabIndex = 150;
            this.lblTenSP.Text = "Tên SP";
            // 
            // lblMaSP
            // 
            this.lblMaSP.AutoSize = true;
            this.lblMaSP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.lblMaSP.Location = new System.Drawing.Point(60, 79);
            this.lblMaSP.Name = "lblMaSP";
            this.lblMaSP.Size = new System.Drawing.Size(59, 20);
            this.lblMaSP.TabIndex = 149;
            this.lblMaSP.Text = "Mã SP";
            // 
            // MaLoai
            // 
            this.MaLoai.HeaderText = "Mã loại SP";
            this.MaLoai.Name = "MaLoai";
            this.MaLoai.ReadOnly = true;
            // 
            // TenLoai
            // 
            this.TenLoai.HeaderText = "Tên loại SP";
            this.TenLoai.Name = "TenLoai";
            this.TenLoai.ReadOnly = true;
            // 
            // Hinh
            // 
            this.Hinh.HeaderText = "Hình ảnh";
            this.Hinh.Name = "Hinh";
            this.Hinh.ReadOnly = true;
            // 
            // FrmQuanLyLoaiSP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1056, 570);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dtgvSP);
            this.Controls.Add(this.pbHinh);
            this.Controls.Add(this.btnCapNhat);
            this.Controls.Add(this.btnXOa);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.txtTimKiem);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.txtTenSP);
            this.Controls.Add(this.txtMaSP);
            this.Controls.Add(this.lblTenSP);
            this.Controls.Add(this.lblMaSP);
            this.Name = "FrmQuanLyLoaiSP";
            this.Text = "FrmQuanLyLoaiSP";
            ((System.ComponentModel.ISupportInitialize)(this.dtgvSP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbHinh)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dtgvSP;
        private System.Windows.Forms.PictureBox pbHinh;
        private System.Windows.Forms.Button btnCapNhat;
        private System.Windows.Forms.Button btnXOa;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.TextBox txtTenSP;
        private System.Windows.Forms.TextBox txtMaSP;
        private System.Windows.Forms.Label lblTenSP;
        private System.Windows.Forms.Label lblMaSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaLoai;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenLoai;
        private System.Windows.Forms.DataGridViewTextBoxColumn Hinh;
    }
}