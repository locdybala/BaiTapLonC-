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
    public partial class f_nhanvien : DevExpress.XtraEditors.XtraForm
    {
        dataprovider dataprovider = new dataprovider();
        private string gioitinh;
        public f_nhanvien()
        {
            InitializeComponent();
            loadnv();
        }
        private void loadnv()
        {
            DataTable dt = new DataTable();
            StringBuilder query = new StringBuilder("select * from tb_nhanvien");
            dt = dataprovider.execQuery(query.ToString());
            dgvnhanvien.DataSource = dt;
        }

        private void dgvnhanvien_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            for (int i = 0; i < dgvnhanvien.RowCount; i++)
            {
                dgvnhanvien.Rows[i].Cells[0].Value = i + 1;
            }
        }
        private void check()
        {
            if (rbnam.Checked == true)
            {
                gioitinh = "Nam";
            }
            else
            {
                gioitinh = "Nữ";
            }
        }

        private void dgvnhanvien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowID = e.RowIndex;
            if (rowID < 0) rowID = 0;
            if (rowID == dgvnhanvien.RowCount) rowID = rowID - 1;
            DataGridViewRow row = dgvnhanvien.Rows[rowID];
            txtmanv.Text = row.Cells[1].Value.ToString();

            txttennv.Text = row.Cells[2].Value.ToString();
            
            txtngaysinh.Text = row.Cells[3].Value.ToString();


            txtsdt.Text = row.Cells[4].Value.ToString();
            if (row.Cells[5].Value.ToString() == "Nam")
            {
                rbnam.Checked = true;
                rbNu.Checked = false;
            }
            else
            {
                rbnam.Checked = false;
                rbNu.Checked = true;
            }
            txtdiachi.Text = row.Cells[6].Value.ToString();
        }
        private void XoaDL()
        {
            txtmanv.ResetText();
            txttennv.ResetText();
            rbnam.Checked = true;
            rbNu.Checked = false;
            txtngaysinh.ResetText();
            txtsdt.ResetText();
            txtdiachi.ResetText();
        }

        private void btnthem_Click_1(object sender, EventArgs e)
        {
            check();
            string tennv = txttennv.Text;
            string ngaysinh = txtngaysinh.Text;
            string sdt = txtsdt.Text;
            string diachi = txtdiachi.Text;

            string sqlthem = "Insert into tb_nhanvien values(N'" + tennv + "',N'" + ngaysinh + "',N'" + sdt + "',N'" + gioitinh + "',N'" + diachi + "')";
            StringBuilder query = new StringBuilder(sqlthem);



            int result = dataprovider.execNonQuery(query.ToString());
            if (result > 0)
            {
                XoaDL();
                loadnv();
                XtraMessageBox.Show("Thêm nhân viêm thành công !", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else
            {
                XtraMessageBox.Show("Thêm nhân viên thất bại !", "Thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnsua_Click_1(object sender, EventArgs e)
        {
            check();
            string manv = txtmanv.Text;
            string tennv = txttennv.Text;
            string ngaysinh = txtngaysinh.Text;
            string sdt = txtsdt.Text;
            string diachi = txtdiachi.Text;

            //khai báo chuỗi insert
            string sqlsua = "Update tb_nhanvien set tenNhanVien=N'" + tennv + "',ngaySinh=N'" + ngaysinh + "',sdtNhanVien=N'" + sdt + "',gioitinh=N'" + gioitinh + "',diaChi=N'" + diachi + "' where maNhanVien = N'" + manv + "' ";
            StringBuilder query = new StringBuilder(sqlsua);



            int result = dataprovider.execNonQuery(query.ToString());
            if (result > 0)
            {
                XoaDL();
                loadnv();
                XtraMessageBox.Show("Sửa nhân viên thành công !", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else
            {
                XtraMessageBox.Show("Sửa nhân viên thất bại !", "Thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnxoa_Click_1(object sender, EventArgs e)
        {
            DialogResult check = XtraMessageBox.Show("Bạn có chắc chắn muốn xóa nhân viên :" + txttennv.Text + "?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (check == DialogResult.Yes)
            {
                string manv = txtmanv.Text;
                string query = "Delete from tb_nhanvien where maNhanVien=N'" + manv + "'";
                int result = dataprovider.execNonQuery(query.ToString());
                if (result > 0)
                {
                    XoaDL();
                    loadnv();
                    XtraMessageBox.Show("Xóa nhân viên thành công !", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                else
                {
                    XtraMessageBox.Show("Xóa nhân viên không thành công !", "Thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnreset_Click_1(object sender, EventArgs e)
        {
            XoaDL();
        }
    }
}