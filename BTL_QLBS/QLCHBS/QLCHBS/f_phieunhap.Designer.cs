
namespace QLCHBS
{
    partial class f_phieunhap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(f_phieunhap));
            this.cbbtennv = new System.Windows.Forms.ComboBox();
            this.cbbtenncc = new System.Windows.Forms.ComboBox();
            this.dgvphieunhap = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.txtmapn = new DevExpress.XtraEditors.TextEdit();
            this.txtngaynhap = new DevExpress.XtraEditors.DateEdit();
            this.btnchitiet = new DevExpress.XtraEditors.SimpleButton();
            this.btnreset = new DevExpress.XtraEditors.SimpleButton();
            this.btnxoa = new DevExpress.XtraEditors.SimpleButton();
            this.btnsua = new DevExpress.XtraEditors.SimpleButton();
            this.btnthem = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvphieunhap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtmapn.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtngaynhap.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtngaynhap.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // cbbtennv
            // 
            this.cbbtennv.FormattingEnabled = true;
            this.cbbtennv.Location = new System.Drawing.Point(119, 99);
            this.cbbtennv.Name = "cbbtennv";
            this.cbbtennv.Size = new System.Drawing.Size(206, 21);
            this.cbbtennv.TabIndex = 5;
            this.cbbtennv.SelectedIndexChanged += new System.EventHandler(this.cbbtennv_SelectedIndexChanged);
            // 
            // cbbtenncc
            // 
            this.cbbtenncc.FormattingEnabled = true;
            this.cbbtenncc.Location = new System.Drawing.Point(520, 50);
            this.cbbtenncc.Name = "cbbtenncc";
            this.cbbtenncc.Size = new System.Drawing.Size(206, 21);
            this.cbbtenncc.TabIndex = 6;
            this.cbbtenncc.SelectedIndexChanged += new System.EventHandler(this.cbbtenncc_SelectedIndexChanged);
            // 
            // dgvphieunhap
            // 
            this.dgvphieunhap.AllowUserToAddRows = false;
            this.dgvphieunhap.AllowUserToDeleteRows = false;
            this.dgvphieunhap.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvphieunhap.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvphieunhap.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvphieunhap.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dgvphieunhap.Location = new System.Drawing.Point(7, 26);
            this.dgvphieunhap.Name = "dgvphieunhap";
            this.dgvphieunhap.ReadOnly = true;
            this.dgvphieunhap.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvphieunhap.Size = new System.Drawing.Size(801, 198);
            this.dgvphieunhap.TabIndex = 17;
            this.dgvphieunhap.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvphieunhap_CellClick);
            this.dgvphieunhap.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvphieunhap_CellDoubleClick);
            this.dgvphieunhap.RowPrePaint += new System.Windows.Forms.DataGridViewRowPrePaintEventHandler(this.dgvphieunhap_RowPrePaint);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "STT";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "maPhieuNhap";
            this.Column2.HeaderText = "Mã Phiếu Nhập";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "tenNhanVien";
            this.Column3.HeaderText = "Tên Nhân Viên";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "tenNhaCungCap";
            this.Column4.HeaderText = "Tên Nhà Cung Cấp";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "ngayNhap";
            this.Column5.HeaderText = "Ngày Nhập";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.btnchitiet);
            this.groupControl1.Controls.Add(this.btnreset);
            this.groupControl1.Controls.Add(this.btnxoa);
            this.groupControl1.Controls.Add(this.btnsua);
            this.groupControl1.Controls.Add(this.btnthem);
            this.groupControl1.Controls.Add(this.txtngaynhap);
            this.groupControl1.Controls.Add(this.txtmapn);
            this.groupControl1.Controls.Add(this.labelControl4);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Controls.Add(this.cbbtenncc);
            this.groupControl1.Controls.Add(this.cbbtennv);
            this.groupControl1.Location = new System.Drawing.Point(14, 33);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(798, 215);
            this.groupControl1.TabIndex = 18;
            this.groupControl1.Text = "groupControl1";
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.dgvphieunhap);
            this.groupControl2.Location = new System.Drawing.Point(5, 257);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(819, 234);
            this.groupControl2.TabIndex = 19;
            this.groupControl2.Text = "Danh sách phiếu nhập";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(42, 55);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(71, 13);
            this.labelControl1.TabIndex = 17;
            this.labelControl1.Text = "Mã Phiếu Nhập";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(44, 107);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(69, 13);
            this.labelControl2.TabIndex = 18;
            this.labelControl2.Text = "Tên Nhân Viên";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(414, 55);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(90, 13);
            this.labelControl3.TabIndex = 19;
            this.labelControl3.Text = "Tên Nhà Cung Cấp";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(451, 108);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(53, 13);
            this.labelControl4.TabIndex = 20;
            this.labelControl4.Text = "Ngày Nhập";
            // 
            // txtmapn
            // 
            this.txtmapn.Location = new System.Drawing.Point(119, 53);
            this.txtmapn.Name = "txtmapn";
            this.txtmapn.Size = new System.Drawing.Size(206, 20);
            this.txtmapn.TabIndex = 21;
            // 
            // txtngaynhap
            // 
            this.txtngaynhap.EditValue = null;
            this.txtngaynhap.Location = new System.Drawing.Point(520, 100);
            this.txtngaynhap.Name = "txtngaynhap";
            this.txtngaynhap.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtngaynhap.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtngaynhap.Size = new System.Drawing.Size(204, 20);
            this.txtngaynhap.TabIndex = 22;
            // 
            // btnchitiet
            // 
            this.btnchitiet.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnin.ImageOptions.Image")));
            this.btnchitiet.Location = new System.Drawing.Point(517, 151);
            this.btnchitiet.Name = "btnchitiet";
            this.btnchitiet.Size = new System.Drawing.Size(75, 23);
            this.btnchitiet.TabIndex = 88;
            this.btnchitiet.Text = "Chi tiết";
            this.btnchitiet.Click += new System.EventHandler(this.btnchitiet_Click);
            // 
            // btnreset
            // 
            this.btnreset.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.btnreset.Location = new System.Drawing.Point(669, 151);
            this.btnreset.Name = "btnreset";
            this.btnreset.Size = new System.Drawing.Size(75, 23);
            this.btnreset.TabIndex = 87;
            this.btnreset.Text = "Reset";
            this.btnreset.Click += new System.EventHandler(this.btnreset_Click_1);
            // 
            // btnxoa
            // 
            this.btnxoa.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton2.ImageOptions.Image")));
            this.btnxoa.Location = new System.Drawing.Point(358, 151);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(75, 23);
            this.btnxoa.TabIndex = 86;
            this.btnxoa.Text = "Xóa";
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click_1);
            // 
            // btnsua
            // 
            this.btnsua.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton3.ImageOptions.Image")));
            this.btnsua.Location = new System.Drawing.Point(193, 151);
            this.btnsua.Name = "btnsua";
            this.btnsua.Size = new System.Drawing.Size(75, 23);
            this.btnsua.TabIndex = 85;
            this.btnsua.Text = "Sửa";
            this.btnsua.Click += new System.EventHandler(this.btnsua_Click_1);
            // 
            // btnthem
            // 
            this.btnthem.AppearanceHovered.BackColor = System.Drawing.Color.White;
            this.btnthem.AppearanceHovered.Options.UseBackColor = true;
            this.btnthem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnthem.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton4.ImageOptions.Image")));
            this.btnthem.Location = new System.Drawing.Point(42, 152);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(72, 22);
            this.btnthem.TabIndex = 84;
            this.btnthem.Text = "Thêm";
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click_1);
            // 
            // f_phieunhap
            // 
            this.Appearance.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(832, 493);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupControl1);
            this.Name = "f_phieunhap";
            this.Text = "f_phieunhap";
            ((System.ComponentModel.ISupportInitialize)(this.dgvphieunhap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtmapn.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtngaynhap.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtngaynhap.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ComboBox cbbtennv;
        private System.Windows.Forms.ComboBox cbbtenncc;
        private System.Windows.Forms.DataGridView dgvphieunhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.DateEdit txtngaynhap;
        private DevExpress.XtraEditors.TextEdit txtmapn;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton btnchitiet;
        private DevExpress.XtraEditors.SimpleButton btnreset;
        private DevExpress.XtraEditors.SimpleButton btnxoa;
        private DevExpress.XtraEditors.SimpleButton btnsua;
        private DevExpress.XtraEditors.SimpleButton btnthem;
    }
}