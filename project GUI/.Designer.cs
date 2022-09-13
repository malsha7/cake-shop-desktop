
namespace project_GUI
{
    partial class frmLoading
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
            this.btnOk = new System.Windows.Forms.Button();
            this.lblwelcome = new System.Windows.Forms.Label();
            this.lblcake = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnOk
            // 
            this.btnOk.BackColor = System.Drawing.Color.Coral;
            this.btnOk.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOk.Location = new System.Drawing.Point(834, 582);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(304, 69);
            this.btnOk.TabIndex = 0;
            this.btnOk.Text = "Click Here....";
            this.btnOk.UseVisualStyleBackColor = false;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // lblwelcome
            // 
            this.lblwelcome.AutoSize = true;
            this.lblwelcome.BackColor = System.Drawing.Color.Coral;
            this.lblwelcome.Font = new System.Drawing.Font("Monotype Corsiva", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblwelcome.Location = new System.Drawing.Point(82, 24);
            this.lblwelcome.Name = "lblwelcome";
            this.lblwelcome.Size = new System.Drawing.Size(913, 97);
            this.lblwelcome.TabIndex = 1;
            this.lblwelcome.Text = "WELCOME TO Jay\'s Art....!";
            // 
            // lblcake
            // 
            this.lblcake.AutoSize = true;
            this.lblcake.BackColor = System.Drawing.Color.MistyRose;
            this.lblcake.Font = new System.Drawing.Font("Monotype Corsiva", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcake.Location = new System.Drawing.Point(40, 568);
            this.lblcake.Name = "lblcake";
            this.lblcake.Size = new System.Drawing.Size(366, 72);
            this.lblcake.TabIndex = 3;
            this.lblcake.Text = "CAKE IS ART";
            // 
            // frmLoading
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Sienna;
            this.BackgroundImage = global::project_GUI.Properties.Resources.jayani_cake;
            this.ClientSize = new System.Drawing.Size(1207, 732);
            this.Controls.Add(this.lblcake);
            this.Controls.Add(this.lblwelcome);
            this.Controls.Add(this.btnOk);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmLoading";
            this.Text = "LOADING";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Label lblwelcome;
        private System.Windows.Forms.Label lblcake;
    }
}

