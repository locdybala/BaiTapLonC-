using DevExpress.XtraEditors;
using QLCHBS.formin;
using QLCHBS.report;
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

    public partial class f_phieunhapchitiet : DevExpress.XtraEditors.XtraForm
    {
        dataprovider dataprovider = new dataprovider();
        private int maSach;
        private int maPhieuNhap;
        private string tenSach;
        public f_phieunhapchitiet(int mapn)
        {
            InitializeComponent();
            this.maPhieuNhap = mapn;
            init(maPhieuNhap);
        }
        private void init(int maPhieuNhap)

        {
            title.Text = "Chi tiết phiếu nhập " + maPhieuNhap;
            loadcbbsach();
            loaddgvctphieunhap();
            loadTongtien();
        }
        private void loaddgvctphieunhap()
        {
            DataTable dt = new DataTable();
            StringBuilder query = new StringBuilder("select tb_sach.tenSach as [Tên Sách]");
            query.Append(",tb_ctphieunhap.soLuong as [Số Lượng]");
            query.Append(",tb_sach.giaBia-(tb_sach.giaBia*tb_nhacungcap.chietkhau) as [Gía nhập]");
            query.Append(",tb_ctphieunhap.soLuong * (tb_sach.giaBia-(tb_sach.giaBia*tb_nhacungcap.chietkhau)) as [Thành Tiền]");
            query.Append(" from tb_sach,tb_ctphieunhap,tb_phieunhap,tb_nhacungcap");
            query.Append(" where tb_sach.maSach=tb_ctphieunhap.maSach and tb_ctphieunhap.maPhieuNhap=tb_phieunhap.maPhieuNhap and tb_phieunhap.maNhaCungCap=tb_nhacungcap.maNhaCungCap and tb_ctphieunhap.maPhieuNhap = " + maPhieuNhap);

            dt = dataprovider.execQuery(query.ToString());

            dgvphieunhapct.DataSource = dt;


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
            if ((int)dataprovider.execScaler("select count(*) from tb_ctphieunhap where maPhieuNhap=" + maPhieuNhap) > 0)
            {
                double tongTien = (double)dataprovider.execScaler("select SUM( tb_ctphieunhap.soLuong * (tb_sach.giaBia-(tb_sach.giaBia*tb_nhacungcap.chietkhau))) from tb_ctphieunhap,tb_sach,tb_phieunhap,tb_nhacungcap where tb_sach.maSach=tb_ctphieunhap.maSach and tb_ctphieunhap.maPhieuNhap=tb_phieunhap.maPhieuNhap and tb_phieunhap.maNhaCungCap=tb_nhacungcap.maNhaCungCap and tb_ctphieunhap.maPhieuNhap = " + maPhieuNhap);
                tongtien.Text = "Tổng Tiền : " + tongTien;
            }

        }
        private void dgvphieunhapct_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowID = e.RowIndex;
            if (rowID < 0) rowID = 0;
            if (rowID == dgvphieunhapct.RowCount) rowID = rowID - 1;
            DataGridViewRow row = dgvphieunhapct.Rows[rowID];

            tenSach = row.Cells[1].Value.ToString();
            cbbtensach.Text = tenSach;
            nbslsach.Value = (int)row.Cells[2].Value;

            maSach = (int)dataprovider.execScaler("select maSach from tb_sach where tenSach =N'" + tenSach + "'");
        }
        private void XoaDL()
        {
            cbbtensach.ResetText();
            nbslsach.ResetText();
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            int dem = (int)dataprovider.execScaler("select count(*) from tb_ctphieunhap where maPhieuNhap=" + maPhieuNhap + "and maSach=" + maSach);
            if (dem == 0)
            {
                
                int soluong = Int32.Parse(nbslsach.Value.ToString());

                string sqlthem = "insert into tb_ctphieunhap(maPhieuNhap,maSach,soLuong) VALUES(N'" + maPhieuNhap + "',N'" + maSach + "',N'" + soluong + "')";
                StringBuilder query = new StringBuilder(sqlthem);
                

                int result = dataprovider.execNonQuery(query.ToString());
                if (result > 0)
                {
                    XoaDL();
                    loadTongtien();
                    loaddgvctphieunhap();
                    XtraMessageBox.Show("Thêm sản phẩm vào phiếu nhập nhập thành công !", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                else
                {
                    XtraMessageBox.Show("Thêm sản phẩm vào phiếu nhập thất bại !", "Thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                dem = (int)dataprovider.execScaler("select sum(soLuong) from tb_ctphieunhap where maPhieuNhap=" + maPhieuNhap + "and maSach= " + maSach);
                update(dem);
            }
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            update(0);
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            DialogResult check = MessageBox.Show("Bạn có chắc chắn muốn xóa sách :" + tenSach + "?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (check == DialogResult.Yes)
            {
                string query = "DELETE from tb_ctphieunhap where maPhieuNhap=" + maPhieuNhap + "and maSach=" + maSach;
                int result = dataprovider.execNonQuery(query.ToString());
                if (result > 0)
                {
                    loadTongtien();
                    loaddgvctphieunhap();
                    MessageBox.Show("Xóa sách khỏi phiếu nhập thành công !", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                else
                {
                    MessageBox.Show("Xóa sách khỏi phiếu nhập không thành công !", "Thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
       

      

        private void cbbtensach_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            System.Windows.Forms.ComboBox comboBox = sender as System.Windows.Forms.ComboBox;
            maSach = (int)comboBox.SelectedValue;
            tenSach = cbbtensach.Text;
        }

        private void btnthem_Click_1(object sender, EventArgs e)
        {
            int dem = (int)dataprovider.execScaler("select count(*) from tb_ctphieunhap where maPhieuNhap=" + maPhieuNhap + "and maSach=" + maSach);
            if (dem == 0)
            {

                int soluong = Int32.Parse(nbslsach.Value.ToString());

                string sqlthem = "insert into tb_ctphieunhap(maPhieuNhap,maSach,soLuong) VALUES(N'" + maPhieuNhap + "',N'" + maSach + "',N'" + soluong + "')";
                StringBuilder query = new StringBuilder(sqlthem);


                int result = dataprovider.execNonQuery(query.ToString());
                if (result > 0)
                {
                    XoaDL();
                    loadTongtien();
                    loaddgvctphieunhap();
                    XtraMessageBox.Show("Thêm sản phẩm vào phiếu nhập nhập thành công !", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                else
                {
                    XtraMessageBox.Show("Thêm sản phẩm vào phiếu nhập thất bại !", "Thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                dem = (int)dataprovider.execScaler("select sum(soLuong) from tb_ctphieunhap where maPhieuNhap=" + maPhieuNhap + "and maSach= " + maSach);
                update(dem);
            }
        }

        private void btnsua_Click_1(object sender, EventArgs e)
        {
            update(0);
        }

        private void btnxoa_Click_1(object sender, EventArgs e)
        {
            DialogResult check = MessageBox.Show("Bạn có chắc chắn muốn xóa sách :" + tenSach + "?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (check == DialogResult.Yes)
            {
                string query = "DELETE from tb_ctphieunhap where maPhieuNhap=" + maPhieuNhap + "and maSach=" + maSach;
                int result = dataprovider.execNonQuery(query.ToString());
                if (result > 0)
                {
                    loadTongtien();
                    loaddgvctphieunhap();
                    MessageBox.Show("Xóa sách khỏi phiếu nhập thành công !", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                else
                {
                    MessageBox.Show("Xóa sách khỏi phiếu nhập không thành công !", "Thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void update(int soLuong)
        {

            int soluong = Int32.Parse(nbslsach.Text);

            //khai báo chuỗi insert
            string sqlsua = "Update tb_ctphieunhap set soLuong=N'" + soluong + "'  where maSach = N'" + maSach + "' and maPhieuNhap = " + maPhieuNhap;
            StringBuilder query = new StringBuilder(sqlsua);

            int result = dataprovider.execNonQuery(query.ToString());
            if (result > 0)
            {
                loadTongtien();
                loaddgvctphieunhap();
                MessageBox.Show("Cập nhập sách trong phiếu nhập thành công !", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else
            {
                MessageBox.Show("Cập nhập sách trong phiếu nhập thất bại !", "Thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnin_Click_1(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = dataprovider.execQuery("EXEC proc_in_ctphieunhap @maPhieuNhap=" + maPhieuNhap);
            f_inpnct report = new f_inpnct();
            report.SetDataSource(dt);
            f_inphieunhapct form = new f_inphieunhapct(report);
            form.ShowDialog();
        }

        private void btnreset_Click_1(object sender, EventArgs e)
        {
            XoaDL();
        }
    }
}