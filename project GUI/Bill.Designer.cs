
namespace project_GUI
{
    partial class Bill
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Bill));
            this.cboqty = new System.Windows.Forms.ComboBox();
            this.btncal = new System.Windows.Forms.Button();
            this.btnexit = new System.Windows.Forms.Button();
            this.btnprint = new System.Windows.Forms.Button();
            this.btnview = new System.Windows.Forms.Button();
            this.btnclr = new System.Windows.Forms.Button();
            this.btnadd = new System.Windows.Forms.Button();
            this.dgcustomerbill = new System.Windows.Forms.DataGridView();
            this.dateorder = new System.Windows.Forms.DateTimePicker();
            this.cbordrtype = new System.Windows.Forms.ComboBox();
            this.txtcontno = new System.Windows.Forms.TextBox();
            this.txtname = new System.Windows.Forms.TextBox();
            this.txtbillno = new System.Windows.Forms.TextBox();
            this.lbltot = new System.Windows.Forms.Label();
            this.lblpaydate = new System.Windows.Forms.Label();
            this.lblqty = new System.Windows.Forms.Label();
            this.lblordr = new System.Windows.Forms.Label();
            this.lblcont = new System.Windows.Forms.Label();
            this.lblcusname = new System.Windows.Forms.Label();
            this.lblbillno = new System.Windows.Forms.Label();
            this.lblcusbill = new System.Windows.Forms.Label();
            this.txtCusid = new System.Windows.Forms.TextBox();
            this.lblCusid = new System.Windows.Forms.Label();
            this.menuStriplogout = new System.Windows.Forms.MenuStrip();
            this.oRDERToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cOUSTOMERToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.LogoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pRODUCTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eMPLOYEEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aDDUSERToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lOGINToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dASHBOARDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rEPORTSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtPayammo = new System.Windows.Forms.TextBox();
            this.lblpayammount = new System.Windows.Forms.Label();
            this.bilprintDocument = new System.Drawing.Printing.PrintDocument();
            this.bilprintPreviewDialog = new System.Windows.Forms.PrintPreviewDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dgcustomerbill)).BeginInit();
            this.menuStriplogout.SuspendLayout();
            this.SuspendLayout();
            // 
            // cboqty
            // 
            this.cboqty.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboqty.FormattingEnabled = true;
            this.cboqty.Items.AddRange(new object[] {
            "1",
            "2",
            "5",
            "10",
            "1kg",
            "2kg",
            "3kg",
            "5kg"});
            this.cboqty.Location = new System.Drawing.Point(222, 244);
            this.cboqty.Name = "cboqty";
            this.cboqty.Size = new System.Drawing.Size(225, 28);
            this.cboqty.TabIndex = 71;
            // 
            // btncal
            // 
            this.btncal.BackColor = System.Drawing.Color.Coral;
            this.btncal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncal.ForeColor = System.Drawing.Color.Black;
            this.btncal.Location = new System.Drawing.Point(12, 570);
            this.btncal.Name = "btncal";
            this.btncal.Size = new System.Drawing.Size(150, 40);
            this.btncal.TabIndex = 70;
            this.btncal.Text = "Calculate";
            this.btncal.UseVisualStyleBackColor = false;
            this.btncal.Click += new System.EventHandler(this.btncal_Click);
            // 
            // btnexit
            // 
            this.btnexit.BackColor = System.Drawing.Color.Coral;
            this.btnexit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnexit.ForeColor = System.Drawing.Color.Black;
            this.btnexit.Location = new System.Drawing.Point(769, 654);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(137, 40);
            this.btnexit.TabIndex = 69;
            this.btnexit.Text = "Exit";
            this.btnexit.UseVisualStyleBackColor = false;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // btnprint
            // 
            this.btnprint.BackColor = System.Drawing.Color.Coral;
            this.btnprint.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnprint.ForeColor = System.Drawing.Color.Black;
            this.btnprint.Location = new System.Drawing.Point(1059, 654);
            this.btnprint.Name = "btnprint";
            this.btnprint.Size = new System.Drawing.Size(144, 40);
            this.btnprint.TabIndex = 68;
            this.btnprint.Text = "Print";
            this.btnprint.UseVisualStyleBackColor = false;
            this.btnprint.Click += new System.EventHandler(this.btnprint_Click);
            // 
            // btnview
            // 
            this.btnview.BackColor = System.Drawing.Color.Coral;
            this.btnview.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnview.ForeColor = System.Drawing.Color.Black;
            this.btnview.Location = new System.Drawing.Point(12, 654);
            this.btnview.Name = "btnview";
            this.btnview.Size = new System.Drawing.Size(150, 40);
            this.btnview.TabIndex = 67;
            this.btnview.Text = "View";
            this.btnview.UseVisualStyleBackColor = false;
            this.btnview.Click += new System.EventHandler(this.btnview_Click);
            // 
            // btnclr
            // 
            this.btnclr.BackColor = System.Drawing.Color.Coral;
            this.btnclr.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclr.ForeColor = System.Drawing.Color.Black;
            this.btnclr.Location = new System.Drawing.Point(339, 570);
            this.btnclr.Name = "btnclr";
            this.btnclr.Size = new System.Drawing.Size(141, 38);
            this.btnclr.TabIndex = 66;
            this.btnclr.Text = "Clear";
            this.btnclr.UseVisualStyleBackColor = false;
            this.btnclr.Click += new System.EventHandler(this.btnclr_Click_1);
            // 
            // btnadd
            // 
            this.btnadd.BackColor = System.Drawing.Color.Coral;
            this.btnadd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnadd.ForeColor = System.Drawing.Color.Black;
            this.btnadd.Location = new System.Drawing.Point(339, 654);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(141, 38);
            this.btnadd.TabIndex = 65;
            this.btnadd.Text = "Add";
            this.btnadd.UseVisualStyleBackColor = false;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // dgcustomerbill
            // 
            this.dgcustomerbill.BackgroundColor = System.Drawing.Color.PapayaWhip;
            this.dgcustomerbill.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgcustomerbill.Location = new System.Drawing.Point(655, 133);
            this.dgcustomerbill.Name = "dgcustomerbill";
            this.dgcustomerbill.RowHeadersWidth = 51;
            this.dgcustomerbill.RowTemplate.Height = 24;
            this.dgcustomerbill.Size = new System.Drawing.Size(548, 382);
            this.dgcustomerbill.TabIndex = 64;
            this.dgcustomerbill.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgcustomerbill_CellContentClick);
            // 
            // dateorder
            // 
            this.dateorder.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateorder.Location = new System.Drawing.Point(222, 393);
            this.dateorder.Name = "dateorder";
            this.dateorder.Size = new System.Drawing.Size(225, 27);
            this.dateorder.TabIndex = 63;
            // 
            // cbordrtype
            // 
            this.cbordrtype.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbordrtype.FormattingEnabled = true;
            this.cbordrtype.Items.AddRange(new object[] {
            "Design Cake",
            "Chocolate Design Cake",
            "Butter Cake",
            "Chocolate Cake",
            "Royal Wedding Cake ",
            "Cup Cake"});
            this.cbordrtype.Location = new System.Drawing.Point(222, 185);
            this.cbordrtype.Name = "cbordrtype";
            this.cbordrtype.Size = new System.Drawing.Size(225, 28);
            this.cbordrtype.TabIndex = 62;
            // 
            // txtcontno
            // 
            this.txtcontno.BackColor = System.Drawing.Color.Bisque;
            this.txtcontno.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcontno.Location = new System.Drawing.Point(222, 130);
            this.txtcontno.Name = "txtcontno";
            this.txtcontno.Size = new System.Drawing.Size(225, 27);
            this.txtcontno.TabIndex = 60;
            // 
            // txtname
            // 
            this.txtname.BackColor = System.Drawing.Color.Bisque;
            this.txtname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtname.Location = new System.Drawing.Point(222, 83);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(225, 27);
            this.txtname.TabIndex = 59;
            // 
            // txtbillno
            // 
            this.txtbillno.BackColor = System.Drawing.Color.Bisque;
            this.txtbillno.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbillno.Location = new System.Drawing.Point(222, 38);
            this.txtbillno.Name = "txtbillno";
            this.txtbillno.Size = new System.Drawing.Size(225, 27);
            this.txtbillno.TabIndex = 58;
            // 
            // lbltot
            // 
            this.lbltot.AutoSize = true;
            this.lbltot.BackColor = System.Drawing.Color.MistyRose;
            this.lbltot.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltot.ForeColor = System.Drawing.Color.Black;
            this.lbltot.Location = new System.Drawing.Point(18, 299);
            this.lbltot.Name = "lbltot";
            this.lbltot.Size = new System.Drawing.Size(0, 20);
            this.lbltot.TabIndex = 57;
            // 
            // lblpaydate
            // 
            this.lblpaydate.AutoSize = true;
            this.lblpaydate.BackColor = System.Drawing.Color.MistyRose;
            this.lblpaydate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpaydate.ForeColor = System.Drawing.Color.Black;
            this.lblpaydate.Location = new System.Drawing.Point(18, 396);
            this.lblpaydate.Name = "lblpaydate";
            this.lblpaydate.Size = new System.Drawing.Size(92, 24);
            this.lblpaydate.TabIndex = 56;
            this.lblpaydate.Text = "Pay Date";
            // 
            // lblqty
            // 
            this.lblqty.AutoSize = true;
            this.lblqty.BackColor = System.Drawing.Color.MistyRose;
            this.lblqty.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblqty.ForeColor = System.Drawing.Color.Black;
            this.lblqty.Location = new System.Drawing.Point(18, 245);
            this.lblqty.Name = "lblqty";
            this.lblqty.Size = new System.Drawing.Size(86, 24);
            this.lblqty.TabIndex = 55;
            this.lblqty.Text = "Quantity";
            this.lblqty.Click += new System.EventHandler(this.lblqty_Click);
            // 
            // lblordr
            // 
            this.lblordr.AutoSize = true;
            this.lblordr.BackColor = System.Drawing.Color.MistyRose;
            this.lblordr.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblordr.ForeColor = System.Drawing.Color.Black;
            this.lblordr.Location = new System.Drawing.Point(18, 188);
            this.lblordr.Name = "lblordr";
            this.lblordr.Size = new System.Drawing.Size(111, 24);
            this.lblordr.TabIndex = 54;
            this.lblordr.Text = "OrderType";
            // 
            // lblcont
            // 
            this.lblcont.AutoSize = true;
            this.lblcont.BackColor = System.Drawing.Color.MistyRose;
            this.lblcont.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcont.ForeColor = System.Drawing.Color.Black;
            this.lblcont.Location = new System.Drawing.Point(18, 131);
            this.lblcont.Name = "lblcont";
            this.lblcont.Size = new System.Drawing.Size(113, 24);
            this.lblcont.TabIndex = 53;
            this.lblcont.Text = "Contact No";
            // 
            // lblcusname
            // 
            this.lblcusname.AutoSize = true;
            this.lblcusname.BackColor = System.Drawing.Color.MistyRose;
            this.lblcusname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcusname.ForeColor = System.Drawing.Color.Black;
            this.lblcusname.Location = new System.Drawing.Point(18, 84);
            this.lblcusname.Name = "lblcusname";
            this.lblcusname.Size = new System.Drawing.Size(160, 24);
            this.lblcusname.TabIndex = 52;
            this.lblcusname.Text = "Customer Name";
            // 
            // lblbillno
            // 
            this.lblbillno.AutoSize = true;
            this.lblbillno.BackColor = System.Drawing.Color.MistyRose;
            this.lblbillno.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblbillno.ForeColor = System.Drawing.Color.Black;
            this.lblbillno.Location = new System.Drawing.Point(60, 41);
            this.lblbillno.Name = "lblbillno";
            this.lblbillno.Size = new System.Drawing.Size(71, 24);
            this.lblbillno.TabIndex = 51;
            this.lblbillno.Text = "Bill No";
            // 
            // lblcusbill
            // 
            this.lblcusbill.AutoSize = true;
            this.lblcusbill.BackColor = System.Drawing.Color.MistyRose;
            this.lblcusbill.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcusbill.Location = new System.Drawing.Point(663, 60);
            this.lblcusbill.Name = "lblcusbill";
            this.lblcusbill.Size = new System.Drawing.Size(124, 24);
            this.lblcusbill.TabIndex = 50;
            this.lblcusbill.Text = "Customer Bill";
            // 
            // txtCusid
            // 
            this.txtCusid.BackColor = System.Drawing.Color.Bisque;
            this.txtCusid.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCusid.Location = new System.Drawing.Point(222, 436);
            this.txtCusid.Name = "txtCusid";
            this.txtCusid.Size = new System.Drawing.Size(225, 27);
            this.txtCusid.TabIndex = 73;
            // 
            // lblCusid
            // 
            this.lblCusid.AutoSize = true;
            this.lblCusid.BackColor = System.Drawing.Color.MistyRose;
            this.lblCusid.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCusid.ForeColor = System.Drawing.Color.Black;
            this.lblCusid.Location = new System.Drawing.Point(18, 439);
            this.lblCusid.Name = "lblCusid";
            this.lblCusid.Size = new System.Drawing.Size(124, 24);
            this.lblCusid.TabIndex = 72;
            this.lblCusid.Text = "Customer ID";
            // 
            // menuStriplogout
            // 
            this.menuStriplogout.BackColor = System.Drawing.Color.LightSalmon;
            this.menuStriplogout.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStriplogout.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.oRDERToolStripMenuItem,
            this.cOUSTOMERToolStripMenuItem,
            this.LogoutToolStripMenuItem,
            this.pRODUCTToolStripMenuItem,
            this.eMPLOYEEToolStripMenuItem,
            this.aDDUSERToolStripMenuItem,
            this.lOGINToolStripMenuItem,
            this.dASHBOARDToolStripMenuItem,
            this.rEPORTSToolStripMenuItem});
            this.menuStriplogout.Location = new System.Drawing.Point(0, 0);
            this.menuStriplogout.Name = "menuStriplogout";
            this.menuStriplogout.Size = new System.Drawing.Size(1261, 28);
            this.menuStriplogout.TabIndex = 75;
            this.menuStriplogout.Text = "LOG OUT MENU STRIP";
            // 
            // oRDERToolStripMenuItem
            // 
            this.oRDERToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.oRDERToolStripMenuItem.Name = "oRDERToolStripMenuItem";
            this.oRDERToolStripMenuItem.Size = new System.Drawing.Size(73, 24);
            this.oRDERToolStripMenuItem.Text = "ORDER";
            this.oRDERToolStripMenuItem.Click += new System.EventHandler(this.oRDERToolStripMenuItem_Click);
            // 
            // cOUSTOMERToolStripMenuItem
            // 
            this.cOUSTOMERToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cOUSTOMERToolStripMenuItem.Name = "cOUSTOMERToolStripMenuItem";
            this.cOUSTOMERToolStripMenuItem.Size = new System.Drawing.Size(113, 24);
            this.cOUSTOMERToolStripMenuItem.Text = "COUSTOMER";
            this.cOUSTOMERToolStripMenuItem.Click += new System.EventHandler(this.cOUSTOMERToolStripMenuItem_Click);
            // 
            // LogoutToolStripMenuItem
            // 
            this.LogoutToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogoutToolStripMenuItem.Name = "LogoutToolStripMenuItem";
            this.LogoutToolStripMenuItem.Size = new System.Drawing.Size(88, 24);
            this.LogoutToolStripMenuItem.Text = "LOG OUT";
            this.LogoutToolStripMenuItem.Click += new System.EventHandler(this.LogoutToolStripMenuItem_Click);
            // 
            // pRODUCTToolStripMenuItem
            // 
            this.pRODUCTToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pRODUCTToolStripMenuItem.Name = "pRODUCTToolStripMenuItem";
            this.pRODUCTToolStripMenuItem.Size = new System.Drawing.Size(93, 24);
            this.pRODUCTToolStripMenuItem.Text = "PRODUCT";
            this.pRODUCTToolStripMenuItem.Click += new System.EventHandler(this.pRODUCTToolStripMenuItem_Click);
            // 
            // eMPLOYEEToolStripMenuItem
            // 
            this.eMPLOYEEToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eMPLOYEEToolStripMenuItem.Name = "eMPLOYEEToolStripMenuItem";
            this.eMPLOYEEToolStripMenuItem.Size = new System.Drawing.Size(98, 24);
            this.eMPLOYEEToolStripMenuItem.Text = "EMPLOYEE";
            this.eMPLOYEEToolStripMenuItem.Click += new System.EventHandler(this.eMPLOYEEToolStripMenuItem_Click);
            // 
            // aDDUSERToolStripMenuItem
            // 
            this.aDDUSERToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aDDUSERToolStripMenuItem.Name = "aDDUSERToolStripMenuItem";
            this.aDDUSERToolStripMenuItem.Size = new System.Drawing.Size(97, 24);
            this.aDDUSERToolStripMenuItem.Text = "ADD USER";
            this.aDDUSERToolStripMenuItem.Click += new System.EventHandler(this.aDDUSERToolStripMenuItem_Click);
            // 
            // lOGINToolStripMenuItem
            // 
            this.lOGINToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lOGINToolStripMenuItem.Name = "lOGINToolStripMenuItem";
            this.lOGINToolStripMenuItem.Size = new System.Drawing.Size(70, 24);
            this.lOGINToolStripMenuItem.Text = "LOGIN";
            this.lOGINToolStripMenuItem.Click += new System.EventHandler(this.lOGINToolStripMenuItem_Click);
            // 
            // dASHBOARDToolStripMenuItem
            // 
            this.dASHBOARDToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dASHBOARDToolStripMenuItem.Name = "dASHBOARDToolStripMenuItem";
            this.dASHBOARDToolStripMenuItem.Size = new System.Drawing.Size(117, 24);
            this.dASHBOARDToolStripMenuItem.Text = "DASHBOARD";
            this.dASHBOARDToolStripMenuItem.Click += new System.EventHandler(this.dASHBOARDToolStripMenuItem_Click);
            // 
            // rEPORTSToolStripMenuItem
            // 
            this.rEPORTSToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rEPORTSToolStripMenuItem.Name = "rEPORTSToolStripMenuItem";
            this.rEPORTSToolStripMenuItem.Size = new System.Drawing.Size(88, 24);
            this.rEPORTSToolStripMenuItem.Text = "REPORTS";
            this.rEPORTSToolStripMenuItem.Click += new System.EventHandler(this.rEPORTSToolStripMenuItem_Click);
            // 
            // txtPayammo
            // 
            this.txtPayammo.BackColor = System.Drawing.Color.Bisque;
            this.txtPayammo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPayammo.Location = new System.Drawing.Point(222, 350);
            this.txtPayammo.Name = "txtPayammo";
            this.txtPayammo.Size = new System.Drawing.Size(225, 27);
            this.txtPayammo.TabIndex = 77;
            // 
            // lblpayammount
            // 
            this.lblpayammount.AutoSize = true;
            this.lblpayammount.BackColor = System.Drawing.Color.MistyRose;
            this.lblpayammount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpayammount.ForeColor = System.Drawing.Color.Black;
            this.lblpayammount.Location = new System.Drawing.Point(18, 351);
            this.lblpayammount.Name = "lblpayammount";
            this.lblpayammount.Size = new System.Drawing.Size(162, 24);
            this.lblpayammount.TabIndex = 76;
            this.lblpayammount.Text = "Payable Amount";
            // 
            // bilprintDocument
            // 
            this.bilprintDocument.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.bilprintDocument_PrintPage);
            // 
            // bilprintPreviewDialog
            // 
            this.bilprintPreviewDialog.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.bilprintPreviewDialog.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.bilprintPreviewDialog.ClientSize = new System.Drawing.Size(400, 300);
            this.bilprintPreviewDialog.Document = this.bilprintDocument;
            this.bilprintPreviewDialog.Enabled = true;
            this.bilprintPreviewDialog.Icon = ((System.Drawing.Icon)(resources.GetObject("bilprintPreviewDialog.Icon")));
            this.bilprintPreviewDialog.Name = "bilprintPreviewDialog";
            this.bilprintPreviewDialog.Visible = false;
            // 
            // Bill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Sienna;
            this.BackgroundImage = global::project_GUI.Properties.Resources.jayani_cake1;
            this.ClientSize = new System.Drawing.Size(1261, 738);
            this.Controls.Add(this.txtPayammo);
            this.Controls.Add(this.lblpayammount);
            this.Controls.Add(this.menuStriplogout);
            this.Controls.Add(this.txtCusid);
            this.Controls.Add(this.lblCusid);
            this.Controls.Add(this.cboqty);
            this.Controls.Add(this.btncal);
            this.Controls.Add(this.btnexit);
            this.Controls.Add(this.btnprint);
            this.Controls.Add(this.btnview);
            this.Controls.Add(this.btnclr);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.dgcustomerbill);
            this.Controls.Add(this.dateorder);
            this.Controls.Add(this.cbordrtype);
            this.Controls.Add(this.txtcontno);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.txtbillno);
            this.Controls.Add(this.lbltot);
            this.Controls.Add(this.lblpaydate);
            this.Controls.Add(this.lblqty);
            this.Controls.Add(this.lblordr);
            this.Controls.Add(this.lblcont);
            this.Controls.Add(this.lblcusname);
            this.Controls.Add(this.lblbillno);
            this.Controls.Add(this.lblcusbill);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Bill";
            this.Text = "Bill";
            this.Load += new System.EventHandler(this.Bill_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgcustomerbill)).EndInit();
            this.menuStriplogout.ResumeLayout(false);
            this.menuStriplogout.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboqty;
        private System.Windows.Forms.Button btncal;
        private System.Windows.Forms.Button btnexit;
        private System.Windows.Forms.Button btnprint;
        private System.Windows.Forms.Button btnview;
        private System.Windows.Forms.Button btnclr;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.DataGridView dgcustomerbill;
        private System.Windows.Forms.DateTimePicker dateorder;
        private System.Windows.Forms.ComboBox cbordrtype;
        private System.Windows.Forms.TextBox txtcontno;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.TextBox txtbillno;
        private System.Windows.Forms.Label lbltot;
        private System.Windows.Forms.Label lblpaydate;
        private System.Windows.Forms.Label lblqty;
        private System.Windows.Forms.Label lblordr;
        private System.Windows.Forms.Label lblcont;
        private System.Windows.Forms.Label lblcusname;
        private System.Windows.Forms.Label lblbillno;
        private System.Windows.Forms.Label lblcusbill;
        private System.Windows.Forms.TextBox txtCusid;
        private System.Windows.Forms.Label lblCusid;
        private System.Windows.Forms.MenuStrip menuStriplogout;
        private System.Windows.Forms.ToolStripMenuItem oRDERToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cOUSTOMERToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem LogoutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pRODUCTToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eMPLOYEEToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aDDUSERToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lOGINToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dASHBOARDToolStripMenuItem;
        private System.Windows.Forms.TextBox txtPayammo;
        private System.Windows.Forms.Label lblpayammount;
        private System.Windows.Forms.ToolStripMenuItem rEPORTSToolStripMenuItem;
        private System.Drawing.Printing.PrintDocument bilprintDocument;
        private System.Windows.Forms.PrintPreviewDialog bilprintPreviewDialog;
    }
}