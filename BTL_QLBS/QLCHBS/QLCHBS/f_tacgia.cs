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
    public partial class f_tacgia : DevExpress.XtraEditors.XtraForm
    {
        dataprovider dataprovider = new dataprovider();
        public string gioitinh;
        public f_tacgia()
        {
            InitializeComponent();
            loadtacgia();
        }
        public void loadtacgia()
        {
            DataTable dt = new DataTable();
            StringBuilder query = new StringBuilder("select * from tb_tacgia");
            dt = dataprovider.execQuery(query.ToString());
            dgvtacgia.DataSource = dt;

        }

        private void dgvtacgia_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            
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

        
        public void XoaDL()
        {
            txtmatacgia.ResetText();
            txttentacgia.ResetText();
            rbnam.Checked = true;
            rbNu.Checked = false;
            txtngaysinh.ResetText();
            txtcoquan.ResetText();
            txttrinhdo.ResetText();
            txttentacgia.Focus();
            loadtacgia();
        }

        private void f_tacgia_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qlbsDataSet.tb_tacgia' table. You can move, or remove it, as needed.
           

        }

        private void btnthem_Click_1(object sender, EventArgs e)
        {
            check();
            string tentacgia = txttentacgia.Text;
            string ngaysinh = txtngaysinh.Text;
            string trinhdo = txttrinhdo.Text;
            string coquan = txtcoquan.Text;

            string sqlthem = "Insert into tb_tacgia values(N'" + tentacgia + "',N'" + gioitinh + "',N'" + ngaysinh + "',N'" + trinhdo + "',N'" + coquan + "')";
            StringBuilder query = new StringBuilder(sqlthem);



            int result = dataprovider.execNonQuery(query.ToString());
            if (result > 0)
            {
                XoaDL();
                loadtacgia();
                XtraMessageBox.Show("Thêm tác giả thành công !", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else
            {
                XtraMessageBox.Show("Thêm tác giả thất bại !", "Thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnsua_Click_1(object sender, EventArgs e)
        {
            check();
            string matacgia = txtmatacgia.Text;
            string tentacgia = txttentacgia.Text;
            string ngaysinh = txtngaysinh.Text;
            string trinhdo = txttrinhdo.Text;
            string coquan = txtcoquan.Text;

            //khai báo chuỗi insert
            string sqlsua = "Update tb_tacgia set tenTacGia=N'" + tentacgia + "',gioiTinh=N'" + gioitinh + "',ngaySinh=N'" + ngaysinh + "',trinhdo=N'" + trinhdo + "',coquan=N'" + coquan + "' where maTacGia = N'" + matacgia + "' ";
            StringBuilder query = new StringBuilder(sqlsua);



            int result = dataprovider.execNonQuery(query.ToString());
            if (result > 0)
            {
                XoaDL();
                loadtacgia();
                XtraMessageBox.Show("Sửa tác giả thành công !", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else
            {
                XtraMessageBox.Show("Sửa tác giả thất bại !", "Thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnxoa_Click_1(object sender, EventArgs e)
        {
            DialogResult check = XtraMessageBox.Show("Bạn có chắc chắn muốn xóa tác giả :" + txttentacgia.Text + "?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (check == DialogResult.Yes)
            {
                string matacgia = txtmatacgia.Text;
                string query = "Delete from tb_tacgia where maTacGia=N'" + matacgia + "'";
                int result = dataprovider.execNonQuery(query.ToString());
                if (result > 0)
                {
                    XoaDL();
                    loadtacgia();
                    XtraMessageBox.Show("Xóa tác giả thành công !", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                else
                {
                    XtraMessageBox.Show("Xóa tác giả không thành công !", "Thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnreset_Click_1(object sender, EventArgs e)
        {
            XoaDL();
        }

        private void dgvtacgia_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowID = e.RowIndex;
            if (rowID < 0) rowID = 0;
            if (rowID == dgvtacgia.RowCount) rowID = rowID - 1;
            DataGridViewRow row = dgvtacgia.Rows[rowID];
            txtmatacgia.Text = row.Cells[1].Value.ToString();

            txttentacgia.Text = row.Cells[2].Value.ToString();
            if (row.Cells[3].Value.ToString() == "Nam")
            {
                rbnam.Checked = true;
                rbNu.Checked = false;
            }
            else
            {
                rbnam.Checked = false;
                rbNu.Checked = true;
            }
            txtngaysinh.Text = row.Cells[4].Value.ToString();


            txttrinhdo.Text = row.Cells[5].Value.ToString();
            
            txtcoquan.Text = row.Cells[6].Value.ToString();
        }

        private void dgvtacgia_RowPrePaint_1(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            for (int i = 0; i < dgvtacgia.RowCount; i++)
            {
                dgvtacgia.Rows[i].Cells[0].Value = i + 1;
            }
        }
    }
}