
namespace QLCHBS
{
    partial class f_doanhthu
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
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.dgvdoanhthu = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.txtngaydau = new DevExpress.XtraEditors.DateEdit();
            this.txtngaycuoi = new DevExpress.XtraEditors.DateEdit();
            this.btnthongke = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdoanhthu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtngaydau.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtngaydau.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtngaycuoi.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtngaycuoi.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.dgvdoanhthu);
            this.groupControl1.Location = new System.Drawing.Point(12, 160);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(573, 267);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "groupControl1";
            // 
            // dgvdoanhthu
            // 
            this.dgvdoanhthu.AllowUserToAddRows = false;
            this.dgvdoanhthu.AllowUserToDeleteRows = false;
            this.dgvdoanhthu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvdoanhthu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvdoanhthu.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvdoanhthu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1});
            this.dgvdoanhthu.Location = new System.Drawing.Point(5, 26);
            this.dgvdoanhthu.Name = "dgvdoanhthu";
            this.dgvdoanhthu.ReadOnly = true;
            this.dgvdoanhthu.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvdoanhthu.Size = new System.Drawing.Size(563, 236);
            this.dgvdoanhthu.TabIndex = 76;
            this.dgvdoanhthu.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvdoanhthu_CellDoubleClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "STT";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.btnthongke);
            this.groupControl2.Controls.Add(this.txtngaycuoi);
            this.groupControl2.Controls.Add(this.txtngaydau);
            this.groupControl2.Location = new System.Drawing.Point(12, 11);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(567, 139);
            this.groupControl2.TabIndex = 1;
            this.groupControl2.Text = "groupControl2";
            // 
            // txtngaydau
            // 
            this.txtngaydau.EditValue = null;
            this.txtngaydau.Location = new System.Drawing.Point(64, 65);
            this.txtngaydau.Name = "txtngaydau";
            this.txtngaydau.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtngaydau.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtngaydau.Size = new System.Drawing.Size(100, 20);
            this.txtngaydau.TabIndex = 0;
            // 
            // txtngaycuoi
            // 
            this.txtngaycuoi.EditValue = null;
            this.txtngaycuoi.Location = new System.Drawing.Point(399, 70);
            this.txtngaycuoi.Name = "txtngaycuoi";
            this.txtngaycuoi.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtngaycuoi.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtngaycuoi.Size = new System.Drawing.Size(100, 20);
            this.txtngaycuoi.TabIndex = 1;
            // 
            // btnthongke
            // 
            this.btnthongke.Location = new System.Drawing.Point(236, 67);
            this.btnthongke.Name = "btnthongke";
            this.btnthongke.Size = new System.Drawing.Size(75, 23);
            this.btnthongke.TabIndex = 2;
            this.btnthongke.Text = "Thống kê";
            this.btnthongke.Click += new System.EventHandler(this.btnthongke_Click);
            // 
            // f_doanhthu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(597, 437);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupControl1);
            this.Name = "f_doanhthu";
            this.Text = "f_doanhthu";
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvdoanhthu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtngaydau.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtngaydau.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtngaycuoi.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtngaycuoi.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.DataGridView dgvdoanhthu;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.SimpleButton btnthongke;
        private DevExpress.XtraEditors.DateEdit txtngaycuoi;
        private DevExpress.XtraEditors.DateEdit txtngaydau;
    }
}