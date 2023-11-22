namespace QuanLyBanSach
{
    partial class TrangChu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TrangChu));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuAdmin = new System.Windows.Forms.ToolStripMenuItem();
            this.menuAccount = new System.Windows.Forms.ToolStripMenuItem();
            this.menuitemChangePass = new System.Windows.Forms.ToolStripMenuItem();
            this.menuitemLogOut = new System.Windows.Forms.ToolStripMenuItem();
            this.tabBill = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnLoginHome = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnBuyNow = new System.Windows.Forms.Button();
            this.btnAddCart = new System.Windows.Forms.Button();
            this.btnViewDetail = new System.Windows.Forms.Button();
            this.txbSearchHome = new System.Windows.Forms.TextBox();
            this.btnSearchHome = new System.Windows.Forms.Button();
            this.dtgHome = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnPay = new System.Windows.Forms.Button();
            this.txbMoney = new System.Windows.Forms.TextBox();
            this.lblMoney = new System.Windows.Forms.Label();
            this.btnSearchCart = new System.Windows.Forms.Button();
            this.txbSearchCart = new System.Windows.Forms.TextBox();
            this.dtgCart = new System.Windows.Forms.DataGridView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.txbStatus = new System.Windows.Forms.TextBox();
            this.txbNameBill = new System.Windows.Forms.TextBox();
            this.btnCancelOrder = new System.Windows.Forms.Button();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblNameBill = new System.Windows.Forms.Label();
            this.txbSearchBill = new System.Windows.Forms.TextBox();
            this.btnSearchBill = new System.Windows.Forms.Button();
            this.dtgOder = new System.Windows.Forms.DataGridView();
            this.menuStrip1.SuspendLayout();
            this.tabBill.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgHome)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgCart)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgOder)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuAdmin,
            this.menuAccount});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(204, 33);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuAdmin
            // 
            this.menuAdmin.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.menuAdmin.ForeColor = System.Drawing.Color.DodgerBlue;
            this.menuAdmin.Name = "menuAdmin";
            this.menuAdmin.Size = new System.Drawing.Size(93, 29);
            this.menuAdmin.Text = "Quản Trị";
            this.menuAdmin.Click += new System.EventHandler(this.menuAdmin_Click);
            // 
            // menuAccount
            // 
            this.menuAccount.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.menuAccount.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuitemChangePass,
            this.menuitemLogOut});
            this.menuAccount.ForeColor = System.Drawing.Color.DodgerBlue;
            this.menuAccount.Name = "menuAccount";
            this.menuAccount.Size = new System.Drawing.Size(103, 29);
            this.menuAccount.Text = "Tài Khoản";
            // 
            // menuitemChangePass
            // 
            this.menuitemChangePass.ForeColor = System.Drawing.Color.DarkOrange;
            this.menuitemChangePass.Name = "menuitemChangePass";
            this.menuitemChangePass.Size = new System.Drawing.Size(222, 34);
            this.menuitemChangePass.Text = "Đổi Mật Khẩu";
            this.menuitemChangePass.Click += new System.EventHandler(this.menuitemChangePass_Click);
            // 
            // menuitemLogOut
            // 
            this.menuitemLogOut.ForeColor = System.Drawing.Color.DarkOrange;
            this.menuitemLogOut.Name = "menuitemLogOut";
            this.menuitemLogOut.Size = new System.Drawing.Size(222, 34);
            this.menuitemLogOut.Text = "Đăng Xuất";
            this.menuitemLogOut.Click += new System.EventHandler(this.menuitemLogOut_Click);
            // 
            // tabBill
            // 
            this.tabBill.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabBill.Controls.Add(this.tabPage1);
            this.tabBill.Controls.Add(this.tabPage2);
            this.tabBill.Controls.Add(this.tabPage3);
            this.tabBill.Location = new System.Drawing.Point(0, 36);
            this.tabBill.Name = "tabBill";
            this.tabBill.SelectedIndex = 0;
            this.tabBill.Size = new System.Drawing.Size(1198, 559);
            this.tabBill.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnLoginHome);
            this.tabPage1.Controls.Add(this.pictureBox2);
            this.tabPage1.Controls.Add(this.btnBuyNow);
            this.tabPage1.Controls.Add(this.btnAddCart);
            this.tabPage1.Controls.Add(this.btnViewDetail);
            this.tabPage1.Controls.Add(this.txbSearchHome);
            this.tabPage1.Controls.Add(this.btnSearchHome);
            this.tabPage1.Controls.Add(this.dtgHome);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1190, 526);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Cửa Hàng";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnLoginHome
            // 
            this.btnLoginHome.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLoginHome.ForeColor = System.Drawing.Color.DarkOrange;
            this.btnLoginHome.Location = new System.Drawing.Point(949, 19);
            this.btnLoginHome.Name = "btnLoginHome";
            this.btnLoginHome.Size = new System.Drawing.Size(227, 40);
            this.btnLoginHome.TabIndex = 8;
            this.btnLoginHome.Text = "Đăng Nhập";
            this.btnLoginHome.UseVisualStyleBackColor = true;
            this.btnLoginHome.Click += new System.EventHandler(this.btnLoginHome_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(949, 123);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(227, 189);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            // 
            // btnBuyNow
            // 
            this.btnBuyNow.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBuyNow.BackColor = System.Drawing.Color.OrangeRed;
            this.btnBuyNow.ForeColor = System.Drawing.Color.Transparent;
            this.btnBuyNow.Location = new System.Drawing.Point(976, 466);
            this.btnBuyNow.Name = "btnBuyNow";
            this.btnBuyNow.Size = new System.Drawing.Size(171, 40);
            this.btnBuyNow.TabIndex = 6;
            this.btnBuyNow.Text = "Mua Ngay";
            this.btnBuyNow.UseVisualStyleBackColor = false;
            this.btnBuyNow.Click += new System.EventHandler(this.btnBuyNow_Click);
            // 
            // btnAddCart
            // 
            this.btnAddCart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddCart.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnAddCart.ForeColor = System.Drawing.Color.Transparent;
            this.btnAddCart.Location = new System.Drawing.Point(976, 403);
            this.btnAddCart.Name = "btnAddCart";
            this.btnAddCart.Size = new System.Drawing.Size(171, 40);
            this.btnAddCart.TabIndex = 5;
            this.btnAddCart.Text = "Thêm Vào Giỏ Hàng";
            this.btnAddCart.UseVisualStyleBackColor = false;
            this.btnAddCart.Click += new System.EventHandler(this.btnAddCart_Click);
            // 
            // btnViewDetail
            // 
            this.btnViewDetail.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnViewDetail.BackColor = System.Drawing.Color.LimeGreen;
            this.btnViewDetail.ForeColor = System.Drawing.Color.Transparent;
            this.btnViewDetail.Location = new System.Drawing.Point(976, 338);
            this.btnViewDetail.Name = "btnViewDetail";
            this.btnViewDetail.Size = new System.Drawing.Size(171, 40);
            this.btnViewDetail.TabIndex = 4;
            this.btnViewDetail.Text = "Xem Chi Tiết";
            this.btnViewDetail.UseVisualStyleBackColor = false;
            // 
            // txbSearchHome
            // 
            this.txbSearchHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbSearchHome.Location = new System.Drawing.Point(33, 19);
            this.txbSearchHome.Name = "txbSearchHome";
            this.txbSearchHome.Size = new System.Drawing.Size(500, 30);
            this.txbSearchHome.TabIndex = 2;
            // 
            // btnSearchHome
            // 
            this.btnSearchHome.BackColor = System.Drawing.Color.DarkOrange;
            this.btnSearchHome.ForeColor = System.Drawing.Color.Transparent;
            this.btnSearchHome.Location = new System.Drawing.Point(549, 19);
            this.btnSearchHome.Name = "btnSearchHome";
            this.btnSearchHome.Size = new System.Drawing.Size(98, 40);
            this.btnSearchHome.TabIndex = 1;
            this.btnSearchHome.Text = "Tìm Kiếm";
            this.btnSearchHome.UseVisualStyleBackColor = false;
            // 
            // dtgHome
            // 
            this.dtgHome.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgHome.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgHome.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dtgHome.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgHome.Location = new System.Drawing.Point(4, 76);
            this.dtgHome.Name = "dtgHome";
            this.dtgHome.RowHeadersWidth = 62;
            this.dtgHome.RowTemplate.Height = 28;
            this.dtgHome.Size = new System.Drawing.Size(931, 446);
            this.dtgHome.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.pictureBox1);
            this.tabPage2.Controls.Add(this.btnPay);
            this.tabPage2.Controls.Add(this.txbMoney);
            this.tabPage2.Controls.Add(this.lblMoney);
            this.tabPage2.Controls.Add(this.btnSearchCart);
            this.tabPage2.Controls.Add(this.txbSearchCart);
            this.tabPage2.Controls.Add(this.dtgCart);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1190, 526);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Giỏ Hàng";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(954, 305);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(212, 194);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // btnPay
            // 
            this.btnPay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPay.BackColor = System.Drawing.Color.ForestGreen;
            this.btnPay.ForeColor = System.Drawing.Color.Transparent;
            this.btnPay.Location = new System.Drawing.Point(1004, 169);
            this.btnPay.Name = "btnPay";
            this.btnPay.Size = new System.Drawing.Size(120, 40);
            this.btnPay.TabIndex = 5;
            this.btnPay.Text = "Thanh Toán";
            this.btnPay.UseVisualStyleBackColor = false;
            this.btnPay.Click += new System.EventHandler(this.btnPay_Click);
            // 
            // txbMoney
            // 
            this.txbMoney.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txbMoney.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbMoney.Location = new System.Drawing.Point(968, 111);
            this.txbMoney.Name = "txbMoney";
            this.txbMoney.Size = new System.Drawing.Size(180, 30);
            this.txbMoney.TabIndex = 4;
            // 
            // lblMoney
            // 
            this.lblMoney.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMoney.AutoSize = true;
            this.lblMoney.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMoney.ForeColor = System.Drawing.Color.Green;
            this.lblMoney.Location = new System.Drawing.Point(997, 70);
            this.lblMoney.Name = "lblMoney";
            this.lblMoney.Size = new System.Drawing.Size(113, 25);
            this.lblMoney.TabIndex = 3;
            this.lblMoney.Text = "Thành Tiền";
            // 
            // btnSearchCart
            // 
            this.btnSearchCart.BackColor = System.Drawing.Color.DarkOrange;
            this.btnSearchCart.ForeColor = System.Drawing.Color.Transparent;
            this.btnSearchCart.Location = new System.Drawing.Point(558, 15);
            this.btnSearchCart.Name = "btnSearchCart";
            this.btnSearchCart.Size = new System.Drawing.Size(98, 40);
            this.btnSearchCart.TabIndex = 2;
            this.btnSearchCart.Text = "Tìm Kiếm";
            this.btnSearchCart.UseVisualStyleBackColor = false;
            // 
            // txbSearchCart
            // 
            this.txbSearchCart.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbSearchCart.Location = new System.Drawing.Point(37, 20);
            this.txbSearchCart.Name = "txbSearchCart";
            this.txbSearchCart.Size = new System.Drawing.Size(500, 30);
            this.txbSearchCart.TabIndex = 1;
            // 
            // dtgCart
            // 
            this.dtgCart.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgCart.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgCart.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dtgCart.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgCart.Location = new System.Drawing.Point(4, 72);
            this.dtgCart.Name = "dtgCart";
            this.dtgCart.RowHeadersWidth = 62;
            this.dtgCart.RowTemplate.Height = 28;
            this.dtgCart.Size = new System.Drawing.Size(931, 450);
            this.dtgCart.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.pictureBox3);
            this.tabPage3.Controls.Add(this.txbStatus);
            this.tabPage3.Controls.Add(this.txbNameBill);
            this.tabPage3.Controls.Add(this.btnCancelOrder);
            this.tabPage3.Controls.Add(this.lblStatus);
            this.tabPage3.Controls.Add(this.lblNameBill);
            this.tabPage3.Controls.Add(this.txbSearchBill);
            this.tabPage3.Controls.Add(this.btnSearchBill);
            this.tabPage3.Controls.Add(this.dtgOder);
            this.tabPage3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tabPage3.Location = new System.Drawing.Point(4, 29);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1190, 526);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Đơn Hàng";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(948, 21);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(227, 247);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 9;
            this.pictureBox3.TabStop = false;
            // 
            // txbStatus
            // 
            this.txbStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txbStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbStatus.Location = new System.Drawing.Point(948, 402);
            this.txbStatus.Name = "txbStatus";
            this.txbStatus.Size = new System.Drawing.Size(227, 30);
            this.txbStatus.TabIndex = 8;
            // 
            // txbNameBill
            // 
            this.txbNameBill.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txbNameBill.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbNameBill.Location = new System.Drawing.Point(948, 317);
            this.txbNameBill.Name = "txbNameBill";
            this.txbNameBill.Size = new System.Drawing.Size(227, 30);
            this.txbNameBill.TabIndex = 7;
            // 
            // btnCancelOrder
            // 
            this.btnCancelOrder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelOrder.BackColor = System.Drawing.Color.Red;
            this.btnCancelOrder.ForeColor = System.Drawing.Color.Transparent;
            this.btnCancelOrder.Location = new System.Drawing.Point(1006, 463);
            this.btnCancelOrder.Name = "btnCancelOrder";
            this.btnCancelOrder.Size = new System.Drawing.Size(100, 40);
            this.btnCancelOrder.TabIndex = 6;
            this.btnCancelOrder.Text = "Hủy Đơn";
            this.btnCancelOrder.UseVisualStyleBackColor = false;
            this.btnCancelOrder.Click += new System.EventHandler(this.btnCancelOrder_Click);
            // 
            // lblStatus
            // 
            this.lblStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblStatus.AutoSize = true;
            this.lblStatus.ForeColor = System.Drawing.Color.Green;
            this.lblStatus.Location = new System.Drawing.Point(944, 364);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(84, 20);
            this.lblStatus.TabIndex = 5;
            this.lblStatus.Text = "Trạng Thái";
            // 
            // lblNameBill
            // 
            this.lblNameBill.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNameBill.AutoSize = true;
            this.lblNameBill.ForeColor = System.Drawing.Color.Green;
            this.lblNameBill.Location = new System.Drawing.Point(944, 282);
            this.lblNameBill.Name = "lblNameBill";
            this.lblNameBill.Size = new System.Drawing.Size(113, 20);
            this.lblNameBill.TabIndex = 4;
            this.lblNameBill.Text = "Tên Đơn Hàng";
            // 
            // txbSearchBill
            // 
            this.txbSearchBill.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbSearchBill.Location = new System.Drawing.Point(27, 21);
            this.txbSearchBill.Name = "txbSearchBill";
            this.txbSearchBill.Size = new System.Drawing.Size(500, 30);
            this.txbSearchBill.TabIndex = 2;
            // 
            // btnSearchBill
            // 
            this.btnSearchBill.BackColor = System.Drawing.Color.DarkOrange;
            this.btnSearchBill.ForeColor = System.Drawing.Color.Transparent;
            this.btnSearchBill.Location = new System.Drawing.Point(544, 21);
            this.btnSearchBill.Name = "btnSearchBill";
            this.btnSearchBill.Size = new System.Drawing.Size(98, 40);
            this.btnSearchBill.TabIndex = 1;
            this.btnSearchBill.Text = "Tìm Kiếm";
            this.btnSearchBill.UseVisualStyleBackColor = false;
            // 
            // dtgOder
            // 
            this.dtgOder.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgOder.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgOder.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dtgOder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgOder.Location = new System.Drawing.Point(5, 72);
            this.dtgOder.Name = "dtgOder";
            this.dtgOder.RowHeadersWidth = 62;
            this.dtgOder.RowTemplate.Height = 28;
            this.dtgOder.Size = new System.Drawing.Size(931, 450);
            this.dtgOder.TabIndex = 0;
            // 
            // TrangChu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1198, 594);
            this.Controls.Add(this.tabBill);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "TrangChu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Trang Chủ";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.TrangChu_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabBill.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgHome)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgCart)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgOder)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuAdmin;
        private System.Windows.Forms.ToolStripMenuItem menuAccount;
        private System.Windows.Forms.ToolStripMenuItem menuitemChangePass;
        private System.Windows.Forms.ToolStripMenuItem menuitemLogOut;
        private System.Windows.Forms.TabControl tabBill;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button btnBuyNow;
        private System.Windows.Forms.Button btnAddCart;
        private System.Windows.Forms.Button btnViewDetail;
        private System.Windows.Forms.TextBox txbSearchHome;
        private System.Windows.Forms.Button btnSearchHome;
        private System.Windows.Forms.DataGridView dtgHome;
        private System.Windows.Forms.Button btnPay;
        private System.Windows.Forms.TextBox txbMoney;
        private System.Windows.Forms.Label lblMoney;
        private System.Windows.Forms.Button btnSearchCart;
        private System.Windows.Forms.TextBox txbSearchCart;
        private System.Windows.Forms.DataGridView dtgCart;
        private System.Windows.Forms.TextBox txbStatus;
        private System.Windows.Forms.TextBox txbNameBill;
        private System.Windows.Forms.Button btnCancelOrder;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblNameBill;
        private System.Windows.Forms.TextBox txbSearchBill;
        private System.Windows.Forms.Button btnSearchBill;
        private System.Windows.Forms.DataGridView dtgOder;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button btnLoginHome;
    }
}

