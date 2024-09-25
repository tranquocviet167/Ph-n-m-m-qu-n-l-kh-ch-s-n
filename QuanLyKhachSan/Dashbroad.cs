using QuanLyKhachSan.All_User_Control;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyKhachSan
{
    public partial class Dashbroad : Form
    {
        public Dashbroad()
        {
            InitializeComponent();

        }

        private void gnExit_Click(object sender, EventArgs e)
        {
            Application.Exit(); 
        }
        private void Dashbroad_Load(object sender, EventArgs e)
        {
            uC_AddRoom1.Visible = false;
            uC_CustomerRes1.Visible = false;
            uC_CheckOut1.Visible = false;
            uC_CustomerDetails1.Visible = false;
            uC_Employee1.Visible = false;

            btnThemPhong.PerformClick();

        }

        private void btnThemPhong_Click(object sender, EventArgs e)
        {
            plDiChuyen.Left = btnThemPhong.Left + 67;
            uC_AddRoom1.Visible = true;
            uC_AddRoom1.BringToFront();
        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

       

        private void btnDangKyKH_Click(object sender, EventArgs e)
        {
            plDiChuyen.Left = btnDangKyKH.Left + 67;
            uC_CustomerRes1.Visible = true;
            uC_CustomerRes1.BringToFront();
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            plDiChuyen.Left = btnThanhToan.Left + 67;
            uC_CheckOut1.Visible = true;
            uC_CheckOut1.BringToFront();
        }

        private void uC_CheckOut1_Load(object sender, EventArgs e)
        {

        }

        private void btnChiTietKH_Click(object sender, EventArgs e)
        {
            plDiChuyen.Left = btnChiTietKH.Left + 67;
            uC_CustomerDetails1.Visible = true;
            uC_CustomerDetails1.BringToFront();
        }

        private void btnNhanVien_Click(object sender, EventArgs e)
        {
            plDiChuyen.Left = btnNhanVien.Left + 67;
            uC_Employee1.Visible = true;
            uC_Employee1.BringToFront();

        }
    }
}
