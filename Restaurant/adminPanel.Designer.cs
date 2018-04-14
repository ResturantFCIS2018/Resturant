namespace Restaurant
{
    partial class adminPanel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(adminPanel));
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.showboyes = new Bunifu.Framework.UI.BunifuTileButton();
            this.showmenu = new Bunifu.Framework.UI.BunifuTileButton();
            this.Food = new System.Windows.Forms.TabPage();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.itemname = new Bunifu.Framework.UI.BunifuTextbox();
            this.bunifuCustomLabel5 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.price = new Bunifu.Framework.UI.BunifuTextbox();
            this.quan = new Bunifu.Framework.UI.BunifuTextbox();
            this.discount = new Bunifu.Framework.UI.BunifuTextbox();
            this.id = new Bunifu.Framework.UI.BunifuTextbox();
            this.add_item = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bunifuCustomLabel4 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.menu = new System.Windows.Forms.DataGridView();
            this.view = new System.Windows.Forms.TabControl();
            this.boy = new System.Windows.Forms.TabPage();
            this.addBoy = new Bunifu.Framework.UI.BunifuThinButton2();
            this.phone = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel7 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel6 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.name = new Bunifu.Framework.UI.BunifuTextbox();
            this.phonenumber = new Bunifu.Framework.UI.BunifuTextbox();
            this.ass_area = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.Food.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.menu)).BeginInit();
            this.view.SuspendLayout();
            this.boy.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(796, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "X";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(103)))), ((int)(((byte)(214)))));
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(825, 50);
            this.panel1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Snap ITC", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(6, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(179, 35);
            this.label2.TabIndex = 1;
            this.label2.Text = "Dashboard";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(59)))), ((int)(((byte)(72)))));
            this.panel2.Controls.Add(this.showboyes);
            this.panel2.Controls.Add(this.showmenu);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 50);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(126, 477);
            this.panel2.TabIndex = 2;
            // 
            // showboyes
            // 
            this.showboyes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(67)))), ((int)(((byte)(147)))));
            this.showboyes.color = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(67)))), ((int)(((byte)(147)))));
            this.showboyes.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(67)))), ((int)(((byte)(147)))));
            this.showboyes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.showboyes.Font = new System.Drawing.Font("Castellar", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showboyes.ForeColor = System.Drawing.Color.White;
            this.showboyes.Image = ((System.Drawing.Image)(resources.GetObject("showboyes.Image")));
            this.showboyes.ImagePosition = 15;
            this.showboyes.ImageZoom = 50;
            this.showboyes.LabelPosition = 31;
            this.showboyes.LabelText = "Show Boys";
            this.showboyes.Location = new System.Drawing.Point(0, 0);
            this.showboyes.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.showboyes.Name = "showboyes";
            this.showboyes.Size = new System.Drawing.Size(128, 113);
            this.showboyes.TabIndex = 1;
            this.showboyes.Click += new System.EventHandler(this.showboyes_Click);
            // 
            // showmenu
            // 
            this.showmenu.BackColor = System.Drawing.Color.Linen;
            this.showmenu.color = System.Drawing.Color.Linen;
            this.showmenu.colorActive = System.Drawing.Color.White;
            this.showmenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.showmenu.Font = new System.Drawing.Font("Castellar", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showmenu.ForeColor = System.Drawing.Color.Black;
            this.showmenu.Image = ((System.Drawing.Image)(resources.GetObject("showmenu.Image")));
            this.showmenu.ImagePosition = 15;
            this.showmenu.ImageZoom = 50;
            this.showmenu.LabelPosition = 31;
            this.showmenu.LabelText = "Show Menu";
            this.showmenu.Location = new System.Drawing.Point(0, 112);
            this.showmenu.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.showmenu.Name = "showmenu";
            this.showmenu.Size = new System.Drawing.Size(128, 113);
            this.showmenu.TabIndex = 0;
            this.showmenu.Click += new System.EventHandler(this.bunifuTileButton1_Click_1);
            // 
            // Food
            // 
            this.Food.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(60)))), ((int)(((byte)(117)))));
            this.Food.Controls.Add(this.label7);
            this.Food.Controls.Add(this.label6);
            this.Food.Controls.Add(this.label5);
            this.Food.Controls.Add(this.label4);
            this.Food.Controls.Add(this.label3);
            this.Food.Controls.Add(this.itemname);
            this.Food.Controls.Add(this.bunifuCustomLabel5);
            this.Food.Controls.Add(this.price);
            this.Food.Controls.Add(this.quan);
            this.Food.Controls.Add(this.discount);
            this.Food.Controls.Add(this.id);
            this.Food.Controls.Add(this.add_item);
            this.Food.Controls.Add(this.bunifuCustomLabel4);
            this.Food.Controls.Add(this.bunifuCustomLabel3);
            this.Food.Controls.Add(this.bunifuCustomLabel2);
            this.Food.Controls.Add(this.bunifuCustomLabel1);
            this.Food.Location = new System.Drawing.Point(4, 22);
            this.Food.Name = "Food";
            this.Food.Padding = new System.Windows.Forms.Padding(3);
            this.Food.Size = new System.Drawing.Size(701, 452);
            this.Food.TabIndex = 3;
            this.Food.Text = "Add to Menu";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 14F);
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label7.Location = new System.Drawing.Point(65, 352);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(17, 23);
            this.label7.TabIndex = 30;
            this.label7.Text = ":";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 14F);
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label6.Location = new System.Drawing.Point(65, 101);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(17, 23);
            this.label6.TabIndex = 29;
            this.label6.Text = ":";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 14F);
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label5.Location = new System.Drawing.Point(65, 186);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(17, 23);
            this.label5.TabIndex = 28;
            this.label5.Text = ":";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 14F);
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(65, 261);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(17, 23);
            this.label4.TabIndex = 27;
            this.label4.Text = ":";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 14F);
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(65, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 23);
            this.label3.TabIndex = 26;
            this.label3.Text = ":";
            // 
            // itemname
            // 
            this.itemname.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(39)))), ((int)(((byte)(59)))));
            this.itemname.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("itemname.BackgroundImage")));
            this.itemname.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.itemname.ForeColor = System.Drawing.Color.White;
            this.itemname.Icon = ((System.Drawing.Image)(resources.GetObject("itemname.Icon")));
            this.itemname.Location = new System.Drawing.Point(88, 96);
            this.itemname.Name = "itemname";
            this.itemname.Size = new System.Drawing.Size(306, 40);
            this.itemname.TabIndex = 25;
            this.itemname.text = "";
            // 
            // bunifuCustomLabel5
            // 
            this.bunifuCustomLabel5.AutoSize = true;
            this.bunifuCustomLabel5.Font = new System.Drawing.Font("Tahoma", 12F);
            this.bunifuCustomLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(246)))), ((int)(((byte)(250)))));
            this.bunifuCustomLabel5.Location = new System.Drawing.Point(12, 102);
            this.bunifuCustomLabel5.Name = "bunifuCustomLabel5";
            this.bunifuCustomLabel5.Size = new System.Drawing.Size(50, 19);
            this.bunifuCustomLabel5.TabIndex = 24;
            this.bunifuCustomLabel5.Text = "Name";
            // 
            // price
            // 
            this.price.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(39)))), ((int)(((byte)(59)))));
            this.price.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("price.BackgroundImage")));
            this.price.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.price.ForeColor = System.Drawing.Color.White;
            this.price.Icon = ((System.Drawing.Image)(resources.GetObject("price.Icon")));
            this.price.Location = new System.Drawing.Point(89, 177);
            this.price.Name = "price";
            this.price.Size = new System.Drawing.Size(306, 38);
            this.price.TabIndex = 23;
            this.price.text = "";
            // 
            // quan
            // 
            this.quan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(39)))), ((int)(((byte)(59)))));
            this.quan.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("quan.BackgroundImage")));
            this.quan.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.quan.ForeColor = System.Drawing.Color.White;
            this.quan.Icon = ((System.Drawing.Image)(resources.GetObject("quan.Icon")));
            this.quan.Location = new System.Drawing.Point(89, 251);
            this.quan.Name = "quan";
            this.quan.Size = new System.Drawing.Size(306, 42);
            this.quan.TabIndex = 22;
            this.quan.text = "";
            // 
            // discount
            // 
            this.discount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(39)))), ((int)(((byte)(59)))));
            this.discount.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("discount.BackgroundImage")));
            this.discount.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.discount.ForeColor = System.Drawing.Color.White;
            this.discount.Icon = ((System.Drawing.Image)(resources.GetObject("discount.Icon")));
            this.discount.Location = new System.Drawing.Point(89, 342);
            this.discount.Name = "discount";
            this.discount.Size = new System.Drawing.Size(306, 42);
            this.discount.TabIndex = 21;
            this.discount.text = "";
            // 
            // id
            // 
            this.id.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(39)))), ((int)(((byte)(59)))));
            this.id.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("id.BackgroundImage")));
            this.id.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.id.ForeColor = System.Drawing.Color.White;
            this.id.Icon = ((System.Drawing.Image)(resources.GetObject("id.Icon")));
            this.id.Location = new System.Drawing.Point(89, 32);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(306, 40);
            this.id.TabIndex = 20;
            this.id.text = "";
            // 
            // add_item
            // 
            this.add_item.ActiveBorderThickness = 1;
            this.add_item.ActiveCornerRadius = 20;
            this.add_item.ActiveFillColor = System.Drawing.Color.White;
            this.add_item.ActiveForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(227)))), ((int)(((byte)(116)))));
            this.add_item.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(227)))), ((int)(((byte)(116)))));
            this.add_item.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(60)))), ((int)(((byte)(117)))));
            this.add_item.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("add_item.BackgroundImage")));
            this.add_item.ButtonText = "Add Item";
            this.add_item.Cursor = System.Windows.Forms.Cursors.Hand;
            this.add_item.Font = new System.Drawing.Font("Copperplate Gothic Bold", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_item.ForeColor = System.Drawing.Color.SeaGreen;
            this.add_item.IdleBorderThickness = 1;
            this.add_item.IdleCornerRadius = 20;
            this.add_item.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(227)))), ((int)(((byte)(116)))));
            this.add_item.IdleForecolor = System.Drawing.Color.White;
            this.add_item.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(227)))), ((int)(((byte)(116)))));
            this.add_item.Location = new System.Drawing.Point(384, 388);
            this.add_item.Margin = new System.Windows.Forms.Padding(9, 6, 9, 6);
            this.add_item.Name = "add_item";
            this.add_item.Size = new System.Drawing.Size(297, 51);
            this.add_item.TabIndex = 19;
            this.add_item.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bunifuCustomLabel4
            // 
            this.bunifuCustomLabel4.AutoSize = true;
            this.bunifuCustomLabel4.Font = new System.Drawing.Font("Tahoma", 12F);
            this.bunifuCustomLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(246)))), ((int)(((byte)(250)))));
            this.bunifuCustomLabel4.Location = new System.Drawing.Point(0, 354);
            this.bunifuCustomLabel4.Name = "bunifuCustomLabel4";
            this.bunifuCustomLabel4.Size = new System.Drawing.Size(70, 19);
            this.bunifuCustomLabel4.TabIndex = 18;
            this.bunifuCustomLabel4.Text = "Discount";
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.AutoSize = true;
            this.bunifuCustomLabel3.Font = new System.Drawing.Font("Tahoma", 12F);
            this.bunifuCustomLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(246)))), ((int)(((byte)(250)))));
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(2, 262);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(69, 19);
            this.bunifuCustomLabel3.TabIndex = 16;
            this.bunifuCustomLabel3.Text = "Quantity";
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Tahoma", 14F);
            this.bunifuCustomLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(246)))), ((int)(((byte)(250)))));
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(12, 188);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(50, 23);
            this.bunifuCustomLabel2.TabIndex = 14;
            this.bunifuCustomLabel2.Text = "Price";
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Tahoma", 14F);
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(246)))), ((int)(((byte)(250)))));
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(12, 39);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(36, 23);
            this.bunifuCustomLabel1.TabIndex = 12;
            this.bunifuCustomLabel1.Text = "ID ";
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.Transparent;
            this.tabPage3.Controls.Add(this.menu);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(701, 452);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Data View";
            // 
            // menu
            // 
            this.menu.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(39)))), ((int)(((byte)(46)))));
            this.menu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.menu.Location = new System.Drawing.Point(-4, 1);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(695, 452);
            this.menu.TabIndex = 0;
            this.menu.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.menu_CellContentClick);
            // 
            // view
            // 
            this.view.Controls.Add(this.tabPage3);
            this.view.Controls.Add(this.Food);
            this.view.Controls.Add(this.boy);
            this.view.Location = new System.Drawing.Point(125, 49);
            this.view.Name = "view";
            this.view.SelectedIndex = 0;
            this.view.Size = new System.Drawing.Size(709, 478);
            this.view.TabIndex = 11;
            // 
            // boy
            // 
            this.boy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(33)))), ((int)(((byte)(79)))));
            this.boy.Controls.Add(this.addBoy);
            this.boy.Controls.Add(this.phone);
            this.boy.Controls.Add(this.bunifuCustomLabel7);
            this.boy.Controls.Add(this.bunifuCustomLabel6);
            this.boy.Controls.Add(this.name);
            this.boy.Controls.Add(this.phonenumber);
            this.boy.Controls.Add(this.ass_area);
            this.boy.Location = new System.Drawing.Point(4, 22);
            this.boy.Name = "boy";
            this.boy.Padding = new System.Windows.Forms.Padding(3);
            this.boy.Size = new System.Drawing.Size(701, 452);
            this.boy.TabIndex = 4;
            this.boy.Text = "Add Delivery Boy";
            // 
            // addBoy
            // 
            this.addBoy.ActiveBorderThickness = 1;
            this.addBoy.ActiveCornerRadius = 20;
            this.addBoy.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(66)))), ((int)(((byte)(250)))));
            this.addBoy.ActiveForecolor = System.Drawing.Color.White;
            this.addBoy.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(66)))), ((int)(((byte)(250)))));
            this.addBoy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(33)))), ((int)(((byte)(79)))));
            this.addBoy.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("addBoy.BackgroundImage")));
            this.addBoy.ButtonText = "Add BOY";
            this.addBoy.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addBoy.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addBoy.ForeColor = System.Drawing.Color.SeaGreen;
            this.addBoy.IdleBorderThickness = 1;
            this.addBoy.IdleCornerRadius = 20;
            this.addBoy.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(71)))), ((int)(((byte)(87)))));
            this.addBoy.IdleForecolor = System.Drawing.Color.White;
            this.addBoy.IdleLineColor = System.Drawing.Color.SeaShell;
            this.addBoy.Location = new System.Drawing.Point(172, 302);
            this.addBoy.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.addBoy.Name = "addBoy";
            this.addBoy.Size = new System.Drawing.Size(306, 47);
            this.addBoy.TabIndex = 26;
            this.addBoy.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // phone
            // 
            this.phone.AutoSize = true;
            this.phone.Font = new System.Drawing.Font("Ravie", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phone.ForeColor = System.Drawing.Color.White;
            this.phone.Location = new System.Drawing.Point(6, 155);
            this.phone.Name = "phone";
            this.phone.Size = new System.Drawing.Size(158, 22);
            this.phone.TabIndex = 25;
            this.phone.Text = "Phone Number";
            // 
            // bunifuCustomLabel7
            // 
            this.bunifuCustomLabel7.AutoSize = true;
            this.bunifuCustomLabel7.Font = new System.Drawing.Font("Ravie", 9F);
            this.bunifuCustomLabel7.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel7.Location = new System.Drawing.Point(6, 225);
            this.bunifuCustomLabel7.Name = "bunifuCustomLabel7";
            this.bunifuCustomLabel7.Size = new System.Drawing.Size(163, 17);
            this.bunifuCustomLabel7.TabIndex = 24;
            this.bunifuCustomLabel7.Text = "Assigned Area Code";
            // 
            // bunifuCustomLabel6
            // 
            this.bunifuCustomLabel6.AutoSize = true;
            this.bunifuCustomLabel6.Font = new System.Drawing.Font("Ravie", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel6.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel6.Location = new System.Drawing.Point(6, 77);
            this.bunifuCustomLabel6.Name = "bunifuCustomLabel6";
            this.bunifuCustomLabel6.Size = new System.Drawing.Size(67, 22);
            this.bunifuCustomLabel6.TabIndex = 23;
            this.bunifuCustomLabel6.Text = "Name";
            // 
            // name
            // 
            this.name.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(39)))), ((int)(((byte)(59)))));
            this.name.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("name.BackgroundImage")));
            this.name.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.name.ForeColor = System.Drawing.Color.White;
            this.name.Icon = ((System.Drawing.Image)(resources.GetObject("name.Icon")));
            this.name.Location = new System.Drawing.Point(172, 65);
            this.name.Margin = new System.Windows.Forms.Padding(8);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(306, 42);
            this.name.TabIndex = 22;
            this.name.text = "";
            // 
            // phonenumber
            // 
            this.phonenumber.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(39)))), ((int)(((byte)(59)))));
            this.phonenumber.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("phonenumber.BackgroundImage")));
            this.phonenumber.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.phonenumber.ForeColor = System.Drawing.Color.White;
            this.phonenumber.Icon = ((System.Drawing.Image)(resources.GetObject("phonenumber.Icon")));
            this.phonenumber.Location = new System.Drawing.Point(172, 140);
            this.phonenumber.Margin = new System.Windows.Forms.Padding(8);
            this.phonenumber.Name = "phonenumber";
            this.phonenumber.Size = new System.Drawing.Size(306, 42);
            this.phonenumber.TabIndex = 21;
            this.phonenumber.text = "";
            // 
            // ass_area
            // 
            this.ass_area.BackColor = System.Drawing.Color.Beige;
            this.ass_area.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ass_area.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ass_area.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.ass_area.FormattingEnabled = true;
            this.ass_area.Items.AddRange(new object[] {
            "Elmarg",
            "Subra",
            "Masr El-gdeida",
            "Nasr City",
            "El-Abasya"});
            this.ass_area.Location = new System.Drawing.Point(172, 224);
            this.ass_area.Name = "ass_area";
            this.ass_area.Size = new System.Drawing.Size(306, 21);
            this.ass_area.TabIndex = 2;
            // 
            // adminPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(87)))), ((int)(((byte)(119)))));
            this.ClientSize = new System.Drawing.Size(825, 527);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.view);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "adminPanel";
            this.Text = "Admin Panel";
            this.Load += new System.EventHandler(this.adminPanel_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.Food.ResumeLayout(false);
            this.Food.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.menu)).EndInit();
            this.view.ResumeLayout(false);
            this.boy.ResumeLayout(false);
            this.boy.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private Bunifu.Framework.UI.BunifuTileButton showmenu;
        private System.Windows.Forms.TabPage Food;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private Bunifu.Framework.UI.BunifuTextbox itemname;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel5;
        private Bunifu.Framework.UI.BunifuTextbox price;
        private Bunifu.Framework.UI.BunifuTextbox quan;
        private Bunifu.Framework.UI.BunifuTextbox discount;
        private Bunifu.Framework.UI.BunifuTextbox id;
        private Bunifu.Framework.UI.BunifuThinButton2 add_item;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel4;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGridView menu;
        private System.Windows.Forms.TabControl view;
        private System.Windows.Forms.TabPage boy;
        private Bunifu.Framework.UI.BunifuThinButton2 addBoy;
        private Bunifu.Framework.UI.BunifuCustomLabel phone;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel7;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel6;
        private Bunifu.Framework.UI.BunifuTextbox name;
        private Bunifu.Framework.UI.BunifuTextbox phonenumber;
        private System.Windows.Forms.ComboBox ass_area;
        private Bunifu.Framework.UI.BunifuTileButton showboyes;

    }
}