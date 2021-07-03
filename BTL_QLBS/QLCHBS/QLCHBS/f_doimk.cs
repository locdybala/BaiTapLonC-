using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLCHBS
{
    public partial class f_doimk : DevExpress.XtraEditors.XtraForm
    {
        dataprovider dataprovider = new dataprovider();
        private string username;
        public f_doimk()
        {
            InitializeComponent();
        }

        private void f_doimk_Load(object sender, EventArgs e)
        {
            txtpass1.Focus();
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            string pass = txtpass1.Text;
            string repass = txtrepass1.Text;
            
            if (pass == "")
            {
                XtraMessageBox.Show("Không được để trống","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            if (repass != pass)
            {
                XtraMessageBox.Show("Mật khẩu nhập lại không khớp", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                string user = txtuser1.Text;
                MessageBox.Show(user);
                //khai báo chuỗi insert
                string sqlsua = "Update tb_dangnhap set password=N'" + pass + "'  where username = N'" + user+"'" ;
                StringBuilder query = new StringBuilder(sqlsua);



                int result = dataprovider.execNonQuery(query.ToString());
                if (result > 0)
                {

                    XtraMessageBox.Show("Đổi Mật Khẩu Thành Công", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    XtraMessageBox.Show("Quay lại trang chủ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    this.Hide();
                   
                }
                else
                {
                    MessageBox.Show("Đổi mật khẩu thất bại !", "Thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
        }
    }
}