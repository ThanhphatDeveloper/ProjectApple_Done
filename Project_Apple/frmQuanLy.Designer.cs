namespace Project_Apple
{
    partial class frmQuanLy
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmQuanLy));
            this.gunaElipse1 = new Guna.UI.WinForms.GunaElipse(this.components);
            this.guna2GroupBox1 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.btnExit = new Guna.UI2.WinForms.Guna2ImageButton();
            this.pnlContent = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.menu = new System.Windows.Forms.Panel();
            this.btnMenu = new Bunifu.Framework.UI.BunifuImageButton();
            this.menuChild = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.user_DX1 = new Project_Apple.User_DX();
            this.txtTenNV = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.picUser = new System.Windows.Forms.PictureBox();
            this.btnQuanLySanPham = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnQuanLyKhachHang = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnBaoCao = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnBaoHanh = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnQuanLyPhieuNhap = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnQuanLyNhaCungCap = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnQuanLyHoaDon = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnQuanLyNhanVien = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnQuanLyTaiKhoan = new Bunifu.Framework.UI.BunifuFlatButton();
            this.pnllogo = new System.Windows.Forms.PictureBox();
            this.panelContent = new System.Windows.Forms.Panel();
            this.guna2GroupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMenu)).BeginInit();
            this.menuChild.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnllogo)).BeginInit();
            this.panelContent.SuspendLayout();
            this.SuspendLayout();
            // 
            // gunaElipse1
            // 
            this.gunaElipse1.TargetControl = this;
            // 
            // guna2GroupBox1
            // 
            this.guna2GroupBox1.Controls.Add(this.btnExit);
            this.guna2GroupBox1.Controls.Add(this.pnlContent);
            this.guna2GroupBox1.Controls.Add(this.panel1);
            this.guna2GroupBox1.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.guna2GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2GroupBox1.FillColor = System.Drawing.Color.Gray;
            this.guna2GroupBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2GroupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.guna2GroupBox1.Location = new System.Drawing.Point(0, 0);
            this.guna2GroupBox1.Name = "guna2GroupBox1";
            this.guna2GroupBox1.ShadowDecoration.Parent = this.guna2GroupBox1;
            this.guna2GroupBox1.Size = new System.Drawing.Size(1373, 806);
            this.guna2GroupBox1.TabIndex = 0;
            this.guna2GroupBox1.Text = "Quản lý";
            this.guna2GroupBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.guna2GroupBox1.Click += new System.EventHandler(this.guna2GroupBox1_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Transparent;
            this.btnExit.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnExit.CheckedState.Parent = this.btnExit;
            this.btnExit.HoverState.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.HoverState.Image")));
            this.btnExit.HoverState.ImageSize = new System.Drawing.Size(50, 50);
            this.btnExit.HoverState.Parent = this.btnExit;
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.ImageRotate = 0F;
            this.btnExit.ImageSize = new System.Drawing.Size(50, 50);
            this.btnExit.Location = new System.Drawing.Point(1321, 0);
            this.btnExit.Name = "btnExit";
            this.btnExit.PressedState.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.PressedState.Image")));
            this.btnExit.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnExit.PressedState.Parent = this.btnExit;
            this.btnExit.Size = new System.Drawing.Size(49, 31);
            this.btnExit.TabIndex = 11;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // pnlContent
            // 
            this.pnlContent.Location = new System.Drawing.Point(249, 37);
            this.pnlContent.Name = "pnlContent";
            this.pnlContent.Size = new System.Drawing.Size(1121, 774);
            this.pnlContent.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.menu);
            this.panel1.Location = new System.Drawing.Point(1, 37);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(248, 774);
            this.panel1.TabIndex = 0;
            // 
            // menu
            // 
            this.menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(45)))), ((int)(((byte)(50)))));
            this.menu.Controls.Add(this.btnMenu);
            this.menu.Controls.Add(this.menuChild);
            this.menu.Controls.Add(this.pnllogo);
            this.menu.Dock = System.Windows.Forms.DockStyle.Left;
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(246, 774);
            this.menu.TabIndex = 5;
            // 
            // btnMenu
            // 
            this.btnMenu.BackColor = System.Drawing.Color.SeaGreen;
            this.btnMenu.Image = ((System.Drawing.Image)(resources.GetObject("btnMenu.Image")));
            this.btnMenu.ImageActive = null;
            this.btnMenu.Location = new System.Drawing.Point(205, 31);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(25, 25);
            this.btnMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMenu.TabIndex = 1;
            this.btnMenu.TabStop = false;
            this.btnMenu.Zoom = 10;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // menuChild
            // 
            this.menuChild.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("menuChild.BackgroundImage")));
            this.menuChild.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.menuChild.Controls.Add(this.panel2);
            this.menuChild.Controls.Add(this.txtTenNV);
            this.menuChild.Controls.Add(this.picUser);
            this.menuChild.Controls.Add(this.btnQuanLySanPham);
            this.menuChild.Controls.Add(this.btnQuanLyKhachHang);
            this.menuChild.Controls.Add(this.btnBaoCao);
            this.menuChild.Controls.Add(this.btnBaoHanh);
            this.menuChild.Controls.Add(this.btnQuanLyPhieuNhap);
            this.menuChild.Controls.Add(this.btnQuanLyNhaCungCap);
            this.menuChild.Controls.Add(this.btnQuanLyHoaDon);
            this.menuChild.Controls.Add(this.btnQuanLyNhanVien);
            this.menuChild.Controls.Add(this.btnQuanLyTaiKhoan);
            this.menuChild.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(45)))), ((int)(((byte)(50)))));
            this.menuChild.GradientBottomRight = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(45)))), ((int)(((byte)(50)))));
            this.menuChild.GradientTopLeft = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(45)))), ((int)(((byte)(50)))));
            this.menuChild.GradientTopRight = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(45)))), ((int)(((byte)(50)))));
            this.menuChild.Location = new System.Drawing.Point(9, 82);
            this.menuChild.Name = "menuChild";
            this.menuChild.Quality = 10;
            this.menuChild.Size = new System.Drawing.Size(228, 664);
            this.menuChild.TabIndex = 0;
            this.menuChild.Paint += new System.Windows.Forms.PaintEventHandler(this.menuChild_Paint);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.user_DX1);
            this.panel2.Location = new System.Drawing.Point(0, 610);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(228, 48);
            this.panel2.TabIndex = 8;
            // 
            // user_DX1
            // 
            this.user_DX1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.user_DX1.Location = new System.Drawing.Point(0, 0);
            this.user_DX1.Name = "user_DX1";
            this.user_DX1.Size = new System.Drawing.Size(228, 48);
            this.user_DX1.TabIndex = 0;
            this.user_DX1.Click += new System.EventHandler(this.user_DX1_Click);
            // 
            // txtTenNV
            // 
            this.txtTenNV.BackColor = System.Drawing.Color.Gold;
            this.txtTenNV.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTenNV.Enabled = false;
            this.txtTenNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenNV.ForeColor = System.Drawing.Color.Black;
            this.txtTenNV.HintForeColor = System.Drawing.Color.Empty;
            this.txtTenNV.HintText = "";
            this.txtTenNV.isPassword = false;
            this.txtTenNV.LineFocusedColor = System.Drawing.Color.Gold;
            this.txtTenNV.LineIdleColor = System.Drawing.Color.Gold;
            this.txtTenNV.LineMouseHoverColor = System.Drawing.Color.Gold;
            this.txtTenNV.LineThickness = 4;
            this.txtTenNV.Location = new System.Drawing.Point(0, 86);
            this.txtTenNV.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txtTenNV.Name = "txtTenNV";
            this.txtTenNV.Size = new System.Drawing.Size(227, 37);
            this.txtTenNV.TabIndex = 7;
            this.txtTenNV.Text = "Phát - Phúc  -Tú";
            this.txtTenNV.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // picUser
            // 
            this.picUser.BackColor = System.Drawing.Color.Transparent;
            this.picUser.Image = ((System.Drawing.Image)(resources.GetObject("picUser.Image")));
            this.picUser.Location = new System.Drawing.Point(72, 2);
            this.picUser.Name = "picUser";
            this.picUser.Size = new System.Drawing.Size(81, 81);
            this.picUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picUser.TabIndex = 6;
            this.picUser.TabStop = false;
            // 
            // btnQuanLySanPham
            // 
            this.btnQuanLySanPham.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(178)))), ((int)(((byte)(136)))));
            this.btnQuanLySanPham.BackColor = System.Drawing.Color.Transparent;
            this.btnQuanLySanPham.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnQuanLySanPham.BorderRadius = 0;
            this.btnQuanLySanPham.ButtonText = "     Quản Lý Sản Phẩm";
            this.btnQuanLySanPham.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnQuanLySanPham.DisabledColor = System.Drawing.Color.Gray;
            this.btnQuanLySanPham.Iconcolor = System.Drawing.Color.Transparent;
            this.btnQuanLySanPham.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnQuanLySanPham.Iconimage")));
            this.btnQuanLySanPham.Iconimage_right = null;
            this.btnQuanLySanPham.Iconimage_right_Selected = null;
            this.btnQuanLySanPham.Iconimage_Selected = null;
            this.btnQuanLySanPham.IconMarginLeft = 0;
            this.btnQuanLySanPham.IconMarginRight = 0;
            this.btnQuanLySanPham.IconRightVisible = true;
            this.btnQuanLySanPham.IconRightZoom = 0D;
            this.btnQuanLySanPham.IconVisible = true;
            this.btnQuanLySanPham.IconZoom = 50D;
            this.btnQuanLySanPham.IsTab = true;
            this.btnQuanLySanPham.Location = new System.Drawing.Point(0, 291);
            this.btnQuanLySanPham.Margin = new System.Windows.Forms.Padding(4);
            this.btnQuanLySanPham.Name = "btnQuanLySanPham";
            this.btnQuanLySanPham.Normalcolor = System.Drawing.Color.Transparent;
            this.btnQuanLySanPham.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(178)))), ((int)(((byte)(136)))));
            this.btnQuanLySanPham.OnHoverTextColor = System.Drawing.Color.White;
            this.btnQuanLySanPham.selected = false;
            this.btnQuanLySanPham.Size = new System.Drawing.Size(228, 48);
            this.btnQuanLySanPham.TabIndex = 5;
            this.btnQuanLySanPham.Text = "     Quản Lý Sản Phẩm";
            this.btnQuanLySanPham.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQuanLySanPham.Textcolor = System.Drawing.Color.White;
            this.btnQuanLySanPham.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuanLySanPham.Click += new System.EventHandler(this.btnQuanLySanPham_Click);
            // 
            // btnQuanLyKhachHang
            // 
            this.btnQuanLyKhachHang.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(178)))), ((int)(((byte)(136)))));
            this.btnQuanLyKhachHang.BackColor = System.Drawing.Color.Transparent;
            this.btnQuanLyKhachHang.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnQuanLyKhachHang.BorderRadius = 0;
            this.btnQuanLyKhachHang.ButtonText = "     Quản Lý Khách Hàng";
            this.btnQuanLyKhachHang.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnQuanLyKhachHang.DisabledColor = System.Drawing.Color.Gray;
            this.btnQuanLyKhachHang.Iconcolor = System.Drawing.Color.Transparent;
            this.btnQuanLyKhachHang.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnQuanLyKhachHang.Iconimage")));
            this.btnQuanLyKhachHang.Iconimage_right = null;
            this.btnQuanLyKhachHang.Iconimage_right_Selected = null;
            this.btnQuanLyKhachHang.Iconimage_Selected = null;
            this.btnQuanLyKhachHang.IconMarginLeft = 0;
            this.btnQuanLyKhachHang.IconMarginRight = 0;
            this.btnQuanLyKhachHang.IconRightVisible = true;
            this.btnQuanLyKhachHang.IconRightZoom = 0D;
            this.btnQuanLyKhachHang.IconVisible = true;
            this.btnQuanLyKhachHang.IconZoom = 50D;
            this.btnQuanLyKhachHang.IsTab = true;
            this.btnQuanLyKhachHang.Location = new System.Drawing.Point(0, 237);
            this.btnQuanLyKhachHang.Margin = new System.Windows.Forms.Padding(4);
            this.btnQuanLyKhachHang.Name = "btnQuanLyKhachHang";
            this.btnQuanLyKhachHang.Normalcolor = System.Drawing.Color.Transparent;
            this.btnQuanLyKhachHang.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(178)))), ((int)(((byte)(136)))));
            this.btnQuanLyKhachHang.OnHoverTextColor = System.Drawing.Color.White;
            this.btnQuanLyKhachHang.selected = false;
            this.btnQuanLyKhachHang.Size = new System.Drawing.Size(228, 48);
            this.btnQuanLyKhachHang.TabIndex = 5;
            this.btnQuanLyKhachHang.Text = "     Quản Lý Khách Hàng";
            this.btnQuanLyKhachHang.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQuanLyKhachHang.Textcolor = System.Drawing.Color.White;
            this.btnQuanLyKhachHang.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuanLyKhachHang.Click += new System.EventHandler(this.btnQuanLyKhachHang_Click);
            // 
            // btnBaoCao
            // 
            this.btnBaoCao.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(178)))), ((int)(((byte)(136)))));
            this.btnBaoCao.BackColor = System.Drawing.Color.Transparent;
            this.btnBaoCao.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBaoCao.BorderRadius = 0;
            this.btnBaoCao.ButtonText = "     Báo Cáo";
            this.btnBaoCao.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBaoCao.DisabledColor = System.Drawing.Color.Gray;
            this.btnBaoCao.Iconcolor = System.Drawing.Color.Transparent;
            this.btnBaoCao.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnBaoCao.Iconimage")));
            this.btnBaoCao.Iconimage_right = null;
            this.btnBaoCao.Iconimage_right_Selected = null;
            this.btnBaoCao.Iconimage_Selected = null;
            this.btnBaoCao.IconMarginLeft = 0;
            this.btnBaoCao.IconMarginRight = 0;
            this.btnBaoCao.IconRightVisible = true;
            this.btnBaoCao.IconRightZoom = 0D;
            this.btnBaoCao.IconVisible = true;
            this.btnBaoCao.IconZoom = 50D;
            this.btnBaoCao.IsTab = true;
            this.btnBaoCao.Location = new System.Drawing.Point(-1, 555);
            this.btnBaoCao.Margin = new System.Windows.Forms.Padding(4);
            this.btnBaoCao.Name = "btnBaoCao";
            this.btnBaoCao.Normalcolor = System.Drawing.Color.Transparent;
            this.btnBaoCao.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(178)))), ((int)(((byte)(136)))));
            this.btnBaoCao.OnHoverTextColor = System.Drawing.Color.White;
            this.btnBaoCao.selected = false;
            this.btnBaoCao.Size = new System.Drawing.Size(228, 48);
            this.btnBaoCao.TabIndex = 5;
            this.btnBaoCao.Text = "     Báo Cáo";
            this.btnBaoCao.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBaoCao.Textcolor = System.Drawing.Color.White;
            this.btnBaoCao.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBaoCao.Click += new System.EventHandler(this.btnBaoCao_Click);
            // 
            // btnBaoHanh
            // 
            this.btnBaoHanh.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(178)))), ((int)(((byte)(136)))));
            this.btnBaoHanh.BackColor = System.Drawing.Color.Transparent;
            this.btnBaoHanh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBaoHanh.BorderRadius = 0;
            this.btnBaoHanh.ButtonText = "     Bảo Hành";
            this.btnBaoHanh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBaoHanh.DisabledColor = System.Drawing.Color.Gray;
            this.btnBaoHanh.Iconcolor = System.Drawing.Color.Transparent;
            this.btnBaoHanh.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnBaoHanh.Iconimage")));
            this.btnBaoHanh.Iconimage_right = null;
            this.btnBaoHanh.Iconimage_right_Selected = null;
            this.btnBaoHanh.Iconimage_Selected = null;
            this.btnBaoHanh.IconMarginLeft = 0;
            this.btnBaoHanh.IconMarginRight = 0;
            this.btnBaoHanh.IconRightVisible = true;
            this.btnBaoHanh.IconRightZoom = 0D;
            this.btnBaoHanh.IconVisible = true;
            this.btnBaoHanh.IconZoom = 50D;
            this.btnBaoHanh.IsTab = true;
            this.btnBaoHanh.Location = new System.Drawing.Point(0, 501);
            this.btnBaoHanh.Margin = new System.Windows.Forms.Padding(4);
            this.btnBaoHanh.Name = "btnBaoHanh";
            this.btnBaoHanh.Normalcolor = System.Drawing.Color.Transparent;
            this.btnBaoHanh.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(178)))), ((int)(((byte)(136)))));
            this.btnBaoHanh.OnHoverTextColor = System.Drawing.Color.White;
            this.btnBaoHanh.selected = false;
            this.btnBaoHanh.Size = new System.Drawing.Size(228, 48);
            this.btnBaoHanh.TabIndex = 5;
            this.btnBaoHanh.Text = "     Bảo Hành";
            this.btnBaoHanh.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBaoHanh.Textcolor = System.Drawing.Color.White;
            this.btnBaoHanh.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBaoHanh.Click += new System.EventHandler(this.btnBaoHanh_Click);
            // 
            // btnQuanLyPhieuNhap
            // 
            this.btnQuanLyPhieuNhap.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(178)))), ((int)(((byte)(136)))));
            this.btnQuanLyPhieuNhap.BackColor = System.Drawing.Color.Transparent;
            this.btnQuanLyPhieuNhap.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnQuanLyPhieuNhap.BorderRadius = 0;
            this.btnQuanLyPhieuNhap.ButtonText = "     Quản Lý Phiếu Nhập";
            this.btnQuanLyPhieuNhap.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnQuanLyPhieuNhap.DisabledColor = System.Drawing.Color.Gray;
            this.btnQuanLyPhieuNhap.Iconcolor = System.Drawing.Color.Transparent;
            this.btnQuanLyPhieuNhap.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnQuanLyPhieuNhap.Iconimage")));
            this.btnQuanLyPhieuNhap.Iconimage_right = null;
            this.btnQuanLyPhieuNhap.Iconimage_right_Selected = null;
            this.btnQuanLyPhieuNhap.Iconimage_Selected = null;
            this.btnQuanLyPhieuNhap.IconMarginLeft = 0;
            this.btnQuanLyPhieuNhap.IconMarginRight = 0;
            this.btnQuanLyPhieuNhap.IconRightVisible = true;
            this.btnQuanLyPhieuNhap.IconRightZoom = 0D;
            this.btnQuanLyPhieuNhap.IconVisible = true;
            this.btnQuanLyPhieuNhap.IconZoom = 50D;
            this.btnQuanLyPhieuNhap.IsTab = true;
            this.btnQuanLyPhieuNhap.Location = new System.Drawing.Point(0, 447);
            this.btnQuanLyPhieuNhap.Margin = new System.Windows.Forms.Padding(4);
            this.btnQuanLyPhieuNhap.Name = "btnQuanLyPhieuNhap";
            this.btnQuanLyPhieuNhap.Normalcolor = System.Drawing.Color.Transparent;
            this.btnQuanLyPhieuNhap.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(178)))), ((int)(((byte)(136)))));
            this.btnQuanLyPhieuNhap.OnHoverTextColor = System.Drawing.Color.White;
            this.btnQuanLyPhieuNhap.selected = false;
            this.btnQuanLyPhieuNhap.Size = new System.Drawing.Size(228, 48);
            this.btnQuanLyPhieuNhap.TabIndex = 5;
            this.btnQuanLyPhieuNhap.Text = "     Quản Lý Phiếu Nhập";
            this.btnQuanLyPhieuNhap.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQuanLyPhieuNhap.Textcolor = System.Drawing.Color.White;
            this.btnQuanLyPhieuNhap.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuanLyPhieuNhap.Click += new System.EventHandler(this.btnQuanLyPhieuNhap_Click);
            // 
            // btnQuanLyNhaCungCap
            // 
            this.btnQuanLyNhaCungCap.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(178)))), ((int)(((byte)(136)))));
            this.btnQuanLyNhaCungCap.BackColor = System.Drawing.Color.Transparent;
            this.btnQuanLyNhaCungCap.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnQuanLyNhaCungCap.BorderRadius = 0;
            this.btnQuanLyNhaCungCap.ButtonText = "Quản Lý Nhà Cung Cấp";
            this.btnQuanLyNhaCungCap.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnQuanLyNhaCungCap.DisabledColor = System.Drawing.Color.Gray;
            this.btnQuanLyNhaCungCap.Iconcolor = System.Drawing.Color.Transparent;
            this.btnQuanLyNhaCungCap.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnQuanLyNhaCungCap.Iconimage")));
            this.btnQuanLyNhaCungCap.Iconimage_right = null;
            this.btnQuanLyNhaCungCap.Iconimage_right_Selected = null;
            this.btnQuanLyNhaCungCap.Iconimage_Selected = null;
            this.btnQuanLyNhaCungCap.IconMarginLeft = 0;
            this.btnQuanLyNhaCungCap.IconMarginRight = 0;
            this.btnQuanLyNhaCungCap.IconRightVisible = true;
            this.btnQuanLyNhaCungCap.IconRightZoom = 0D;
            this.btnQuanLyNhaCungCap.IconVisible = true;
            this.btnQuanLyNhaCungCap.IconZoom = 50D;
            this.btnQuanLyNhaCungCap.IsTab = true;
            this.btnQuanLyNhaCungCap.Location = new System.Drawing.Point(0, 399);
            this.btnQuanLyNhaCungCap.Margin = new System.Windows.Forms.Padding(4);
            this.btnQuanLyNhaCungCap.Name = "btnQuanLyNhaCungCap";
            this.btnQuanLyNhaCungCap.Normalcolor = System.Drawing.Color.Transparent;
            this.btnQuanLyNhaCungCap.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(178)))), ((int)(((byte)(136)))));
            this.btnQuanLyNhaCungCap.OnHoverTextColor = System.Drawing.Color.White;
            this.btnQuanLyNhaCungCap.selected = false;
            this.btnQuanLyNhaCungCap.Size = new System.Drawing.Size(228, 48);
            this.btnQuanLyNhaCungCap.TabIndex = 5;
            this.btnQuanLyNhaCungCap.Text = "Quản Lý Nhà Cung Cấp";
            this.btnQuanLyNhaCungCap.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQuanLyNhaCungCap.Textcolor = System.Drawing.Color.White;
            this.btnQuanLyNhaCungCap.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuanLyNhaCungCap.Click += new System.EventHandler(this.btnQuanLyNhaCungCap_Click);
            // 
            // btnQuanLyHoaDon
            // 
            this.btnQuanLyHoaDon.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(178)))), ((int)(((byte)(136)))));
            this.btnQuanLyHoaDon.BackColor = System.Drawing.Color.Transparent;
            this.btnQuanLyHoaDon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnQuanLyHoaDon.BorderRadius = 0;
            this.btnQuanLyHoaDon.ButtonText = "     Quản Lý Hóa Đơn";
            this.btnQuanLyHoaDon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnQuanLyHoaDon.DisabledColor = System.Drawing.Color.Gray;
            this.btnQuanLyHoaDon.Iconcolor = System.Drawing.Color.Transparent;
            this.btnQuanLyHoaDon.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnQuanLyHoaDon.Iconimage")));
            this.btnQuanLyHoaDon.Iconimage_right = null;
            this.btnQuanLyHoaDon.Iconimage_right_Selected = null;
            this.btnQuanLyHoaDon.Iconimage_Selected = null;
            this.btnQuanLyHoaDon.IconMarginLeft = 0;
            this.btnQuanLyHoaDon.IconMarginRight = 0;
            this.btnQuanLyHoaDon.IconRightVisible = true;
            this.btnQuanLyHoaDon.IconRightZoom = 0D;
            this.btnQuanLyHoaDon.IconVisible = true;
            this.btnQuanLyHoaDon.IconZoom = 50D;
            this.btnQuanLyHoaDon.IsTab = true;
            this.btnQuanLyHoaDon.Location = new System.Drawing.Point(0, 345);
            this.btnQuanLyHoaDon.Margin = new System.Windows.Forms.Padding(4);
            this.btnQuanLyHoaDon.Name = "btnQuanLyHoaDon";
            this.btnQuanLyHoaDon.Normalcolor = System.Drawing.Color.Transparent;
            this.btnQuanLyHoaDon.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(178)))), ((int)(((byte)(136)))));
            this.btnQuanLyHoaDon.OnHoverTextColor = System.Drawing.Color.White;
            this.btnQuanLyHoaDon.selected = false;
            this.btnQuanLyHoaDon.Size = new System.Drawing.Size(228, 48);
            this.btnQuanLyHoaDon.TabIndex = 5;
            this.btnQuanLyHoaDon.Text = "     Quản Lý Hóa Đơn";
            this.btnQuanLyHoaDon.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQuanLyHoaDon.Textcolor = System.Drawing.Color.White;
            this.btnQuanLyHoaDon.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuanLyHoaDon.Click += new System.EventHandler(this.btnQuanLyHoaDon_Click);
            // 
            // btnQuanLyNhanVien
            // 
            this.btnQuanLyNhanVien.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(178)))), ((int)(((byte)(136)))));
            this.btnQuanLyNhanVien.BackColor = System.Drawing.Color.Transparent;
            this.btnQuanLyNhanVien.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnQuanLyNhanVien.BorderRadius = 0;
            this.btnQuanLyNhanVien.ButtonText = "     Quản Lý Nhân Viên";
            this.btnQuanLyNhanVien.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnQuanLyNhanVien.DisabledColor = System.Drawing.Color.Gray;
            this.btnQuanLyNhanVien.Iconcolor = System.Drawing.Color.Transparent;
            this.btnQuanLyNhanVien.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnQuanLyNhanVien.Iconimage")));
            this.btnQuanLyNhanVien.Iconimage_right = null;
            this.btnQuanLyNhanVien.Iconimage_right_Selected = null;
            this.btnQuanLyNhanVien.Iconimage_Selected = null;
            this.btnQuanLyNhanVien.IconMarginLeft = 0;
            this.btnQuanLyNhanVien.IconMarginRight = 0;
            this.btnQuanLyNhanVien.IconRightVisible = true;
            this.btnQuanLyNhanVien.IconRightZoom = 0D;
            this.btnQuanLyNhanVien.IconVisible = true;
            this.btnQuanLyNhanVien.IconZoom = 50D;
            this.btnQuanLyNhanVien.IsTab = true;
            this.btnQuanLyNhanVien.Location = new System.Drawing.Point(0, 183);
            this.btnQuanLyNhanVien.Margin = new System.Windows.Forms.Padding(4);
            this.btnQuanLyNhanVien.Name = "btnQuanLyNhanVien";
            this.btnQuanLyNhanVien.Normalcolor = System.Drawing.Color.Transparent;
            this.btnQuanLyNhanVien.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(178)))), ((int)(((byte)(136)))));
            this.btnQuanLyNhanVien.OnHoverTextColor = System.Drawing.Color.White;
            this.btnQuanLyNhanVien.selected = false;
            this.btnQuanLyNhanVien.Size = new System.Drawing.Size(228, 48);
            this.btnQuanLyNhanVien.TabIndex = 5;
            this.btnQuanLyNhanVien.Text = "     Quản Lý Nhân Viên";
            this.btnQuanLyNhanVien.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQuanLyNhanVien.Textcolor = System.Drawing.Color.White;
            this.btnQuanLyNhanVien.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuanLyNhanVien.Click += new System.EventHandler(this.btnQuanLyNhanVien_Click);
            // 
            // btnQuanLyTaiKhoan
            // 
            this.btnQuanLyTaiKhoan.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(178)))), ((int)(((byte)(136)))));
            this.btnQuanLyTaiKhoan.BackColor = System.Drawing.Color.Transparent;
            this.btnQuanLyTaiKhoan.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnQuanLyTaiKhoan.BorderRadius = 0;
            this.btnQuanLyTaiKhoan.ButtonText = "     Quản Lý Tài Khoản";
            this.btnQuanLyTaiKhoan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnQuanLyTaiKhoan.DisabledColor = System.Drawing.Color.Gray;
            this.btnQuanLyTaiKhoan.Iconcolor = System.Drawing.Color.Transparent;
            this.btnQuanLyTaiKhoan.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnQuanLyTaiKhoan.Iconimage")));
            this.btnQuanLyTaiKhoan.Iconimage_right = null;
            this.btnQuanLyTaiKhoan.Iconimage_right_Selected = null;
            this.btnQuanLyTaiKhoan.Iconimage_Selected = null;
            this.btnQuanLyTaiKhoan.IconMarginLeft = 0;
            this.btnQuanLyTaiKhoan.IconMarginRight = 0;
            this.btnQuanLyTaiKhoan.IconRightVisible = true;
            this.btnQuanLyTaiKhoan.IconRightZoom = 0D;
            this.btnQuanLyTaiKhoan.IconVisible = true;
            this.btnQuanLyTaiKhoan.IconZoom = 50D;
            this.btnQuanLyTaiKhoan.IsTab = true;
            this.btnQuanLyTaiKhoan.Location = new System.Drawing.Point(0, 129);
            this.btnQuanLyTaiKhoan.Margin = new System.Windows.Forms.Padding(4);
            this.btnQuanLyTaiKhoan.Name = "btnQuanLyTaiKhoan";
            this.btnQuanLyTaiKhoan.Normalcolor = System.Drawing.Color.Transparent;
            this.btnQuanLyTaiKhoan.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(178)))), ((int)(((byte)(136)))));
            this.btnQuanLyTaiKhoan.OnHoverTextColor = System.Drawing.Color.White;
            this.btnQuanLyTaiKhoan.selected = false;
            this.btnQuanLyTaiKhoan.Size = new System.Drawing.Size(228, 48);
            this.btnQuanLyTaiKhoan.TabIndex = 5;
            this.btnQuanLyTaiKhoan.Text = "     Quản Lý Tài Khoản";
            this.btnQuanLyTaiKhoan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQuanLyTaiKhoan.Textcolor = System.Drawing.Color.White;
            this.btnQuanLyTaiKhoan.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuanLyTaiKhoan.Click += new System.EventHandler(this.btnQuanLyTaiKhoan_Click);
            // 
            // pnllogo
            // 
            this.pnllogo.Image = ((System.Drawing.Image)(resources.GetObject("pnllogo.Image")));
            this.pnllogo.Location = new System.Drawing.Point(12, 6);
            this.pnllogo.Name = "pnllogo";
            this.pnllogo.Size = new System.Drawing.Size(132, 75);
            this.pnllogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pnllogo.TabIndex = 0;
            this.pnllogo.TabStop = false;
            // 
            // panelContent
            // 
            this.panelContent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(239)))), ((int)(((byte)(245)))));
            this.panelContent.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panelContent.Controls.Add(this.guna2GroupBox1);
            this.panelContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContent.Location = new System.Drawing.Point(0, 0);
            this.panelContent.Name = "panelContent";
            this.panelContent.Size = new System.Drawing.Size(1373, 806);
            this.panelContent.TabIndex = 7;
            // 
            // frmQuanLy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1373, 806);
            this.Controls.Add(this.panelContent);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmQuanLy";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmQuanLy";
            this.Load += new System.EventHandler(this.frmQuanLy_Load);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.frmQuanLy_KeyUp);
            this.guna2GroupBox1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.menu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnMenu)).EndInit();
            this.menuChild.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnllogo)).EndInit();
            this.panelContent.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaElipse gunaElipse1;
        private System.Windows.Forms.Panel panelContent;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox1;
        private Guna.UI2.WinForms.Guna2ImageButton btnExit;
        private System.Windows.Forms.Panel pnlContent;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel menu;
        private Bunifu.Framework.UI.BunifuImageButton btnMenu;
        private Bunifu.Framework.UI.BunifuGradientPanel menuChild;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtTenNV;
        private System.Windows.Forms.PictureBox picUser;
        private Bunifu.Framework.UI.BunifuFlatButton btnQuanLySanPham;
        private Bunifu.Framework.UI.BunifuFlatButton btnQuanLyKhachHang;
        private Bunifu.Framework.UI.BunifuFlatButton btnBaoCao;
        private Bunifu.Framework.UI.BunifuFlatButton btnBaoHanh;
        private Bunifu.Framework.UI.BunifuFlatButton btnQuanLyPhieuNhap;
        private Bunifu.Framework.UI.BunifuFlatButton btnQuanLyNhaCungCap;
        private Bunifu.Framework.UI.BunifuFlatButton btnQuanLyHoaDon;
        private Bunifu.Framework.UI.BunifuFlatButton btnQuanLyNhanVien;
        private Bunifu.Framework.UI.BunifuFlatButton btnQuanLyTaiKhoan;
        private System.Windows.Forms.PictureBox pnllogo;
        private System.Windows.Forms.Panel panel2;
        private User_DX user_DX1;
    }
}