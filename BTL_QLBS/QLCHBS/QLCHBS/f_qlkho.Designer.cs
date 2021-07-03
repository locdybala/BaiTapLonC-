
namespace QLCHBS
{
    partial class f_qlkho
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
            this.soluongxuat = new DevExpress.XtraEditors.LabelControl();
            this.soluongnhap = new DevExpress.XtraEditors.LabelControl();
            this.soluongton = new DevExpress.XtraEditors.LabelControl();
            this.dgvkho = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.tenSach = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ss = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.sad = new DevExpress.XtraGrid.Columns.GridColumn();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            ((System.ComponentModel.ISupportInitialize)(this.dgvkho)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            this.SuspendLayout();
            // 
            // soluongxuat
            // 
            this.soluongxuat.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.soluongxuat.Appearance.Options.UseFont = true;
            this.soluongxuat.Location = new System.Drawing.Point(67, 62);
            this.soluongxuat.Name = "soluongxuat";
            this.soluongxuat.Size = new System.Drawing.Size(110, 19);
            this.soluongxuat.TabIndex = 0;
            this.soluongxuat.Text = "Số lượng xuất: ";
            // 
            // soluongnhap
            // 
            this.soluongnhap.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.soluongnhap.Appearance.Options.UseFont = true;
            this.soluongnhap.Location = new System.Drawing.Point(296, 66);
            this.soluongnhap.Name = "soluongnhap";
            this.soluongnhap.Size = new System.Drawing.Size(115, 19);
            this.soluongnhap.TabIndex = 1;
            this.soluongnhap.Text = "Số lượng nhập :";
            // 
            // soluongton
            // 
            this.soluongton.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.soluongton.Appearance.Options.UseFont = true;
            this.soluongton.Location = new System.Drawing.Point(513, 66);
            this.soluongton.Name = "soluongton";
            this.soluongton.Size = new System.Drawing.Size(71, 19);
            this.soluongton.TabIndex = 2;
            this.soluongton.Text = "Tồn Kho :";
            // 
            // dgvkho
            // 
            this.dgvkho.Location = new System.Drawing.Point(5, 26);
            this.dgvkho.MainView = this.gridView1;
            this.dgvkho.Name = "dgvkho";
            this.dgvkho.Size = new System.Drawing.Size(716, 242);
            this.dgvkho.TabIndex = 3;
            this.dgvkho.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.dgvkho.Click += new System.EventHandler(this.gridControl1_Click);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.tenSach,
            this.ss,
            this.gridColumn1,
            this.sad});
            this.gridView1.GridControl = this.dgvkho;
            this.gridView1.Name = "gridView1";
            // 
            // tenSach
            // 
            this.tenSach.Caption = "Tên sách";
            this.tenSach.FieldName = "tenSach";
            this.tenSach.Name = "tenSach";
            this.tenSach.Visible = true;
            this.tenSach.VisibleIndex = 0;
            // 
            // ss
            // 
            this.ss.Caption = "Số Lượng Nhập";
            this.ss.FieldName = "soLuongNhap";
            this.ss.Name = "ss";
            this.ss.Visible = true;
            this.ss.VisibleIndex = 1;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Số Lượng Bán";
            this.gridColumn1.FieldName = "soLuongBan";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 2;
            // 
            // sad
            // 
            this.sad.Caption = "Tồn Kho";
            this.sad.FieldName = "tonKho";
            this.sad.Name = "sad";
            this.sad.Visible = true;
            this.sad.VisibleIndex = 3;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.Black;
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseForeColor = true;
            this.labelControl1.Location = new System.Drawing.Point(325, 12);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(43, 23);
            this.labelControl1.TabIndex = 4;
            this.labelControl1.Text = "KHO";
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.soluongton);
            this.groupControl1.Controls.Add(this.soluongnhap);
            this.groupControl1.Controls.Add(this.soluongxuat);
            this.groupControl1.Location = new System.Drawing.Point(7, 46);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(730, 111);
            this.groupControl1.TabIndex = 5;
            this.groupControl1.Text = "Hiển thị số lượng";
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.dgvkho);
            this.groupControl2.Location = new System.Drawing.Point(7, 178);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(730, 277);
            this.groupControl2.TabIndex = 6;
            this.groupControl2.Text = "Thông tin chi tiết";
            // 
            // f_qlkho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(740, 458);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.labelControl1);
            this.Name = "f_qlkho";
            this.Text = "f_qlkho";
            this.Load += new System.EventHandler(this.f_qlkho_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvkho)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl soluongxuat;
        private DevExpress.XtraEditors.LabelControl soluongnhap;
        private DevExpress.XtraEditors.LabelControl soluongton;
        private DevExpress.XtraGrid.GridControl dgvkho;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn tenSach;
        private DevExpress.XtraGrid.Columns.GridColumn ss;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn sad;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.GroupControl groupControl2;
    }
}