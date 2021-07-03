
namespace QLCHBS
{
    partial class f_sach
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(f_sach));
            this.dgvsach = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.cbbtacgia = new System.Windows.Forms.ComboBox();
            this.cbbloaisach = new System.Windows.Forms.ComboBox();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.txtmasach = new DevExpress.XtraEditors.TextEdit();
            this.txtTenSach = new DevExpress.XtraEditors.TextEdit();
            this.txtgiaban = new DevExpress.XtraEditors.TextEdit();
            this.txtNamXB = new DevExpress.XtraEditors.DateEdit();
            this.btnreset = new DevExpress.XtraEditors.SimpleButton();
            this.btnxoa = new DevExpress.XtraEditors.SimpleButton();
            this.btnsua = new DevExpress.XtraEditors.SimpleButton();
            this.btnthem = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvsach)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtmasach.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenSach.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtgiaban.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNamXB.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNamXB.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvsach
            // 
            this.dgvsach.AllowUserToAddRows = false;
            this.dgvsach.AllowUserToDeleteRows = false;
            this.dgvsach.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvsach.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvsach.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvsach.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column7,
            this.Column8});
            this.dgvsach.Location = new System.Drawing.Point(5, 30);
            this.dgvsach.Name = "dgvsach";
            this.dgvsach.ReadOnly = true;
            this.dgvsach.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvsach.Size = new System.Drawing.Size(873, 230);
            this.dgvsach.TabIndex = 2;
            this.dgvsach.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvsach_CellClick);
            this.dgvsach.RowPrePaint += new System.Windows.Forms.DataGridViewRowPrePaintEventHandler(this.dgvsach_RowPrePaint);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "STT";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "maSach";
            this.Column2.HeaderText = "Mã Sách";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "tenLoaiSach";
            this.Column3.HeaderText = "Thể loại";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "tenSach";
            this.Column4.HeaderText = "Tên sách";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "tenTacGia";
            this.Column5.HeaderText = "Tác giả";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "giaBia";
            this.Column7.HeaderText = "Gía Bìa";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // Column8
            // 
            this.Column8.DataPropertyName = "namXuatBan";
            this.Column8.HeaderText = "Năm Xuất Bản";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.dgvsach);
            this.groupControl1.Location = new System.Drawing.Point(7, 268);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(883, 265);
            this.groupControl1.TabIndex = 51;
            this.groupControl1.Text = "Danh sách sách";
            // 
            // cbbtacgia
            // 
            this.cbbtacgia.FormattingEnabled = true;
            this.cbbtacgia.Location = new System.Drawing.Point(535, 43);
            this.cbbtacgia.Name = "cbbtacgia";
            this.cbbtacgia.Size = new System.Drawing.Size(200, 21);
            this.cbbtacgia.TabIndex = 42;
            this.cbbtacgia.SelectedIndexChanged += new System.EventHandler(this.cbbtacgia_SelectedIndexChanged);
            // 
            // cbbloaisach
            // 
            this.cbbloaisach.FormattingEnabled = true;
            this.cbbloaisach.Location = new System.Drawing.Point(166, 112);
            this.cbbloaisach.Name = "cbbloaisach";
            this.cbbloaisach.Size = new System.Drawing.Size(200, 21);
            this.cbbloaisach.TabIndex = 40;
            this.cbbloaisach.SelectedIndexChanged += new System.EventHandler(this.cbbloaisach_SelectedIndexChanged);
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(97, 51);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(39, 13);
            this.labelControl1.TabIndex = 49;
            this.labelControl1.Text = "Mã sách";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(93, 80);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(43, 13);
            this.labelControl2.TabIndex = 50;
            this.labelControl2.Text = "Tên sách";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(97, 120);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(37, 13);
            this.labelControl3.TabIndex = 51;
            this.labelControl3.Text = "Thể loại";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(478, 46);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(35, 13);
            this.labelControl4.TabIndex = 52;
            this.labelControl4.Text = "Tác Giả";
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(481, 81);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(32, 13);
            this.labelControl5.TabIndex = 53;
            this.labelControl5.Text = "Giá Bìa";
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(446, 120);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(67, 13);
            this.labelControl6.TabIndex = 54;
            this.labelControl6.Text = "Năm Xuất Bản";
            // 
            // groupControl2
            // 
            this.groupControl2.Appearance.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupControl2.Appearance.Options.UseBackColor = true;
            this.groupControl2.Controls.Add(this.btnreset);
            this.groupControl2.Controls.Add(this.btnxoa);
            this.groupControl2.Controls.Add(this.btnsua);
            this.groupControl2.Controls.Add(this.btnthem);
            this.groupControl2.Controls.Add(this.txtNamXB);
            this.groupControl2.Controls.Add(this.txtgiaban);
            this.groupControl2.Controls.Add(this.txtTenSach);
            this.groupControl2.Controls.Add(this.txtmasach);
            this.groupControl2.Controls.Add(this.labelControl6);
            this.groupControl2.Controls.Add(this.labelControl5);
            this.groupControl2.Controls.Add(this.labelControl4);
            this.groupControl2.Controls.Add(this.labelControl3);
            this.groupControl2.Controls.Add(this.labelControl2);
            this.groupControl2.Controls.Add(this.labelControl1);
            this.groupControl2.Controls.Add(this.cbbloaisach);
            this.groupControl2.Controls.Add(this.cbbtacgia);
            this.groupControl2.Location = new System.Drawing.Point(7, 38);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(882, 210);
            this.groupControl2.TabIndex = 52;
            this.groupControl2.Text = "Nhập thông tin";
            // 
            // txtmasach
            // 
            this.txtmasach.Location = new System.Drawing.Point(166, 48);
            this.txtmasach.Name = "txtmasach";
            this.txtmasach.Properties.ReadOnly = true;
            this.txtmasach.Size = new System.Drawing.Size(200, 20);
            this.txtmasach.TabIndex = 55;
            // 
            // txtTenSach
            // 
            this.txtTenSach.Location = new System.Drawing.Point(166, 78);
            this.txtTenSach.Name = "txtTenSach";
            this.txtTenSach.Size = new System.Drawing.Size(200, 20);
            this.txtTenSach.TabIndex = 56;
            // 
            // txtgiaban
            // 
            this.txtgiaban.Location = new System.Drawing.Point(535, 78);
            this.txtgiaban.Name = "txtgiaban";
            this.txtgiaban.Size = new System.Drawing.Size(200, 20);
            this.txtgiaban.TabIndex = 57;
            // 
            // txtNamXB
            // 
            this.txtNamXB.EditValue = null;
            this.txtNamXB.Location = new System.Drawing.Point(535, 117);
            this.txtNamXB.Name = "txtNamXB";
            this.txtNamXB.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtNamXB.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtNamXB.Size = new System.Drawing.Size(200, 20);
            this.txtNamXB.TabIndex = 58;
            // 
            // btnreset
            // 
            this.btnreset.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnreset.ImageOptions.Image")));
            this.btnreset.Location = new System.Drawing.Point(633, 163);
            this.btnreset.Name = "btnreset";
            this.btnreset.Size = new System.Drawing.Size(75, 23);
            this.btnreset.TabIndex = 78;
            this.btnreset.Text = "Reset";
            this.btnreset.Click += new System.EventHandler(this.btnreset_Click_1);
            // 
            // btnxoa
            // 
            this.btnxoa.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnxoa.ImageOptions.Image")));
            this.btnxoa.Location = new System.Drawing.Point(464, 163);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(75, 23);
            this.btnxoa.TabIndex = 77;
            this.btnxoa.Text = "Xóa";
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click_1);
            // 
            // btnsua
            // 
            this.btnsua.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnsua.ImageOptions.Image")));
            this.btnsua.Location = new System.Drawing.Point(299, 163);
            this.btnsua.Name = "btnsua";
            this.btnsua.Size = new System.Drawing.Size(75, 23);
            this.btnsua.TabIndex = 76;
            this.btnsua.Text = "Sửa";
            this.btnsua.Click += new System.EventHandler(this.btnsua_Click_1);
            // 
            // btnthem
            // 
            this.btnthem.AppearanceHovered.BackColor = System.Drawing.Color.White;
            this.btnthem.AppearanceHovered.Options.UseBackColor = true;
            this.btnthem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnthem.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnthem.ImageOptions.Image")));
            this.btnthem.Location = new System.Drawing.Point(130, 163);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(72, 22);
            this.btnthem.TabIndex = 75;
            this.btnthem.Text = "Thêm";
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click_1);
            // 
            // f_sach
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(901, 545);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupControl1);
            this.Name = "f_sach";
            this.Text = "Danh sách Sách";
            ((System.ComponentModel.ISupportInitialize)(this.dgvsach)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.groupControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtmasach.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenSach.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtgiaban.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNamXB.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNamXB.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvsach;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.ComboBox cbbtacgia;
        private System.Windows.Forms.ComboBox cbbloaisach;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.DateEdit txtNamXB;
        private DevExpress.XtraEditors.TextEdit txtgiaban;
        private DevExpress.XtraEditors.TextEdit txtTenSach;
        private DevExpress.XtraEditors.TextEdit txtmasach;
        private DevExpress.XtraEditors.SimpleButton btnreset;
        private DevExpress.XtraEditors.SimpleButton btnxoa;
        private DevExpress.XtraEditors.SimpleButton btnsua;
        private DevExpress.XtraEditors.SimpleButton btnthem;
    }
}