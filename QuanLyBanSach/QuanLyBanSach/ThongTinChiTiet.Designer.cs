namespace QuanLyBanSach
{
    partial class ThongTinChiTiet
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
            this.dtgDetailBook = new System.Windows.Forms.DataGridView();
            this.btnComBack = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgDetailBook)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgDetailBook
            // 
            this.dtgDetailBook.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgDetailBook.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgDetailBook.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dtgDetailBook.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgDetailBook.Location = new System.Drawing.Point(1, 120);
            this.dtgDetailBook.Name = "dtgDetailBook";
            this.dtgDetailBook.RowHeadersWidth = 62;
            this.dtgDetailBook.RowTemplate.Height = 28;
            this.dtgDetailBook.Size = new System.Drawing.Size(1066, 478);
            this.dtgDetailBook.TabIndex = 0;
            // 
            // btnComBack
            // 
            this.btnComBack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnComBack.BackColor = System.Drawing.Color.Red;
            this.btnComBack.ForeColor = System.Drawing.Color.Transparent;
            this.btnComBack.Location = new System.Drawing.Point(969, 80);
            this.btnComBack.Name = "btnComBack";
            this.btnComBack.Size = new System.Drawing.Size(100, 40);
            this.btnComBack.TabIndex = 1;
            this.btnComBack.Text = "Quay Lại";
            this.btnComBack.UseVisualStyleBackColor = false;
            this.btnComBack.Click += new System.EventHandler(this.btnComBack_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Green;
            this.label1.Location = new System.Drawing.Point(356, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(351, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "Chi Tiết Sách Của Chúng Tôi";
            // 
            // ThongTinChiTiet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 599);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnComBack);
            this.Controls.Add(this.dtgDetailBook);
            this.Name = "ThongTinChiTiet";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thông Tin Chi Tiết";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ThongTinChiTiet_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgDetailBook)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgDetailBook;
        private System.Windows.Forms.Button btnComBack;
        private System.Windows.Forms.Label label1;
    }
}