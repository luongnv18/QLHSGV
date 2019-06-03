using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DarkDemo.DAO;
using DarkDemo.DTO;

namespace DarkDemo.uc_controls
{
    public partial class QLHocSinh : UserControl
    {
        BindingSource List = new BindingSource();
        public QLHocSinh()
        {
            InitializeComponent();
            LoadData();
        }

        void LoadData()
        {
            dtgvHS.DataSource = List;

            LoadList();
            Binding();
        }

        void LoadList()
        {
           List.DataSource = HocSinh.Instance.GetListProduct();
        }

        void Binding()
        {
            groupBox1.Enabled = false;
            txtMa.DataBindings.Add(new Binding("Text", dtgvHS.DataSource, "mahocsinh", true, DataSourceUpdateMode.Never));
            txtTen.DataBindings.Add(new Binding("Text", dtgvHS.DataSource, "ten", true, DataSourceUpdateMode.Never));
            txtQue.DataBindings.Add(new Binding("Text", dtgvHS.DataSource, "quequan", true, DataSourceUpdateMode.Never));
            txtDC.DataBindings.Add(new Binding("Text", dtgvHS.DataSource, "diachi", true, DataSourceUpdateMode.Never));
            txtSDT.DataBindings.Add(new Binding("Text", dtgvHS.DataSource, "sdt", true, DataSourceUpdateMode.Never));
            txtDT.DataBindings.Add(new Binding("Text", dtgvHS.DataSource, "dantoc", true, DataSourceUpdateMode.Never));
            txtNS.DataBindings.Add(new Binding("Text", dtgvHS.DataSource, "ngaysinh", true, DataSourceUpdateMode.Never));
            cbGt.DataBindings.Add(new Binding("Text", dtgvHS.DataSource, "gioitinh", true, DataSourceUpdateMode.Never));
            cbLop.DataBindings.Add(new Binding("Text", dtgvHS.DataSource, "tenlop", true, DataSourceUpdateMode.Never));

            cbLop.DataSource = HocSinh.Instance.DanhSachLopHoc();
            cbLop.DisplayMember = "Name";
            //cbSearch.DataSource = MenuFood.Instance.GetListMenuFood();
            //cbSearch.DisplayMember = "Name";

        }

        void Clear()
        {
            txtMa.Text = null;
            txtTen.Text = null;
            txtQue.Text = null;
            txtDC.Text = null;
            txtSDT.Text = null;
            txtDT.Text = null;
            cbGt.Text = null;
            cbLop.Text = null;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Clear();
            groupBox1.Enabled = true;
            dtgvHS.Enabled = false;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            groupBox1.Enabled = true;
            dtgvHS.Enabled = false;
            txtMa.Enabled = false;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string id = txtMa.Text;

            if (MessageBox.Show("Delete this Product ?", "Quetion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                return;
            }
            else
                if (HocSinh.Instance.Delete(id))
            {
                LoadList();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtMa.Enabled != false)
            {
                groupBox1.Enabled = false;
                dtgvHS.Enabled = true;
                string ma = txtMa.Text;
                string ten = txtTen.Text;
                string gt = cbGt.SelectedItem.ToString();
                string ns = txtNS.Text;
                string dt = txtDT.Text;
                string que = txtQue.Text;
                string dc = txtDC.Text;
                string sdt = txtSDT.Text;

                string lop = (cbLop.SelectedItem as LopHoc).ID;
                if (HocSinh.Instance.Insert(ma, ten, gt, ns, dt, que, dc, sdt, lop))
                {
                    LoadList();
                }
            }
            else if (txtMa.Enabled == false)
            {
                groupBox1.Enabled = false;
                dtgvHS.Enabled = true;
                string ma = txtMa.Text;
                string ten = txtTen.Text;
                string gt = cbGt.SelectedItem.ToString();
                string ns = txtNS.Text;
                string dt = txtDT.Text;
                string que = txtQue.Text;
                string dc = txtDC.Text;
                string sdt = txtSDT.Text;

                string lop = (cbLop.SelectedItem as LopHoc).ID;

                if (HocSinh.Instance.Update(ma, ten, gt, ns, dt, que, dc, sdt, lop))
                {
                    LoadList();
                }
            }
        }

        private void cbKhoi_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbLopKhoi.DataSource = HocSinh.Instance.DanhSachLopTheoKhoi(cbKhoi.SelectedItem.ToString());
            cbLopKhoi.DisplayMember = "Name";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List.DataSource = HocSinh.Instance.GetList(((cbLopKhoi.SelectedItem as LopHoc).ID));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            LoadList();
        }
    }
}
