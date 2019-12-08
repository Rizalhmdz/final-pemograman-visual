namespace Final_Test
{
    partial class Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.panel1 = new System.Windows.Forms.Panel();
            this.TBpw = new System.Windows.Forms.TextBox();
            this.TBuser = new System.Windows.Forms.TextBox();
            this.login = new System.Windows.Forms.Button();
            this.pnlBox = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.pnlBG = new System.Windows.Forms.Panel();
            this.pnlBox.SuspendLayout();
            this.pnlBG.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.Location = new System.Drawing.Point(586, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(0, 0);
            this.panel1.TabIndex = 0;
            // 
            // TBpw
            // 
            this.TBpw.Location = new System.Drawing.Point(99, 169);
            this.TBpw.Name = "TBpw";
            this.TBpw.PasswordChar = '*';
            this.TBpw.Size = new System.Drawing.Size(161, 20);
            this.TBpw.TabIndex = 2;
            // 
            // TBuser
            // 
            this.TBuser.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TBuser.Location = new System.Drawing.Point(99, 123);
            this.TBuser.Name = "TBuser";
            this.TBuser.Size = new System.Drawing.Size(161, 20);
            this.TBuser.TabIndex = 1;
            // 
            // login
            // 
            this.login.BackColor = System.Drawing.Color.Gold;
            this.login.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.login.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.login.FlatAppearance.BorderSize = 0;
            this.login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.login.Font = new System.Drawing.Font("Bebas Neue", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login.ForeColor = System.Drawing.SystemColors.InfoText;
            this.login.Location = new System.Drawing.Point(115, 246);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(125, 30);
            this.login.TabIndex = 1;
            this.login.Text = "Log in";
            this.login.UseVisualStyleBackColor = false;
            this.login.Click += new System.EventHandler(this.button1_Click);
            // 
            // pnlBox
            // 
            this.pnlBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlBox.BackColor = System.Drawing.Color.White;
            this.pnlBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pnlBox.Controls.Add(this.button2);
            this.pnlBox.Controls.Add(this.login);
            this.pnlBox.Controls.Add(this.button1);
            this.pnlBox.Controls.Add(this.TBpw);
            this.pnlBox.Controls.Add(this.TBuser);
            this.pnlBox.Location = new System.Drawing.Point(67, 128);
            this.pnlBox.Name = "pnlBox";
            this.pnlBox.Size = new System.Drawing.Size(350, 350);
            this.pnlBox.TabIndex = 3;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Gold;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Bebas Neue", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(176, 0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(174, 40);
            this.button2.TabIndex = 5;
            this.button2.Text = "Sign Up";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Bebas Neue", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(174, 40);
            this.button1.TabIndex = 4;
            this.button1.Text = "Sign In";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // pnlBG
            // 
            this.pnlBG.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlBG.BackColor = System.Drawing.Color.Transparent;
            this.pnlBG.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlBG.Controls.Add(this.pnlBox);
            this.pnlBG.Location = new System.Drawing.Point(0, 0);
            this.pnlBG.Name = "pnlBG";
            this.pnlBG.Size = new System.Drawing.Size(500, 596);
            this.pnlBG.TabIndex = 3;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(500, 593);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlBG);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Onery";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Home_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pnlBox.ResumeLayout(false);
            this.pnlBox.PerformLayout();
            this.pnlBG.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox TBpw;
        private System.Windows.Forms.TextBox TBuser;
        private System.Windows.Forms.Button login;
        private System.Windows.Forms.Panel pnlBox;
        private System.Windows.Forms.Panel pnlBG;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

