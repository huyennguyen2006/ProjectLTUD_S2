namespace DienMay
{
    partial class QuanLySP
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QuanLySP));
            this.button1 = new System.Windows.Forms.Button();
            this.dtgvSP = new System.Windows.Forms.DataGridView();
            this.pbHinh = new System.Windows.Forms.PictureBox();
            this.lblTTSP = new System.Windows.Forms.Label();
            this.btnCapNhat = new System.Windows.Forms.Button();
            this.btnXOa = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.cbxLoaiSP = new System.Windows.Forms.ComboBox();
            this.txtNuocSX = new System.Windows.Forms.TextBox();
            this.txtGiaBan = new System.Windows.Forms.TextBox();
            this.txtTenSP = new System.Windows.Forms.TextBox();
            this.txtMaSP = new System.Windows.Forms.TextBox();
            this.lblNuocSX = new System.Windows.Forms.Label();
            this.lblGiaBan = new System.Windows.Forms.Label();
            this.lblLoaiSP = new System.Windows.Forms.Label();
            this.lblTenSP = new System.Windows.Forms.Label();
            this.lblMaSP = new System.Windows.Forms.Label();
            this.MaSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Hinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LoaiSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NuocSX = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvSP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbHinh)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.button1.Location = new System.Drawing.Point(390, 192);
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
            this.MaSP,
            this.Hinh,
            this.TenSP,
            this.LoaiSP,
            this.Gia,
            this.NuocSX});
            this.dtgvSP.Location = new System.Drawing.Point(550, 12);
            this.dtgvSP.Name = "dtgvSP";
            this.dtgvSP.ReadOnly = true;
            this.dtgvSP.Size = new System.Drawing.Size(643, 325);
            this.dtgvSP.TabIndex = 161;
            // 
            // pbHinh
            // 
            this.pbHinh.Image = ((System.Drawing.Image)(resources.GetObject("pbHinh.Image")));
            this.pbHinh.Location = new System.Drawing.Point(343, 12);
            this.pbHinh.Name = "pbHinh";
            this.pbHinh.Size = new System.Drawing.Size(182, 158);
            this.pbHinh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbHinh.TabIndex = 160;
            this.pbHinh.TabStop = false;
            // 
            // lblTTSP
            // 
            this.lblTTSP.AutoSize = true;
            this.lblTTSP.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblTTSP.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblTTSP.Location = new System.Drawing.Point(599, -40);
            this.lblTTSP.Name = "lblTTSP";
            this.lblTTSP.Size = new System.Drawing.Size(273, 32);
            this.lblTTSP.TabIndex = 159;
            this.lblTTSP.Text = "Thông Tin Sản Phẩm";
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.btnCapNhat.Image = ((System.Drawing.Image)(resources.GetObject("btnCapNhat.Image")));
            this.btnCapNhat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCapNhat.Location = new System.Drawing.Point(157, 380);
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
            this.btnXOa.Location = new System.Drawing.Point(875, 406);
            this.btnXOa.Name = "btnXOa";
            this.btnXOa.Size = new System.Drawing.Size(107, 42);
            this.btnXOa.TabIndex = 157;
            this.btnXOa.Text = "Xóa";
            this.btnXOa.UseVisualStyleBackColor = true;
            // 
            // btnThem
            // 
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.btnThem.Image = ((System.Drawing.Image)(resources.GetObject("btnThem.Image")));
            this.btnThem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThem.Location = new System.Drawing.Point(712, 406);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(114, 42);
            this.btnThem.TabIndex = 156;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.txtTimKiem.Location = new System.Drawing.Point(674, 361);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(266, 26);
            this.txtTimKiem.TabIndex = 155;
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.btnTimKiem.Image = ((System.Drawing.Image)(resources.GetObject("btnTimKiem.Image")));
            this.btnTimKiem.Location = new System.Drawing.Point(974, 355);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(41, 38);
            this.btnTimKiem.TabIndex = 154;
            this.btnTimKiem.UseVisualStyleBackColor = true;
            // 
            // cbxLoaiSP
            // 
            this.cbxLoaiSP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.cbxLoaiSP.FormattingEnabled = true;
            this.cbxLoaiSP.Location = new System.Drawing.Point(129, 157);
            this.cbxLoaiSP.Name = "cbxLoaiSP";
            this.cbxLoaiSP.Size = new System.Drawing.Size(208, 28);
            this.cbxLoaiSP.TabIndex = 166;
            // 
            // txtNuocSX
            // 
            this.txtNuocSX.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.txtNuocSX.Location = new System.Drawing.Point(129, 274);
            this.txtNuocSX.Name = "txtNuocSX";
            this.txtNuocSX.Size = new System.Drawing.Size(208, 26);
            this.txtNuocSX.TabIndex = 168;
            // 
            // txtGiaBan
            // 
            this.txtGiaBan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.txtGiaBan.Location = new System.Drawing.Point(129, 216);
            this.txtGiaBan.Name = "txtGiaBan";
            this.txtGiaBan.Size = new System.Drawing.Size(208, 26);
            this.txtGiaBan.TabIndex = 167;
            // 
            // txtTenSP
            // 
            this.txtTenSP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.txtTenSP.Location = new System.Drawing.Point(129, 92);
            this.txtTenSP.Name = "txtTenSP";
            this.txtTenSP.Size = new System.Drawing.Size(208, 26);
            this.txtTenSP.TabIndex = 165;
            // 
            // txtMaSP
            // 
            this.txtMaSP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.txtMaSP.Location = new System.Drawing.Point(129, 33);
            this.txtMaSP.Name = "txtMaSP";
            this.txtMaSP.Size = new System.Drawing.Size(208, 26);
            this.txtMaSP.TabIndex = 164;
            // 
            // lblNuocSX
            // 
            this.lblNuocSX.AutoSize = true;
            this.lblNuocSX.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.lblNuocSX.Location = new System.Drawing.Point(12, 277);
            this.lblNuocSX.Name = "lblNuocSX";
            this.lblNuocSX.Size = new System.Drawing.Size(116, 20);
            this.lblNuocSX.TabIndex = 173;
            this.lblNuocSX.Text = "Nước sản xuất";
            // 
            // lblGiaBan
            // 
            this.lblGiaBan.AutoSize = true;
            this.lblGiaBan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.lblGiaBan.Location = new System.Drawing.Point(12, 222);
            this.lblGiaBan.Name = "lblGiaBan";
            this.lblGiaBan.Size = new System.Drawing.Size(113, 20);
            this.lblGiaBan.TabIndex = 172;
            this.lblGiaBan.Text = "Gía sản phẩm";
            // 
            // lblLoaiSP
            // 
            this.lblLoaiSP.AutoSize = true;
            this.lblLoaiSP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.lblLoaiSP.Location = new System.Drawing.Point(12, 160);
            this.lblLoaiSP.Name = "lblLoaiSP";
            this.lblLoaiSP.Size = new System.Drawing.Size(119, 20);
            this.lblLoaiSP.TabIndex = 171;
            this.lblLoaiSP.Text = "Loại sản phẩm";
            // 
            // lblTenSP
            // 
            this.lblTenSP.AutoSize = true;
            this.lblTenSP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.lblTenSP.Location = new System.Drawing.Point(12, 98);
            this.lblTenSP.Name = "lblTenSP";
            this.lblTenSP.Size = new System.Drawing.Size(117, 20);
            this.lblTenSP.TabIndex = 170;
            this.lblTenSP.Text = "Tên Sản phẩm";
            // 
            // lblMaSP
            // 
            this.lblMaSP.AutoSize = true;
            this.lblMaSP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.lblMaSP.Location = new System.Drawing.Point(12, 39);
            this.lblMaSP.Name = "lblMaSP";
            this.lblMaSP.Size = new System.Drawing.Size(112, 20);
            this.lblMaSP.TabIndex = 169;
            this.lblMaSP.Text = "Mã Sản phẩm";
            // 
            // MaSP
            // 
            this.MaSP.HeaderText = "Mã SP";
            this.MaSP.Name = "MaSP";
            this.MaSP.ReadOnly = true;
            // 
            // Hinh
            // 
            this.Hinh.HeaderText = "Hình ảnh";
            this.Hinh.Name = "Hinh";
            this.Hinh.ReadOnly = true;
            // 
            // TenSP
            // 
            this.TenSP.HeaderText = "Tên SP";
            this.TenSP.Name = "TenSP";
            this.TenSP.ReadOnly = true;
            // 
            // LoaiSP
            // 
            this.LoaiSP.HeaderText = "Loại SP";
            this.LoaiSP.Name = "LoaiSP";
            this.LoaiSP.ReadOnly = true;
            // 
            // Gia
            // 
            this.Gia.HeaderText = "Giá SP";
            this.Gia.Name = "Gia";
            this.Gia.ReadOnly = true;
            // 
            // NuocSX
            // 
            this.NuocSX.HeaderText = "Nước SX";
            this.NuocSX.Name = "NuocSX";
            this.NuocSX.ReadOnly = true;
            // 
            // QuanLySP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1205, 488);
            this.Controls.Add(this.cbxLoaiSP);
            this.Controls.Add(this.txtNuocSX);
            this.Controls.Add(this.txtGiaBan);
            this.Controls.Add(this.txtTenSP);
            this.Controls.Add(this.txtMaSP);
            this.Controls.Add(this.lblNuocSX);
            this.Controls.Add(this.lblGiaBan);
            this.Controls.Add(this.lblLoaiSP);
            this.Controls.Add(this.lblTenSP);
            this.Controls.Add(this.lblMaSP);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dtgvSP);
            this.Controls.Add(this.pbHinh);
            this.Controls.Add(this.lblTTSP);
            this.Controls.Add(this.btnCapNhat);
            this.Controls.Add(this.btnXOa);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.txtTimKiem);
            this.Controls.Add(this.btnTimKiem);
            this.Name = "QuanLySP";
            this.Text = "Quản lý sản phẩm";
            ((System.ComponentModel.ISupportInitialize)(this.dtgvSP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbHinh)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dtgvSP;
        private System.Windows.Forms.PictureBox pbHinh;
        private System.Windows.Forms.Label lblTTSP;
        private System.Windows.Forms.Button btnCapNhat;
        private System.Windows.Forms.Button btnXOa;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.ComboBox cbxLoaiSP;
        private System.Windows.Forms.TextBox txtNuocSX;
        private System.Windows.Forms.TextBox txtGiaBan;
        private System.Windows.Forms.TextBox txtTenSP;
        private System.Windows.Forms.TextBox txtMaSP;
        private System.Windows.Forms.Label lblNuocSX;
        private System.Windows.Forms.Label lblGiaBan;
        private System.Windows.Forms.Label lblLoaiSP;
        private System.Windows.Forms.Label lblTenSP;
        private System.Windows.Forms.Label lblMaSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn Hinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn LoaiSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gia;
        private System.Windows.Forms.DataGridViewTextBoxColumn NuocSX;
    }
}

