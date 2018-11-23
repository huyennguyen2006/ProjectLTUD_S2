namespace DienMay
{
    partial class FrmQuanLyLoaiSanPham
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmQuanLyLoaiSanPham));
            this.txtTenLoaiSP = new System.Windows.Forms.TextBox();
            this.txtMaSP = new System.Windows.Forms.TextBox();
            this.lblTenSP = new System.Windows.Forms.Label();
            this.lblMaSP = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.dtgvLoaiSP = new System.Windows.Forms.DataGridView();
            this.pbHinh = new System.Windows.Forms.PictureBox();
            this.lblTTSP = new System.Windows.Forms.Label();
            this.btnCapNhat = new System.Windows.Forms.Button();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.btnXOa = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.txtMaLoai = new System.Windows.Forms.TextBox();
            this.MaLoai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Hinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvLoaiSP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbHinh)).BeginInit();
            this.SuspendLayout();
            // 
            // txtTenLoaiSP
            // 
            this.txtTenLoaiSP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.txtTenLoaiSP.Location = new System.Drawing.Point(132, 80);
            this.txtTenLoaiSP.Name = "txtTenLoaiSP";
            this.txtTenLoaiSP.Size = new System.Drawing.Size(208, 26);
            this.txtTenLoaiSP.TabIndex = 185;
            // 
            // txtMaSP
            // 
            this.txtMaSP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.txtMaSP.Location = new System.Drawing.Point(132, 21);
            this.txtMaSP.Name = "txtMaSP";
            this.txtMaSP.Size = new System.Drawing.Size(208, 26);
            this.txtMaSP.TabIndex = 184;
            // 
            // lblTenSP
            // 
            this.lblTenSP.AutoSize = true;
            this.lblTenSP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.lblTenSP.Location = new System.Drawing.Point(15, 86);
            this.lblTenSP.Name = "lblTenSP";
            this.lblTenSP.Size = new System.Drawing.Size(95, 20);
            this.lblTenSP.TabIndex = 190;
            this.lblTenSP.Text = "Tên loại SP";
            // 
            // lblMaSP
            // 
            this.lblMaSP.AutoSize = true;
            this.lblMaSP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.lblMaSP.Location = new System.Drawing.Point(15, 27);
            this.lblMaSP.Name = "lblMaSP";
            this.lblMaSP.Size = new System.Drawing.Size(63, 20);
            this.lblMaSP.TabIndex = 189;
            this.lblMaSP.Text = "Mã loại";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.button1.Location = new System.Drawing.Point(19, 185);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 29);
            this.button1.TabIndex = 183;
            this.button1.Text = "Chọn Ảnh";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // dtgvLoaiSP
            // 
            this.dtgvLoaiSP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvLoaiSP.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaLoai,
            this.TenSP,
            this.Hinh});
            this.dtgvLoaiSP.Location = new System.Drawing.Point(473, 12);
            this.dtgvLoaiSP.Name = "dtgvLoaiSP";
            this.dtgvLoaiSP.ReadOnly = true;
            this.dtgvLoaiSP.Size = new System.Drawing.Size(343, 338);
            this.dtgvLoaiSP.TabIndex = 181;
            // 
            // pbHinh
            // 
            this.pbHinh.Image = ((System.Drawing.Image)(resources.GetObject("pbHinh.Image")));
            this.pbHinh.Location = new System.Drawing.Point(143, 112);
            this.pbHinh.Name = "pbHinh";
            this.pbHinh.Size = new System.Drawing.Size(182, 158);
            this.pbHinh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbHinh.TabIndex = 180;
            this.pbHinh.TabStop = false;
            // 
            // lblTTSP
            // 
            this.lblTTSP.AutoSize = true;
            this.lblTTSP.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblTTSP.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblTTSP.Location = new System.Drawing.Point(602, -52);
            this.lblTTSP.Name = "lblTTSP";
            this.lblTTSP.Size = new System.Drawing.Size(273, 32);
            this.lblTTSP.TabIndex = 179;
            this.lblTTSP.Text = "Thông Tin Sản Phẩm";
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.btnCapNhat.Image = ((System.Drawing.Image)(resources.GetObject("btnCapNhat.Image")));
            this.btnCapNhat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCapNhat.Location = new System.Drawing.Point(61, 419);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(119, 42);
            this.btnCapNhat.TabIndex = 178;
            this.btnCapNhat.Text = "Cập Nhật";
            this.btnCapNhat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCapNhat.UseVisualStyleBackColor = true;
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.txtTimKiem.Location = new System.Drawing.Point(501, 362);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(247, 26);
            this.txtTimKiem.TabIndex = 175;
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.btnTimKiem.Image = ((System.Drawing.Image)(resources.GetObject("btnTimKiem.Image")));
            this.btnTimKiem.Location = new System.Drawing.Point(775, 356);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(41, 38);
            this.btnTimKiem.TabIndex = 174;
            this.btnTimKiem.UseVisualStyleBackColor = true;
            // 
            // btnXOa
            // 
            this.btnXOa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.btnXOa.Image = ((System.Drawing.Image)(resources.GetObject("btnXOa.Image")));
            this.btnXOa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXOa.Location = new System.Drawing.Point(682, 420);
            this.btnXOa.Name = "btnXOa";
            this.btnXOa.Size = new System.Drawing.Size(85, 42);
            this.btnXOa.TabIndex = 177;
            this.btnXOa.Text = "Xóa";
            this.btnXOa.UseVisualStyleBackColor = true;
            // 
            // btnThem
            // 
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.btnThem.Image = ((System.Drawing.Image)(resources.GetObject("btnThem.Image")));
            this.btnThem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThem.Location = new System.Drawing.Point(520, 419);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(93, 42);
            this.btnThem.TabIndex = 176;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            // 
            // txtMaLoai
            // 
            this.txtMaLoai.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.txtMaLoai.Location = new System.Drawing.Point(132, 21);
            this.txtMaLoai.Name = "txtMaLoai";
            this.txtMaLoai.Size = new System.Drawing.Size(208, 26);
            this.txtMaLoai.TabIndex = 184;
            // 
            // MaLoai
            // 
            this.MaLoai.HeaderText = "Mã Loại SP";
            this.MaLoai.Name = "MaLoai";
            this.MaLoai.ReadOnly = true;
            // 
            // TenSP
            // 
            this.TenSP.HeaderText = "Tên loại SP";
            this.TenSP.Name = "TenSP";
            this.TenSP.ReadOnly = true;
            // 
            // Hinh
            // 
            this.Hinh.HeaderText = "Hinh";
            this.Hinh.Name = "Hinh";
            this.Hinh.ReadOnly = true;
            // 
            // FrmQuanLyLoaiSanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(940, 474);
            this.Controls.Add(this.txtTenLoaiSP);
            this.Controls.Add(this.txtMaLoai);
            this.Controls.Add(this.txtMaSP);
            this.Controls.Add(this.lblTenSP);
            this.Controls.Add(this.lblMaSP);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dtgvLoaiSP);
            this.Controls.Add(this.pbHinh);
            this.Controls.Add(this.lblTTSP);
            this.Controls.Add(this.btnCapNhat);
            this.Controls.Add(this.txtTimKiem);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.btnXOa);
            this.Controls.Add(this.btnThem);
            this.Name = "FrmQuanLyLoaiSanPham";
            this.Text = "FrmQuanLyLoaiSanPham";
            ((System.ComponentModel.ISupportInitialize)(this.dtgvLoaiSP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbHinh)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtTenLoaiSP;
        private System.Windows.Forms.TextBox txtMaSP;
        private System.Windows.Forms.Label lblTenSP;
        private System.Windows.Forms.Label lblMaSP;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dtgvLoaiSP;
        private System.Windows.Forms.PictureBox pbHinh;
        private System.Windows.Forms.Label lblTTSP;
        private System.Windows.Forms.Button btnCapNhat;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.Button btnXOa;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.TextBox txtMaLoai;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaLoai;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn Hinh;
    }
}