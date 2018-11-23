namespace DienMay
{
    partial class FrmChiTietSanPham
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmChiTietSanPham));
            this.lblTenSP = new System.Windows.Forms.Label();
            this.lblGiaBan = new System.Windows.Forms.Label();
            this.lblNuocSX = new System.Windows.Forms.Label();
            this.btnQuayLoai = new System.Windows.Forms.Button();
            this.pbHinh = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbHinh)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTenSP
            // 
            this.lblTenSP.AutoSize = true;
            this.lblTenSP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.lblTenSP.Location = new System.Drawing.Point(307, 25);
            this.lblTenSP.Name = "lblTenSP";
            this.lblTenSP.Size = new System.Drawing.Size(115, 20);
            this.lblTenSP.TabIndex = 118;
            this.lblTenSP.Text = "Tên sản phẩm";
            // 
            // lblGiaBan
            // 
            this.lblGiaBan.AutoSize = true;
            this.lblGiaBan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.lblGiaBan.Location = new System.Drawing.Point(309, 72);
            this.lblGiaBan.Name = "lblGiaBan";
            this.lblGiaBan.Size = new System.Drawing.Size(113, 20);
            this.lblGiaBan.TabIndex = 120;
            this.lblGiaBan.Text = "Gía sản phẩm";
            // 
            // lblNuocSX
            // 
            this.lblNuocSX.AutoSize = true;
            this.lblNuocSX.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.lblNuocSX.Location = new System.Drawing.Point(309, 124);
            this.lblNuocSX.Name = "lblNuocSX";
            this.lblNuocSX.Size = new System.Drawing.Size(116, 20);
            this.lblNuocSX.TabIndex = 121;
            this.lblNuocSX.Text = "Nước sản xuất";
            // 
            // btnQuayLoai
            // 
            this.btnQuayLoai.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.btnQuayLoai.Image = ((System.Drawing.Image)(resources.GetObject("btnQuayLoai.Image")));
            this.btnQuayLoai.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQuayLoai.Location = new System.Drawing.Point(349, 276);
            this.btnQuayLoai.Name = "btnQuayLoai";
            this.btnQuayLoai.Size = new System.Drawing.Size(172, 37);
            this.btnQuayLoai.TabIndex = 123;
            this.btnQuayLoai.Text = "Trang Sản phẩm";
            this.btnQuayLoai.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnQuayLoai.UseVisualStyleBackColor = true;
            // 
            // pbHinh
            // 
            this.pbHinh.Image = ((System.Drawing.Image)(resources.GetObject("pbHinh.Image")));
            this.pbHinh.InitialImage = null;
            this.pbHinh.Location = new System.Drawing.Point(35, 25);
            this.pbHinh.Name = "pbHinh";
            this.pbHinh.Size = new System.Drawing.Size(193, 165);
            this.pbHinh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbHinh.TabIndex = 124;
            this.pbHinh.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label1.Location = new System.Drawing.Point(309, 162);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 121;
            this.label1.Text = "Mô tả";
            // 
            // FrmChiTietSanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(830, 365);
            this.Controls.Add(this.pbHinh);
            this.Controls.Add(this.btnQuayLoai);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblNuocSX);
            this.Controls.Add(this.lblGiaBan);
            this.Controls.Add(this.lblTenSP);
            this.Name = "FrmChiTietSanPham";
            this.Text = "FrmChiTietSanPham";
            ((System.ComponentModel.ISupportInitialize)(this.pbHinh)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTenSP;
        private System.Windows.Forms.Label lblGiaBan;
        private System.Windows.Forms.Label lblNuocSX;
        private System.Windows.Forms.Button btnQuayLoai;
        private System.Windows.Forms.PictureBox pbHinh;
        private System.Windows.Forms.Label label1;
    }
}