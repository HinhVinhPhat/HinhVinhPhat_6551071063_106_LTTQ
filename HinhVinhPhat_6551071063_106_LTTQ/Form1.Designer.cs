namespace HinhVinhPhat_6551071063_106_LTTQ
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            grbThongtinSP = new GroupBox();
            txtGiaBan = new TextBox();
            txtTenSP = new TextBox();
            txtMaSP = new TextBox();
            lblGiaBan = new Label();
            lblTenSP = new Label();
            lblMaSP = new Label();
            grbDanhSachSP = new GroupBox();
            dgvDanhSachSP = new DataGridView();
            grbThaoTac = new GroupBox();
            btnThoat = new Button();
            btnXoa = new Button();
            btnSua = new Button();
            btnThem = new Button();
            grbThongtinSP.SuspendLayout();
            grbDanhSachSP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDanhSachSP).BeginInit();
            grbThaoTac.SuspendLayout();
            SuspendLayout();
            // 
            // grbThongtinSP
            // 
            grbThongtinSP.Controls.Add(txtGiaBan);
            grbThongtinSP.Controls.Add(txtTenSP);
            grbThongtinSP.Controls.Add(txtMaSP);
            grbThongtinSP.Controls.Add(lblGiaBan);
            grbThongtinSP.Controls.Add(lblTenSP);
            grbThongtinSP.Controls.Add(lblMaSP);
            grbThongtinSP.Location = new Point(2, 32);
            grbThongtinSP.Name = "grbThongtinSP";
            grbThongtinSP.Size = new Size(422, 162);
            grbThongtinSP.TabIndex = 0;
            grbThongtinSP.TabStop = false;
            grbThongtinSP.Text = "Thông tin sản phẩm";
            // 
            // txtGiaBan
            // 
            txtGiaBan.Location = new Point(133, 110);
            txtGiaBan.Name = "txtGiaBan";
            txtGiaBan.Size = new Size(125, 27);
            txtGiaBan.TabIndex = 5;
            // 
            // txtTenSP
            // 
            txtTenSP.Location = new Point(133, 73);
            txtTenSP.Name = "txtTenSP";
            txtTenSP.Size = new Size(255, 27);
            txtTenSP.TabIndex = 4;
            // 
            // txtMaSP
            // 
            txtMaSP.Location = new Point(133, 32);
            txtMaSP.Name = "txtMaSP";
            txtMaSP.Size = new Size(125, 27);
            txtMaSP.TabIndex = 3;
            // 
            // lblGiaBan
            // 
            lblGiaBan.AutoSize = true;
            lblGiaBan.Location = new Point(10, 110);
            lblGiaBan.Name = "lblGiaBan";
            lblGiaBan.Size = new Size(108, 20);
            lblGiaBan.TabIndex = 2;
            lblGiaBan.Text = "Giá bán (VND):";
            // 
            // lblTenSP
            // 
            lblTenSP.AutoSize = true;
            lblTenSP.Location = new Point(10, 73);
            lblTenSP.Name = "lblTenSP";
            lblTenSP.Size = new Size(103, 20);
            lblTenSP.TabIndex = 1;
            lblTenSP.Text = "Tên sản phẩm:";
            // 
            // lblMaSP
            // 
            lblMaSP.AutoSize = true;
            lblMaSP.Location = new Point(10, 35);
            lblMaSP.Name = "lblMaSP";
            lblMaSP.Size = new Size(101, 20);
            lblMaSP.TabIndex = 0;
            lblMaSP.Text = "Mã sản phẩm:";
            // 
            // grbDanhSachSP
            // 
            grbDanhSachSP.Controls.Add(dgvDanhSachSP);
            grbDanhSachSP.Location = new Point(2, 200);
            grbDanhSachSP.Name = "grbDanhSachSP";
            grbDanhSachSP.Size = new Size(796, 253);
            grbDanhSachSP.TabIndex = 1;
            grbDanhSachSP.TabStop = false;
            grbDanhSachSP.Text = "Danh sách sản phẩm";
            // 
            // dgvDanhSachSP
            // 
            dgvDanhSachSP.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDanhSachSP.Location = new Point(0, 26);
            dgvDanhSachSP.Name = "dgvDanhSachSP";
            dgvDanhSachSP.RowHeadersWidth = 51;
            dgvDanhSachSP.Size = new Size(796, 221);
            dgvDanhSachSP.TabIndex = 0;
            dgvDanhSachSP.CellClick += dgvDanhSachSP_CellClick;
            dgvDanhSachSP.CellContentClick += dgvDanhSachSP_CellContentClick;
            dgvDanhSachSP.Click += dgvDanhSachSP_Click;
            // 
            // grbThaoTac
            // 
            grbThaoTac.Controls.Add(btnThoat);
            grbThaoTac.Controls.Add(btnXoa);
            grbThaoTac.Controls.Add(btnSua);
            grbThaoTac.Controls.Add(btnThem);
            grbThaoTac.Location = new Point(430, 32);
            grbThaoTac.Name = "grbThaoTac";
            grbThaoTac.Size = new Size(368, 162);
            grbThaoTac.TabIndex = 2;
            grbThaoTac.TabStop = false;
            grbThaoTac.Text = "Thao tác";
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(278, 78);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(80, 29);
            btnThoat.TabIndex = 3;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(192, 78);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(80, 29);
            btnXoa.TabIndex = 2;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(106, 78);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(80, 29);
            btnSua.TabIndex = 1;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += button2_Click;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(20, 78);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(80, 29);
            btnThem.TabIndex = 0;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(grbThaoTac);
            Controls.Add(grbDanhSachSP);
            Controls.Add(grbThongtinSP);
            Name = "Form1";
            Text = "Quản lý Sản phẩm / Hàng hóa -VP106 ";
            Load += Form1_Load;
            grbThongtinSP.ResumeLayout(false);
            grbThongtinSP.PerformLayout();
            grbDanhSachSP.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvDanhSachSP).EndInit();
            grbThaoTac.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grbThongtinSP;
        private GroupBox grbDanhSachSP;
        private GroupBox grbThaoTac;
        private TextBox txtGiaBan;
        private TextBox txtTenSP;
        private TextBox txtMaSP;
        private Label lblGiaBan;
        private Label lblTenSP;
        private Label lblMaSP;
        private DataGridView dgvDanhSachSP;
        private Button btnThoat;
        private Button btnXoa;
        private Button btnSua;
        private Button btnThem;
    }
}
