using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyKhachSan.All_User_Control
{
    public partial class UC_AddRoom : UserControl
    {
        function fn = new function();
        String query;
        public UC_AddRoom()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }


        private void UC_AddRoom_Load(object sender, EventArgs e)
        {
            query = "select * from rooms ";
            DataSet ds = fn.getData(query);
            datagridview.DataSource = ds.Tables[0];
            datagridview.ColumnHeadersHeight = 40;
            // Thay đổi tên các cột
            datagridview.Columns[0].HeaderText = "ID";
            datagridview.Columns[1].HeaderText = "Số phòng";
            datagridview.Columns[2].HeaderText = "Loại phòng";
            datagridview.Columns[3].HeaderText = "Loại giường";
            datagridview.Columns[4].HeaderText = "Giá tiền";
            datagridview.Columns[5].HeaderText = "Đã đặt";
        }


        private void btnThemPhongg_Click(object sender, EventArgs e)
        {
            if (txtSoPhong.Text !="" && cbbLoaiPhong.Text !="" && cbbLoaiGiuong.Text !="" && txtGiaTien.Text!="")
            {
                String sophong = txtSoPhong.Text;
                String loaiphong = cbbLoaiPhong.Text;
                String loaigiuong = cbbLoaiGiuong.Text;
                Int64 giatien = Int64.Parse(txtGiaTien.Text);


                query = "insert into rooms (roomNo,roomType,bed,price)values('" + sophong + " ','" + loaiphong + "','" + loaigiuong +"'," + giatien +")";
                fn.setData(query, "Đã thêm phòng !");

              




                UC_AddRoom_Load(this,null);
                clearAll();

            }
            else
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin !!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void clearAll()
        {
            txtSoPhong.Clear();
            cbbLoaiGiuong.SelectedIndex = -1;
            cbbLoaiGiuong.SelectedIndex = -1;
            txtGiaTien.Clear();
        }

        private void UC_AddRoom_Leave(object sender, EventArgs e)
        {
            clearAll();
        }

        private void UC_AddRoom_Enter(object sender, EventArgs e)
        {
            UC_AddRoom_Load(this, null);
        }

        private void datagridview_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
