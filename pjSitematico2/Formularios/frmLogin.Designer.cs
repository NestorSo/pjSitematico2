namespace pjSitematico2.Formularios
{
    partial class frmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.Home = new System.Windows.Forms.Panel();
            this.pExit = new System.Windows.Forms.PictureBox();
            this.pMinimized = new System.Windows.Forms.PictureBox();
            this.btnAcceder = new System.Windows.Forms.Button();
            this.Home.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pExit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pMinimized)).BeginInit();
            this.SuspendLayout();
            // 
            // Home
            // 
            this.Home.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(106)))), ((int)(((byte)(94)))));
            this.Home.Controls.Add(this.pExit);
            this.Home.Controls.Add(this.pMinimized);
            this.Home.Dock = System.Windows.Forms.DockStyle.Top;
            this.Home.Location = new System.Drawing.Point(0, 0);
            this.Home.Name = "Home";
            this.Home.Size = new System.Drawing.Size(389, 40);
            this.Home.TabIndex = 0;
            this.Home.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Home_MouseDown);
            // 
            // pExit
            // 
            this.pExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pExit.Image = ((System.Drawing.Image)(resources.GetObject("pExit.Image")));
            this.pExit.Location = new System.Drawing.Point(352, 8);
            this.pExit.Name = "pExit";
            this.pExit.Size = new System.Drawing.Size(25, 25);
            this.pExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pExit.TabIndex = 2;
            this.pExit.TabStop = false;
            this.pExit.Click += new System.EventHandler(this.pExit_Click);
            // 
            // pMinimized
            // 
            this.pMinimized.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pMinimized.Image = ((System.Drawing.Image)(resources.GetObject("pMinimized.Image")));
            this.pMinimized.Location = new System.Drawing.Point(297, 8);
            this.pMinimized.Name = "pMinimized";
            this.pMinimized.Size = new System.Drawing.Size(25, 25);
            this.pMinimized.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pMinimized.TabIndex = 1;
            this.pMinimized.TabStop = false;
            this.pMinimized.Click += new System.EventHandler(this.pMinimized_Click);
            // 
            // btnAcceder
            // 
            this.btnAcceder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAcceder.FlatAppearance.BorderSize = 0;
            this.btnAcceder.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(69)))), ((int)(((byte)(61)))));
            this.btnAcceder.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(106)))), ((int)(((byte)(94)))));
            this.btnAcceder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAcceder.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAcceder.Location = new System.Drawing.Point(120, 405);
            this.btnAcceder.Name = "btnAcceder";
            this.btnAcceder.Size = new System.Drawing.Size(143, 34);
            this.btnAcceder.TabIndex = 1;
            this.btnAcceder.Text = "ACCEDER";
            this.btnAcceder.UseVisualStyleBackColor = true;
            this.btnAcceder.Click += new System.EventHandler(this.btnAcceder_Click);
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(128)))), ((int)(((byte)(114)))));
            this.ClientSize = new System.Drawing.Size(389, 503);
            this.Controls.Add(this.btnAcceder);
            this.Controls.Add(this.Home);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmLogin";
            this.Text = "frmLogin";
            this.Home.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pExit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pMinimized)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel Home;
        private PictureBox pExit;
        private PictureBox pMinimized;
        private Button btnAcceder;
    }
}