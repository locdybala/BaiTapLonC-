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
    public partial class f_sach : DevExpress.XtraEditors.XtraForm
    {
        private dataprovider dataprovider = new dataprovider();
        private int maLoaiSach;
        private int maTacGia;
        
        public f_sach()
        {
            InitializeComponent();
            init();
        }
        private void init()
        {
            initSach();
        }
        private void initSach()
        {
            loaddgvsach();
            loadcbbloaisach();
            loadcbbtacgia();

        }
        private void loaddgvsach()
        {
            DataTable dt = new DataTable();

            StringBuilder query = new StringBuilder("Select tb_sach.maSach,tenLoaiSach,tenSach,tenTacGia,namXuatBan,tb_sach.giaBia from tb_sach,tb_loaisach,tb_tacgia where tb_sach.maLoaiSach=tb_loaisach.maLoaiSach and tb_tacgia.maTacGia=tb_sach.maTacGia ");
            dt = dataprovider.execQuery(query.ToString());
            dgvsach.DataSource = dt;
        }
        private void loadcbbloaisach()
        {
            DataTable dt = new DataTable();
            dt = dataprovider.execQuery("select * from tb_loaisach");
            cbbloaisach.DisplayMember = "tenLoaiSach";
            cbbloaisach.ValueMember = "maLoaiSach";
            cbbloaisach.DataSource = dt;
        }
        private void loadcbbtacgia()
        {
            DataTable dt = new DataTable();
            dt = dataprovider.execQuery("select * from tb_tacgia");
            cbbtacgia.DisplayMember = "tenTacGia";
            cbbtacgia.ValueMember = "maTacGia";
            cbbtacgia.DataSource = dt;
        }

        private void dgvsach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowID = e.RowIndex;
            if (rowID < 0) rowID = 0;
            if (rowID == dgvsach.RowCount) rowID = rowID - 1;
            DataGridViewRow row = dgvsach.Rows[rowID];
            txtmasach.Text = row.Cells[1].Value.ToString();
            cbbloaisach.Text = row.Cells[2].Value.ToString();
            txtTenSach.Text = row.Cells[3].Value.ToString();
            cbbtacgia.Text = row.Cells[4].Value.ToString();
            txtNamXB.Text = row.Cells[5].Value.ToString();
            txtgiaban.Text = row.Cells[6].Value.ToString();
        }

        private void cbbloaisach_SelectedIndexChanged(object sender, EventArgs e)
        {
            System.Windows.Forms.ComboBox comboBox = sender as System.Windows.Forms.ComboBox;
            maLoaiSach = (int)comboBox.SelectedValue;
        }

        private void cbbtacgia_SelectedIndexChanged(object sender, EventArgs e)
        {
            System.Windows.Forms.ComboBox comboBox = sender as System.Windows.Forms.ComboBox;
            maTacGia = (int)comboBox.SelectedValue;
        }
        private void XoaDL()
        {
            txtmasach.ResetText();
            txtTenSach.ResetText();
            txtgiaban.ResetText();
            txtNamXB.ResetText();
            cbbloaisach.ResetText();
            cbbtacgia.ResetText();
            txtTenSach.Focus();
        }

        private void dgvsach_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            for (int i = 0; i < dgvsach.RowCount; i++)
            {
                dgvsach.Rows[i].Cells[0].Value = i + 1;
            }
        }

       
        private void btnthem_Click_1(object sender, EventArgs e)
        {
            string tensach = txtTenSach.Text;
            string giabia = txtgiaban.Text;
            string namxb = txtNamXB.Text;

            string sqlthem = "Insert into tb_sach values(N'" + tensach + "',N'" + maLoaiSach + "',N'" + maTacGia + "',N'" + namxb + "',N'" + giabia + "')";
            StringBuilder query = new StringBuilder(sqlthem);



            int result = dataprovider.execNonQuery(query.ToString());
            if (result > 0)
            {
                XoaDL();
                loaddgvsach();
                XtraMessageBox.Show("Thêm sách thành công !", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else
            {
                XtraMessageBox.Show("Thêm sách thất bại !", "Thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnsua_Click_1(object sender, EventArgs e)
        {
            string masach = txtmasach.Text;
            string tensach = txtTenSach.Text;
            string giabia = txtgiaban.Text;
            string namxb = txtNamXB.Text;
            string sqlsua = "Update tb_sach set tenSach=N'" + tensach + "',maLoaiSach=N'" + maLoaiSach + "',maTacGia=N'" + maTacGia + "',namXuatBan=N'" + namxb + "',giaBia=N'" + giabia + "' where maSach = N'" + masach + "' ";
            StringBuilder query = new StringBuilder(sqlsua);



            int result = dataprovider.execNonQuery(query.ToString());
            if (result > 0)
            {
                XoaDL();
                loaddgvsach();
                XtraMessageBox.Show("Sửa sách thành công !", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else
            {
                XtraMessageBox.Show("Sửa sách thất bại !", "Thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnxoa_Click_1(object sender, EventArgs e)
        {
            DialogResult check = XtraMessageBox.Show("Bạn có chắc chắn muốn xóa sách :" + txtTenSach.Text + "?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (check == DialogResult.Yes)
            {
                string maSach = txtmasach.Text;
                string query = "Delete from tb_sach where maSach=N'" + maSach + "'";
                int result = dataprovider.execNonQuery(query.ToString());
                if (result > 0)
                {
                    XoaDL();
                    loaddgvsach();
                    XtraMessageBox.Show("Xóa sách thành công !", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                else
                {
                    XtraMessageBox.Show("Xóa sách không thành công !", "Thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnreset_Click_1(object sender, EventArgs e)
        {
            XoaDL();
        }
    }
}