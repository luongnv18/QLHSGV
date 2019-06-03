using DarkDemo.uc_controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DarkDemo
{
    public partial class frmMain : Form
    {
        int mov;
        int movX,movY;
        public frmMain()
        {
            InitializeComponent();
        }

        private void AddControlsToPanel(Control c)
        {
            c.Dock = DockStyle.Fill;
            panel2.Controls.Clear();
            panel2.Controls.Add(c);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            QLHocSinh uch = new QLHocSinh();
            AddControlsToPanel(uch);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            QLGiaoVien ucm = new QLGiaoVien();
            AddControlsToPanel(ucm);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            QLGiangDay uck = new QLGiangDay();
            AddControlsToPanel(uck);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void panel3_MouseDown(object sender, MouseEventArgs e)
        {
            mov = 1;
            movX = e.X;
            movY = e.Y;
        }

        private void panel3_MouseUp(object sender, MouseEventArgs e)
        {
            mov = 0;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Location = Screen.AllScreens[1].WorkingArea.Location;
        }

        private void panel3_MouseMove(object sender, MouseEventArgs e)
        {
            if (mov==1)
            {
                this.SetDesktopLocation(MousePosition.X - movX, MousePosition.Y - movY);
            }
        }
    }
}
