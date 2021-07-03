using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
namespace QLCHBS
{
    public partial class f_Main : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        string chuoiketnoi = @"Data Source=DESKTOP-AGD9BP2\SQLEXPRESS;Initial Catalog=qlbs;Integrated Security=True";
        SqlConnection conn;
        public static string idLogin;
        public static string user;
        private string username, password;
        public int position;
        private bool check = false;
        public f_Main()
        {
            InitializeComponent();
            skins();
            
            
        }
        public f_Main(int position,bool check)
        {
            InitializeComponent();
            skins();
            this.position = position;
            this.check = check;

        }

        public void phanQuyen(int po)
        {
            if (check == true)
            {
                
                btnlogin.Enabled = false;
                btndoipass.Enabled = true;
                btnlogout.Enabled = true;
                trogiup.Enabled = true;
                btnsach.Enabled = true;
                btnloaisach.Enabled = true;
                btntacgia.Enabled = true;
                btnnhanvien.Enabled = true;
                btnkhachhang.Enabled = true;
                btnncc.Enabled = true;
                btnkho.Enabled = true;
                btnhoadon.Enabled = true;
                btnphieunhap.Enabled = true;
                btntkhd.Enabled = true;
                btndoanhthu.Enabled = true;
                btntknv.Enabled = true;
                btnsachban.Enabled = true;
                if (po == 0)
                {
                    btnsach.Enabled = false;
                    btnloaisach.Enabled = false;
                    btntacgia.Enabled = false;
                    btnnhanvien.Enabled = false;
                    btnncc.Enabled = false;
                }
            }
        }
        
        public void skins()
        {
            DevExpress.LookAndFeel.DefaultLookAndFeel thems = new DevExpress.LookAndFeel.DefaultLookAndFeel();
            thems.LookAndFeel.SkinName = "Valentine";
        }


        private void f_Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dr;
            dr = XtraMessageBox.Show("Bạn có muốn thoát ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.No)
            {
                e.Cancel = true;
                Application.Exit();
            }

        }

        private void btnlogin_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            f_dangnhap login = null;
            checkdangnhap:
            if (login == null || login.IsDisposed)
            {
                login = new f_dangnhap();
                login.Show();
                
            }
          

        }
        private void f_Main_Load(object sender, EventArgs e)
        {
            phanQuyen(position);
        }

        private void btnsach_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            f_sach f = new f_sach();
            f.MdiParent = this;
            f.Show();
        }

        private void barCheckItem2_CheckedChanged(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            f_doanhthu f = new f_doanhthu();
            f.MdiParent = this;
            f.Show();
        }

        private void barCheckItem1_CheckedChanged(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            f_tacgia f = new f_tacgia();
            f.MdiParent = this;
            f.Show();
        }

        private void btnlogout_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DialogResult dr;
            dr = XtraMessageBox.Show("Bạn có muốn đăng xuất khỏi hệ thống ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                f_dangnhap f = new f_dangnhap();
                f.Show();
                this.Hide();
            }
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            f_tacgia f = new f_tacgia();
            f.MdiParent = this;
            f.Show();
        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            f_nhanvien f = new f_nhanvien();
            f.MdiParent = this;
            f.Show();
        }

        private void ủa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            f_khachhang f = new f_khachhang();
            f.MdiParent = this;
            f.Show();
        }

        private void barButtonItem14_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            f_nhacungcap f = new f_nhacungcap();
            f.MdiParent = this;
            f.Show();
        }

        private void barButtonItem9_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            f_qlkho f = new f_qlkho();
            f.MdiParent = this;
            f.Show();
        }

        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            f_hoadon f = new f_hoadon();
            f.MdiParent = this;
            f.Show();
        }

        private void barButtonItem4_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            f_phieunhap f = new f_phieunhap();
            f.MdiParent = this;
            f.Show();
        }

        private void btndoipass_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            
            f_doimk login = null;
        
            if (login == null || login.IsDisposed)
            {
                login = new f_doimk();
                login.Show();
                login.txtuser1.Text = tentk.Text;
            }
        }

        private void btnloaisach_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            f_loaisach f = new f_loaisach();
            f.MdiParent = this;
            f.Show();
        }
    }
}
