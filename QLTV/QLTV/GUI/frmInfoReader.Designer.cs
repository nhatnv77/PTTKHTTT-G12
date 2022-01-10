
namespace QLTV.GUI
{
    partial class frmInfoReader
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInfoReader));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.readerCode = new DevExpress.XtraEditors.TextEdit();
            this.mssv = new DevExpress.XtraEditors.TextEdit();
            this.name = new DevExpress.XtraEditors.TextEdit();
            this.txPhone = new DevExpress.XtraEditors.TextEdit();
            this.txEmail = new DevExpress.XtraEditors.TextEdit();
            this.pw = new DevExpress.XtraEditors.TextEdit();
            this.btnUpdate = new DevExpress.XtraEditors.SimpleButton();
            this.label8 = new System.Windows.Forms.Label();
            this.ckShowPassword = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.readerCode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mssv.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.name.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txPhone.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txEmail.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pw.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(166, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã độc giả";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label2.Location = new System.Drawing.Point(166, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "MSSV";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label3.Location = new System.Drawing.Point(166, 205);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "Họ và tên";
            this.label3.Click += new System.EventHandler(this.label2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label4.Location = new System.Drawing.Point(166, 270);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 17);
            this.label4.TabIndex = 1;
            this.label4.Text = "SĐT";
            this.label4.Click += new System.EventHandler(this.label2_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label5.Location = new System.Drawing.Point(166, 344);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 17);
            this.label5.TabIndex = 1;
            this.label5.Text = "Email";
            this.label5.Click += new System.EventHandler(this.label2_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label6.Location = new System.Drawing.Point(166, 409);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 17);
            this.label6.TabIndex = 1;
            this.label6.Text = "Password";
            this.label6.Click += new System.EventHandler(this.label2_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(166, 472);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 17);
            this.label7.TabIndex = 1;
            this.label7.Click += new System.EventHandler(this.label2_Click);
            // 
            // readerCode
            // 
            this.readerCode.Enabled = false;
            this.readerCode.Location = new System.Drawing.Point(305, 68);
            this.readerCode.Name = "readerCode";
            this.readerCode.Size = new System.Drawing.Size(187, 22);
            this.readerCode.TabIndex = 2;
            // 
            // mssv
            // 
            this.mssv.Enabled = false;
            this.mssv.Location = new System.Drawing.Point(305, 137);
            this.mssv.Name = "mssv";
            this.mssv.Size = new System.Drawing.Size(187, 22);
            this.mssv.TabIndex = 2;
            // 
            // name
            // 
            this.name.Enabled = false;
            this.name.Location = new System.Drawing.Point(305, 200);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(187, 22);
            this.name.TabIndex = 2;
            // 
            // txPhone
            // 
            this.txPhone.Location = new System.Drawing.Point(305, 267);
            this.txPhone.Name = "txPhone";
            this.txPhone.Size = new System.Drawing.Size(187, 22);
            this.txPhone.TabIndex = 2;
            // 
            // txEmail
            // 
            this.txEmail.Location = new System.Drawing.Point(305, 339);
            this.txEmail.Name = "txEmail";
            this.txEmail.Size = new System.Drawing.Size(187, 22);
            this.txEmail.TabIndex = 2;
            // 
            // pw
            // 
            this.pw.Location = new System.Drawing.Point(305, 404);
            this.pw.Name = "pw";
            this.pw.Properties.UseSystemPasswordChar = true;
            this.pw.Size = new System.Drawing.Size(187, 22);
            this.pw.TabIndex = 2;
            // 
            // btnUpdate
            // 
            this.btnUpdate.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("simpleButton1.ImageOptions.SvgImage")));
            this.btnUpdate.Location = new System.Drawing.Point(318, 472);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(174, 50);
            this.btnUpdate.TabIndex = 3;
            this.btnUpdate.Text = "Cập nhật thông tin";
            this.btnUpdate.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label8.Location = new System.Drawing.Point(260, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(245, 29);
            this.label8.TabIndex = 0;
            this.label8.Text = "Thông tin tài khoản";
            // 
            // ckShowPassword
            // 
            this.ckShowPassword.AutoSize = true;
            this.ckShowPassword.Location = new System.Drawing.Point(600, 409);
            this.ckShowPassword.Name = "ckShowPassword";
            this.ckShowPassword.Size = new System.Drawing.Size(118, 21);
            this.ckShowPassword.TabIndex = 4;
            this.ckShowPassword.Text = "Hiện mật khẩu";
            this.ckShowPassword.UseVisualStyleBackColor = true;
            this.ckShowPassword.CheckedChanged += new System.EventHandler(this.ckShowPassword_CheckedChanged);
            // 
            // frmInfoReader
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(846, 591);
            this.Controls.Add(this.ckShowPassword);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.pw);
            this.Controls.Add(this.txEmail);
            this.Controls.Add(this.txPhone);
            this.Controls.Add(this.name);
            this.Controls.Add(this.mssv);
            this.Controls.Add(this.readerCode);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label1);
            this.Name = "frmInfoReader";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thông tin cá nhân";
            ((System.ComponentModel.ISupportInitialize)(this.readerCode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mssv.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.name.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txPhone.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txEmail.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pw.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private DevExpress.XtraEditors.TextEdit readerCode;
        private DevExpress.XtraEditors.TextEdit mssv;
        private DevExpress.XtraEditors.TextEdit name;
        private DevExpress.XtraEditors.TextEdit txPhone;
        private DevExpress.XtraEditors.TextEdit txEmail;
        private DevExpress.XtraEditors.TextEdit pw;
        private DevExpress.XtraEditors.SimpleButton btnUpdate;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckBox ckShowPassword;
    }
}