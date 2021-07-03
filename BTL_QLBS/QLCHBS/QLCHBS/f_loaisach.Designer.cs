
namespace QLCHBS
{
    partial class f_loaisach
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(f_loaisach));
            this.dgvloaissach = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.btnreset = new DevExpress.XtraEditors.SimpleButton();
            this.btnxoa = new DevExpress.XtraEditors.SimpleButton();
            this.btnsua = new DevExpress.XtraEditors.SimpleButton();
            this.btnthem = new DevExpress.XtraEditors.SimpleButton();
            this.txtmaloaisach = new DevExpress.XtraEditors.TextEdit();
            this.txttenloaisach = new DevExpress.XtraEditors.TextEdit();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.dgvloaissach)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtmaloaisach.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txttenloaisach.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvloaissach
            // 
            this.dgvloaissach.AllowUserToAddRows = false;
            this.dgvloaissach.AllowUserToDeleteRows = false;
            this.dgvloaissach.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvloaissach.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvloaissach.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvloaissach.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.dgvloaissach.Location = new System.Drawing.Point(17, 37);
            this.dgvloaissach.Name = "dgvloaissach";
            this.dgvloaissach.ReadOnly = true;
            this.dgvloaissach.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvloaissach.Size = new System.Drawing.Size(492, 262);
            this.dgvloaissach.TabIndex = 2;
            this.dgvloaissach.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvloaissach_CellClick);
            this.dgvloaissach.RowPrePaint += new System.Windows.Forms.DataGridViewRowPrePaintEventHandler(this.dgvloaissach_RowPrePaint);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "STT";
            this.Column1.MinimumWidth = 3;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "maLoaiSach";
            this.Column2.HeaderText = "Mã Loại Sách";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "tenLoaiSach";
            this.Column3.HeaderText = "Tên Loại Sách";
            this.Column3.MinimumWidth = 7;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(26, 136);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(66, 13);
            this.labelControl2.TabIndex = 88;
            this.labelControl2.Text = "Tên Loại Sách";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(26, 85);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(62, 13);
            this.labelControl1.TabIndex = 87;
            this.labelControl1.Text = "Mã Loại Sách";
            // 
            // btnreset
            // 
            this.btnreset.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnreset.ImageOptions.Image")));
            this.btnreset.Location = new System.Drawing.Point(178, 231);
            this.btnreset.Name = "btnreset";
            this.btnreset.Size = new System.Drawing.Size(75, 23);
            this.btnreset.TabIndex = 86;
            this.btnreset.Text = "Reset";
            // 
            // btnxoa
            // 
            this.btnxoa.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnxoa.ImageOptions.Image")));
            this.btnxoa.Location = new System.Drawing.Point(76, 231);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(75, 23);
            this.btnxoa.TabIndex = 85;
            this.btnxoa.Text = "Xóa";
            // 
            // btnsua
            // 
            this.btnsua.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnsua.ImageOptions.Image")));
            this.btnsua.Location = new System.Drawing.Point(178, 189);
            this.btnsua.Name = "btnsua";
            this.btnsua.Size = new System.Drawing.Size(75, 23);
            this.btnsua.TabIndex = 84;
            this.btnsua.Text = "Sửa";
            // 
            // btnthem
            // 
            this.btnthem.AppearanceHovered.BackColor = System.Drawing.Color.White;
            this.btnthem.AppearanceHovered.Options.UseBackColor = true;
            this.btnthem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnthem.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnthem.ImageOptions.Image")));
            this.btnthem.Location = new System.Drawing.Point(76, 190);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(72, 22);
            this.btnthem.TabIndex = 83;
            this.btnthem.Text = "Thêm";
            // 
            // txtmaloaisach
            // 
            this.txtmaloaisach.Location = new System.Drawing.Point(114, 82);
            this.txtmaloaisach.Name = "txtmaloaisach";
            this.txtmaloaisach.Properties.ReadOnly = true;
            this.txtmaloaisach.Size = new System.Drawing.Size(177, 20);
            this.txtmaloaisach.TabIndex = 89;
            // 
            // txttenloaisach
            // 
            this.txttenloaisach.Location = new System.Drawing.Point(114, 133);
            this.txttenloaisach.Name = "txttenloaisach";
            this.txttenloaisach.Size = new System.Drawing.Size(177, 20);
            this.txttenloaisach.TabIndex = 90;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.dgvloaissach);
            this.groupControl1.Location = new System.Drawing.Point(368, 73);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(528, 316);
            this.groupControl1.TabIndex = 91;
            this.groupControl1.Text = "Danh sách loại sách";
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.txttenloaisach);
            this.groupControl2.Controls.Add(this.txtmaloaisach);
            this.groupControl2.Controls.Add(this.labelControl2);
            this.groupControl2.Controls.Add(this.labelControl1);
            this.groupControl2.Controls.Add(this.btnreset);
            this.groupControl2.Controls.Add(this.btnxoa);
            this.groupControl2.Controls.Add(this.btnsua);
            this.groupControl2.Controls.Add(this.btnthem);
            this.groupControl2.Location = new System.Drawing.Point(19, 73);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(333, 315);
            this.groupControl2.TabIndex = 92;
            this.groupControl2.Text = "Thông tin loại sách";
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl7.Appearance.Options.UseFont = true;
            this.labelControl7.Location = new System.Drawing.Point(331, 24);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(220, 23);
            this.labelControl7.TabIndex = 93;
            this.labelControl7.Text = "DANH MỤC LOẠI SÁCH";
            // 
            // f_loaisach
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(908, 401);
            this.Controls.Add(this.labelControl7);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupControl1);
            this.Name = "f_loaisach";
            this.Text = "f_loaisach";
            ((System.ComponentModel.ISupportInitialize)(this.dgvloaissach)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtmaloaisach.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txttenloaisach.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.groupControl2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvloaissach;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton btnreset;
        private DevExpress.XtraEditors.SimpleButton btnxoa;
        private DevExpress.XtraEditors.SimpleButton btnsua;
        private DevExpress.XtraEditors.SimpleButton btnthem;
        private DevExpress.XtraEditors.TextEdit txtmaloaisach;
        private DevExpress.XtraEditors.TextEdit txttenloaisach;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.LabelControl labelControl7;
    }
}