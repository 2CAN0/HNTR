namespace Multi
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.buttonLogin = new LollipopButton();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.textBoxUser = new LollipopTextBox();
            this.textBoxPass = new LollipopTextBox();
            this.lollipopToggle1 = new LollipopToggle();
            this.lollipopLabel1 = new LollipopLabel();
            this.buttonExit = new LollipopButton();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.bunifuDragControl2 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonLogin
            // 
            this.buttonLogin.BackColor = System.Drawing.Color.Transparent;
            this.buttonLogin.BGColor = "Red";
            this.buttonLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonLogin.FontColor = "#ffffff";
            this.buttonLogin.Location = new System.Drawing.Point(71, 322);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(143, 41);
            this.buttonLogin.TabIndex = 0;
            this.buttonLogin.Text = "Login";
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.Image = global::Multi.Properties.Resources.Logo;
            this.pictureBoxLogo.Location = new System.Drawing.Point(48, 65);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(201, 62);
            this.pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxLogo.TabIndex = 1;
            this.pictureBoxLogo.TabStop = false;
            // 
            // textBoxUser
            // 
            this.textBoxUser.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxUser.FocusedColor = "Red";
            this.textBoxUser.FontColor = "#999999";
            this.textBoxUser.IsEnabled = true;
            this.textBoxUser.Location = new System.Drawing.Point(55, 179);
            this.textBoxUser.MaxLength = 32767;
            this.textBoxUser.Multiline = false;
            this.textBoxUser.Name = "textBoxUser";
            this.textBoxUser.ReadOnly = false;
            this.textBoxUser.Size = new System.Drawing.Size(177, 24);
            this.textBoxUser.TabIndex = 2;
            this.textBoxUser.Text = "Username";
            this.textBoxUser.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.textBoxUser.UseSystemPasswordChar = false;
            this.textBoxUser.Click += new System.EventHandler(this.textBoxUser_Click);
            // 
            // textBoxPass
            // 
            this.textBoxPass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.textBoxPass.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxPass.FocusedColor = "Red";
            this.textBoxPass.FontColor = "#999999";
            this.textBoxPass.IsEnabled = true;
            this.textBoxPass.Location = new System.Drawing.Point(55, 221);
            this.textBoxPass.MaxLength = 32767;
            this.textBoxPass.Multiline = false;
            this.textBoxPass.Name = "textBoxPass";
            this.textBoxPass.ReadOnly = false;
            this.textBoxPass.Size = new System.Drawing.Size(177, 24);
            this.textBoxPass.TabIndex = 3;
            this.textBoxPass.Text = "Password";
            this.textBoxPass.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.textBoxPass.UseSystemPasswordChar = false;
            this.textBoxPass.Click += new System.EventHandler(this.textBoxPass_Click);
            // 
            // lollipopToggle1
            // 
            this.lollipopToggle1.AutoSize = true;
            this.lollipopToggle1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lollipopToggle1.EllipseBorderColor = "Red";
            this.lollipopToggle1.EllipseColor = "Red";
            this.lollipopToggle1.Location = new System.Drawing.Point(49, 253);
            this.lollipopToggle1.Name = "lollipopToggle1";
            this.lollipopToggle1.Size = new System.Drawing.Size(47, 19);
            this.lollipopToggle1.TabIndex = 4;
            this.lollipopToggle1.Text = "Remember";
            this.lollipopToggle1.UseVisualStyleBackColor = true;
            // 
            // lollipopLabel1
            // 
            this.lollipopLabel1.AutoSize = true;
            this.lollipopLabel1.BackColor = System.Drawing.Color.Transparent;
            this.lollipopLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lollipopLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.lollipopLabel1.Location = new System.Drawing.Point(94, 252);
            this.lollipopLabel1.Name = "lollipopLabel1";
            this.lollipopLabel1.Size = new System.Drawing.Size(100, 17);
            this.lollipopLabel1.TabIndex = 5;
            this.lollipopLabel1.Text = "Remember Me";
            // 
            // buttonExit
            // 
            this.buttonExit.BackColor = System.Drawing.Color.Transparent;
            this.buttonExit.BGColor = "Red";
            this.buttonExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonExit.FontColor = "#ffffff";
            this.buttonExit.Location = new System.Drawing.Point(273, -2);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(26, 26);
            this.buttonExit.TabIndex = 6;
            this.buttonExit.Text = "X";
            this.buttonExit.Click += new System.EventHandler(this.lollipopButton1_Click);
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this;
            this.bunifuDragControl1.Vertical = true;
            // 
            // bunifuDragControl2
            // 
            this.bunifuDragControl2.Fixed = true;
            this.bunifuDragControl2.Horizontal = true;
            this.bunifuDragControl2.TargetControl = this.pictureBoxLogo;
            this.bunifuDragControl2.Vertical = true;
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 15;
            this.bunifuElipse1.TargetControl = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(297, 389);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.lollipopLabel1);
            this.Controls.Add(this.lollipopToggle1);
            this.Controls.Add(this.textBoxPass);
            this.Controls.Add(this.textBoxUser);
            this.Controls.Add(this.pictureBoxLogo);
            this.Controls.Add(this.buttonLogin);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "HNTR | GUI";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private LollipopButton buttonLogin;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private LollipopTextBox textBoxUser;
        private LollipopTextBox textBoxPass;
        private LollipopToggle lollipopToggle1;
        private LollipopLabel lollipopLabel1;
        private LollipopButton buttonExit;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl2;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
    }
}

