
namespace project_GUI
{
    partial class Empoyee
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
            this.dgemployee = new System.Windows.Forms.DataGridView();
            this.btnexit = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btncal = new System.Windows.Forms.Button();
            this.txtwrkdays = new System.Windows.Forms.TextBox();
            this.txtemid = new System.Windows.Forms.TextBox();
            this.txtemname = new System.Windows.Forms.TextBox();
            this.lblsalary = new System.Windows.Forms.Label();
            this.lblwrkday = new System.Windows.Forms.Label();
            this.lblemid = new System.Windows.Forms.Label();
            this.lblemname = new System.Windows.Forms.Label();
            this.btnadd = new System.Windows.Forms.Button();
            this.menuStriplogout = new System.Windows.Forms.MenuStrip();
            this.oRDERToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cOUSTOMERToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bIlToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pRODUCTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.LOGOUTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aDDUSERToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lOGINToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dASHBOARDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rEPORTSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgemployee)).BeginInit();
            this.menuStriplogout.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnview
            // 
            this.btnview.BackColor = System.Drawing.Color.Coral;
            this.btnview.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnview.ForeColor = System.Drawing.Color.Black;
            this.btnview.Location = new System.Drawing.Point(793, 628);
            this.btnview.Name = "btnview";
            this.btnview.Size = new System.Drawing.Size(127, 45);
            this.btnview.TabIndex = 25;
            this.btnview.Text = "View";
            this.btnview.UseVisualStyleBackColor = false;
            this.btnview.Click += new System.EventHandler(this.btnview_Click);
            // 
            // dgemployee
            // 
            this.dgemployee.BackgroundColor = System.Drawing.Color.PapayaWhip;
            this.dgemployee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgemployee.Location = new System.Drawing.Point(563, 104);
            this.dgemployee.Name = "dgemployee";
            this.dgemployee.RowHeadersWidth = 51;
            this.dgemployee.RowTemplate.Height = 24;
            this.dgemployee.Size = new System.Drawing.Size(627, 372);
            this.dgemployee.TabIndex = 24;
            // 
            // btnexit
            // 
            this.btnexit.BackColor = System.Drawing.Color.Coral;
            this.btnexit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnexit.ForeColor = System.Drawing.Color.Black;
            this.btnexit.Location = new System.Drawing.Point(1089, 628);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(129, 45);
            this.btnexit.TabIndex = 23;
            this.btnexit.Text = "Exit";
            this.btnexit.UseVisualStyleBackColor = false;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.Coral;
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.Color.Black;
            this.btnClear.Location = new System.Drawing.Point(544, 628);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(130, 45);
            this.btnClear.TabIndex = 22;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btncal
            // 
            this.btncal.BackColor = System.Drawing.Color.Coral;
            this.btncal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncal.ForeColor = System.Drawing.Color.Black;
            this.btncal.Location = new System.Drawing.Point(53, 628);
            this.btncal.Name = "btncal";
            this.btncal.Size = new System.Drawing.Size(124, 45);
            this.btncal.TabIndex = 21;
            this.btncal.Text = "Calculate";
            this.btncal.UseVisualStyleBackColor = false;
            this.btncal.Click += new System.EventHandler(this.btncal_Click);
            // 
            // txtwrkdays
            // 
            this.txtwrkdays.BackColor = System.Drawing.Color.Bisque;
            this.txtwrkdays.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtwrkdays.Location = new System.Drawing.Point(250, 269);
            this.txtwrkdays.Name = "txtwrkdays";
            this.txtwrkdays.Size = new System.Drawing.Size(206, 27);
            this.txtwrkdays.TabIndex = 19;
            // 
            // txtemid
            // 
            this.txtemid.BackColor = System.Drawing.Color.Bisque;
            this.txtemid.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtemid.Location = new System.Drawing.Point(250, 185);
            this.txtemid.Name = "txtemid";
            this.txtemid.Size = new System.Drawing.Size(206, 27);
            this.txtemid.TabIndex = 18;
            // 
            // txtemname
            // 
            this.txtemname.BackColor = System.Drawing.Color.Bisque;
            this.txtemname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtemname.Location = new System.Drawing.Point(250, 116);
            this.txtemname.Name = "txtemname";
            this.txtemname.Size = new System.Drawing.Size(206, 27);
            this.txtemname.TabIndex = 17;
            // 
            // lblsalary
            // 
            this.lblsalary.AutoSize = true;
            this.lblsalary.BackColor = System.Drawing.Color.MistyRose;
            this.lblsalary.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsalary.ForeColor = System.Drawing.Color.Black;
            this.lblsalary.Location = new System.Drawing.Point(49, 341);
            this.lblsalary.Name = "lblsalary";
            this.lblsalary.Size = new System.Drawing.Size(0, 24);
            this.lblsalary.TabIndex = 16;
            // 
            // lblwrkday
            // 
            this.lblwrkday.AutoSize = true;
            this.lblwrkday.BackColor = System.Drawing.Color.MistyRose;
            this.lblwrkday.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblwrkday.ForeColor = System.Drawing.Color.Black;
            this.lblwrkday.Location = new System.Drawing.Point(45, 267);
            this.lblwrkday.Name = "lblwrkday";
            this.lblwrkday.Size = new System.Drawing.Size(136, 24);
            this.lblwrkday.TabIndex = 15;
            this.lblwrkday.Text = "Working days";
            // 
            // lblemid
            // 
            this.lblemid.AutoSize = true;
            this.lblemid.BackColor = System.Drawing.Color.MistyRose;
            this.lblemid.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblemid.ForeColor = System.Drawing.Color.Black;
            this.lblemid.Location = new System.Drawing.Point(45, 183);
            this.lblemid.Name = "lblemid";
            this.lblemid.Size = new System.Drawing.Size(129, 24);
            this.lblemid.TabIndex = 14;
            this.lblemid.Text = "Employee ID";
            // 
            // lblemname
            // 
            this.lblemname.AutoSize = true;
            this.lblemname.BackColor = System.Drawing.Color.MistyRose;
            this.lblemname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblemname.ForeColor = System.Drawing.Color.Black;
            this.lblemname.Location = new System.Drawing.Point(39, 114);
            this.lblemname.Name = "lblemname";
            this.lblemname.Size = new System.Drawing.Size(165, 24);
            this.lblemname.TabIndex = 13;
            this.lblemname.Text = "Employee Name";
            // 
            // btnadd
            // 
            this.btnadd.BackColor = System.Drawing.Color.Coral;
            this.btnadd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnadd.ForeColor = System.Drawing.Color.Black;
            this.btnadd.Location = new System.Drawing.Point(301, 628);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(130, 45);
            this.btnadd.TabIndex = 26;
            this.btnadd.Text = "Add";
            this.btnadd.UseVisualStyleBackColor = false;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // menuStriplogout
            // 
            this.menuStriplogout.BackColor = System.Drawing.Color.LightSalmon;
            this.menuStriplogout.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStriplogout.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.oRDERToolStripMenuItem,
            this.cOUSTOMERToolStripMenuItem,
            this.bIlToolStripMenuItem,
            this.pRODUCTToolStripMenuItem,
            this.LOGOUTToolStripMenuItem,
            this.aDDUSERToolStripMenuItem,
            this.lOGINToolStripMenuItem,
            this.dASHBOARDToolStripMenuItem,
            this.rEPORTSToolStripMenuItem});
            this.menuStriplogout.Location = new System.Drawing.Point(0, 0);
            this.menuStriplogout.Name = "menuStriplogout";
            this.menuStriplogout.Size = new System.Drawing.Size(1267, 30);
            this.menuStriplogout.TabIndex = 28;
            this.menuStriplogout.Text = "LOG OUT MENU STRIP";
            // 
            // oRDERToolStripMenuItem
            // 
            this.oRDERToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.oRDERToolStripMenuItem.Name = "oRDERToolStripMenuItem";
            this.oRDERToolStripMenuItem.Size = new System.Drawing.Size(73, 26);
            this.oRDERToolStripMenuItem.Text = "ORDER";
            this.oRDERToolStripMenuItem.Click += new System.EventHandler(this.oRDERToolStripMenuItem_Click);
            // 
            // cOUSTOMERToolStripMenuItem
            // 
            this.cOUSTOMERToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cOUSTOMERToolStripMenuItem.Name = "cOUSTOMERToolStripMenuItem";
            this.cOUSTOMERToolStripMenuItem.Size = new System.Drawing.Size(113, 26);
            this.cOUSTOMERToolStripMenuItem.Text = "COUSTOMER";
            this.cOUSTOMERToolStripMenuItem.Click += new System.EventHandler(this.cOUSTOMERToolStripMenuItem_Click);
            // 
            // bIlToolStripMenuItem
            // 
            this.bIlToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bIlToolStripMenuItem.Name = "bIlToolStripMenuItem";
            this.bIlToolStripMenuItem.Size = new System.Drawing.Size(42, 26);
            this.bIlToolStripMenuItem.Text = "BIl";
            this.bIlToolStripMenuItem.Click += new System.EventHandler(this.bIlToolStripMenuItem_Click);
            // 
            // pRODUCTToolStripMenuItem
            // 
            this.pRODUCTToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pRODUCTToolStripMenuItem.Name = "pRODUCTToolStripMenuItem";
            this.pRODUCTToolStripMenuItem.Size = new System.Drawing.Size(93, 26);
            this.pRODUCTToolStripMenuItem.Text = "PRODUCT";
            this.pRODUCTToolStripMenuItem.Click += new System.EventHandler(this.pRODUCTToolStripMenuItem_Click);
            // 
            // LOGOUTToolStripMenuItem
            // 
            this.LOGOUTToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LOGOUTToolStripMenuItem.Name = "LOGOUTToolStripMenuItem";
            this.LOGOUTToolStripMenuItem.Size = new System.Drawing.Size(88, 26);
            this.LOGOUTToolStripMenuItem.Text = "LOG OUT";
            this.LOGOUTToolStripMenuItem.Click += new System.EventHandler(this.LOGOUTToolStripMenuItem_Click);
            // 
            // aDDUSERToolStripMenuItem
            // 
            this.aDDUSERToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aDDUSERToolStripMenuItem.Name = "aDDUSERToolStripMenuItem";
            this.aDDUSERToolStripMenuItem.Size = new System.Drawing.Size(97, 26);
            this.aDDUSERToolStripMenuItem.Text = "ADD USER";
            this.aDDUSERToolStripMenuItem.Click += new System.EventHandler(this.aDDUSERToolStripMenuItem_Click);
            // 
            // lOGINToolStripMenuItem
            // 
            this.lOGINToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lOGINToolStripMenuItem.Name = "lOGINToolStripMenuItem";
            this.lOGINToolStripMenuItem.Size = new System.Drawing.Size(70, 26);
            this.lOGINToolStripMenuItem.Text = "LOGIN";
            this.lOGINToolStripMenuItem.Click += new System.EventHandler(this.lOGINToolStripMenuItem_Click);
            // 
            // dASHBOARDToolStripMenuItem
            // 
            this.dASHBOARDToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dASHBOARDToolStripMenuItem.Name = "dASHBOARDToolStripMenuItem";
            this.dASHBOARDToolStripMenuItem.Size = new System.Drawing.Size(117, 26);
            this.dASHBOARDToolStripMenuItem.Text = "DASHBOARD";
            this.dASHBOARDToolStripMenuItem.Click += new System.EventHandler(this.dASHBOARDToolStripMenuItem_Click);
            // 
            // rEPORTSToolStripMenuItem
            // 
            this.rEPORTSToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rEPORTSToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.rEPORTSToolStripMenuItem.Name = "rEPORTSToolStripMenuItem";
            this.rEPORTSToolStripMenuItem.Size = new System.Drawing.Size(88, 26);
            this.rEPORTSToolStripMenuItem.Text = "REPORTS";
            this.rEPORTSToolStripMenuItem.Click += new System.EventHandler(this.rEPORTSToolStripMenuItem_Click);
            // 
            // Empoyee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Sienna;
            this.BackgroundImage = global::project_GUI.Properties.Resources.jayani_cake1;
            this.ClientSize = new System.Drawing.Size(1267, 738);
            this.Controls.Add(this.menuStriplogout);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.btnview);
            this.Controls.Add(this.dgemployee);
            this.Controls.Add(this.btnexit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btncal);
            this.Controls.Add(this.txtwrkdays);
            this.Controls.Add(this.txtemid);
            this.Controls.Add(this.txtemname);
            this.Controls.Add(this.lblsalary);
            this.Controls.Add(this.lblwrkday);
            this.Controls.Add(this.lblemid);
            this.Controls.Add(this.lblemname);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Empoyee";
            this.Text = "Employee";
            ((System.ComponentModel.ISupportInitialize)(this.dgemployee)).EndInit();
            this.menuStriplogout.ResumeLayout(false);
            this.menuStriplogout.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnview;
        private System.Windows.Forms.DataGridView dgemployee;
        private System.Windows.Forms.Button btnexit;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btncal;
        private System.Windows.Forms.TextBox txtwrkdays;
        private System.Windows.Forms.TextBox txtemid;
        private System.Windows.Forms.TextBox txtemname;
        private System.Windows.Forms.Label lblsalary;
        private System.Windows.Forms.Label lblwrkday;
        private System.Windows.Forms.Label lblemid;
        private System.Windows.Forms.Label lblemname;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.MenuStrip menuStriplogout;
        private System.Windows.Forms.ToolStripMenuItem oRDERToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cOUSTOMERToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bIlToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pRODUCTToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem LOGOUTToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aDDUSERToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lOGINToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dASHBOARDToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rEPORTSToolStripMenuItem;
    }
}