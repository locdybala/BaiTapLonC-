
namespace QLCHBS
{
    partial class f_doimk
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
            this.btndong = new DevExpress.XtraEditors.SimpleButton();
            this.btnupdate = new DevExpress.XtraEditors.SimpleButton();
            this.txtrepass1 = new DevExpress.XtraEditors.TextEdit();
            this.txtpass1 = new DevExpress.XtraEditors.TextEdit();
            this.txtuser1 = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtrepass1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtpass1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtuser1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.btndong);
            this.groupControl1.Controls.Add(this.btnupdate);
            this.groupControl1.Controls.Add(this.txtrepass1);
            this.groupControl1.Controls.Add(this.txtpass1);
            this.groupControl1.Controls.Add(this.txtuser1);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Location = new System.Drawing.Point(12, 12);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(398, 281);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "groupControl1";
            // 
            // btndong
            // 
            this.btndong.Location = new System.Drawing.Point(255, 209);
            this.btndong.Name = "btndong";
            this.btndong.Size = new System.Drawing.Size(75, 23);
            this.btndong.TabIndex = 7;
            this.btndong.Text = "Đóng ";
            // 
            // btnupdate
            // 
            this.btnupdate.Location = new System.Drawing.Point(152, 209);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(75, 23);
            this.btnupdate.TabIndex = 6;
            this.btnupdate.Text = "Cập nhập";
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // txtrepass1
            // 
            this.txtrepass1.Location = new System.Drawing.Point(152, 155);
            this.txtrepass1.Name = "txtrepass1";
            this.txtrepass1.Size = new System.Drawing.Size(178, 20);
            this.txtrepass1.TabIndex = 5;
            // 
            // txtpass1
            // 
            this.txtpass1.Location = new System.Drawing.Point(152, 98);
            this.txtpass1.Name = "txtpass1";
            this.txtpass1.Size = new System.Drawing.Size(178, 20);
            this.txtpass1.TabIndex = 4;
            // 
            // txtuser1
            // 
            this.txtuser1.Location = new System.Drawing.Point(152, 52);
            this.txtuser1.Name = "txtuser1";
            this.txtuser1.Properties.ReadOnly = true;
            this.txtuser1.Size = new System.Drawing.Size(178, 20);
            this.txtuser1.TabIndex = 3;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(32, 158);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(85, 13);
            this.labelControl3.TabIndex = 2;
            this.labelControl3.Text = "Nhập lại mật khẩu";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(32, 105);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(44, 13);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "Mật khẩu";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(32, 55);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(65, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Tên tài khoản";
            // 
            // f_doimk
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(422, 312);
            this.Controls.Add(this.groupControl1);
            this.Name = "f_doimk";
            this.Text = "f_doimk";
            this.Load += new System.EventHandler(this.f_doimk_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtrepass1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtpass1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtuser1.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SimpleButton btndong;
        private DevExpress.XtraEditors.SimpleButton btnupdate;
        private DevExpress.XtraEditors.TextEdit txtrepass1;
        private DevExpress.XtraEditors.TextEdit txtpass1;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        public DevExpress.XtraEditors.TextEdit txtuser1;
    }
}