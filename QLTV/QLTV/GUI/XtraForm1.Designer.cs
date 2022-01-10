
namespace QLTV.GUI
{
    partial class frmReview
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReview));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.nmGrade = new System.Windows.Forms.NumericUpDown();
            this.txComment = new System.Windows.Forms.RichTextBox();
            this.btnReview = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.nmGrade)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(159, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Điểm";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label2.Location = new System.Drawing.Point(159, 192);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nội dung";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label4.Location = new System.Drawing.Point(233, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(266, 29);
            this.label4.TabIndex = 0;
            this.label4.Text = "ĐÁNH GIÁ THƯ VIỆN";
            // 
            // nmGrade
            // 
            this.nmGrade.Location = new System.Drawing.Point(267, 111);
            this.nmGrade.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nmGrade.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nmGrade.Name = "nmGrade";
            this.nmGrade.Size = new System.Drawing.Size(89, 23);
            this.nmGrade.TabIndex = 2;
            this.nmGrade.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // txComment
            // 
            this.txComment.Location = new System.Drawing.Point(267, 202);
            this.txComment.Name = "txComment";
            this.txComment.Size = new System.Drawing.Size(285, 145);
            this.txComment.TabIndex = 3;
            this.txComment.Text = "";
            // 
            // btnReview
            // 
            this.btnReview.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnReview.ImageOptions.Image")));
            this.btnReview.Location = new System.Drawing.Point(329, 395);
            this.btnReview.Name = "btnReview";
            this.btnReview.Size = new System.Drawing.Size(109, 39);
            this.btnReview.TabIndex = 4;
            this.btnReview.Text = "Đánh giá";
            this.btnReview.Click += new System.EventHandler(this.btnReview_Click);
            // 
            // frmReview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(718, 473);
            this.Controls.Add(this.btnReview);
            this.Controls.Add(this.txComment);
            this.Controls.Add(this.nmGrade);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Name = "frmReview";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đánh giá thư viện";
            ((System.ComponentModel.ISupportInitialize)(this.nmGrade)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown nmGrade;
        private System.Windows.Forms.RichTextBox txComment;
        private DevExpress.XtraEditors.SimpleButton btnReview;
    }
}