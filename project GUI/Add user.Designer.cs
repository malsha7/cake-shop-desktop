
namespace project_GUI
{
    partial class Add_user
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
            this.lblemployeeiod = new System.Windows.Forms.Label();
            this.lblusername = new System.Windows.Forms.Label();
            this.lblpassword = new System.Windows.Forms.Label();
            this.txtEId = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.dataGridViewAdduser = new System.Windows.Forms.DataGridView();
            this.btnadd = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnview = new System.Windows.Forms.Button();
            this.menuStriplogout = new System.Windows.Forms.MenuStrip();
            this.oRDERToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cOUSTOMERToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bIlToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pRODUCTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eMPLOYEEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.LOGOUTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lOGINToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dASHBOARDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rEPORTSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAdduser)).BeginInit();
            this.menuStriplogout.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblemployeeiod
            // 
            this.lblemployeeiod.AutoSize = true;
            this.lblemployeeiod.BackColor = System.Drawing.Color.MistyRose;
            this.lblemployeeiod.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblemployeeiod.ForeColor = System.Drawing.Color.Black;
            this.lblemployeeiod.Location = new System.Drawing.Point(57, 175);
            this.lblemployeeiod.Name = "lblemployeeiod";
            this.lblemployeeiod.Size = new System.Drawing.Size(134, 25);
            this.lblemployeeiod.TabIndex = 0;
            this.lblemployeeiod.Text = "Employee ID";
            // 
            // lblusername
            // 
            this.lblusername.AutoSize = true;
            this.lblusername.BackColor = System.Drawing.Color.MistyRose;
            this.lblusername.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblusername.ForeColor = System.Drawing.Color.Black;
            this.lblusername.Location = new System.Drawing.Point(57, 248);
            this.lblusername.Name = "lblusername";
            this.lblusername.Size = new System.Drawing.Size(119, 25);
            this.lblusername.TabIndex = 1;
            this.lblusername.Text = "User Name";
            // 
            // lblpassword
            // 
            this.lblpassword.AutoSize = true;
            this.lblpassword.BackColor = System.Drawing.Color.MistyRose;
            this.lblpassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpassword.ForeColor = System.Drawing.Color.Black;
            this.lblpassword.Location = new System.Drawing.Point(57, 329);
            this.lblpassword.Name = "lblpassword";
            this.lblpassword.Size = new System.Drawing.Size(106, 25);
            this.lblpassword.TabIndex = 2;
            this.lblpassword.Text = "Password";
            // 
            // txtEId
            // 
            this.txtEId.BackColor = System.Drawing.Color.Bisque;
            this.txtEId.Location = new System.Drawing.Point(254, 179);
            this.txtEId.Name = "txtEId";
            this.txtEId.Size = new System.Drawing.Size(203, 22);
            this.txtEId.TabIndex = 3;
            // 
            // txtUsername
            // 
            this.txtUsername.BackColor = System.Drawing.Color.Bisque;
            this.txtUsername.Location = new System.Drawing.Point(254, 248);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(203, 22);
            this.txtUsername.TabIndex = 4;
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.Color.Bisque;
            this.txtPassword.Location = new System.Drawing.Point(254, 333);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(203, 22);
            this.txtPassword.TabIndex = 5;
            // 
            // dataGridViewAdduser
            // 
            this.dataGridViewAdduser.BackgroundColor = System.Drawing.Color.PapayaWhip;
            this.dataGridViewAdduser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAdduser.Location = new System.Drawing.Point(591, 116);
            this.dataGridViewAdduser.Name = "dataGridViewAdduser";
            this.dataGridViewAdduser.RowHeadersWidth = 51;
            this.dataGridViewAdduser.RowTemplate.Height = 24;
            this.dataGridViewAdduser.Size = new System.Drawing.Size(556, 336);
            this.dataGridViewAdduser.TabIndex = 6;
            this.dataGridViewAdduser.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btnadd
            // 
            this.btnadd.BackColor = System.Drawing.Color.Coral;
            this.btnadd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnadd.Location = new System.Drawing.Point(41, 589);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(122, 43);
            this.btnadd.TabIndex = 7;
            this.btnadd.Text = "Add";
            this.btnadd.UseVisualStyleBackColor = false;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.Coral;
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(293, 589);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(146, 43);
            this.btnClear.TabIndex = 8;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Coral;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(580, 589);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(150, 43);
            this.btnExit.TabIndex = 9;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnview
            // 
            this.btnview.BackColor = System.Drawing.Color.Coral;
            this.btnview.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnview.Location = new System.Drawing.Point(901, 589);
            this.btnview.Name = "btnview";
            this.btnview.Size = new System.Drawing.Size(158, 43);
            this.btnview.TabIndex = 10;
            this.btnview.Text = "View";
            this.btnview.UseVisualStyleBackColor = false;
            this.btnview.Click += new System.EventHandler(this.btnview_Click);
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
            this.eMPLOYEEToolStripMenuItem,
            this.LOGOUTToolStripMenuItem,
            this.lOGINToolStripMenuItem,
            this.dASHBOARDToolStripMenuItem,
            this.rEPORTSToolStripMenuItem});
            this.menuStriplogout.Location = new System.Drawing.Point(0, 0);
            this.menuStriplogout.Name = "menuStriplogout";
            this.menuStriplogout.Size = new System.Drawing.Size(1257, 28);
            this.menuStriplogout.TabIndex = 12;
            this.menuStriplogout.Text = "LOG OUT MENU STRIP";
            this.menuStriplogout.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStriplogout_ItemClicked);
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
            // LOGOUTToolStripMenuItem
            // 
            this.LOGOUTToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LOGOUTToolStripMenuItem.Name = "LOGOUTToolStripMenuItem";
            this.LOGOUTToolStripMenuItem.Size = new System.Drawing.Size(88, 24);
            this.LOGOUTToolStripMenuItem.Text = "LOG OUT";
            this.LOGOUTToolStripMenuItem.Click += new System.EventHandler(this.LOGOUTToolStripMenuItem_Click);
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
            // Add_user
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Sienna;
            this.BackgroundImage = global::project_GUI.Properties.Resources.jayani_cake1;
            this.ClientSize = new System.Drawing.Size(1257, 729);
            this.Controls.Add(this.menuStriplogout);
            this.Controls.Add(this.btnview);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.dataGridViewAdduser);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.txtEId);
            this.Controls.Add(this.lblpassword);
            this.Controls.Add(this.lblusername);
            this.Controls.Add(this.lblemployeeiod);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Add_user";
            this.Text = "Add User";
            this.Load += new System.EventHandler(this.Add_user_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAdduser)).EndInit();
            this.menuStriplogout.ResumeLayout(false);
            this.menuStriplogout.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblemployeeiod;
        private System.Windows.Forms.Label lblusername;
        private System.Windows.Forms.Label lblpassword;
        private System.Windows.Forms.TextBox txtEId;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.DataGridView dataGridViewAdduser;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnview;
        private System.Windows.Forms.MenuStrip menuStriplogout;
        private System.Windows.Forms.ToolStripMenuItem oRDERToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cOUSTOMERToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bIlToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pRODUCTToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eMPLOYEEToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem LOGOUTToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lOGINToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dASHBOARDToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rEPORTSToolStripMenuItem;
    }
}