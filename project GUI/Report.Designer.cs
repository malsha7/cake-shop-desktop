
namespace project_GUI
{
    partial class Report
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
            this.dataGridViewreport = new System.Windows.Forms.DataGridView();
            this.btnreport = new System.Windows.Forms.Button();
            this.menuStripreports = new System.Windows.Forms.MenuStrip();
            this.oRDERToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cOUSTOMERToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bIlToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pRODUCTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eMPLOYEEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aDDUSERToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lOGINToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dASHBOARDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rEPORTSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewreport)).BeginInit();
            this.menuStripreports.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewreport
            // 
            this.dataGridViewreport.BackgroundColor = System.Drawing.Color.PapayaWhip;
            this.dataGridViewreport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewreport.Location = new System.Drawing.Point(12, 77);
            this.dataGridViewreport.Name = "dataGridViewreport";
            this.dataGridViewreport.RowHeadersWidth = 51;
            this.dataGridViewreport.RowTemplate.Height = 24;
            this.dataGridViewreport.Size = new System.Drawing.Size(652, 377);
            this.dataGridViewreport.TabIndex = 0;
            // 
            // btnreport
            // 
            this.btnreport.BackColor = System.Drawing.Color.Coral;
            this.btnreport.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnreport.Location = new System.Drawing.Point(720, 520);
            this.btnreport.Name = "btnreport";
            this.btnreport.Size = new System.Drawing.Size(207, 39);
            this.btnreport.TabIndex = 1;
            this.btnreport.Text = "VIEW REPORT";
            this.btnreport.UseVisualStyleBackColor = false;
            this.btnreport.Click += new System.EventHandler(this.button1_Click);
            // 
            // menuStripreports
            // 
            this.menuStripreports.BackColor = System.Drawing.Color.LightSalmon;
            this.menuStripreports.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStripreports.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.oRDERToolStripMenuItem,
            this.cOUSTOMERToolStripMenuItem,
            this.bIlToolStripMenuItem,
            this.pRODUCTToolStripMenuItem,
            this.eMPLOYEEToolStripMenuItem,
            this.aDDUSERToolStripMenuItem,
            this.lOGINToolStripMenuItem,
            this.dASHBOARDToolStripMenuItem,
            this.rEPORTSToolStripMenuItem});
            this.menuStripreports.Location = new System.Drawing.Point(0, 0);
            this.menuStripreports.Name = "menuStripreports";
            this.menuStripreports.Size = new System.Drawing.Size(988, 28);
            this.menuStripreports.TabIndex = 8;
            this.menuStripreports.Text = "Reports MENU STRIP";
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
            this.rEPORTSToolStripMenuItem.Text = "LOG OUT";
            this.rEPORTSToolStripMenuItem.Click += new System.EventHandler(this.rEPORTSToolStripMenuItem_Click);
            // 
            // Report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Sienna;
            this.BackgroundImage = global::project_GUI.Properties.Resources.jayani_cake1;
            this.ClientSize = new System.Drawing.Size(988, 593);
            this.Controls.Add(this.menuStripreports);
            this.Controls.Add(this.btnreport);
            this.Controls.Add(this.dataGridViewreport);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Report";
            this.Text = "Report";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewreport)).EndInit();
            this.menuStripreports.ResumeLayout(false);
            this.menuStripreports.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewreport;
        private System.Windows.Forms.Button btnreport;
        private System.Windows.Forms.MenuStrip menuStripreports;
        private System.Windows.Forms.ToolStripMenuItem oRDERToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cOUSTOMERToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bIlToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pRODUCTToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eMPLOYEEToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aDDUSERToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lOGINToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dASHBOARDToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rEPORTSToolStripMenuItem;
    }
}