using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace DarkDemo
{
    public partial class frmDangNhap : Form
    {
        public static string ID_USER = "";
        public frmDangNhap()
        {
            InitializeComponent();
        }
        private string getID(string username, string pass)
        {
            SqlConnection con = new SqlConnection(@"Data Source=NVL-PC;Initial Catalog=QLHocSinhGiaoVien;Integrated Security=True");
            string id = "";
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM TaiKhoan WHERE tentaikhoan ='" + username + "' and matkhau='" + pass + "'", con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt != null)
                {
                    foreach (DataRow dr in dt.Rows)
                    {
                        id = dr["id"].ToString();
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Lỗi xảy ra khi truy vấn dữ liệu hoặc kết nối với server thất bại !");
            }
            finally
            {
                con.Close();
            }
            return id;
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            
                ID_USER = getID(txtTaiKhoan.Text, txtMatKhau.Text);
                if (ID_USER != "")
                {
                    frmMain fmain = new frmMain();
                    this.Hide();
                    fmain.Show();
                }
                else
                {
                    MessageBox.Show("Tài khoản và mật khẩu không đúng !");
                }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
