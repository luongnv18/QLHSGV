using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace DarkDemo.uc_controls
{
    public partial class QLGiaoVien : UserControl
    {
        public QLGiaoVien()
        {
            InitializeComponent();
        }
        SqlConnection con;
        private void QLGiaoVien_Load(object sender, EventArgs e)
        {
            string connectionStr = @"Data Source=NVL-PC;Initial Catalog=QLHocSinhGiaoVien;Integrated Security=True";
            con = new SqlConnection(connectionStr);
            if (con.State != ConnectionState.Open)
                con.Open();
            HienThidgvGiaoVien();
            HienThicbxMonDay();
        }
        public void HienThidgvGiaoVien()
        {
            string sqlSelectGiaoVien = "select * from GiaoVien";
            SqlCommand cmd = new SqlCommand(sqlSelectGiaoVien, con);
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            dgvGiaoVien.DataSource = dt;
            dgvGiaoVien.Columns[0].HeaderText = "Mã giáo viên";
            dgvGiaoVien.Columns[0].Width = 50;
            dgvGiaoVien.Columns[1].HeaderText = "Tên giáo viên";
            dgvGiaoVien.Columns[1].Width = 150;
            dgvGiaoVien.Columns[2].HeaderText = "Quê quán";
            dgvGiaoVien.Columns[2].Width = 150;
            dgvGiaoVien.Columns[3].HeaderText = "Dân tộc";
            dgvGiaoVien.Columns[3].Width = 50;
            dgvGiaoVien.Columns[4].HeaderText = "Ngày sinh";
            dgvGiaoVien.Columns[4].Width = 100;
            dgvGiaoVien.Columns[5].HeaderText = "Giới tính";
            dgvGiaoVien.Columns[5].Width = 50;
            dgvGiaoVien.Columns[6].HeaderText = "Địa chỉ";
            dgvGiaoVien.Columns[6].Width = 150;
            dgvGiaoVien.Columns[7].HeaderText = "SĐT";
            dgvGiaoVien.Columns[7].Width = 100;
            dgvGiaoVien.Columns[8].HeaderText = "Mã môn giảng dạy";
            dgvGiaoVien.Columns[8].Width = 50;
        }

        public void HienThicbxMonDay()
        {
            string sqlSelectMonHoc = "select * from MonHoc";
            SqlCommand cmd = new SqlCommand(sqlSelectMonHoc, con);
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            cbxMonDay.DataSource = dt;
            cbxMonDay.DisplayMember = "tenmon";
            cbxMonDay.ValueMember = "mamonhoc";
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string sqlINSERT = "INSERT INTO GiaoVien VALUES(@tenGV, @queQuan,@danToc,@ngaySinh,@gioiTinh,@diaChi,@sdt,@maMonDay)";
            SqlCommand cmd = new SqlCommand(sqlINSERT, con);
            cmd.Parameters.AddWithValue("@tenGV", txtHoVaTenGV.Text);
            cmd.Parameters.AddWithValue("@queQuan", txtQueQuanGV.Text);
            cmd.Parameters.AddWithValue("@danToc", txtDanTocGV.Text);
            cmd.Parameters.AddWithValue("@ngaySinh", Convert.ToDateTime(dtpNgaySinh.Text));
            cmd.Parameters.AddWithValue("@gioiTinh", radNam.Checked ? radNam.Text : radNu.Text);
            cmd.Parameters.AddWithValue("@diaChi", txtDiaChiGV.Text);
            cmd.Parameters.AddWithValue("@sdt", txtSDTGV.Text);
            cmd.Parameters.AddWithValue("@maMonDay", cbxMonDay.SelectedValue.ToString());
            cmd.ExecuteNonQuery();
            HienThidgvGiaoVien();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string sqlEdit = "UPDATE GiaoVien SET ten=@tenGV, quequan=@queQuan, dantoc=@danToc,ngaysinh=@ngaySinh," +
                "gioitinh=@gioiTinh,diachi=@diaChi,sdt=@sdt,mamongiangday=@maMonDay WHERE magiaovien=@maGV";
            SqlCommand cmd = new SqlCommand(sqlEdit, con);
            cmd.Parameters.AddWithValue("@maGV", txtMaGV.Text);
            cmd.Parameters.AddWithValue("@tenGV", txtHoVaTenGV.Text);
            cmd.Parameters.AddWithValue("@queQuan", txtQueQuanGV.Text);
            cmd.Parameters.AddWithValue("@danToc", txtDanTocGV.Text);
            cmd.Parameters.AddWithValue("@ngaySinh", Convert.ToDateTime(dtpNgaySinh.Value));
            cmd.Parameters.AddWithValue("@gioiTinh", radNam.Checked ? radNam.Text : radNu.Text);
            cmd.Parameters.AddWithValue("@diaChi", txtDiaChiGV.Text);
            cmd.Parameters.AddWithValue("@sdt", txtSDTGV.Text);
            cmd.Parameters.AddWithValue("@maMonDay", cbxMonDay.SelectedValue.ToString());
            cmd.ExecuteNonQuery();
            HienThidgvGiaoVien();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string sqlDELETE = "DELETE FROM GiaoVien WHERE magiaovien=@maGV";
            SqlCommand cmd = new SqlCommand(sqlDELETE, con);
            cmd.Parameters.AddWithValue("@maGV", txtMaGV.Text);
            cmd.ExecuteNonQuery();
            HienThidgvGiaoVien();
        }

        private void dgvGiaoVien_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int numrow;
            numrow = e.RowIndex;
            if (numrow < 0) return;
            txtMaGV.Text = dgvGiaoVien.Rows[numrow].Cells[0].Value.ToString();
            txtHoVaTenGV.Text = dgvGiaoVien.Rows[numrow].Cells[1].Value.ToString();
            txtQueQuanGV.Text = dgvGiaoVien.Rows[numrow].Cells[2].Value.ToString();
            txtDanTocGV.Text = dgvGiaoVien.Rows[numrow].Cells[3].Value.ToString();
            dtpNgaySinh.Value = Convert.ToDateTime(dgvGiaoVien.Rows[numrow].Cells[4].Value);
            if (dgvGiaoVien.Rows[numrow].Cells[5].Value.ToString() == "Nam") radNam.Checked = true;
            else if (dgvGiaoVien.Rows[numrow].Cells[5].Value.ToString() == "Nữ") radNu.Checked = true;
            txtDiaChiGV.Text = dgvGiaoVien.Rows[numrow].Cells[6].Value.ToString();
            txtSDTGV.Text = dgvGiaoVien.Rows[numrow].Cells[7].Value.ToString();
            cbxMonDay.SelectedValue = dgvGiaoVien.Rows[numrow].Cells[8].Value.ToString();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            if (txtTimKiemTen.Text != "")
            {
                string sqlTimKiem = @"SELECT * FROM GiaoVien WHERE ten like N'%" + txtTimKiemTen.Text + "%'";
                SqlCommand cmd = new SqlCommand(sqlTimKiem, con);
                SqlDataReader dr = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(dr);
                dgvGiaoVien.DataSource = dt;
            }
            else
            {
                MessageBox.Show("Vui lòng nhập thông tin cần tìm!", "Thông báo");
                return;
            }
        }
    }
}
