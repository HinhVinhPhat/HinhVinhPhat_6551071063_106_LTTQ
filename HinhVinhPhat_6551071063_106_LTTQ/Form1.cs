using HinhVinhPhat_6551071063_106_LTTQ.Models;

namespace HinhVinhPhat_6551071063_106_LTTQ
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void TaiDuLieu()
        {
            using var db = new DuLieuContext();
            dgvDanhSachSP.DataSource = db.SanPham.ToList();
            dgvDanhSachSP.ClearSelection();
            dgvDanhSachSP.CurrentCell = null;

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnThoat.Enabled = true;
            btnThem.Enabled = true;
            dgvDanhSachSP.ReadOnly = true;

            dgvDanhSachSP.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            dgvDanhSachSP.MultiSelect = false;
            dgvDanhSachSP.AllowUserToAddRows = false;
            dgvDanhSachSP.AllowUserToDeleteRows = false;
            TaiDuLieu();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (!Kiemtra()) return;
            using var db = new DuLieuContext();
            String ma = txtMaSP.Text.Trim();
            if (db.SanPham.Find(ma) != null)
            {
                MessageBox.Show("mã đã tồn tại");
                return;
            }
            var sp = new SanPham
            {
                MaSanPham = ma,
                TenSanPham = txtTenSP.Text.Trim(),
                GiaBan = txtGiaBan.Text.Trim()

            };
            db.SanPham.Add(sp);
            try
            {
                db.SaveChanges();
            }
            catch (Microsoft.EntityFrameworkCore.DbUpdateException) {
                MessageBox.Show("Khong luu dc");
                return;
            }
            TaiDuLieu();
            //XoaNhap();
            MessageBox.Show("them thanh cong");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!Kiemtra()) return;
            using var db = new DuLieuContext();
            var sp = db.SanPham.Find(txtMaSP.Text.Trim());
            if (sp == null)
            {
                MessageBox.Show("khong tim thay tai lieu");
                return;
            }
            sp.TenSanPham = txtTenSP.Text.Trim();
            sp.GiaBan = txtGiaBan.Text.Trim();
            try
            {
                db.SaveChanges();
            }
            catch (Microsoft.EntityFrameworkCore.DbUpdateException)
            {
                MessageBox.Show("Khong luu dc");
                return;
            }
            TaiDuLieu();
            MessageBox.Show("sua thanh cong");
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {

        }

        private void dgvDanhSachSP_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvDanhSachSP_Click(object sender, EventArgs e)
        {

        }

        private void dgvDanhSachSP_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            var sp = dgvDanhSachSP.Rows[e.RowIndex].DataBoundItem
                as SanPham;
            if (sp == null) return;
            txtMaSP.Text = sp.MaSanPham;
            txtTenSP.Text = sp.TenSanPham;
            txtGiaBan.Text = sp.GiaBan;

            txtMaSP.ReadOnly = true;
            btnThem.Enabled = false;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;

        }

        private bool Kiemtra()
        {   
            if( string.IsNullOrWhiteSpace(txtTenSP.Text)||string.IsNullOrWhiteSpace(txtMaSP.Text)||string.IsNullOrWhiteSpace(txtGiaBan.Text)
                )
            {
                MessageBox.Show("Hãy nhập đủ dữ liệu vào các ô textbox");
                return false;
            }
            if (!float.TryParse(txtGiaBan.Text, out float GiaBan))
            {
                MessageBox.Show("Giá Bán phải là số thực");
                return false;
            }
            return true;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Bạn có chắc chắn muốn thoát chương trình không?",
                "Xác nhận thoát",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (result == DialogResult.Yes)
            {
                Application.Exit(); 
            }
        }
    }
}
