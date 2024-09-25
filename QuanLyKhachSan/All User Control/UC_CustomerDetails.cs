﻿using System;
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
    public partial class UC_CustomerDetails : UserControl
    {
        function fn = new function();
        String query;
        public UC_CustomerDetails()
        {
            InitializeComponent();
        }

        private void txtTimKiem_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (txtTimKiem.SelectedIndex == 0)
            {
                query = "select customer.cid , customer.cname, customer.mobile , customer.nationality,customer.gender, customer.dob,customer.idproof,customer.address, customer.checkin,rooms.roomNo,rooms.roomType, rooms.bed,rooms.price from customer inner join rooms on customer.roomid = rooms.roomid ";
                getRecord(query);


            }
            else if (txtTimKiem.SelectedIndex == 1)
            {
                query = "select customer.cid , customer.cname, customer.mobile , customer.nationality,customer.gender, customer.dob,customer.idproof,customer.address, customer.checkin,rooms.roomNo,rooms.roomType, rooms.bed,rooms.price from customer inner join rooms on customer.roomid = rooms.roomid where checkout is null";
                getRecord(query);
            }
            else if(txtTimKiem.SelectedIndex == 2)
            {
                query = "select customer.cid , customer.cname, customer.mobile , customer.nationality,customer.gender, customer.dob,customer.idproof,customer.address, customer.checkin,rooms.roomNo,rooms.roomType, rooms.bed,rooms.price from customer inner join rooms on customer.roomid = rooms.roomid where checkout is not null";
                getRecord(query);
            }
        }
        private void getRecord(String query)
        {
            DataSet ds = fn.getData(query);
            guna2DataGridView1.DataSource = ds.Tables[0];
        }
    }
}
