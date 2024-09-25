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
    public partial class UC_Employee : UserControl
    {
        function fn = new function();
        String query;

        public UC_Employee()
        {
            InitializeComponent();
            // Gắn sự kiện cho guna2DataGridView2 khi người dùng click vào dòng
            this.guna2DataGridView2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.guna2DataGridView2_CellClick);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void guna2TextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2TextBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void UC_Employee_Load(object sender, EventArgs e)
        {
            getMaxID();
            guna2DataGridView1.ColumnHeadersHeight = 40;

        }

        //==================================
        public void getMaxID()
        {
            query = "select max(eid) from employee";
            DataSet ds = fn.getData(query);

            if (ds.Tables[0].Rows[0][0].ToString() != "")
            {
                Int64 num = Int64.Parse(ds.Tables[0].Rows[0][0].ToString());
                LabelToSET.Text = (num + 1).ToString();
            }
        }

        private void btnDangKyNhanVien_Click(object sender, EventArgs e)
        {
            if (txtTen.Text != "" && txtSdt.Text != "" && txtEmail.Text != "" && cbbGioiTinh.Text != "" && txtTenDangNhap.Text != "" && txtMatKhau.Text != "")
            {
                String name = txtTen.Text;
                Int64 mobile = Int64.Parse(txtSdt.Text);
                String gender = cbbGioiTinh.Text;
                String username = txtTenDangNhap.Text;
                String pass = txtMatKhau.Text;
                String email = txtEmail.Text;

                query = "insert into employee (ename, mobile, gender, emailid, username, pass) values ('" + name + "'," + mobile + ", '" + gender + "','" + email + "','" + username + "','" + pass + "')";
                fn.setData(query, "Đăng ký nhân viên thành công !!!");

                clearAll();
                getMaxID();
            }
            else
            {
                MessageBox.Show("Vui lòng nhập đủ thông tin !!!", " Thông báo ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
        }

        public void clearAll()
        {
            txtTen.Clear();
            txtSdt.Clear();
            cbbGioiTinh.SelectedIndex = -1;
            txtEmail.Clear();
            txtMatKhau.Clear();
            txtTenDangNhap.Clear();
        }

        private void tabEmployee_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabEmployee.SelectedIndex == 1)
            {
                setEmployee(guna2DataGridView1);
            }
            else if (tabEmployee.SelectedIndex == 2)
            {
                setEmployee(guna2DataGridView2);
            }
        }

        public void setEmployee(DataGridView dgv)
        {
            query = "select * from employee";
            DataSet ds = fn.getData(query);
            dgv.DataSource = ds.Tables[0];
        }

        private void tabEmployee_Leave(object sender, EventArgs e)
        {

        }

        // Sự kiện khi chọn hàng trong guna2DataGridView2
        private void guna2DataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)  // Kiểm tra xem có phải là hàng hợp lệ không
            {
                DataGridViewRow row = guna2DataGridView2.Rows[e.RowIndex];

                // Lấy giá trị từ cột "eid" và gán vào txtID
                txtID.Text = row.Cells["eid"].Value.ToString();
            }
        }

        // Xóa nhân viên khi nhấn nút Xóa
        private void btnXoa_Click(object sender, EventArgs e)
        {
            btnXoa.FillColor = Color.Red;
            if (txtID.Text != "")
            {
                if (MessageBox.Show("Bạn có chắc chắn không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    query = "delete from employee where eid = " + txtID.Text;
                    fn.setData(query, "Thông tin nhân viên đã được xoá!!");

                    // Cập nhật lại DataGridView
                    setEmployee(guna2DataGridView2);

                    txtID.Clear();  // Xóa giá trị ID sau khi xóa
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn nhân viên cần xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txtSdt_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Kiểm tra nếu ký tự không phải là số và không phải là phím Backspace (phím xóa)
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                // Hủy ký tự không hợp lệ
                e.Handled = true;
            }
        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void LabelToSET_Click(object sender, EventArgs e)
        {

        }
    }
}
