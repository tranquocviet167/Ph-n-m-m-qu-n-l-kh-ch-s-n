using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyKhachSan.All_User_Control
{
    public partial class UC_CustomerRes : UserControl
    {
        function fn = new function();
        String query;
        public UC_CustomerRes()
        {
            InitializeComponent();
        }

        public void setComboBox(String query, ComboBox combo)
        {
            SqlDataReader sdr = fn.getForCombo(query);
            while (sdr.Read())
            {
                for (int i = 0; i < sdr.FieldCount; i++)
                {
                    combo.Items.Add(sdr.GetString(i));
                }
            }
            sdr.Close();
        }

      

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void txtGiaTien_TextChanged(object sender, EventArgs e)
        {

        }

        

        private void cbbLoaiPhong_SelectedIndexChanged(object sender, EventArgs e)
        {
           cbbSoPhong.Items.Clear();
            query = "select roomNo from rooms where bed = '" + cbbLoaiGiuong.Text + "' and roomType = '" + cbbLoaiPhong.Text + "' and booked = 'NO'";
            setComboBox(query, cbbSoPhong);
           

        }
        private void cbbLoaiGiuong_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbbLoaiPhong.SelectedIndex = -1;
            cbbSoPhong.Items.Clear();
            txtGiaTien.Clear();

            
        }
        int rid;
        private void cbbSoPhong_SelectedIndexChanged(object sender, EventArgs e)
        {
            query = "select price , roomid from rooms where roomNo = '" + cbbSoPhong.Text + "'";
            DataSet ds = fn.getData(query);
            txtGiaTien.Text = ds.Tables[0].Rows[0][0].ToString();
            rid = int.Parse(ds.Tables[0].Rows[0][1].ToString());     
        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            if ( txtNhapTen.Text != "" && txtSoDienThoai.Text != "" && txtQuocTich.Text != "" && cbbGioiTinh.Text != "" && txtMaDinhDanh.Text !="" && txtDiaChi.Text !="" && txtNgayDangKy.Text !="" && txtGiaTien.Text != "")
            {
                String name = txtNhapTen.Text;
                Int64 mobile = Int64.Parse(txtSoDienThoai.Text);
                String quoctich = txtQuocTich.Text;
                String gioitinh = cbbGioiTinh.Text;
                String ngaysinh = txtNgaySinh.Text; 
                String madinhdanh = txtMaDinhDanh.Text;
                String diachi = txtDiaChi.Text;
                String ngaydangki = txtNgayDangKy.Text;

                query = " insert into customer (cname , mobile , nationality , gender , dob , idproof " +
                    ", address , checkin , roomid) values ('" + name + "'," + mobile + ",' "
                    + quoctich + " ',' " + gioitinh + " ','" + ngaysinh + "','"
                    + madinhdanh + "' ,'" + diachi + "','" + ngaydangki + "'," + rid + ")update rooms set booked = 'YES' where roomNo ='" + cbbSoPhong.Text + "'";


                fn.setData(query, "Số phòng " + cbbSoPhong.Text + "Đăng ký khách hàng thành công !");
                clearAll();


            }
            else
            {
                MessageBox.Show("Xin vui lòng nhập đầy đủ thông tin ", "Thông tin ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        public void clearAll()
        {
            txtNhapTen.Clear();
            txtSoDienThoai.Clear();
            txtQuocTich.Clear();
            cbbGioiTinh.SelectedIndex = -1;
            cbbGioiTinh.ResetText();
            txtMaDinhDanh.Clear();
            txtNgayDangKy.ResetText();
            txtDiaChi.Clear();
            cbbLoaiGiuong.SelectedIndex = -1;
            cbbLoaiPhong.SelectedIndex = -1;    
            cbbSoPhong.Items.Clear();   
            txtGiaTien.Clear();


        }

        private void UC_CustomerRes_Leave(object sender, EventArgs e)
        {
            clearAll();
     
        }
        private void UC_CustomerRes_Load(object sender, EventArgs e)
        {

        }
    }
}
