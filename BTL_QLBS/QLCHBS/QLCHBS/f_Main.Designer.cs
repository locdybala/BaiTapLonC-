
namespace QLCHBS
{
    partial class f_Main
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
            DevExpress.XtraBars.Ribbon.RibbonPage danhmuc;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(f_Main));
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.btnsach = new DevExpress.XtraBars.BarButtonItem();
            this.btnloaisach = new DevExpress.XtraBars.BarButtonItem();
            this.btntacgia = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.btnnhanvien = new DevExpress.XtraBars.BarButtonItem();
            this.btnkhachhang = new DevExpress.XtraBars.BarButtonItem();
            this.btnncc = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPageGroup4 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.btnkho = new DevExpress.XtraBars.BarButtonItem();
            this.btnhoadon = new DevExpress.XtraBars.BarButtonItem();
            this.btnphieunhap = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.imgcl1 = new System.Windows.Forms.ImageList(this.components);
            this.btnlogin = new DevExpress.XtraBars.BarButtonItem();
            this.btndoipass = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem5 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem6 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonGroup1 = new DevExpress.XtraBars.BarButtonGroup();
            this.barSubItem1 = new DevExpress.XtraBars.BarSubItem();
            this.barCheckItem1 = new DevExpress.XtraBars.BarCheckItem();
            this.barButtonItem7 = new DevExpress.XtraBars.BarButtonItem();
            this.btndoanhthu = new DevExpress.XtraBars.BarCheckItem();
            this.barButtonItem8 = new DevExpress.XtraBars.BarButtonItem();
            this.barToggleSwitchItem1 = new DevExpress.XtraBars.BarToggleSwitchItem();
            this.barSubItem2 = new DevExpress.XtraBars.BarSubItem();
            this.skinRibbonGalleryBarItem1 = new DevExpress.XtraBars.SkinRibbonGalleryBarItem();
            this.btnlogout = new DevExpress.XtraBars.BarButtonItem();
            this.trogiup = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem10 = new DevExpress.XtraBars.BarButtonItem();
            this.btntknv = new DevExpress.XtraBars.BarButtonItem();
            this.btnsachban = new DevExpress.XtraBars.BarButtonItem();
            this.btntkhd = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup9 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.quanly = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup7 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.lbuser = new System.Windows.Forms.Label();
            this.xtraTabbedMdiManager1 = new DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(this.components);
            this.title = new DevExpress.XtraBars.BarHeaderItem();
            this.title1 = new DevExpress.XtraBars.BarStaticItem();
            this.tentk = new DevExpress.XtraEditors.LabelControl();
            danhmuc = new DevExpress.XtraBars.Ribbon.RibbonPage();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // danhmuc
            // 
            danhmuc.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup2,
            this.ribbonPageGroup3,
            this.ribbonPageGroup4});
            danhmuc.Name = "danhmuc";
            danhmuc.Text = "Nghiệp vụ";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.btnsach);
            this.ribbonPageGroup2.ItemLinks.Add(this.btnloaisach);
            this.ribbonPageGroup2.ItemLinks.Add(this.btntacgia);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.Text = "Thông tin";
            // 
            // btnsach
            // 
            this.btnsach.Caption = "Sách";
            this.btnsach.Enabled = false;
            this.btnsach.Id = 3;
            this.btnsach.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnsach.ImageOptions.Image")));
            this.btnsach.ImageOptions.ImageIndex = 17;
            this.btnsach.Name = "btnsach";
            this.btnsach.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnsach_ItemClick);
            // 
            // btnloaisach
            // 
            this.btnloaisach.Caption = "Loại Sách";
            this.btnloaisach.Enabled = false;
            this.btnloaisach.Id = 4;
            this.btnloaisach.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnloaisach.ImageOptions.Image")));
            this.btnloaisach.Name = "btnloaisach";
            this.btnloaisach.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnloaisach_ItemClick);
            // 
            // btntacgia
            // 
            this.btntacgia.Caption = "Tác giả";
            this.btntacgia.Enabled = false;
            this.btntacgia.Id = 18;
            this.btntacgia.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btntacgia.ImageOptions.Image")));
            this.btntacgia.Name = "btntacgia";
            this.btntacgia.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) 
            | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            this.btntacgia.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem1_ItemClick);
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.ItemLinks.Add(this.btnnhanvien);
            this.ribbonPageGroup3.ItemLinks.Add(this.btnkhachhang);
            this.ribbonPageGroup3.ItemLinks.Add(this.btnncc);
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            this.ribbonPageGroup3.Text = "Quản lý";
            // 
            // btnnhanvien
            // 
            this.btnnhanvien.Caption = "Quản lý nhân viên";
            this.btnnhanvien.Enabled = false;
            this.btnnhanvien.Id = 19;
            this.btnnhanvien.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnnhanvien.ImageOptions.Image")));
            this.btnnhanvien.Name = "btnnhanvien";
            this.btnnhanvien.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnnhanvien.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem2_ItemClick);
            // 
            // btnkhachhang
            // 
            this.btnkhachhang.Caption = "Quản lý khách hàng";
            this.btnkhachhang.Enabled = false;
            this.btnkhachhang.Id = 20;
            this.btnkhachhang.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnkhachhang.ImageOptions.Image")));
            this.btnkhachhang.Name = "btnkhachhang";
            this.btnkhachhang.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) 
            | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            this.btnkhachhang.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.ủa_ItemClick);
            // 
            // btnncc
            // 
            this.btnncc.Caption = "Nhà cung cấp";
            this.btnncc.Enabled = false;
            this.btnncc.Id = 28;
            this.btnncc.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnncc.ImageOptions.Image")));
            this.btnncc.Name = "btnncc";
            this.btnncc.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) 
            | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            this.btnncc.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem14_ItemClick);
            // 
            // ribbonPageGroup4
            // 
            this.ribbonPageGroup4.ItemLinks.Add(this.btnkho);
            this.ribbonPageGroup4.ItemLinks.Add(this.btnhoadon);
            this.ribbonPageGroup4.ItemLinks.Add(this.btnphieunhap);
            this.ribbonPageGroup4.Name = "ribbonPageGroup4";
            this.ribbonPageGroup4.Text = "Hàng Hóa";
            // 
            // btnkho
            // 
            this.btnkho.Caption = "Quản lý kho";
            this.btnkho.Enabled = false;
            this.btnkho.Id = 23;
            this.btnkho.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnkho.ImageOptions.Image")));
            this.btnkho.Name = "btnkho";
            this.btnkho.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) 
            | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            this.btnkho.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem9_ItemClick);
            // 
            // btnhoadon
            // 
            this.btnhoadon.Caption = "Hóa Đơn";
            this.btnhoadon.Enabled = false;
            this.btnhoadon.Id = 21;
            this.btnhoadon.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnhoadon.ImageOptions.Image")));
            this.btnhoadon.Name = "btnhoadon";
            this.btnhoadon.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem3_ItemClick);
            // 
            // btnphieunhap
            // 
            this.btnphieunhap.Caption = "Phiếu Nhập";
            this.btnphieunhap.Enabled = false;
            this.btnphieunhap.Id = 22;
            this.btnphieunhap.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnphieunhap.ImageOptions.Image")));
            this.btnphieunhap.Name = "btnphieunhap";
            this.btnphieunhap.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem4_ItemClick);
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Images = this.imgcl1;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.ribbonControl1.SearchEditItem,
            this.btnlogin,
            this.btndoipass,
            this.btnsach,
            this.btnloaisach,
            this.barButtonItem5,
            this.barButtonItem6,
            this.barButtonGroup1,
            this.barSubItem1,
            this.barCheckItem1,
            this.barButtonItem7,
            this.btndoanhthu,
            this.barButtonItem8,
            this.barToggleSwitchItem1,
            this.barSubItem2,
            this.skinRibbonGalleryBarItem1,
            this.btnlogout,
            this.trogiup,
            this.btntacgia,
            this.btnnhanvien,
            this.btnkhachhang,
            this.btnhoadon,
            this.btnphieunhap,
            this.btnkho,
            this.barButtonItem10,
            this.btntknv,
            this.btnsachban,
            this.btntkhd,
            this.btnncc,
            this.title,
            this.title1});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 31;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1,
            danhmuc,
            this.quanly});
            this.ribbonControl1.Size = new System.Drawing.Size(961, 158);
            // 
            // imgcl1
            // 
            this.imgcl1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgcl1.ImageStream")));
            this.imgcl1.TransparentColor = System.Drawing.Color.Transparent;
            this.imgcl1.Images.SetKeyName(0, "note.png");
            this.imgcl1.Images.SetKeyName(1, "checklist.png");
            this.imgcl1.Images.SetKeyName(2, "receipt.png");
            this.imgcl1.Images.SetKeyName(3, "supplier.png");
            this.imgcl1.Images.SetKeyName(4, "staff.png");
            this.imgcl1.Images.SetKeyName(5, "sneakers (1).png");
            this.imgcl1.Images.SetKeyName(6, "sneakers.png");
            this.imgcl1.Images.SetKeyName(7, "3.jpg");
            this.imgcl1.Images.SetKeyName(8, "iconfinder_exit_28363.png");
            this.imgcl1.Images.SetKeyName(9, "iconfinder_fork5_62576.png");
            this.imgcl1.Images.SetKeyName(10, "iconfinder_hand-coins_532625.png");
            this.imgcl1.Images.SetKeyName(11, "iconfinder_resolutions-05_897243.png");
            this.imgcl1.Images.SetKeyName(12, "iconfinder_4_1320813.png");
            this.imgcl1.Images.SetKeyName(13, "iconfinder_6_3319634.png");
            this.imgcl1.Images.SetKeyName(14, "iconfinder_shopping-bag-customer-commerce-purchase_7811681.png");
            this.imgcl1.Images.SetKeyName(15, "iconfinder_Manager_131484.png");
            this.imgcl1.Images.SetKeyName(16, "iconfinder_User_43350.png");
            this.imgcl1.Images.SetKeyName(17, "iconfinder_address-book-alt_299047.png");
            this.imgcl1.Images.SetKeyName(18, "iconfinder_exit-enter-leave-in-door_2931187.png");
            this.imgcl1.Images.SetKeyName(19, "iconfinder_question_1814114.png");
            this.imgcl1.Images.SetKeyName(20, "iconfinder_question_1814114.ico");
            this.imgcl1.Images.SetKeyName(21, "iconfinder_address-book_285679.ico");
            this.imgcl1.Images.SetKeyName(22, "iconfinder_address-book_285679.png");
            this.imgcl1.Images.SetKeyName(23, "183244115_543974509923333_7442728663873480893_n.jpg");
            this.imgcl1.Images.SetKeyName(24, "sachxua.vn-banner-1.jpg");
            this.imgcl1.Images.SetKeyName(25, "tải xuống.png");
            this.imgcl1.Images.SetKeyName(26, "1749.jpg_wh860.jpg");
            this.imgcl1.Images.SetKeyName(27, "exit.png");
            this.imgcl1.Images.SetKeyName(28, "exit.ico");
            this.imgcl1.Images.SetKeyName(29, "undo.ico");
            this.imgcl1.Images.SetKeyName(30, "repair.ico");
            this.imgcl1.Images.SetKeyName(31, "gnome_edit_delete.png");
            this.imgcl1.Images.SetKeyName(32, "add1.png");
            this.imgcl1.Images.SetKeyName(33, "key-lock.png");
            this.imgcl1.Images.SetKeyName(34, "key.png");
            this.imgcl1.Images.SetKeyName(35, "logout.png");
            this.imgcl1.Images.SetKeyName(36, "user.png");
            // 
            // btnlogin
            // 
            this.btnlogin.Caption = "Đăng nhập";
            this.btnlogin.Id = 1;
            this.btnlogin.ImageOptions.ImageIndex = 33;
            this.btnlogin.Name = "btnlogin";
            this.btnlogin.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) 
            | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            this.btnlogin.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnlogin_ItemClick);
            // 
            // btndoipass
            // 
            this.btndoipass.Caption = "Đổi mật khẩu";
            this.btndoipass.Enabled = false;
            this.btndoipass.Id = 2;
            this.btndoipass.ImageOptions.ImageIndex = 34;
            this.btndoipass.Name = "btndoipass";
            this.btndoipass.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btndoipass_ItemClick);
            // 
            // barButtonItem5
            // 
            this.barButtonItem5.Caption = "Quản Lý Nhân Viên";
            this.barButtonItem5.Id = 5;
            this.barButtonItem5.Name = "barButtonItem5";
            // 
            // barButtonItem6
            // 
            this.barButtonItem6.Caption = "Quản lý khách hàng";
            this.barButtonItem6.Id = 6;
            this.barButtonItem6.Name = "barButtonItem6";
            // 
            // barButtonGroup1
            // 
            this.barButtonGroup1.Caption = "Thống kê";
            this.barButtonGroup1.Id = 7;
            this.barButtonGroup1.Name = "barButtonGroup1";
            // 
            // barSubItem1
            // 
            this.barSubItem1.Id = 8;
            this.barSubItem1.Name = "barSubItem1";
            // 
            // barCheckItem1
            // 
            this.barCheckItem1.Caption = "Tác giả";
            this.barCheckItem1.Id = 9;
            this.barCheckItem1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barCheckItem1.ImageOptions.Image")));
            this.barCheckItem1.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barCheckItem1.ImageOptions.LargeImage")));
            this.barCheckItem1.Name = "barCheckItem1";
            this.barCheckItem1.CheckedChanged += new DevExpress.XtraBars.ItemClickEventHandler(this.barCheckItem1_CheckedChanged);
            // 
            // barButtonItem7
            // 
            this.barButtonItem7.Id = 10;
            this.barButtonItem7.Name = "barButtonItem7";
            // 
            // btndoanhthu
            // 
            this.btndoanhthu.Caption = "Doanh thu";
            this.btndoanhthu.Enabled = false;
            this.btndoanhthu.Id = 11;
            this.btndoanhthu.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btndoanhthu.ImageOptions.Image")));
            this.btndoanhthu.Name = "btndoanhthu";
            this.btndoanhthu.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btndoanhthu.CheckedChanged += new DevExpress.XtraBars.ItemClickEventHandler(this.barCheckItem2_CheckedChanged);
            // 
            // barButtonItem8
            // 
            this.barButtonItem8.Id = 12;
            this.barButtonItem8.Name = "barButtonItem8";
            // 
            // barToggleSwitchItem1
            // 
            this.barToggleSwitchItem1.Caption = "barToggleSwitchItem1";
            this.barToggleSwitchItem1.Id = 13;
            this.barToggleSwitchItem1.Name = "barToggleSwitchItem1";
            // 
            // barSubItem2
            // 
            this.barSubItem2.Caption = "Số lượng sách bán";
            this.barSubItem2.Id = 14;
            this.barSubItem2.Name = "barSubItem2";
            // 
            // skinRibbonGalleryBarItem1
            // 
            this.skinRibbonGalleryBarItem1.Caption = "skinRibbonGalleryBarItem1";
            this.skinRibbonGalleryBarItem1.Id = 15;
            this.skinRibbonGalleryBarItem1.Name = "skinRibbonGalleryBarItem1";
            // 
            // btnlogout
            // 
            this.btnlogout.Caption = "Đăng xuất";
            this.btnlogout.Enabled = false;
            this.btnlogout.Id = 16;
            this.btnlogout.ImageOptions.ImageIndex = 35;
            this.btnlogout.Name = "btnlogout";
            this.btnlogout.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnlogout_ItemClick);
            // 
            // trogiup
            // 
            this.trogiup.Caption = "Trợ giúp";
            this.trogiup.Enabled = false;
            this.trogiup.Id = 17;
            this.trogiup.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("trogiup.ImageOptions.Image")));
            this.trogiup.Name = "trogiup";
            this.trogiup.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) 
            | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            // 
            // barButtonItem10
            // 
            this.barButtonItem10.Caption = "barButtonItem10";
            this.barButtonItem10.Id = 24;
            this.barButtonItem10.Name = "barButtonItem10";
            // 
            // btntknv
            // 
            this.btntknv.Caption = "Nhân viên";
            this.btntknv.Enabled = false;
            this.btntknv.Id = 25;
            this.btntknv.Name = "btntknv";
            // 
            // btnsachban
            // 
            this.btnsachban.Caption = "Số lượng sách bán";
            this.btnsachban.Enabled = false;
            this.btnsachban.Id = 26;
            this.btnsachban.Name = "btnsachban";
            // 
            // btntkhd
            // 
            this.btntkhd.Caption = "Danh sách hóa đơn";
            this.btntkhd.Enabled = false;
            this.btntkhd.Id = 27;
            this.btntkhd.Name = "btntkhd";
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1,
            this.ribbonPageGroup9});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Hệ thống";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.btnlogin);
            this.ribbonPageGroup1.ItemLinks.Add(this.btndoipass);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnlogout);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "Hệ thống";
            // 
            // ribbonPageGroup9
            // 
            this.ribbonPageGroup9.ItemLinks.Add(this.skinRibbonGalleryBarItem1);
            this.ribbonPageGroup9.Name = "ribbonPageGroup9";
            this.ribbonPageGroup9.Text = "Giao diện";
            // 
            // quanly
            // 
            this.quanly.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup7});
            this.quanly.Name = "quanly";
            this.quanly.Text = "Thống kê báo cáo";
            // 
            // ribbonPageGroup7
            // 
            this.ribbonPageGroup7.ItemLinks.Add(this.barButtonItem7);
            this.ribbonPageGroup7.ItemLinks.Add(this.btndoanhthu);
            this.ribbonPageGroup7.ItemLinks.Add(this.barButtonItem8);
            this.ribbonPageGroup7.ItemLinks.Add(this.btntknv);
            this.ribbonPageGroup7.ItemLinks.Add(this.btnsachban);
            this.ribbonPageGroup7.Name = "ribbonPageGroup7";
            this.ribbonPageGroup7.Text = "Hàng hóa";
            // 
            // lbuser
            // 
            this.lbuser.AutoSize = true;
            this.lbuser.Location = new System.Drawing.Point(698, 39);
            this.lbuser.Name = "lbuser";
            this.lbuser.Size = new System.Drawing.Size(0, 13);
            this.lbuser.TabIndex = 1;
            // 
            // xtraTabbedMdiManager1
            // 
            this.xtraTabbedMdiManager1.MdiParent = this;
            // 
            // title
            // 
            this.title.Caption = "Xin chào : ";
            this.title.Id = 29;
            this.title.Name = "title";
            // 
            // title1
            // 
            this.title1.Caption = "Xin chào";
            this.title1.Id = 30;
            this.title1.Name = "title1";
            // 
            // tentk
            // 
            this.tentk.Location = new System.Drawing.Point(862, 39);
            this.tentk.Name = "tentk";
            this.tentk.Size = new System.Drawing.Size(6, 13);
            this.tentk.TabIndex = 3;
            this.tentk.Text = "1";
            // 
            // f_Main
            // 
            this.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(961, 682);
            this.Controls.Add(this.tentk);
            this.Controls.Add(this.lbuser);
            this.Controls.Add(this.ribbonControl1);
            this.InactiveGlowColor = System.Drawing.Color.Red;
            this.IsMdiContainer = true;
            this.Name = "f_Main";
            this.Ribbon = this.ribbonControl1;
            this.Text = "QUẢN LÝ CỬA HÀNG BÁN SÁCH";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.f_Main_FormClosing);
            this.Load += new System.EventHandler(this.f_Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.BarButtonItem btnlogin;
        private DevExpress.XtraBars.BarButtonItem btndoipass;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.BarButtonItem btnsach;
        private DevExpress.XtraBars.BarButtonItem btnloaisach;
        private DevExpress.XtraBars.BarButtonItem barButtonItem5;
        private DevExpress.XtraBars.BarButtonItem barButtonItem6;
        private DevExpress.XtraBars.BarButtonGroup barButtonGroup1;
        private DevExpress.XtraBars.BarSubItem barSubItem1;
        private DevExpress.XtraBars.BarCheckItem barCheckItem1;
        private DevExpress.XtraBars.Ribbon.RibbonPage quanly;
        private DevExpress.XtraBars.BarButtonItem barButtonItem7;
        private DevExpress.XtraBars.BarCheckItem btndoanhthu;
        private DevExpress.XtraBars.BarButtonItem barButtonItem8;
        private DevExpress.XtraBars.BarToggleSwitchItem barToggleSwitchItem1;
        private DevExpress.XtraBars.BarSubItem barSubItem2;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup7;
        private DevExpress.XtraBars.SkinRibbonGalleryBarItem skinRibbonGalleryBarItem1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup9;
        private DevExpress.XtraBars.BarButtonItem btnlogout;
        private System.Windows.Forms.ImageList imgcl1;
        private System.Windows.Forms.Label lbuser;
        private DevExpress.XtraBars.BarButtonItem trogiup;
        private DevExpress.XtraTabbedMdi.XtraTabbedMdiManager xtraTabbedMdiManager1;
        private DevExpress.XtraBars.BarButtonItem btntacgia;
        private DevExpress.XtraBars.BarButtonItem btnnhanvien;
        private DevExpress.XtraBars.BarButtonItem btnkhachhang;
        private DevExpress.XtraBars.BarButtonItem btnhoadon;
        private DevExpress.XtraBars.BarButtonItem btnphieunhap;
        private DevExpress.XtraBars.BarButtonItem btnkho;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup4;
        private DevExpress.XtraBars.BarButtonItem barButtonItem10;
        private DevExpress.XtraBars.BarButtonItem btntknv;
        private DevExpress.XtraBars.BarButtonItem btnsachban;
        private DevExpress.XtraBars.BarButtonItem btntkhd;
        private DevExpress.XtraBars.BarButtonItem btnncc;
        private DevExpress.XtraBars.BarHeaderItem title;
        private DevExpress.XtraBars.BarStaticItem title1;
        public DevExpress.XtraEditors.LabelControl tentk;
    }
}

