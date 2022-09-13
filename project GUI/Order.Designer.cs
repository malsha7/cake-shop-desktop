
namespace project_GUI
{
    partial class Order
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
            this.btnview = new System.Windows.Forms.Button();
            this.datedeliver = new System.Windows.Forms.DateTimePicker();
            this.lbldeliver = new System.Windows.Forms.Label();
            this.btnexit = new System.Windows.Forms.Button();
            this.btnclear = new System.Windows.Forms.Button();
            this.btnadd = new System.Windows.Forms.Button();
            this.dgcustomer = new System.Windows.Forms.DataGridView();
            this.dateorder = new System.Windows.Forms.DateTimePicker();
            this.lblorderdate = new System.Windows.Forms.Label();
            this.cbotype = new System.Windows.Forms.ComboBox();
            this.lbltype = new System.Windows.Forms.Label();
            this.txtname = new System.Windows.Forms.TextBox();
            this.lblname = new System.Windows.Forms.Label();
            this.txtordrno = new System.Windows.Forms.TextBox();
            this.lblno = new System.Windows.Forms.Label();
            this.menuStriplogout = new System.Windows.Forms.MenuStrip();
            this.LOGOUTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cOUSTOMERToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bIlToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pRODUCTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eMPLOYEEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aDDUSERToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lOGINToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dASHBOARDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rEPORTSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtcusid = new System.Windows.Forms.TextBox();
            this.lblCusid = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgcustomer)).BeginInit();
            this.menuStriplogout.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnview
            // 
            this.btnview.BackColor = System.Drawing.Color.Coral;
            this.btnview.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnview.Location = new System.Drawing.Point(1003, 629);
            this.btnview.Name = "btnview";
            this.btnview.Size = new System.Drawing.Size(147, 35);
            this.btnview.TabIndex = 33;
            this.btnview.Text = "View";
            this.btnview.UseVisualStyleBackColor = false;
            this.btnview.Click += new System.EventHandler(this.btnview_Click);
            // 
            // datedeliver
            // 
            this.datedeliver.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datedeliver.Location = new System.Drawing.Point(262, 376);
            this.datedeliver.Name = "datedeliver";
            this.datedeliver.Size = new System.Drawing.Size(200, 27);
            this.datedeliver.TabIndex = 32;
            this.datedeliver.Value = new System.DateTime(2020, 10, 31, 0, 0, 0, 0);
            // 
            // lbldeliver
            // 
            this.lbldeliver.AutoSize = true;
            this.lbldeliver.BackColor = System.Drawing.Color.MistyRose;
            this.lbldeliver.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldeliver.ForeColor = System.Drawing.Color.Black;
            this.lbldeliver.Location = new System.Drawing.Point(51, 376);
            this.lbldeliver.Name = "lbldeliver";
            this.lbldeliver.Size = new System.Drawing.Size(151, 25);
            this.lbldeliver.TabIndex = 31;
            this.lbldeliver.Text = "Deilvered date";
            // 
            // btnexit
            // 
            this.btnexit.BackColor = System.Drawing.Color.Coral;
            this.btnexit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnexit.Location = new System.Drawing.Point(656, 629);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(149, 35);
            this.btnexit.TabIndex = 30;
            this.btnexit.Text = "Exit";
            this.btnexit.UseVisualStyleBackColor = false;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // btnclear
            // 
            this.btnclear.BackColor = System.Drawing.Color.Coral;
            this.btnclear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclear.Location = new System.Drawing.Point(337, 629);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(151, 35);
            this.btnclear.TabIndex = 29;
            this.btnclear.Text = "Clear";
            this.btnclear.UseVisualStyleBackColor = false;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // btnadd
            // 
            this.btnadd.BackColor = System.Drawing.Color.Coral;
            this.btnadd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnadd.Location = new System.Drawing.Point(33, 629);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(149, 35);
            this.btnadd.TabIndex = 28;
            this.btnadd.Text = "Add";
            this.btnadd.UseVisualStyleBackColor = false;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // dgcustomer
            // 
            this.dgcustomer.BackgroundColor = System.Drawing.Color.PapayaWhip;
            this.dgcustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgcustomer.Location = new System.Drawing.Point(626, 92);
            this.dgcustomer.Name = "dgcustomer";
            this.dgcustomer.RowHeadersWidth = 51;
            this.dgcustomer.RowTemplate.Height = 24;
            this.dgcustomer.Size = new System.Drawing.Size(606, 368);
            this.dgcustomer.TabIndex = 27;
            // 
            // dateorder
            // 
            this.dateorder.CalendarTitleForeColor = System.Drawing.Color.IndianRed;
            this.dateorder.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateorder.Location = new System.Drawing.Point(262, 311);
            this.dateorder.Name = "dateorder";
            this.dateorder.Size = new System.Drawing.Size(200, 27);
            this.dateorder.TabIndex = 26;
            // 
            // lblorderdate
            // 
            this.lblorderdate.AutoSize = true;
            this.lblorderdate.BackColor = System.Drawing.Color.MistyRose;
            this.lblorderdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblorderdate.ForeColor = System.Drawing.Color.Black;
            this.lblorderdate.Location = new System.Drawing.Point(51, 316);
            this.lblorderdate.Name = "lblorderdate";
            this.lblorderdate.Size = new System.Drawing.Size(139, 25);
            this.lblorderdate.TabIndex = 25;
            this.lblorderdate.Text = "Ordered date";
            // 
            // cbotype
            // 
            this.cbotype.BackColor = System.Drawing.Color.Bisque;
            this.cbotype.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbotype.FormattingEnabled = true;
            this.cbotype.Items.AddRange(new object[] {
            "Butter Cake",
            "Chocolate Cake",
            "Design Cake",
            "Chocolate Design Cake",
            "Cup Cake",
            "Royal Wedding Cake"});
            this.cbotype.Location = new System.Drawing.Point(262, 182);
            this.cbotype.Name = "cbotype";
            this.cbotype.Size = new System.Drawing.Size(200, 28);
            this.cbotype.TabIndex = 24;
            // 
            // lbltype
            // 
            this.lbltype.AutoSize = true;
            this.lbltype.BackColor = System.Drawing.Color.MistyRose;
            this.lbltype.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltype.ForeColor = System.Drawing.Color.Black;
            this.lbltype.Location = new System.Drawing.Point(51, 185);
            this.lbltype.Name = "lbltype";
            this.lbltype.Size = new System.Drawing.Size(114, 25);
            this.lbltype.TabIndex = 23;
            this.lbltype.Text = "Order type";
            // 
            // txtname
            // 
            this.txtname.BackColor = System.Drawing.Color.Bisque;
            this.txtname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtname.Location = new System.Drawing.Point(262, 125);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(200, 27);
            this.txtname.TabIndex = 20;
            // 
            // lblname
            // 
            this.lblname.AutoSize = true;
            this.lblname.BackColor = System.Drawing.Color.MistyRose;
            this.lblname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblname.ForeColor = System.Drawing.Color.Black;
            this.lblname.Location = new System.Drawing.Point(51, 125);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(68, 25);
            this.lblname.TabIndex = 19;
            this.lblname.Text = "Name";
            // 
            // txtordrno
            // 
            this.txtordrno.BackColor = System.Drawing.Color.Bisque;
            this.txtordrno.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtordrno.Location = new System.Drawing.Point(262, 62);
            this.txtordrno.Name = "txtordrno";
            this.txtordrno.Size = new System.Drawing.Size(200, 27);
            this.txtordrno.TabIndex = 18;
            // 
            // lblno
            // 
            this.lblno.AutoSize = true;
            this.lblno.BackColor = System.Drawing.Color.MistyRose;
            this.lblno.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblno.ForeColor = System.Drawing.Color.Black;
            this.lblno.Location = new System.Drawing.Point(51, 65);
            this.lblno.Name = "lblno";
            this.lblno.Size = new System.Drawing.Size(106, 25);
            this.lblno.TabIndex = 17;
            this.lblno.Text = "Order No.";
            // 
            // menuStriplogout
            // 
            this.menuStriplogout.BackColor = System.Drawing.Color.LightSalmon;
            this.menuStriplogout.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStriplogout.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.LOGOUTToolStripMenuItem,
            this.cOUSTOMERToolStripMenuItem,
            this.bIlToolStripMenuItem,
            this.pRODUCTToolStripMenuItem,
            this.eMPLOYEEToolStripMenuItem,
            this.aDDUSERToolStripMenuItem,
            this.lOGINToolStripMenuItem,
            this.dASHBOARDToolStripMenuItem,
            this.rEPORTSToolStripMenuItem});
            this.menuStriplogout.Location = new System.Drawing.Point(0, 0);
            this.menuStriplogout.Name = "menuStriplogout";
            this.menuStriplogout.Size = new System.Drawing.Size(1292, 28);
            this.menuStriplogout.TabIndex = 36;
            this.menuStriplogout.Text = "LOG OUT MENU STRIP";
            // 
            // LOGOUTToolStripMenuItem
            // 
            this.LOGOUTToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LOGOUTToolStripMenuItem.Name = "LOGOUTToolStripMenuItem";
            this.LOGOUTToolStripMenuItem.Size = new System.Drawing.Size(88, 24);
            this.LOGOUTToolStripMenuItem.Text = "LOG OUT";
            this.LOGOUTToolStripMenuItem.Click += new System.EventHandler(this.LOGOUTToolStripMenuItem_Click);
            // 
            // cOUSTOMERToolStripMenuItem
            // 
            this.cOUSTOMERToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cOUSTOMERToolStripMenuItem.Name = "cOUSTOMERToolStripMenuItem";
            this.cOUSTOMERToolStripMenuItem.Size = new System.Drawing.Size(113, 24);
            this.cOUSTOMERToolStripMenuItem.Text = "COUSTOMER";
            this.cOUSTOMERToolStripMenuItem.Click += new System.EventHandler(this.cOUSTOMERToolStripMenuItem_Click);
            // 
            // bIlToolStripMenuItem
            // 
            this.bIlToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bIlToolStripMenuItem.Name = "bIlToolStripMenuItem";
            this.bIlToolStripMenuItem.Size = new System.Drawing.Size(42, 24);
            this.bIlToolStripMenuItem.Text = "BIl";
            this.bIlToolStripMenuItem.Click += new System.EventHandler(this.bIlToolStripMenuItem_Click);
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
            // txtcusid
            // 
            this.txtcusid.BackColor = System.Drawing.Color.Bisque;
            this.txtcusid.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcusid.Location = new System.Drawing.Point(262, 249);
            this.txtcusid.Name = "txtcusid";
            this.txtcusid.Size = new System.Drawing.Size(200, 27);
            this.txtcusid.TabIndex = 38;
            // 
            // lblCusid
            // 
            this.lblCusid.AutoSize = true;
            this.lblCusid.BackColor = System.Drawing.Color.MistyRose;
            this.lblCusid.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCusid.ForeColor = System.Drawing.Color.Black;
            this.lblCusid.Location = new System.Drawing.Point(51, 252);
            this.lblCusid.Name = "lblCusid";
            this.lblCusid.Size = new System.Drawing.Size(132, 25);
            this.lblCusid.TabIndex = 37;
            this.lblCusid.Text = "Customer ID";
            // 
            // Order
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Sienna;
            this.BackgroundImage = global::project_GUI.Properties.Resources.jayani_cake1;
            this.ClientSize = new System.Drawing.Size(1292, 741);
            this.Controls.Add(this.txtcusid);
            this.Controls.Add(this.lblCusid);
            this.Controls.Add(this.menuStriplogout);
            this.Controls.Add(this.btnview);
            this.Controls.Add(this.datedeliver);
            this.Controls.Add(this.lbldeliver);
            this.Controls.Add(this.btnexit);
            this.Controls.Add(this.btnclear);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.dgcustomer);
            this.Controls.Add(this.dateorder);
            this.Controls.Add(this.lblorderdate);
            this.Controls.Add(this.cbotype);
            this.Controls.Add(this.lbltype);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.lblname);
            this.Controls.Add(this.txtordrno);
            this.Controls.Add(this.lblno);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Order";
            this.Text = "Order";
            this.Load += new System.EventHandler(this.Order_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgcustomer)).EndInit();
            this.menuStriplogout.ResumeLayout(false);
            this.menuStriplogout.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnview;
        private System.Windows.Forms.DateTimePicker datedeliver;
        private System.Windows.Forms.Label lbldeliver;
        private System.Windows.Forms.Button btnexit;
        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.DataGridView dgcustomer;
        private System.Windows.Forms.DateTimePicker dateorder;
        private System.Windows.Forms.Label lblorderdate;
        private System.Windows.Forms.ComboBox cbotype;
        private System.Windows.Forms.Label lbltype;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.Label lblname;
        private System.Windows.Forms.TextBox txtordrno;
        private System.Windows.Forms.Label lblno;
        private System.Windows.Forms.MenuStrip menuStriplogout;
        private System.Windows.Forms.ToolStripMenuItem LOGOUTToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cOUSTOMERToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bIlToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pRODUCTToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eMPLOYEEToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aDDUSERToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lOGINToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dASHBOARDToolStripMenuItem;
        private System.Windows.Forms.TextBox txtcusid;
        private System.Windows.Forms.Label lblCusid;
        private System.Windows.Forms.ToolStripMenuItem rEPORTSToolStripMenuItem;
    }
}