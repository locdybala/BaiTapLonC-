using DevExpress.XtraEditors;
using QLCHBS.Controller;
using QLCHBS.Model;
using QLCHBS.report;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QLCHBS
{
    public partial class f_hoadonchitiet : DevExpress.XtraEditors.XtraForm
    {
        string chuoiketnoi = @"Data Source=DESKTOP-AGD9BP2\SQLEXPRESS;Initial Catalog=qlbs;Integrated Security=True";
        SqlConnection conn;

        dataprovider dataprovider = new dataprovider();
        private int maHoaDon;
        private int maSach;
        private string tenSach;

        public f_hoadonchitiet(int mahd)
        {
            InitializeComponent();
            this.maHoaDon = mahd;
            init(mahd);
        }

        private void cbbtensach_SelectedIndexChanged(object sender, EventArgs e)
        {
            System.Windows.Forms.ComboBox comboBox = sender as System.Windows.Forms.ComboBox;
            maSach = (int)comboBox.SelectedValue;
            tenSach = cbbtensach.Text;
        }

        private void init(int maHoaDon)

        {
            title.Text = "Chi tiết hóa đơn " + maHoaDon;
           
            loaddgvcthoadon();
            loadcbbsach();
            loadTongtien();
            tonKho();
        }
       
     

        private void loaddgvcthoadon()
        {
            DataTable dt = new DataTable();
            StringBuilder query = new StringBuilder("select tb_sach.tenSach as [Tên Sách]");
            query.Append(",tb_cthoadon.soLuong as [Số Lượng]");
            query.Append(",tb_sach.giaBia as [Gía bán]");
            query.Append(",tb_cthoadon.soLuong * tb_sach.giaBia as [Thành Tiền]");
            query.Append(" from tb_sach,tb_cthoadon");
            query.Append(" where tb_sach.maSach=tb_cthoadon.maSach and maHoaDon = " + maHoaDon);
            dt = dataprovider.execQuery(query.ToString());

            dgvhoadonct.DataSource = dt;
        }
        private void loadcbbsach()
        {
            DataTable dt = new DataTable();
            dt = dataprovider.execQuery("select * from tb_sach");
            cbbtensach.DisplayMember = "tenSach";
            cbbtensach.ValueMember = "maSach";
            cbbtensach.DataSource = dt;
        }
        private void loadTongtien()
        {
            if ((int)dataprovider.execScaler("select count(*) from tb_cthoadon where maHoaDon=" + maHoaDon) > 0)
            {
                int tongTien = (int)dataprovider.execScaler("SELECT SUM( tb_cthoadon.soLuong * tb_sach.giaBia ) from tb_cthoadon,tb_sach where tb_cthoadon.maSach=tb_sach.maSach and maHoaDon = " +maHoaDon);
                tongtien.Text = "Tổng Tiền : " + tongTien;
            }
        }

        private void cbbtensach_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            System.Windows.Forms.ComboBox comboBox = sender as System.Windows.Forms.ComboBox;
            maSach = (int)comboBox.SelectedValue;
            tenSach = cbbtensach.Text;
            tonKho();
        }
        private managerKhoSach mngKho = new managerKhoSach();
        //nó load lên 0 r đấy
        public void tonKho()// vs lại cái này nữa
        {
            conn = new SqlConnection(chuoiketnoi);
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
            nbsltk.Text = (mngKho.timkiem(cbbtensach.Text)).ToString();

        }

        private void dgvhoadonct_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowID = e.RowIndex;
            if (rowID < 0) rowID = 0;
            if (rowID == dgvhoadonct.RowCount) rowID = rowID - 1;
            DataGridViewRow row = dgvhoadonct.Rows[rowID];

            tenSach = row.Cells[1].Value.ToString();
            cbbtensach.Text = tenSach;
            nbsl.Value = (int)row.Cells[2].Value;

            maSach = (int)dataprovider.execScaler("select maSach from tb_sach where tenSach =N'" + tenSach + "'");

        }

        private void dgvhoadonct_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            for (int i = 0; i < dgvhoadonct.RowCount; i++)
            {
                dgvhoadonct.Rows[i].Cells[0].Value = i + 1;
            }
        }
        private void XoaDL()
        {
            cbbtensach.ResetText();
            nbsl.ResetText();
            nbsltk.ResetText();
            loaddgvcthoadon();
        }


        private void btnthem_Click_1(object sender, EventArgs e)
        {
            int tk = Int32.Parse(nbsltk.Text);

            if (nbsl.Value >= tk)
            {
                XtraMessageBox.Show("Số lượng sách nhập quá số lượng sách còn trong kho !", "Thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int dem = (int)dataprovider.execScaler("select count(*) from tb_cthoadon where maHoaDon=" + maHoaDon + "and maSach=" + maSach);

                if (dem == 0)
                {
                    int soluong = Int32.Parse(nbsl.Value.ToString());

                    string sqlthem = "Insert into tb_cthoadon values(N'" + maHoaDon + "',N'" + maSach + "',N'" + soluong + "')";
                    StringBuilder query = new StringBuilder(sqlthem);


                    int result = dataprovider.execNonQuery(query.ToString());
                    if (result > 0)
                    {
                        loadTongtien();
                        loaddgvcthoadon();
                        XtraMessageBox.Show("Thêm sách vào hóa đơn thành công !", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        XoaDL();

                    }
                    else
                    {
                        XtraMessageBox.Show("Thêm sách vào hóa đơn thất bại !", "Thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    dem = (int)dataprovider.execScaler("select sum(soLuong) from tb_cthoadon where maHoaDon=" + maHoaDon + "and maSach= " + maSach);
                    update(dem);
                }
            }
        }

        private void btnsua_Click_1(object sender, EventArgs e)
        {
            update(0);
        }
        private void update(int soLuong)
        {
            int soluong = Int32.Parse(nbsl.Text);

            //khai báo chuỗi insert
            string sqlsua = "Update tb_cthoadon set soLuong=N'" + soluong + "'  where maSach = N'" + maSach + "' and maHoaDon = " + maHoaDon;
            StringBuilder query = new StringBuilder(sqlsua);



            int result = dataprovider.execNonQuery(query.ToString());
            if (result > 0)
            {
                loadTongtien();
                loaddgvcthoadon();
                MessageBox.Show("Cập nhập sách trong phiếu nhập thành công !", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                XoaDL();
            }
            else
            {
                MessageBox.Show("Cập nhập sách trong phiếu nhập thất bại !", "Thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
        private void btnxoa_Click_1(object sender, EventArgs e)
        {
            DialogResult check = XtraMessageBox.Show("Bạn có chắc chắn muốn xóa  sách :" + tenSach + "?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (check == DialogResult.Yes)
            {
                string query = "DELETE from tb_cthoadon where maHoaDon=" + maHoaDon + "and maSach=" + maSach;
                int result = dataprovider.execNonQuery(query.ToString());
                if (result > 0)
                {
                    loadTongtien();
                    loaddgvcthoadon();
                    XtraMessageBox.Show("Xóa sách khỏi hóa đơn thành công !", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    XoaDL();
                }
                else
                {
                    XtraMessageBox.Show("Xóa sách khỏi hóa đơn không thành công !", "Thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnin_Click_1(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = dataprovider.execQuery("EXEC proc_in_cthoadon @maHoaDon=" + maHoaDon);
            f_inhoadon report = new f_inhoadon();
            report.SetDataSource(dt);
            f_inhd form = new f_inhd(report);
            form.ShowDialog();
        }

        private void btnreset_Click_1(object sender, EventArgs e)
        {
            XoaDL();
        }
    }
}