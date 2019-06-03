namespace DarkDemo.uc_controls
{
    partial class QLGiaoVien
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvGiaoVien = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTimKiemTen = new System.Windows.Forms.TextBox();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.cbxMonDay = new System.Windows.Forms.ComboBox();
            this.dtpNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.radNu = new System.Windows.Forms.RadioButton();
            this.radNam = new System.Windows.Forms.RadioButton();
            this.txtDanTocGV = new System.Windows.Forms.TextBox();
            this.txtQueQuanGV = new System.Windows.Forms.TextBox();
            this.txtHoVaTenGV = new System.Windows.Forms.TextBox();
            this.txtSDTGV = new System.Windows.Forms.TextBox();
            this.txtDiaChiGV = new System.Windows.Forms.TextBox();
            this.txtMaGV = new System.Windows.Forms.TextBox();
            this.lblNgaySinhGV = new System.Windows.Forms.Label();
            this.lblDanToc = new System.Windows.Forms.Label();
            this.lblMaMonGiangDay = new System.Windows.Forms.Label();
            this.lblQueQuanGV = new System.Windows.Forms.Label();
            this.lblSDTGV = new System.Windows.Forms.Label();
            this.lblTenGV = new System.Windows.Forms.Label();
            this.lblDiaChiGV = new System.Windows.Forms.Label();
            this.lblGioiTinhGV = new System.Windows.Forms.Label();
            this.lblMaGV = new System.Windows.Forms.Label();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGiaoVien)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvGiaoVien);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(759, 223);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách giáo viên";
            // 
            // dgvGiaoVien
            // 
            this.dgvGiaoVien.AllowUserToAddRows = false;
            this.dgvGiaoVien.AllowUserToDeleteRows = false;
            this.dgvGiaoVien.AllowUserToResizeRows = false;
            this.dgvGiaoVien.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvGiaoVien.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvGiaoVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvGiaoVien.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvGiaoVien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvGiaoVien.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dgvGiaoVien.Location = new System.Drawing.Point(3, 16);
            this.dgvGiaoVien.MultiSelect = false;
            this.dgvGiaoVien.Name = "dgvGiaoVien";
            this.dgvGiaoVien.ReadOnly = true;
            this.dgvGiaoVien.RowHeadersVisible = false;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.dgvGiaoVien.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvGiaoVien.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvGiaoVien.Size = new System.Drawing.Size(753, 204);
            this.dgvGiaoVien.TabIndex = 0;
            this.dgvGiaoVien.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvGiaoVien_CellMouseClick);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Controls.Add(this.cbxMonDay);
            this.groupBox2.Controls.Add(this.dtpNgaySinh);
            this.groupBox2.Controls.Add(this.radNu);
            this.groupBox2.Controls.Add(this.radNam);
            this.groupBox2.Controls.Add(this.txtDanTocGV);
            this.groupBox2.Controls.Add(this.txtQueQuanGV);
            this.groupBox2.Controls.Add(this.txtHoVaTenGV);
            this.groupBox2.Controls.Add(this.txtSDTGV);
            this.groupBox2.Controls.Add(this.txtDiaChiGV);
            this.groupBox2.Controls.Add(this.txtMaGV);
            this.groupBox2.Controls.Add(this.lblNgaySinhGV);
            this.groupBox2.Controls.Add(this.lblDanToc);
            this.groupBox2.Controls.Add(this.lblMaMonGiangDay);
            this.groupBox2.Controls.Add(this.lblQueQuanGV);
            this.groupBox2.Controls.Add(this.lblSDTGV);
            this.groupBox2.Controls.Add(this.lblTenGV);
            this.groupBox2.Controls.Add(this.lblDiaChiGV);
            this.groupBox2.Controls.Add(this.lblGioiTinhGV);
            this.groupBox2.Controls.Add(this.lblMaGV);
            this.groupBox2.Controls.Add(this.btnXoa);
            this.groupBox2.Controls.Add(this.btnSua);
            this.groupBox2.Controls.Add(this.btnThem);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.groupBox2.Location = new System.Drawing.Point(0, 223);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(759, 220);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chi tiết";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.txtTimKiemTen);
            this.groupBox3.Controls.Add(this.btnTimKiem);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBox3.Location = new System.Drawing.Point(473, 16);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(283, 201);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Tìm kiếm";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nhập tên cần tìm:";
            // 
            // txtTimKiemTen
            // 
            this.txtTimKiemTen.Location = new System.Drawing.Point(110, 50);
            this.txtTimKiemTen.Name = "txtTimKiemTen";
            this.txtTimKiemTen.Size = new System.Drawing.Size(155, 20);
            this.txtTimKiemTen.TabIndex = 1;
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTimKiem.Location = new System.Drawing.Point(110, 100);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(75, 23);
            this.btnTimKiem.TabIndex = 0;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // cbxMonDay
            // 
            this.cbxMonDay.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxMonDay.FormattingEnabled = true;
            this.cbxMonDay.Location = new System.Drawing.Point(268, 133);
            this.cbxMonDay.Name = "cbxMonDay";
            this.cbxMonDay.Size = new System.Drawing.Size(100, 21);
            this.cbxMonDay.TabIndex = 6;
            // 
            // dtpNgaySinh
            // 
            this.dtpNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgaySinh.Location = new System.Drawing.Point(84, 169);
            this.dtpNgaySinh.Name = "dtpNgaySinh";
            this.dtpNgaySinh.Size = new System.Drawing.Size(100, 20);
            this.dtpNgaySinh.TabIndex = 5;
            // 
            // radNu
            // 
            this.radNu.AutoSize = true;
            this.radNu.Location = new System.Drawing.Point(329, 30);
            this.radNu.Name = "radNu";
            this.radNu.Size = new System.Drawing.Size(39, 17);
            this.radNu.TabIndex = 4;
            this.radNu.TabStop = true;
            this.radNu.Text = "Nữ";
            this.radNu.UseVisualStyleBackColor = true;
            // 
            // radNam
            // 
            this.radNam.AutoSize = true;
            this.radNam.Location = new System.Drawing.Point(268, 30);
            this.radNam.Name = "radNam";
            this.radNam.Size = new System.Drawing.Size(47, 17);
            this.radNam.TabIndex = 3;
            this.radNam.TabStop = true;
            this.radNam.Text = "Nam";
            this.radNam.UseVisualStyleBackColor = true;
            // 
            // txtDanTocGV
            // 
            this.txtDanTocGV.Location = new System.Drawing.Point(84, 135);
            this.txtDanTocGV.Name = "txtDanTocGV";
            this.txtDanTocGV.Size = new System.Drawing.Size(100, 20);
            this.txtDanTocGV.TabIndex = 2;
            // 
            // txtQueQuanGV
            // 
            this.txtQueQuanGV.Location = new System.Drawing.Point(84, 101);
            this.txtQueQuanGV.Name = "txtQueQuanGV";
            this.txtQueQuanGV.Size = new System.Drawing.Size(100, 20);
            this.txtQueQuanGV.TabIndex = 2;
            // 
            // txtHoVaTenGV
            // 
            this.txtHoVaTenGV.Location = new System.Drawing.Point(84, 66);
            this.txtHoVaTenGV.Name = "txtHoVaTenGV";
            this.txtHoVaTenGV.Size = new System.Drawing.Size(100, 20);
            this.txtHoVaTenGV.TabIndex = 2;
            // 
            // txtSDTGV
            // 
            this.txtSDTGV.Location = new System.Drawing.Point(268, 97);
            this.txtSDTGV.Name = "txtSDTGV";
            this.txtSDTGV.Size = new System.Drawing.Size(100, 20);
            this.txtSDTGV.TabIndex = 2;
            // 
            // txtDiaChiGV
            // 
            this.txtDiaChiGV.Location = new System.Drawing.Point(268, 62);
            this.txtDiaChiGV.Name = "txtDiaChiGV";
            this.txtDiaChiGV.Size = new System.Drawing.Size(100, 20);
            this.txtDiaChiGV.TabIndex = 2;
            // 
            // txtMaGV
            // 
            this.txtMaGV.Location = new System.Drawing.Point(84, 28);
            this.txtMaGV.Name = "txtMaGV";
            this.txtMaGV.ReadOnly = true;
            this.txtMaGV.Size = new System.Drawing.Size(100, 20);
            this.txtMaGV.TabIndex = 2;
            // 
            // lblNgaySinhGV
            // 
            this.lblNgaySinhGV.AutoSize = true;
            this.lblNgaySinhGV.Location = new System.Drawing.Point(21, 173);
            this.lblNgaySinhGV.Name = "lblNgaySinhGV";
            this.lblNgaySinhGV.Size = new System.Drawing.Size(57, 13);
            this.lblNgaySinhGV.TabIndex = 1;
            this.lblNgaySinhGV.Text = "Ngày sinh:";
            // 
            // lblDanToc
            // 
            this.lblDanToc.AutoSize = true;
            this.lblDanToc.Location = new System.Drawing.Point(21, 139);
            this.lblDanToc.Name = "lblDanToc";
            this.lblDanToc.Size = new System.Drawing.Size(48, 13);
            this.lblDanToc.TabIndex = 1;
            this.lblDanToc.Text = "Dân tộc:";
            // 
            // lblMaMonGiangDay
            // 
            this.lblMaMonGiangDay.AutoSize = true;
            this.lblMaMonGiangDay.Location = new System.Drawing.Point(205, 136);
            this.lblMaMonGiangDay.Name = "lblMaMonGiangDay";
            this.lblMaMonGiangDay.Size = new System.Drawing.Size(51, 13);
            this.lblMaMonGiangDay.TabIndex = 1;
            this.lblMaMonGiangDay.Text = "Môn dạy:";
            // 
            // lblQueQuanGV
            // 
            this.lblQueQuanGV.AutoSize = true;
            this.lblQueQuanGV.Location = new System.Drawing.Point(21, 105);
            this.lblQueQuanGV.Name = "lblQueQuanGV";
            this.lblQueQuanGV.Size = new System.Drawing.Size(57, 13);
            this.lblQueQuanGV.TabIndex = 1;
            this.lblQueQuanGV.Text = "Quê quán:";
            // 
            // lblSDTGV
            // 
            this.lblSDTGV.AutoSize = true;
            this.lblSDTGV.Location = new System.Drawing.Point(205, 101);
            this.lblSDTGV.Name = "lblSDTGV";
            this.lblSDTGV.Size = new System.Drawing.Size(32, 13);
            this.lblSDTGV.TabIndex = 1;
            this.lblSDTGV.Text = "SĐT:";
            // 
            // lblTenGV
            // 
            this.lblTenGV.AutoSize = true;
            this.lblTenGV.Location = new System.Drawing.Point(21, 70);
            this.lblTenGV.Name = "lblTenGV";
            this.lblTenGV.Size = new System.Drawing.Size(57, 13);
            this.lblTenGV.TabIndex = 1;
            this.lblTenGV.Text = "Họ và tên:";
            // 
            // lblDiaChiGV
            // 
            this.lblDiaChiGV.AutoSize = true;
            this.lblDiaChiGV.Location = new System.Drawing.Point(205, 66);
            this.lblDiaChiGV.Name = "lblDiaChiGV";
            this.lblDiaChiGV.Size = new System.Drawing.Size(43, 13);
            this.lblDiaChiGV.TabIndex = 1;
            this.lblDiaChiGV.Text = "Địa chỉ:";
            // 
            // lblGioiTinhGV
            // 
            this.lblGioiTinhGV.AutoSize = true;
            this.lblGioiTinhGV.Location = new System.Drawing.Point(205, 32);
            this.lblGioiTinhGV.Name = "lblGioiTinhGV";
            this.lblGioiTinhGV.Size = new System.Drawing.Size(50, 13);
            this.lblGioiTinhGV.TabIndex = 1;
            this.lblGioiTinhGV.Text = "Giới tính:";
            // 
            // lblMaGV
            // 
            this.lblMaGV.AutoSize = true;
            this.lblMaGV.Location = new System.Drawing.Point(21, 31);
            this.lblMaGV.Name = "lblMaGV";
            this.lblMaGV.Size = new System.Drawing.Size(43, 13);
            this.lblMaGV.TabIndex = 1;
            this.lblMaGV.Text = "Mã GV:";
            // 
            // btnXoa
            // 
            this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoa.Location = new System.Drawing.Point(392, 116);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 23);
            this.btnXoa.TabIndex = 0;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSua.Location = new System.Drawing.Point(392, 84);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 23);
            this.btnSua.TabIndex = 0;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThem.Location = new System.Drawing.Point(392, 52);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 23);
            this.btnThem.TabIndex = 0;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // QLGiaoVien
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "QLGiaoVien";
            this.Size = new System.Drawing.Size(759, 443);
            this.Load += new System.EventHandler(this.QLGiaoVien_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGiaoVien)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvGiaoVien;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtMaGV;
        private System.Windows.Forms.Label lblMaGV;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.DateTimePicker dtpNgaySinh;
        private System.Windows.Forms.RadioButton radNu;
        private System.Windows.Forms.RadioButton radNam;
        private System.Windows.Forms.TextBox txtDanTocGV;
        private System.Windows.Forms.TextBox txtQueQuanGV;
        private System.Windows.Forms.TextBox txtHoVaTenGV;
        private System.Windows.Forms.TextBox txtSDTGV;
        private System.Windows.Forms.TextBox txtDiaChiGV;
        private System.Windows.Forms.Label lblNgaySinhGV;
        private System.Windows.Forms.Label lblDanToc;
        private System.Windows.Forms.Label lblMaMonGiangDay;
        private System.Windows.Forms.Label lblQueQuanGV;
        private System.Windows.Forms.Label lblSDTGV;
        private System.Windows.Forms.Label lblTenGV;
        private System.Windows.Forms.Label lblDiaChiGV;
        private System.Windows.Forms.Label lblGioiTinhGV;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.ComboBox cbxMonDay;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTimKiemTen;
        private System.Windows.Forms.Button btnTimKiem;
    }
}
