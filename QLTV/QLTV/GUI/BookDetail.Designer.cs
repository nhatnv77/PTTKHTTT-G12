
namespace QLTV.GUI
{
    partial class BookDetail
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BookDetail));
            this.bookContent = new System.Windows.Forms.RichTextBox();
            this.lbBookName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbAuthorname = new System.Windows.Forms.Label();
            this.lbPublishDate = new System.Windows.Forms.Label();
            this.lbCompany = new System.Windows.Forms.Label();
            this.lbTotalPage = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.btnOrder = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // bookContent
            // 
            this.bookContent.Enabled = false;
            this.bookContent.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookContent.Location = new System.Drawing.Point(36, 119);
            this.bookContent.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.bookContent.Name = "bookContent";
            this.bookContent.Size = new System.Drawing.Size(552, 488);
            this.bookContent.TabIndex = 0;
            this.bookContent.Text = "";
            // 
            // lbBookName
            // 
            this.lbBookName.AutoSize = true;
            this.lbBookName.Font = new System.Drawing.Font("Tahoma", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBookName.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lbBookName.Location = new System.Drawing.Point(186, 47);
            this.lbBookName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbBookName.Name = "lbBookName";
            this.lbBookName.Size = new System.Drawing.Size(178, 36);
            this.lbBookName.TabIndex = 1;
            this.lbBookName.Text = "bookName";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(624, 131);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tác giả";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label2.Location = new System.Drawing.Point(624, 207);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ngày xuất bản";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label3.Location = new System.Drawing.Point(624, 354);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Số trang";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label4.Location = new System.Drawing.Point(624, 287);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 18);
            this.label4.TabIndex = 2;
            this.label4.Text = "Nhà xuất bản";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // lbAuthorname
            // 
            this.lbAuthorname.AutoSize = true;
            this.lbAuthorname.Font = new System.Drawing.Font("Tahoma", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAuthorname.ForeColor = System.Drawing.Color.Black;
            this.lbAuthorname.Location = new System.Drawing.Point(848, 127);
            this.lbAuthorname.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbAuthorname.Name = "lbAuthorname";
            this.lbAuthorname.Size = new System.Drawing.Size(78, 18);
            this.lbAuthorname.TabIndex = 2;
            this.lbAuthorname.Text = "Họ và tên";
            this.lbAuthorname.Click += new System.EventHandler(this.lbAuthorname_Click);
            // 
            // lbPublishDate
            // 
            this.lbPublishDate.AutoSize = true;
            this.lbPublishDate.Font = new System.Drawing.Font("Tahoma", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPublishDate.ForeColor = System.Drawing.Color.Black;
            this.lbPublishDate.Location = new System.Drawing.Point(848, 203);
            this.lbPublishDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbPublishDate.Name = "lbPublishDate";
            this.lbPublishDate.Size = new System.Drawing.Size(115, 18);
            this.lbPublishDate.TabIndex = 2;
            this.lbPublishDate.Text = "Ngày xuất bản";
            this.lbPublishDate.Click += new System.EventHandler(this.lbPublishDate_Click);
            // 
            // lbCompany
            // 
            this.lbCompany.AutoSize = true;
            this.lbCompany.Font = new System.Drawing.Font("Tahoma", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCompany.ForeColor = System.Drawing.Color.Black;
            this.lbCompany.Location = new System.Drawing.Point(848, 283);
            this.lbCompany.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbCompany.Name = "lbCompany";
            this.lbCompany.Size = new System.Drawing.Size(106, 18);
            this.lbCompany.TabIndex = 2;
            this.lbCompany.Text = "Nhà xuất bản";
            this.lbCompany.Click += new System.EventHandler(this.lbCompany_Click);
            // 
            // lbTotalPage
            // 
            this.lbTotalPage.AutoSize = true;
            this.lbTotalPage.Font = new System.Drawing.Font("Tahoma", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotalPage.ForeColor = System.Drawing.Color.Black;
            this.lbTotalPage.Location = new System.Drawing.Point(848, 350);
            this.lbTotalPage.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbTotalPage.Name = "lbTotalPage";
            this.lbTotalPage.Size = new System.Drawing.Size(71, 18);
            this.lbTotalPage.TabIndex = 2;
            this.lbTotalPage.Text = "Số trang";
            this.lbTotalPage.Click += new System.EventHandler(this.label3_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label5.Location = new System.Drawing.Point(773, 510);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(134, 17);
            this.label5.TabIndex = 2;
            this.label5.Text = "Số sách cần mượn";
            this.label5.Click += new System.EventHandler(this.label3_Click);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(1021, 508);
            this.numericUpDown1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(71, 23);
            this.numericUpDown1.TabIndex = 3;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label6.Location = new System.Drawing.Point(596, 431);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(209, 24);
            this.label6.TabIndex = 2;
            this.label6.Text = "Đăng ký mượn sách";
            this.label6.Click += new System.EventHandler(this.label3_Click);
            // 
            // btnOrder
            // 
            this.btnOrder.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnOrder.ImageOptions.Image")));
            this.btnOrder.Location = new System.Drawing.Point(826, 559);
            this.btnOrder.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(154, 48);
            this.btnOrder.TabIndex = 4;
            this.btnOrder.Text = "Đăng ký mượn";
            this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click);
            // 
            // BookDetail
            // 
            this.Appearance.ForeColor = System.Drawing.Color.Black;
            this.Appearance.Options.UseFont = true;
            this.Appearance.Options.UseForeColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1177, 638);
            this.Controls.Add(this.btnOrder);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.lbCompany);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbTotalPage);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbPublishDate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbAuthorname);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbBookName);
            this.Controls.Add(this.bookContent);
            this.Font = new System.Drawing.Font("Tahoma", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "BookDetail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BookDetail";
            this.Load += new System.EventHandler(this.BookDetail_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox bookContent;
        private System.Windows.Forms.Label lbBookName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbAuthorname;
        private System.Windows.Forms.Label lbPublishDate;
        private System.Windows.Forms.Label lbCompany;
        private System.Windows.Forms.Label lbTotalPage;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label6;
        private DevExpress.XtraEditors.SimpleButton btnOrder;
    }
}