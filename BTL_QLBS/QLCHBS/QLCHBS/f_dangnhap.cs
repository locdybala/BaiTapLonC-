using DevExpress.XtraEditors;
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

namespace QLCHBS
{
    public partial class f_dangnhap : DevExpress.XtraEditors.XtraForm
    {
        public f_dangnhap()
        {
            InitializeComponent();
        }
        string chuoiketnoi = @"Data Source=DESKTOP-AGD9BP2\SQLEXPRESS;Initial Catalog=qlbs;Integrated Security=True";
        SqlConnection conn;

      

        private void btnlogin_Click_1(object sender, EventArgs e)
        {
            string username = txtuser.Text;
            string password = txtpass.Text;
            MessageBox.Show(username);
            conn = new SqlConnection(chuoiketnoi);
            conn.Open();

            string sql_kt = "Select * from tb_dangnhap where username='" + username + "'and password='" + password + "' ";

            SqlDataAdapter Mydata = new SqlDataAdapter(sql_kt, conn);
            DataTable dt = new DataTable(); //tạo 1 bảng
                                            // đổ dữ liệu từ mydata vào bảng
            Mydata.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                if (Int32.Parse(dt.Rows[0][2].ToString()) == 1)
                {
                    XtraMessageBox.Show("Chào admin!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Question);

                }
                else
                {
                    XtraMessageBox.Show("Chào nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Question);

                }
                f_Main f = new f_Main(Int32.Parse(dt.Rows[0][2].ToString()), true);
                foreach (Form form in Application.OpenForms)
                {
                    form.Hide();
                }
                
                f.Show();
                f.tentk.Text =  username;
  
            }
            else
            {
                XtraMessageBox.Show("Tên hoặc mật khâu không đúng", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            }
        }

        private void f_dangnhap_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dr;
            dr = XtraMessageBox.Show("Bạn có muốn thoát ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.No)
            {
                e.Cancel = true;
                Application.Exit();
            }

        }
    }
 }