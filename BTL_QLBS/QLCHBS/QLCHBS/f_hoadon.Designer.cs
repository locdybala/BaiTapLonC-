
namespace QLCHBS
{
    partial class f_hoadon
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(f_hoadon));
            this.cbbtennv = new System.Windows.Forms.ComboBox();
            this.dgvhoadon = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbbkh = new System.Windows.Forms.ComboBox();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.txtmahd = new DevExpress.XtraEditors.TextEdit();
            this.txtngaylap = new DevExpress.XtraEditors.DateEdit();
            this.btnchitiet = new DevExpress.XtraEditors.SimpleButton();
            this.btnreset = new DevExpress.XtraEditors.SimpleButton();
            this.btnxoa = new DevExpress.XtraEditors.SimpleButton();
            this.btnsua = new DevExpress.XtraEditors.SimpleButton();
            this.btnthem = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.dgvhoadon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtmahd.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtngaylap.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtngaylap.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // cbbtennv
            // 
            this.cbbtennv.FormattingEnabled = true;
            this.cbbtennv.Location = new System.Drawing.Point(158, 83);
            this.cbbtennv.Name = "cbbtennv";
            this.cbbtennv.Size = new System.Drawing.Size(200, 21);
            this.cbbtennv.TabIndex = 2;
            this.cbbtennv.SelectedIndexChanged += new System.EventHandler(this.cbbtennv_SelectedIndexChanged);
            // 
            // dgvhoadon
            // 
            this.dgvhoadon.AllowUserToAddRows = false;
            this.dgvhoadon.AllowUserToDeleteRows = false;
            this.dgvhoadon.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvhoadon.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvhoadon.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvhoadon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column6,
            this.Column5,
            this.Column4});
            this.dgvhoadon.Location = new System.Drawing.Point(5, 26);
            this.dgvhoadon.Name = "dgvhoadon";
            this.dgvhoadon.ReadOnly = true;
            this.dgvhoadon.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvhoadon.Size = new System.Drawing.Size(809, 201);
            this.dgvhoadon.TabIndex = 45;
            this.dgvhoadon.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvhoadon_CellClick);
            this.dgvhoadon.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvhoadon_CellDoubleClick);
            this.dgvhoadon.RowPrePaint += new System.Windows.Forms.DataGridViewRowPrePaintEventHandler(this.dgvhoadon_RowPrePaint);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "STT";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "maHoaDon";
            this.Column2.HeaderText = "Mã Hóa Đơn";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "tenKhachHang";
            this.Column3.HeaderText = "Tên khách hàng";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "sdtKH";
            this.Column6.HeaderText = "Số Điện Thoại";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "ngaylap";
            this.Column5.HeaderText = "Ngày Lập";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "tenNhanVien";
            this.Column4.HeaderText = "Tên Nhân Viên";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // cbbkh
            // 
            this.cbbkh.FormattingEnabled = true;
            this.cbbkh.Location = new System.Drawing.Point(502, 42);
            this.cbbkh.Name = "cbbkh";
            this.cbbkh.Size = new System.Drawing.Size(200, 21);
            this.cbbkh.TabIndex = 53;
            this.cbbkh.SelectedIndexChanged += new System.EventHandler(this.cbbkh_SelectedIndexChanged);
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.btnchitiet);
            this.groupControl1.Controls.Add(this.btnreset);
            this.groupControl1.Controls.Add(this.btnxoa);
            this.groupControl1.Controls.Add(this.btnsua);
            this.groupControl1.Controls.Add(this.btnthem);
            this.groupControl1.Controls.Add(this.txtngaylap);
            this.groupControl1.Controls.Add(this.txtmahd);
            this.groupControl1.Controls.Add(this.labelControl4);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Controls.Add(this.cbbkh);
            this.groupControl1.Controls.Add(this.cbbtennv);
            this.groupControl1.Location = new System.Drawing.Point(12, 43);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(818, 164);
            this.groupControl1.TabIndex = 56;
            this.groupControl1.Text = "groupControl1";
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.dgvhoadon);
            this.groupControl2.Location = new System.Drawing.Point(12, 218);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(819, 232);
            this.groupControl2.TabIndex = 57;
            this.groupControl2.Text = "groupControl2";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(62, 50);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(59, 13);
            this.labelControl1.TabIndex = 56;
            this.labelControl1.Text = "Mã Hóa Đơn";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(62, 83);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(69, 13);
            this.labelControl2.TabIndex = 57;
            this.labelControl2.Text = "Tên Nhân Viên";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(406, 45);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(78, 13);
            this.labelControl3.TabIndex = 58;
            this.labelControl3.Text = "Tên Khách Hàng";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(406, 91);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(45, 13);
            this.labelControl4.TabIndex = 59;
            this.labelControl4.Text = "Ngày Lập";
            // 
            // txtmahd
            // 
            this.txtmahd.Location = new System.Drawing.Point(158, 47);
            this.txtmahd.Name = "txtmahd";
            this.txtmahd.Properties.ReadOnly = true;
            this.txtmahd.Size = new System.Drawing.Size(200, 20);
            this.txtmahd.TabIndex = 60;
            // 
            // txtngaylap
            // 
            this.txtngaylap.EditValue = null;
            this.txtngaylap.Location = new System.Drawing.Point(502, 88);
            this.txtngaylap.Name = "txtngaylap";
            this.txtngaylap.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtngaylap.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtngaylap.Size = new System.Drawing.Size(199, 20);
            this.txtngaylap.TabIndex = 61;
            // 
            // btnchitiet
            // 
            this.btnchitiet.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnchitiet.ImageOptions.Image")));
            this.btnchitiet.Location = new System.Drawing.Point(518, 125);
            this.btnchitiet.Name = "btnchitiet";
            this.btnchitiet.Size = new System.Drawing.Size(75, 23);
            this.btnchitiet.TabIndex = 93;
            this.btnchitiet.Text = "Chi tiết";
            this.btnchitiet.Click += new System.EventHandler(this.btnchitiet_Click);
            // 
            // btnreset
            // 
            this.btnreset.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnreset.ImageOptions.Image")));
            this.btnreset.Location = new System.Drawing.Point(670, 125);
            this.btnreset.Name = "btnreset";
            this.btnreset.Size = new System.Drawing.Size(75, 23);
            this.btnreset.TabIndex = 92;
            this.btnreset.Text = "Reset";
            this.btnreset.Click += new System.EventHandler(this.btnreset_Click_1);
            // 
            // btnxoa
            // 
            this.btnxoa.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnxoa.ImageOptions.Image")));
            this.btnxoa.Location = new System.Drawing.Point(359, 125);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(75, 23);
            this.btnxoa.TabIndex = 91;
            this.btnxoa.Text = "Xóa";
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click_1);
            // 
            // btnsua
            // 
            this.btnsua.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnsua.ImageOptions.Image")));
            this.btnsua.Location = new System.Drawing.Point(194, 125);
            this.btnsua.Name = "btnsua";
            this.btnsua.Size = new System.Drawing.Size(75, 23);
            this.btnsua.TabIndex = 90;
            this.btnsua.Text = "Sửa";
            this.btnsua.Click += new System.EventHandler(this.btnsua_Click_1);
            // 
            // btnthem
            // 
            this.btnthem.AppearanceHovered.BackColor = System.Drawing.Color.White;
            this.btnthem.AppearanceHovered.Options.UseBackColor = true;
            this.btnthem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnthem.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnthem.ImageOptions.Image")));
            this.btnthem.Location = new System.Drawing.Point(43, 126);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(72, 22);
            this.btnthem.TabIndex = 89;
            this.btnthem.Text = "Thêm";
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click_1);
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(351, 12);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(95, 23);
            this.labelControl5.TabIndex = 58;
            this.labelControl5.Text = "HÓA ĐƠN";
            // 
            // f_hoadon
            // 
            this.Appearance.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(843, 460);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupControl1);
            this.Name = "f_hoadon";
            this.Text = "f_hoadon";
            ((System.ComponentModel.ISupportInitialize)(this.dgvhoadon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtmahd.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtngaylap.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtngaylap.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cbbtennv;
        private System.Windows.Forms.DataGridView dgvhoadon;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.ComboBox cbbkh;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.DateEdit txtngaylap;
        private DevExpress.XtraEditors.TextEdit txtmahd;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.SimpleButton btnchitiet;
        private DevExpress.XtraEditors.SimpleButton btnreset;
        private DevExpress.XtraEditors.SimpleButton btnxoa;
        private DevExpress.XtraEditors.SimpleButton btnsua;
        private DevExpress.XtraEditors.SimpleButton btnthem;
        private DevExpress.XtraEditors.LabelControl labelControl5;
    }
}