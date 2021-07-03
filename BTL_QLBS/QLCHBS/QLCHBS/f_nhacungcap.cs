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
    
    public partial class f_nhacungcap : DevExpress.XtraEditors.XtraForm
    {
        dataprovider dataprovider = new dataprovider();
        public f_nhacungcap()
        {
            InitializeComponent();
            loadncc();
        }
        private void loadncc()
        {
            DataTable dt = new DataTable();
            StringBuilder query = new StringBuilder("Select * from tb_nhacungcap");
            dt = dataprovider.execQuery(query.ToString());
            dgvncc.DataSource = dt;
        }

        private void dgvncc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowID = e.RowIndex;
            if (rowID < 0) rowID = 0;
            if (rowID == dgvncc.RowCount) rowID = rowID - 1;
            DataGridViewRow row = dgvncc.Rows[rowID];
            txtmancc.Text = row.Cells[1].Value.ToString();
            txttenncc.Text = row.Cells[2].Value.ToString();
            txtdiachi.Text = row.Cells[3].Value.ToString();
            txtsdt.Text = row.Cells[4].Value.ToString();
            txtghichu.Text = row.Cells[5].Value.ToString();
            txtchietkhau.Text = row.Cells[6].Value.ToString();
        }

        private void dgvncc_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            for (int i = 0; i < dgvncc.RowCount; i++)
            {
                dgvncc.Rows[i].Cells[0].Value = i + 1;
            }
        }
        private void XoaDL()
        {
            txtmancc.ResetText();
            txttenncc.ResetText();
            txtdiachi.ResetText();
            txtsdt.ResetText();
            txtchietkhau.ResetText();
            txtghichu.ResetText();
            txttenncc.Focus();
        }

      

        

        private void btnthem_Click_1(object sender, EventArgs e)
        {
            string tenncc = txttenncc.Text;
            string diachi = txtdiachi.Text;
            string sdt = txtsdt.Text;
            string ghichu = txtghichu.Text;
            string chietkhau = txtchietkhau.Text;

            string sqlthem = "Insert into tb_nhacungcap values(N'" + tenncc + "',N'" + diachi + "',N'" + sdt + "',N'" + ghichu + "',N'" + chietkhau + "')";
            StringBuilder query = new StringBuilder(sqlthem);



            int result = dataprovider.execNonQuery(query.ToString());
            if (result > 0)
            {
                XoaDL();
                loadncc();
                XtraMessageBox.Show("Thêm nhà cung cấp thành công !", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else
            {
                XtraMessageBox.Show("Thêm nhà cung cấp thất bại !", "Thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnsua_Click_1(object sender, EventArgs e)
        {
            string mancc = txtmancc.Text;
            string tenncc = txttenncc.Text;
            string diachi = txtdiachi.Text;
            string sdt = txtsdt.Text;
            string ghichu = txtghichu.Text;
            string chietkhau = txtchietkhau.Text;
            string sqlsua = "Update tb_nhacungcap set tenNhaCungCap=N'" + tenncc + "',diaChi=N'" + diachi + "',sdtNhaCungCap=N'" + sdt + "',ghichu=N'" + ghichu + "',chietkhau=N'" + chietkhau + "' where maNhaCungCap = N'" + mancc + "' ";
            StringBuilder query = new StringBuilder(sqlsua);



            int result = dataprovider.execNonQuery(query.ToString());
            if (result > 0)
            {
                XoaDL();
                loadncc();
                XtraMessageBox.Show("Sửa nhà cung cấp thành công !", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else
            {
                XtraMessageBox.Show("Sửa nhà cung cấp thất bại !", "Thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnxoa_Click_1(object sender, EventArgs e)
        {
            DialogResult check = XtraMessageBox.Show("Bạn có chắc chắn muốn xóa nhà cung cấp : " + txttenncc.Text + "?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (check == DialogResult.Yes)
            {
                string manhacungcap = txtmancc.Text;
                string query = "Delete from tb_nhacungcap where maNhaCungCap=N'" + manhacungcap + "'";
                int result = dataprovider.execNonQuery(query.ToString());
                if (result > 0)
                {
                    XoaDL();
                    loadncc();
                    XtraMessageBox.Show("Xóa nhà cung cấp thành công !", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                else
                {
                    XtraMessageBox.Show("Xóa nhà cung cấp thất bại !", "Thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnreset_Click_1(object sender, EventArgs e)
        {
            XoaDL();
        }
    }
}