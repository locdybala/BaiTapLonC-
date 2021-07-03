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
    public partial class f_doanhthu : DevExpress.XtraEditors.XtraForm
    {
        dataprovider dataprovider = new dataprovider();
        public int maHoaDon;
        public f_doanhthu()
        {
            InitializeComponent();
            loaddgv();
        }
        public void loaddgv()
        {
            DataTable dt = new DataTable();

            StringBuilder query = new StringBuilder("select tb_cthoadon.maHoaDon as [Mã Hóa Đơn]");
            query.Append(",sum(tb_cthoadon.soLuong * tb_sach.giaBia) as [Tổng Tiền]");
           
            query.Append(",ngaylap as [Ngày lập]");

      
            query.Append(" from tb_cthoadon,tb_sach,tb_hoadon");
            query.Append(" where tb_cthoadon.maSach=tb_sach.maSach and tb_cthoadon.maHoaDon=tb_hoadon.maHoaDon ");
            query.Append(" group by tb_cthoadon.maHoaDon,ngaylap");
            dt = dataprovider.execQuery(query.ToString());
            dgvdoanhthu.DataSource = dt;
        }

        private void btnthongke_Click(object sender, EventArgs e)
        {
            string ngaydau = txtngaydau.Text;
            string ngaycuoi = txtngaycuoi.Text;
            DataTable dt = new DataTable();

            StringBuilder query = new StringBuilder("select tb_cthoadon.maHoaDon as [Mã Hóa Đơn]");
            query.Append(",sum(tb_cthoadon.soLuong * tb_sach.giaBia) as [Tổng Tiền]");

            query.Append(",ngaylap as [Ngày lập]");


            query.Append(" from tb_cthoadon,tb_sach,tb_hoadon");
            query.Append(" where tb_cthoadon.maSach=tb_sach.maSach and tb_cthoadon.maHoaDon=tb_hoadon.maHoaDon and ngaylap BETWEEN '"+ngaydau+"' and '"+ngaycuoi+"'");
            
            query.Append(" group by tb_cthoadon.maHoaDon,ngaylap");
            dt = dataprovider.execQuery(query.ToString());
            dgvdoanhthu.DataSource = dt;
        }

        private void dgvdoanhthu_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}