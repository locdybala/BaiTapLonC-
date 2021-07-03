
namespace QLCHBS
{
    partial class f_hoadonchitiet
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(f_hoadonchitiet));
            this.title = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.nbsl = new System.Windows.Forms.NumericUpDown();
            this.nbsltk = new System.Windows.Forms.NumericUpDown();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.dgvhoadonct = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tongtien = new DevExpress.XtraEditors.LabelControl();
            this.cbbtensach = new System.Windows.Forms.ComboBox();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.btnin = new DevExpress.XtraEditors.SimpleButton();
            this.btnreset = new DevExpress.XtraEditors.SimpleButton();
            this.btnxoa = new DevExpress.XtraEditors.SimpleButton();
            this.btnsua = new DevExpress.XtraEditors.SimpleButton();
            this.btnthem = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.nbsl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nbsltk)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvhoadonct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            this.SuspendLayout();
            // 
            // title
            // 
            this.title.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.Appearance.Options.UseFont = true;
            this.title.Location = new System.Drawing.Point(304, 21);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(169, 23);
            this.title.TabIndex = 0;
            this.title.Text = "Chi Tiết Hóa Đơn ";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(95, 94);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(45, 13);
            this.labelControl2.TabIndex = 4;
            this.labelControl2.Text = "Số Lượng";
            // 
            // nbsl
            // 
            this.nbsl.Location = new System.Drawing.Point(173, 86);
            this.nbsl.Name = "nbsl";
            this.nbsl.Size = new System.Drawing.Size(47, 21);
            this.nbsl.TabIndex = 5;
            // 
            // nbsltk
            // 
            this.nbsltk.Location = new System.Drawing.Point(593, 48);
            this.nbsltk.Name = "nbsltk";
            this.nbsltk.ReadOnly = true;
            this.nbsltk.Size = new System.Drawing.Size(47, 21);
            this.nbsltk.TabIndex = 7;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(464, 54);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(113, 13);
            this.labelControl3.TabIndex = 6;
            this.labelControl3.Text = "Số Lượng Sách Tồn Kho";
            // 
            // dgvhoadonct
            // 
            this.dgvhoadonct.AllowUserToAddRows = false;
            this.dgvhoadonct.AllowUserToDeleteRows = false;
            this.dgvhoadonct.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvhoadonct.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvhoadonct.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvhoadonct.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1});
            this.dgvhoadonct.Location = new System.Drawing.Point(8, 26);
            this.dgvhoadonct.Name = "dgvhoadonct";
            this.dgvhoadonct.ReadOnly = true;
            this.dgvhoadonct.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvhoadonct.Size = new System.Drawing.Size(752, 202);
            this.dgvhoadonct.TabIndex = 28;
            this.dgvhoadonct.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvhoadonct_CellClick);
            this.dgvhoadonct.RowPrePaint += new System.Windows.Forms.DataGridViewRowPrePaintEventHandler(this.dgvhoadonct_RowPrePaint);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "STT";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // tongtien
            // 
            this.tongtien.Location = new System.Drawing.Point(464, 94);
            this.tongtien.Name = "tongtien";
            this.tongtien.Size = new System.Drawing.Size(47, 13);
            this.tongtien.TabIndex = 29;
            this.tongtien.Text = "Tổng Tiền";
            // 
            // cbbtensach
            // 
            this.cbbtensach.FormattingEnabled = true;
            this.cbbtensach.Location = new System.Drawing.Point(173, 46);
            this.cbbtensach.Name = "cbbtensach";
            this.cbbtensach.Size = new System.Drawing.Size(199, 21);
            this.cbbtensach.TabIndex = 30;
            this.cbbtensach.SelectedIndexChanged += new System.EventHandler(this.cbbtensach_SelectedIndexChanged_1);
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(97, 50);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(43, 13);
            this.labelControl4.TabIndex = 31;
            this.labelControl4.Text = "Tên sách";
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.btnin);
            this.groupControl1.Controls.Add(this.btnreset);
            this.groupControl1.Controls.Add(this.btnxoa);
            this.groupControl1.Controls.Add(this.btnsua);
            this.groupControl1.Controls.Add(this.btnthem);
            this.groupControl1.Controls.Add(this.labelControl4);
            this.groupControl1.Controls.Add(this.cbbtensach);
            this.groupControl1.Controls.Add(this.tongtien);
            this.groupControl1.Controls.Add(this.nbsltk);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.nbsl);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Location = new System.Drawing.Point(13, 60);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(765, 187);
            this.groupControl1.TabIndex = 32;
            this.groupControl1.Text = "Nhập thông tin";
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.dgvhoadonct);
            this.groupControl2.Location = new System.Drawing.Point(12, 266);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(765, 237);
            this.groupControl2.TabIndex = 33;
            this.groupControl2.Text = "Thông tin hóa đơn";
            // 
            // btnin
            // 
            this.btnin.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnin.ImageOptions.Image")));
            this.btnin.Location = new System.Drawing.Point(497, 135);
            this.btnin.Name = "btnin";
            this.btnin.Size = new System.Drawing.Size(75, 23);
            this.btnin.TabIndex = 88;
            this.btnin.Text = "In";
            this.btnin.Click += new System.EventHandler(this.btnin_Click_1);
            // 
            // btnreset
            // 
            this.btnreset.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnreset.ImageOptions.Image")));
            this.btnreset.Location = new System.Drawing.Point(649, 135);
            this.btnreset.Name = "btnreset";
            this.btnreset.Size = new System.Drawing.Size(75, 23);
            this.btnreset.TabIndex = 87;
            this.btnreset.Text = "Reset";
            this.btnreset.Click += new System.EventHandler(this.btnreset_Click_1);
            // 
            // btnxoa
            // 
            this.btnxoa.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnxoa.ImageOptions.Image")));
            this.btnxoa.Location = new System.Drawing.Point(338, 135);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(75, 23);
            this.btnxoa.TabIndex = 86;
            this.btnxoa.Text = "Xóa";
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click_1);
            // 
            // btnsua
            // 
            this.btnsua.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnsua.ImageOptions.Image")));
            this.btnsua.Location = new System.Drawing.Point(173, 135);
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
            this.btnthem.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnthem.ImageOptions.Image")));
            this.btnthem.Location = new System.Drawing.Point(22, 136);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(72, 22);
            this.btnthem.TabIndex = 84;
            this.btnthem.Text = "Thêm";
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click_1);
            // 
            // f_hoadonchitiet
            // 
            this.Appearance.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(791, 515);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.title);
            this.Name = "f_hoadonchitiet";
            this.Text = "f_hoadonchitiet";
            ((System.ComponentModel.ISupportInitialize)(this.nbsl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nbsltk)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvhoadonct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl title;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private System.Windows.Forms.NumericUpDown nbsl;
        private System.Windows.Forms.NumericUpDown nbsltk;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private System.Windows.Forms.DataGridView dgvhoadonct;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private DevExpress.XtraEditors.LabelControl tongtien;
        private System.Windows.Forms.ComboBox cbbtensach;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.SimpleButton btnin;
        private DevExpress.XtraEditors.SimpleButton btnreset;
        private DevExpress.XtraEditors.SimpleButton btnxoa;
        private DevExpress.XtraEditors.SimpleButton btnsua;
        private DevExpress.XtraEditors.SimpleButton btnthem;
    }
}