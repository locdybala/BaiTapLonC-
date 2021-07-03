using DevExpress.XtraEditors;
using QLCHBS.Controller;
using QLCHBS.Model;
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
    public partial class f_qlkho : DevExpress.XtraEditors.XtraForm
    {
        dataprovider dataprovider = new dataprovider();
        private int soluongNhap;
        private int soluongXuat;
        private int Ton;

        string chuoiketnoi = @"Data Source=DESKTOP-AGD9BP2\SQLEXPRESS;Initial Catalog=qlbs;Integrated Security=True";
        SqlConnection conn;
        public f_qlkho()
        {
            InitializeComponent();
            loadsoluongnhap();

            loadsoluongxuat();
            loadsoluongton();
        }

        private void gridControl1_Click(object sender, EventArgs e)
        {

        }
        private managerKhoSach mngKho = new managerKhoSach();
        public void tonKho()// vs lại cái này nữa
        {
            conn = new SqlConnection(chuoiketnoi);
            /*
            conn.Open();
            string sql_tonkho1 = "Select tb_sach.tenSach from tb_sach ";
            SqlCommand cmd2 = new SqlCommand(sql_tonkho1, conn);
            SqlDataReader Dr2 = cmd2.ExecuteReader();
            while (Dr2.Read())
            {
                mngKho.addKho(new KhoSach(Dr2[0].ToString(), 0, 0));
            }

            conn.Close();*/
            conn.Open();

            string sql_tonkho0 = "Select tb_sach.tenSach, SUM(tb_ctphieunhap.soLuong) from tb_sach  INNER JOIN tb_ctphieunhap on tb_sach.maSach = tb_ctphieunhap.maSach GROUP BY tb_sach.tenSach ";
            SqlCommand cmd1 = new SqlCommand(sql_tonkho0, conn);
            SqlDataReader Dr1 = cmd1.ExecuteReader();
            while (Dr1.Read())
            {
                mngKho.addKho(new KhoSach(Dr1[0].ToString(), Int32.Parse(Dr1[1].ToString())));
            }

            conn.Close();

            conn.Open();
            string sql_tonkho = "select tb_sach.tenSach , sum(tb_cthoadon.soLuong) from tb_sach,tb_cthoadon where tb_sach.maSach = tb_cthoadon.maSach group by tb_sach.tenSach ";
            SqlCommand cmd = new SqlCommand(sql_tonkho, conn);
            SqlDataReader Dr;
            Dr = cmd.ExecuteReader();
            while (Dr.Read())
            {
                mngKho.editKho(new KhoSach(Dr[0].ToString(), 0, Int32.Parse(Dr[1].ToString())));
            }
            conn.Close();


            dgvkho.DataSource = mngKho.listKho;





        }
        private void loadsoluongnhap()
        {

            soluongNhap = (int)dataprovider.execScaler("select sum(soLuong) from tb_ctphieunhap ");
            soluongnhap.Text = " Số lượng nhập: " + soluongNhap;

        }
        private void loadsoluongxuat()
        {
            soluongXuat = (int)dataprovider.execScaler("select sum(soLuong) from tb_cthoadon ");
            soluongxuat.Text = " Số lượng xuất: " + soluongXuat;

        }

        private void loadsoluongton()
        {
            Ton = (soluongNhap - soluongXuat);
            soluongton.Text = "Số lượng tồn: " + Ton;


        }

        private void f_qlkho_Load(object sender, EventArgs e)
        {
            tonKho();
        }
    }
}