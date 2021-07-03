
namespace QLCHBS
{
    partial class f_phieunhapchitiet
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(f_phieunhapchitiet));
            this.cbbtensach = new System.Windows.Forms.ComboBox();
            this.nbslsach = new System.Windows.Forms.NumericUpDown();
            this.tongtien = new System.Windows.Forms.Label();
            this.dgvphieunhapct = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.btnin = new DevExpress.XtraEditors.SimpleButton();
            this.btnreset = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.btnxoa = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.btnsua = new DevExpress.XtraEditors.SimpleButton();
            this.btnthem = new DevExpress.XtraEditors.SimpleButton();
            this.title = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.nbslsach)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvphieunhapct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbbtensach
            // 
            this.cbbtensach.FormattingEnabled = true;
            this.cbbtensach.Location = new System.Drawing.Point(200, 36);
            this.cbbtensach.Name = "cbbtensach";
            this.cbbtensach.Size = new System.Drawing.Size(196, 21);
            this.cbbtensach.TabIndex = 1;
            this.cbbtensach.SelectedIndexChanged += new System.EventHandler(this.cbbtensach_SelectedIndexChanged_1);
            // 
            // nbslsach
            // 
            this.nbslsach.Location = new System.Drawing.Point(201, 77);
            this.nbslsach.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nbslsach.Name = "nbslsach";
            this.nbslsach.Size = new System.Drawing.Size(79, 21);
            this.nbslsach.TabIndex = 2;
            this.nbslsach.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // tongtien
            // 
            this.tongtien.AutoSize = true;
            this.tongtien.Location = new System.Drawing.Point(474, 64);
            this.tongtien.Name = "tongtien";
            this.tongtien.Size = new System.Drawing.Size(0, 13);
            this.tongtien.TabIndex = 4;
            // 
            // dgvphieunhapct
            // 
            this.dgvphieunhapct.AllowUserToAddRows = false;
            this.dgvphieunhapct.AllowUserToDeleteRows = false;
            this.dgvphieunhapct.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvphieunhapct.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvphieunhapct.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvphieunhapct.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1});
            this.dgvphieunhapct.Location = new System.Drawing.Point(5, 35);
            this.dgvphieunhapct.Name = "dgvphieunhapct";
            this.dgvphieunhapct.ReadOnly = true;
            this.dgvphieunhapct.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvphieunhapct.Size = new System.Drawing.Size(781, 213);
            this.dgvphieunhapct.TabIndex = 23;
            this.dgvphieunhapct.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvphieunhapct_CellClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "STT";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.dgvphieunhapct);
            this.groupControl1.Location = new System.Drawing.Point(10, 256);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(791, 259);
            this.groupControl1.TabIndex = 25;
            this.groupControl1.Text = "Thông tin phiếu nhập";
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.btnin);
            this.groupControl2.Controls.Add(this.btnreset);
            this.groupControl2.Controls.Add(this.labelControl3);
            this.groupControl2.Controls.Add(this.btnxoa);
            this.groupControl2.Controls.Add(this.labelControl2);
            this.groupControl2.Controls.Add(this.btnsua);
            this.groupControl2.Controls.Add(this.btnthem);
            this.groupControl2.Controls.Add(this.tongtien);
            this.groupControl2.Controls.Add(this.nbslsach);
            this.groupControl2.Controls.Add(this.cbbtensach);
            this.groupControl2.Location = new System.Drawing.Point(10, 56);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(791, 167);
            this.groupControl2.TabIndex = 26;
            this.groupControl2.Text = "Nhập Thông Tin";
            // 
            // btnin
            // 
            this.btnin.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnin.ImageOptions.Image")));
            this.btnin.Location = new System.Drawing.Point(504, 123);
            this.btnin.Name = "btnin";
            this.btnin.Size = new System.Drawing.Size(75, 23);
            this.btnin.TabIndex = 83;
            this.btnin.Text = "In";
            this.btnin.Click += new System.EventHandler(this.btnin_Click_1);
            // 
            // btnreset
            // 
            this.btnreset.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.btnreset.Location = new System.Drawing.Point(656, 123);
            this.btnreset.Name = "btnreset";
            this.btnreset.Size = new System.Drawing.Size(75, 23);
            this.btnreset.TabIndex = 82;
            this.btnreset.Text = "Reset";
            this.btnreset.Click += new System.EventHandler(this.btnreset_Click_1);
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(132, 79);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(54, 16);
            this.labelControl3.TabIndex = 24;
            this.labelControl3.Text = "Số Lượng";
            // 
            // btnxoa
            // 
            this.btnxoa.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton2.ImageOptions.Image")));
            this.btnxoa.Location = new System.Drawing.Point(345, 123);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(75, 23);
            this.btnxoa.TabIndex = 81;
            this.btnxoa.Text = "Xóa";
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click_1);
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(132, 39);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(52, 16);
            this.labelControl2.TabIndex = 23;
            this.labelControl2.Text = "Tên sách";
            // 
            // btnsua
            // 
            this.btnsua.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton3.ImageOptions.Image")));
            this.btnsua.Location = new System.Drawing.Point(180, 123);
            this.btnsua.Name = "btnsua";
            this.btnsua.Size = new System.Drawing.Size(75, 23);
            this.btnsua.TabIndex = 80;
            this.btnsua.Text = "Sửa";
            this.btnsua.Click += new System.EventHandler(this.btnsua_Click_1);
            // 
            // btnthem
            // 
            this.btnthem.AppearanceHovered.BackColor = System.Drawing.Color.White;
            this.btnthem.AppearanceHovered.Options.UseBackColor = true;
            this.btnthem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnthem.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton4.ImageOptions.Image")));
            this.btnthem.Location = new System.Drawing.Point(29, 124);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(72, 22);
            this.btnthem.TabIndex = 79;
            this.btnthem.Text = "Thêm";
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click_1);
            // 
            // title
            // 
            this.title.Appearance.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.Appearance.Options.UseFont = true;
            this.title.Location = new System.Drawing.Point(297, 12);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(196, 25);
            this.title.TabIndex = 27;
            this.title.Text = "Chi tiết phiếu nhập";
            // 
            // f_phieunhapchitiet
            // 
            this.Appearance.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(813, 527);
            this.Controls.Add(this.title);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupControl1);
            this.Name = "f_phieunhapchitiet";
            this.Text = "f_phieunhapchitiet";
            ((System.ComponentModel.ISupportInitialize)(this.nbslsach)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvphieunhapct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.groupControl2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cbbtensach;
        private System.Windows.Forms.NumericUpDown nbslsach;
        private System.Windows.Forms.Label tongtien;
        private System.Windows.Forms.DataGridView dgvphieunhapct;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl title;
        private DevExpress.XtraEditors.SimpleButton btnin;
        private DevExpress.XtraEditors.SimpleButton btnreset;
        private DevExpress.XtraEditors.SimpleButton btnxoa;
        private DevExpress.XtraEditors.SimpleButton btnsua;
        private DevExpress.XtraEditors.SimpleButton btnthem;
    }
}