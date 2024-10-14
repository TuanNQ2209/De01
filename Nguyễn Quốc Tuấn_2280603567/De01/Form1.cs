using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using De01.Model;

namespace De01
{
    public partial class Form1 : Form
    {
        Model1 contetxDB = new Model1();
        public Form1()
        {
            InitializeComponent();
        }
        private void ResetControl()
        {
            txtMaSV.Clear();
            txtHotenSV.Clear();
            dtNgaysinh = null;
            cboLop.SelectedIndex = -1;
            dgvSinhvien.ClearSelection();
        }

        private void FillFacultyCombobox(List<Lop> dslop)
        {
            cboLop.Items.Clear();
            cboLop.DataSource = dslop;
            cboLop.DisplayMember = "TenLop";
            cboLop.ValueMember = "Malop";
        }

        private void BindGrid(List<Sinhvien> dssv)
        {
            dgvSinhvien.Rows.Clear();
            foreach (var item in dssv)
            {
                int index = dgvSinhvien.Rows.Add();
                dgvSinhvien.Rows[index].Cells[0].Value = item.MaSV;
                dgvSinhvien.Rows[index].Cells[1].Value = item.HotenSV;
                dgvSinhvien.Rows[index].Cells[2].Value = item.Ngaysinh;
                dgvSinhvien.Rows[index].Cells[3].Value = item.Lop.TenLop; ;
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                List<Sinhvien> dssinhvien = contetxDB.Sinhviens.ToList();
                List<Lop> dslop = contetxDB.Lops.ToList();
                FillFacultyCombobox(dslop);
                BindGrid(dssinhvien);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btThoat_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bạn có muốn thoát không", "Thông báo", MessageBoxButtons.YesNo);
            this.Close();
        }
        private bool KiemTraRangBuoc()
        {
            if (string.IsNullOrWhiteSpace(txtMaSV.Text))
            {
                MessageBox.Show("Không được để trống mã sinh viên");
                txtMaSV.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtHoten.Text))
            {
                MessageBox.Show("Không được để trống họ tên");
                txtHoten.Focus();
                return false;
            }
            if (cboLop.SelectedIndex < 0)
            {
                MessageBox.Show("Không được để trống lớp");
                cboLop.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(dtNgaysinh.Text))
            {
                MessageBox.Show("Không được để trống ngày");
                dtNgaysinh.Focus();
                return false;
            }
            return true;
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            string maSV = txtMaSV.Text;
            var timSV = contetxDB.Sinhviens.Find(maSV);
            if (timSV != null)
            {
                MessageBox.Show("Mã sinh viên đã tồn tại");
                return;
            }

            var student = new Sinhvien
            {
                MaSV = txtMaSV.Text,
                HotenSV = txtHotenSV.Text,
                Ngaysinh = Convert.ToDateTime(dtNgaysinh.Text),
                MaLop = (cboLop.SelectedItem as Lop).MaLop,
            };

            contetxDB.Sinhviens.Add(student);
            MessageBox.Show("Thêm sinh viên thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            BindGrid(contetxDB.Sinhviens.ToList());
            ResetControl();

        }

        private void btXoa_Click(object sender, EventArgs e)
        {

            try
            {
                string maSV = txtMaSV.Text;
                var timSV = contetxDB.Sinhviens.Find(maSV);
                if (timSV != null)
                {
                    contetxDB.Sinhviens.Remove(timSV);
                    contetxDB.SaveChanges();

                    BindGrid(contetxDB.Sinhviens.ToList());
                    ResetControl();
                    MessageBox.Show("Xóa sinh viên thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch
            {
                MessageBox.Show("Có lỗi trong quá trình xóa sinh viên", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btSua_Click(object sender, EventArgs e, DateTime t, Sinhvien timSV)
        {
            try
            {
                string maSV = txtMaSV.Text;
                var timsv = contetxDB.Sinhviens.Find(maSV);

                if (timsv != null)
                {
                    timsv.HotenSV = txtHoten.Text;
                    timsv.MaLop = (cboLop.SelectedItem as Lop).MaLop;
                    timsv.Ngaysinh = Convert.ToDateTime(dtNgaysinh.Value);
                    contetxDB.SaveChanges();

                    MessageBox.Show("Sửa sinh viên thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    BindGrid(contetxDB.Sinhviens.ToList());
                    ResetControl();
                }
            }
            catch
            {
                MessageBox.Show("Có lỗi trong quá trình sửa sinh viên", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btLuu_Click(object sender, EventArgs e)
        {
            try
            {
                contetxDB.SaveChanges();
                MessageBox.Show("Lưu thay đổi thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Có lỗi xảy ra khi lưu: {ex.Message}", "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btKhong_Click(object sender, EventArgs e)
        {
            
        }
        private void dgvSinhvien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var row = dgvSinhvien.Rows[e.RowIndex];
                txtMaSV.Text = row.Cells[0].Value.ToString();
                txtHotenSV.Text = row.Cells[1].Value.ToString();
                dtNgaysinh.Text = row.Cells[2].Value.ToString();
                cboLop.Text = row.Cells[3].Value.ToString();
            }
        }

        private void btThoat_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Bạn có muốn thoát không", "Thông báo", MessageBoxButtons.YesNo);
            this.Close();
        }
    }
}
