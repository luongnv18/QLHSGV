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
    public partial class QLGiangDay : UserControl
    {
        BindingSource List = new BindingSource();
        BindingSource List2 = new BindingSource();
        public QLGiangDay()
        {
            InitializeComponent();
            Loadcb();
        }

        void Loadcb()
        {
            cbMon.DataSource = GiangDay.Instance.DanhSachMon();
            cbMon.DisplayMember = "Name";

            cbGv2.DataSource = GiangDay.Instance.DanhSachGiaoVien();
            cbGv2.DisplayMember = "Name";

            cbLop.DataSource = HocSinh.Instance.DanhSachLopHoc();
            cbLop.DisplayMember = "Name";

            cbLopGD.DataSource = HocSinh.Instance.DanhSachLopHoc();
            cbLopGD.DisplayMember = "Name";
        }
        private void btnS1_Click(object sender, EventArgs e)
        {
            cbGv2.DataBindings.Clear();
            txtMon2.DataBindings.Clear();
            txtThoiGian2.DataBindings.Clear();
            dataGridView1.DataSource = List;
            Binding1();

            dataGridView1.Columns[1].Width = 70;
            dataGridView1.Columns[1].Width = dataGridView1.Columns[2].Width = dataGridView1.Columns[3].Width = 200;
        }
        void Binding1()
        {
            cbGV.DataBindings.Add(new Binding("Text", dataGridView1.DataSource, "ten", true, DataSourceUpdateMode.Never));
            cbLopGD.DataBindings.Add(new Binding("Text", dataGridView1.DataSource, "tenlop", true, DataSourceUpdateMode.Never));
            txtThoigian.DataBindings.Add(new Binding("Text", dataGridView1.DataSource, "thoigian", true, DataSourceUpdateMode.Never));
        }
        private void btnS2_Click(object sender, EventArgs e)
        {
            cbGV.DataBindings.Clear();
            cbLopGD.DataBindings.Clear();
            txtThoigian.DataBindings.Clear();
            dataGridView1.DataSource = List2;
            Binding2();
        }
        void Binding2()
        {
            cbGv2.DataBindings.Add(new Binding("Text", dataGridView1.DataSource, "ten", true, DataSourceUpdateMode.Never));
            txtMon2.DataBindings.Add(new Binding("Text", dataGridView1.DataSource, "tenmon", true, DataSourceUpdateMode.Never));
            txtThoiGian2.DataBindings.Add(new Binding("Text", dataGridView1.DataSource, "thoigian", true, DataSourceUpdateMode.Never));
        }
        private void cbMon_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbGV.DataSource = GiangDay.Instance.DanhSachGVtheoMon((cbMon.SelectedItem as MonHoc).ID);
            cbGV.DisplayMember = "Name";

            txtMon.Text = (cbMon.SelectedItem as MonHoc).Name;
            List.DataSource = GiangDay.Instance.GetList1((cbMon.SelectedItem as MonHoc).ID);
        }

        private void btnAdd1_Click(object sender, EventArgs e)
        {
            string magv = (cbGV.SelectedItem as GiaoVien).ID;
            string malop = (cbLopGD.SelectedItem as LopHoc).ID;
            string tgian = txtThoigian.Text;
            if (GiangDay.Instance.Insert1(magv, malop, tgian))
            {
                List.DataSource = GiangDay.Instance.GetList1((cbMon.SelectedItem as MonHoc).ID);
            }
        }

        private void btnEdit1_Click(object sender, EventArgs e)
        {
            string magv = (cbGV.SelectedItem as GiaoVien).ID;
            string malop = (cbLopGD.SelectedItem as LopHoc).ID;
            string tgian = txtThoigian.Text;
            int rowindex = dataGridView1.CurrentCell.RowIndex;

            string magd = dataGridView1.Rows[rowindex].Cells[0].Value.ToString();
            if (GiangDay.Instance.Update1(magv, malop, tgian, magd))
            {
                List.DataSource = GiangDay.Instance.GetList1((cbMon.SelectedItem as MonHoc).ID);
            }
        }

        private void btnDel1_Click(object sender, EventArgs e)
        {
            int rowindex = dataGridView1.CurrentCell.RowIndex;
            string magd = dataGridView1.Rows[rowindex].Cells[0].Value.ToString();

            if (GiangDay.Instance.Delete1(magd))
            {
                List.DataSource = GiangDay.Instance.GetList1((cbMon.SelectedItem as MonHoc).ID);
            }

        }

        private void cbLop_SelectedIndexChanged(object sender, EventArgs e)
        {
            List2.DataSource = GiangDay.Instance.GetList2((cbLop.SelectedItem as LopHoc).ID);
        }

        private void cbGv2_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                foreach (DataRow item in GiangDay.Instance.DanhSachMontheoGV((cbGv2.SelectedItem as GiaoVien).ID).Rows)
                {
                    txtMon2.Text = item[1].ToString();
                }
            }
            catch (Exception)
            {

            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string magv = (cbGv2.SelectedItem as GiaoVien).ID;
            string malop = (cbLop.SelectedItem as LopHoc).ID;
            string tgian = txtThoiGian2.Text;
            if (GiangDay.Instance.Insert1(magv, malop, tgian))
            {
                List2.DataSource = GiangDay.Instance.GetList2((cbLop.SelectedItem as LopHoc).ID);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            string magv = (cbGv2.SelectedItem as GiaoVien).ID;
            string malop = (cbLop.SelectedItem as LopHoc).ID;
            string tgian = txtThoiGian2.Text;
            int rowindex = dataGridView1.CurrentCell.RowIndex;

            string magd = dataGridView1.Rows[rowindex].Cells[0].Value.ToString();
            if (GiangDay.Instance.Update1(magv, malop, tgian, magd))
            {
                List2.DataSource = GiangDay.Instance.GetList2((cbLop.SelectedItem as LopHoc).ID);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int rowindex = dataGridView1.CurrentCell.RowIndex;
            string magd = dataGridView1.Rows[rowindex].Cells[0].Value.ToString();

            if (GiangDay.Instance.Delete1(magd))
            {
                List2.DataSource = GiangDay.Instance.GetList2((cbLop.SelectedItem as LopHoc).ID);
            }
        }
    }
}
