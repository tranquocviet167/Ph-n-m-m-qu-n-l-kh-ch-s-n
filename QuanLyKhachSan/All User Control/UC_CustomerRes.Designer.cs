namespace QuanLyKhachSan.All_User_Control
{
    partial class UC_CustomerRes
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
            this.components = new System.ComponentModel.Container();
            this.btnDangKy = new Guna.UI2.WinForms.Guna2Button();
            this.cbbGioiTinh = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtGiaTien = new Guna.UI2.WinForms.Guna2TextBox();
            this.cbbSoPhong = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cbbLoaiPhong = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtNgayDangKy = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtDiaChi = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtMaDinhDanh = new Guna.UI2.WinForms.Guna2TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNgaySinh = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.cbbLoaiGiuong = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtQuocTich = new Guna.UI2.WinForms.Guna2TextBox();
            this.lab = new System.Windows.Forms.Label();
            this.txtSoDienThoai = new Guna.UI2.WinForms.Guna2TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNhapTen = new Guna.UI2.WinForms.Guna2TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.guna2Elipse2 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.SuspendLayout();
            // 
            // btnDangKy
            // 
            this.btnDangKy.BorderRadius = 18;
            this.btnDangKy.BorderStyle = System.Drawing.Drawing2D.DashStyle.DashDot;
            this.btnDangKy.BorderThickness = 1;
            this.btnDangKy.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(221)))));
            this.btnDangKy.CheckedState.ForeColor = System.Drawing.Color.White;
            this.btnDangKy.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDangKy.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDangKy.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDangKy.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDangKy.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDangKy.FillColor = System.Drawing.Color.White;
            this.btnDangKy.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDangKy.ForeColor = System.Drawing.Color.Black;
            this.btnDangKy.Location = new System.Drawing.Point(2341, 991);
            this.btnDangKy.Name = "btnDangKy";
            this.btnDangKy.Size = new System.Drawing.Size(365, 143);
            this.btnDangKy.TabIndex = 7;
            this.btnDangKy.Text = "Thêm Khách Hàng";
            this.btnDangKy.Click += new System.EventHandler(this.btnDangKy_Click);
            // 
            // cbbGioiTinh
            // 
            this.cbbGioiTinh.BackColor = System.Drawing.Color.Transparent;
            this.cbbGioiTinh.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbbGioiTinh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbGioiTinh.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbbGioiTinh.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbbGioiTinh.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbbGioiTinh.ForeColor = System.Drawing.Color.Black;
            this.cbbGioiTinh.ItemHeight = 30;
            this.cbbGioiTinh.Items.AddRange(new object[] {
            "Nam",
            "Nữ",
            "Khác"});
            this.cbbGioiTinh.Location = new System.Drawing.Point(150, 960);
            this.cbbGioiTinh.Margin = new System.Windows.Forms.Padding(4);
            this.cbbGioiTinh.Name = "cbbGioiTinh";
            this.cbbGioiTinh.Size = new System.Drawing.Size(747, 36);
            this.cbbGioiTinh.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.cbbGioiTinh.TabIndex = 5;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 10.125F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(150, 886);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(123, 37);
            this.label12.TabIndex = 2;
            this.label12.Text = "Giới Tính";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 10.125F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(1948, 741);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(114, 37);
            this.label11.TabIndex = 2;
            this.label11.Text = "Giá Tiền";
            this.label11.Click += new System.EventHandler(this.label6_Click);
            // 
            // txtGiaTien
            // 
            this.txtGiaTien.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtGiaTien.DefaultText = "";
            this.txtGiaTien.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtGiaTien.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtGiaTien.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtGiaTien.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtGiaTien.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtGiaTien.Font = new System.Drawing.Font("Segoe UI", 10.875F);
            this.txtGiaTien.ForeColor = System.Drawing.Color.Black;
            this.txtGiaTien.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtGiaTien.Location = new System.Drawing.Point(1948, 804);
            this.txtGiaTien.Margin = new System.Windows.Forms.Padding(5);
            this.txtGiaTien.Name = "txtGiaTien";
            this.txtGiaTien.PasswordChar = '\0';
            this.txtGiaTien.PlaceholderText = "";
            this.txtGiaTien.ReadOnly = true;
            this.txtGiaTien.SelectedText = "";
            this.txtGiaTien.Size = new System.Drawing.Size(758, 87);
            this.txtGiaTien.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txtGiaTien.TabIndex = 4;
            this.txtGiaTien.TextChanged += new System.EventHandler(this.txtGiaTien_TextChanged);
            // 
            // cbbSoPhong
            // 
            this.cbbSoPhong.BackColor = System.Drawing.Color.Transparent;
            this.cbbSoPhong.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbbSoPhong.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbSoPhong.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbbSoPhong.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbbSoPhong.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbbSoPhong.ForeColor = System.Drawing.Color.Black;
            this.cbbSoPhong.ItemHeight = 30;
            this.cbbSoPhong.Location = new System.Drawing.Point(1948, 642);
            this.cbbSoPhong.Margin = new System.Windows.Forms.Padding(4);
            this.cbbSoPhong.Name = "cbbSoPhong";
            this.cbbSoPhong.Size = new System.Drawing.Size(751, 36);
            this.cbbSoPhong.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.cbbSoPhong.TabIndex = 5;
            this.cbbSoPhong.SelectedIndexChanged += new System.EventHandler(this.cbbSoPhong_SelectedIndexChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 10.125F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(1948, 577);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(126, 37);
            this.label10.TabIndex = 2;
            this.label10.Text = "Số Phòng";
            // 
            // cbbLoaiPhong
            // 
            this.cbbLoaiPhong.BackColor = System.Drawing.Color.Transparent;
            this.cbbLoaiPhong.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dot;
            this.cbbLoaiPhong.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbbLoaiPhong.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbLoaiPhong.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbbLoaiPhong.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbbLoaiPhong.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbbLoaiPhong.ForeColor = System.Drawing.Color.Black;
            this.cbbLoaiPhong.ItemHeight = 30;
            this.cbbLoaiPhong.Items.AddRange(new object[] {
            "Phòng cho 1 người",
            "Phòng cho 2 người",
            "Phòng cho 3 người",
            "Phòng cho 4 người"});
            this.cbbLoaiPhong.Location = new System.Drawing.Point(1948, 472);
            this.cbbLoaiPhong.Margin = new System.Windows.Forms.Padding(4);
            this.cbbLoaiPhong.Name = "cbbLoaiPhong";
            this.cbbLoaiPhong.Size = new System.Drawing.Size(751, 36);
            this.cbbLoaiPhong.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.cbbLoaiPhong.TabIndex = 5;
            this.cbbLoaiPhong.SelectedIndexChanged += new System.EventHandler(this.cbbLoaiPhong_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 10.125F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(1948, 408);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(148, 37);
            this.label9.TabIndex = 2;
            this.label9.Text = "Loại Phòng";
            // 
            // txtNgayDangKy
            // 
            this.txtNgayDangKy.Checked = true;
            this.txtNgayDangKy.FillColor = System.Drawing.Color.DarkTurquoise;
            this.txtNgayDangKy.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtNgayDangKy.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtNgayDangKy.Location = new System.Drawing.Point(1049, 735);
            this.txtNgayDangKy.Margin = new System.Windows.Forms.Padding(4);
            this.txtNgayDangKy.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.txtNgayDangKy.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.txtNgayDangKy.Name = "txtNgayDangKy";
            this.txtNgayDangKy.Size = new System.Drawing.Size(751, 89);
            this.txtNgayDangKy.TabIndex = 6;
            this.txtNgayDangKy.Value = new System.DateTime(2024, 6, 14, 9, 25, 14, 23);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 10.125F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(1049, 668);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(187, 37);
            this.label8.TabIndex = 2;
            this.label8.Text = "Ngày Đăng Ký";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 10.125F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(1049, 454);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(104, 37);
            this.label7.TabIndex = 2;
            this.label7.Text = "Địa Chỉ";
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDiaChi.DefaultText = "";
            this.txtDiaChi.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtDiaChi.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtDiaChi.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDiaChi.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDiaChi.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDiaChi.Font = new System.Drawing.Font("Segoe UI", 10.875F);
            this.txtDiaChi.ForeColor = System.Drawing.Color.Black;
            this.txtDiaChi.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDiaChi.Location = new System.Drawing.Point(1049, 517);
            this.txtDiaChi.Margin = new System.Windows.Forms.Padding(5);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.PasswordChar = '\0';
            this.txtDiaChi.PlaceholderText = "VD : Bắc Từ Liêm , Hà Nội";
            this.txtDiaChi.SelectedText = "";
            this.txtDiaChi.Size = new System.Drawing.Size(758, 87);
            this.txtDiaChi.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txtDiaChi.TabIndex = 4;
            // 
            // txtMaDinhDanh
            // 
            this.txtMaDinhDanh.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMaDinhDanh.DefaultText = "";
            this.txtMaDinhDanh.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtMaDinhDanh.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtMaDinhDanh.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMaDinhDanh.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMaDinhDanh.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMaDinhDanh.Font = new System.Drawing.Font("Segoe UI", 10.875F);
            this.txtMaDinhDanh.ForeColor = System.Drawing.Color.Black;
            this.txtMaDinhDanh.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMaDinhDanh.Location = new System.Drawing.Point(1049, 292);
            this.txtMaDinhDanh.Margin = new System.Windows.Forms.Padding(5);
            this.txtMaDinhDanh.Name = "txtMaDinhDanh";
            this.txtMaDinhDanh.PasswordChar = '\0';
            this.txtMaDinhDanh.PlaceholderText = "Mã định danh : CCCD , CMND  ";
            this.txtMaDinhDanh.SelectedText = "";
            this.txtMaDinhDanh.Size = new System.Drawing.Size(758, 87);
            this.txtMaDinhDanh.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txtMaDinhDanh.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 10.125F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(1042, 229);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(188, 37);
            this.label6.TabIndex = 2;
            this.label6.Text = "Mã Định Danh";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // txtNgaySinh
            // 
            this.txtNgaySinh.Checked = true;
            this.txtNgaySinh.FillColor = System.Drawing.Color.DarkTurquoise;
            this.txtNgaySinh.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtNgaySinh.Location = new System.Drawing.Point(150, 1122);
            this.txtNgaySinh.Margin = new System.Windows.Forms.Padding(4);
            this.txtNgaySinh.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.txtNgaySinh.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.txtNgaySinh.Name = "txtNgaySinh";
            this.txtNgaySinh.Size = new System.Drawing.Size(751, 89);
            this.txtNgaySinh.TabIndex = 6;
            this.txtNgaySinh.Value = new System.DateTime(2024, 6, 14, 9, 25, 14, 23);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10.125F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(150, 1055);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(137, 37);
            this.label5.TabIndex = 2;
            this.label5.Text = "Ngày Sinh";
            // 
            // cbbLoaiGiuong
            // 
            this.cbbLoaiGiuong.BackColor = System.Drawing.Color.Transparent;
            this.cbbLoaiGiuong.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbbLoaiGiuong.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbLoaiGiuong.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbbLoaiGiuong.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbbLoaiGiuong.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbbLoaiGiuong.ForeColor = System.Drawing.Color.Black;
            this.cbbLoaiGiuong.ItemHeight = 30;
            this.cbbLoaiGiuong.Items.AddRange(new object[] {
            "Giường đơn",
            "Giường đôi",
            "Giường cho gia đình "});
            this.cbbLoaiGiuong.Location = new System.Drawing.Point(1948, 303);
            this.cbbLoaiGiuong.Margin = new System.Windows.Forms.Padding(4);
            this.cbbLoaiGiuong.Name = "cbbLoaiGiuong";
            this.cbbLoaiGiuong.Size = new System.Drawing.Size(747, 36);
            this.cbbLoaiGiuong.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.cbbLoaiGiuong.TabIndex = 5;
            this.cbbLoaiGiuong.SelectedIndexChanged += new System.EventHandler(this.cbbLoaiGiuong_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10.125F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(1948, 229);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(160, 37);
            this.label4.TabIndex = 2;
            this.label4.Text = "Loại Giường";
            // 
            // txtQuocTich
            // 
            this.txtQuocTich.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtQuocTich.DefaultText = "";
            this.txtQuocTich.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtQuocTich.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtQuocTich.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtQuocTich.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtQuocTich.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtQuocTich.Font = new System.Drawing.Font("Segoe UI", 10.875F);
            this.txtQuocTich.ForeColor = System.Drawing.Color.Black;
            this.txtQuocTich.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtQuocTich.Location = new System.Drawing.Point(150, 735);
            this.txtQuocTich.Margin = new System.Windows.Forms.Padding(5);
            this.txtQuocTich.Name = "txtQuocTich";
            this.txtQuocTich.PasswordChar = '\0';
            this.txtQuocTich.PlaceholderText = "Nhập quốc tịch";
            this.txtQuocTich.SelectedText = "";
            this.txtQuocTich.Size = new System.Drawing.Size(758, 87);
            this.txtQuocTich.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txtQuocTich.TabIndex = 4;
            // 
            // lab
            // 
            this.lab.AutoSize = true;
            this.lab.Font = new System.Drawing.Font("Segoe UI", 10.125F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab.Location = new System.Drawing.Point(150, 664);
            this.lab.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lab.Name = "lab";
            this.lab.Size = new System.Drawing.Size(133, 37);
            this.lab.TabIndex = 2;
            this.lab.Text = "Quốc Tịch";
            // 
            // txtSoDienThoai
            // 
            this.txtSoDienThoai.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSoDienThoai.DefaultText = "";
            this.txtSoDienThoai.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSoDienThoai.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSoDienThoai.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSoDienThoai.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSoDienThoai.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSoDienThoai.Font = new System.Drawing.Font("Segoe UI", 10.875F);
            this.txtSoDienThoai.ForeColor = System.Drawing.Color.Black;
            this.txtSoDienThoai.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSoDienThoai.Location = new System.Drawing.Point(150, 517);
            this.txtSoDienThoai.Margin = new System.Windows.Forms.Padding(5);
            this.txtSoDienThoai.Name = "txtSoDienThoai";
            this.txtSoDienThoai.PasswordChar = '\0';
            this.txtSoDienThoai.PlaceholderText = "Nhập SĐT";
            this.txtSoDienThoai.SelectedText = "";
            this.txtSoDienThoai.Size = new System.Drawing.Size(758, 87);
            this.txtSoDienThoai.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txtSoDienThoai.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10.125F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(150, 446);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(184, 37);
            this.label3.TabIndex = 2;
            this.label3.Text = "Số Điện Thoại ";
            // 
            // txtNhapTen
            // 
            this.txtNhapTen.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNhapTen.DefaultText = "";
            this.txtNhapTen.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtNhapTen.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtNhapTen.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNhapTen.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNhapTen.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNhapTen.Font = new System.Drawing.Font("Segoe UI", 10.875F);
            this.txtNhapTen.ForeColor = System.Drawing.Color.Black;
            this.txtNhapTen.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNhapTen.Location = new System.Drawing.Point(150, 301);
            this.txtNhapTen.Margin = new System.Windows.Forms.Padding(5);
            this.txtNhapTen.Name = "txtNhapTen";
            this.txtNhapTen.PasswordChar = '\0';
            this.txtNhapTen.PlaceholderText = "VD : Nguyễn Văn A ";
            this.txtNhapTen.SelectedText = "";
            this.txtNhapTen.Size = new System.Drawing.Size(758, 87);
            this.txtNhapTen.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txtNhapTen.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.125F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(150, 229);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 37);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tên ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century", 21F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(116, 73);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(635, 67);
            this.label1.TabIndex = 1;
            this.label1.Text = "Đăng Ký Khách Hàng ";
            // 
            // guna2Elipse2
            // 
            this.guna2Elipse2.BorderRadius = 30;
            this.guna2Elipse2.TargetControl = this;
            // 
            // UC_CustomerRes
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.Controls.Add(this.btnDangKy);
            this.Controls.Add(this.txtNgayDangKy);
            this.Controls.Add(this.txtNgaySinh);
            this.Controls.Add(this.cbbSoPhong);
            this.Controls.Add(this.cbbLoaiPhong);
            this.Controls.Add(this.cbbGioiTinh);
            this.Controls.Add(this.cbbLoaiGiuong);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtQuocTich);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lab);
            this.Controls.Add(this.txtSoDienThoai);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtDiaChi);
            this.Controls.Add(this.txtGiaTien);
            this.Controls.Add(this.txtMaDinhDanh);
            this.Controls.Add(this.txtNhapTen);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UC_CustomerRes";
            this.Size = new System.Drawing.Size(2847, 1291);
            this.Load += new System.EventHandler(this.UC_CustomerRes_Load);
            this.Leave += new System.EventHandler(this.UC_CustomerRes_Leave);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Button btnDangKy;
        private Guna.UI2.WinForms.Guna2DateTimePicker txtNgayDangKy;
        private Guna.UI2.WinForms.Guna2DateTimePicker txtNgaySinh;
        private Guna.UI2.WinForms.Guna2ComboBox cbbSoPhong;
        private Guna.UI2.WinForms.Guna2ComboBox cbbLoaiPhong;
        private Guna.UI2.WinForms.Guna2ComboBox cbbGioiTinh;
        private Guna.UI2.WinForms.Guna2ComboBox cbbLoaiGiuong;
        private System.Windows.Forms.Label label8;
        private Guna.UI2.WinForms.Guna2TextBox txtQuocTich;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lab;
        private Guna.UI2.WinForms.Guna2TextBox txtSoDienThoai;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2TextBox txtDiaChi;
        private Guna.UI2.WinForms.Guna2TextBox txtGiaTien;
        private Guna.UI2.WinForms.Guna2TextBox txtMaDinhDanh;
        private Guna.UI2.WinForms.Guna2TextBox txtNhapTen;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse2;
    }
}
