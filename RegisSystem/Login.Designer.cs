
namespace RegisSystem
{
    partial class Login
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
            this.txtusername = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtpassword = new System.Windows.Forms.TextBox();
            this.btnlogin = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.btnx = new System.Windows.Forms.Button();
            this.lusername = new System.Windows.Forms.Label();
            this.lpassword = new System.Windows.Forms.Label();
            this.btnverify = new System.Windows.Forms.Button();
            this.btngenerate = new System.Windows.Forms.Button();
            this.txtcapcha = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelcaptcha = new System.Windows.Forms.Panel();
            this.txtcode = new System.Windows.Forms.TextBox();
            this.btnsubmit = new System.Windows.Forms.Button();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelcaptcha.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtusername
            // 
            this.txtusername.Location = new System.Drawing.Point(62, 85);
            this.txtusername.Name = "txtusername";
            this.txtusername.Size = new System.Drawing.Size(161, 20);
            this.txtusername.TabIndex = 0;
            this.txtusername.Click += new System.EventHandler(this.txtusername_Click);
            this.txtusername.TabIndexChanged += new System.EventHandler(this.txtusername_TabIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(95, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Enter details to login.";
            // 
            // txtpassword
            // 
            this.txtpassword.Location = new System.Drawing.Point(62, 124);
            this.txtpassword.Name = "txtpassword";
            this.txtpassword.Size = new System.Drawing.Size(161, 20);
            this.txtpassword.TabIndex = 1;
            this.txtpassword.Click += new System.EventHandler(this.txtpassword_Click);
            this.txtpassword.TextChanged += new System.EventHandler(this.txtpassword_TextChanged);
            // 
            // btnlogin
            // 
            this.btnlogin.Location = new System.Drawing.Point(98, 170);
            this.btnlogin.Name = "btnlogin";
            this.btnlogin.Size = new System.Drawing.Size(75, 23);
            this.btnlogin.TabIndex = 2;
            this.btnlogin.Text = "Login";
            this.btnlogin.UseVisualStyleBackColor = true;
            this.btnlogin.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(59, 377);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Don\'t have an account? ";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.linkLabel1.Location = new System.Drawing.Point(59, 392);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(74, 13);
            this.linkLabel1.TabIndex = 4;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Register Now!";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // btnx
            // 
            this.btnx.BackColor = System.Drawing.Color.Red;
            this.btnx.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnx.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnx.ForeColor = System.Drawing.Color.White;
            this.btnx.Location = new System.Drawing.Point(277, 2);
            this.btnx.Name = "btnx";
            this.btnx.Size = new System.Drawing.Size(25, 23);
            this.btnx.TabIndex = 5;
            this.btnx.Text = "X";
            this.btnx.UseVisualStyleBackColor = false;
            this.btnx.Click += new System.EventHandler(this.btnx_Click);
            // 
            // lusername
            // 
            this.lusername.AutoSize = true;
            this.lusername.BackColor = System.Drawing.Color.White;
            this.lusername.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lusername.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lusername.Location = new System.Drawing.Point(63, 87);
            this.lusername.Name = "lusername";
            this.lusername.Size = new System.Drawing.Size(65, 15);
            this.lusername.TabIndex = 6;
            this.lusername.Text = "Username";
            this.lusername.Click += new System.EventHandler(this.lusername_Click);
            // 
            // lpassword
            // 
            this.lpassword.AutoSize = true;
            this.lpassword.BackColor = System.Drawing.Color.White;
            this.lpassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lpassword.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lpassword.Location = new System.Drawing.Point(63, 126);
            this.lpassword.Name = "lpassword";
            this.lpassword.Size = new System.Drawing.Size(61, 15);
            this.lpassword.TabIndex = 7;
            this.lpassword.Text = "Password";
            this.lpassword.Click += new System.EventHandler(this.lpassword_Click);
            // 
            // btnverify
            // 
            this.btnverify.Location = new System.Drawing.Point(49, 127);
            this.btnverify.Name = "btnverify";
            this.btnverify.Size = new System.Drawing.Size(75, 23);
            this.btnverify.TabIndex = 31;
            this.btnverify.Text = "Verify";
            this.btnverify.UseVisualStyleBackColor = true;
            this.btnverify.Click += new System.EventHandler(this.btnverify_Click);
            // 
            // btngenerate
            // 
            this.btngenerate.Location = new System.Drawing.Point(19, 69);
            this.btngenerate.Name = "btngenerate";
            this.btngenerate.Size = new System.Drawing.Size(75, 23);
            this.btngenerate.TabIndex = 30;
            this.btngenerate.Text = "Generate";
            this.btngenerate.UseVisualStyleBackColor = true;
            this.btngenerate.Click += new System.EventHandler(this.btngenerate_Click);
            // 
            // txtcapcha
            // 
            this.txtcapcha.Location = new System.Drawing.Point(15, 101);
            this.txtcapcha.Name = "txtcapcha";
            this.txtcapcha.Size = new System.Drawing.Size(161, 20);
            this.txtcapcha.TabIndex = 29;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(19, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(157, 60);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 28;
            this.pictureBox1.TabStop = false;
            // 
            // panelcaptcha
            // 
            this.panelcaptcha.Controls.Add(this.btnverify);
            this.panelcaptcha.Controls.Add(this.btngenerate);
            this.panelcaptcha.Controls.Add(this.txtcapcha);
            this.panelcaptcha.Controls.Add(this.pictureBox1);
            this.panelcaptcha.Location = new System.Drawing.Point(43, 197);
            this.panelcaptcha.Name = "panelcaptcha";
            this.panelcaptcha.Size = new System.Drawing.Size(190, 159);
            this.panelcaptcha.TabIndex = 32;
            // 
            // txtcode
            // 
            this.txtcode.Location = new System.Drawing.Point(48, 59);
            this.txtcode.Name = "txtcode";
            this.txtcode.Size = new System.Drawing.Size(189, 20);
            this.txtcode.TabIndex = 33;
            // 
            // btnsubmit
            // 
            this.btnsubmit.Location = new System.Drawing.Point(98, 84);
            this.btnsubmit.Name = "btnsubmit";
            this.btnsubmit.Size = new System.Drawing.Size(75, 23);
            this.btnsubmit.TabIndex = 34;
            this.btnsubmit.Text = "Submit";
            this.btnsubmit.UseVisualStyleBackColor = true;
            this.btnsubmit.Click += new System.EventHandler(this.btnsubmit_Click);
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.linkLabel2.Location = new System.Drawing.Point(63, 147);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(92, 13);
            this.linkLabel2.TabIndex = 35;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "Forgot Password?";
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumPurple;
            this.ClientSize = new System.Drawing.Size(303, 450);
            this.Controls.Add(this.linkLabel2);
            this.Controls.Add(this.btnsubmit);
            this.Controls.Add(this.txtcode);
            this.Controls.Add(this.panelcaptcha);
            this.Controls.Add(this.lpassword);
            this.Controls.Add(this.lusername);
            this.Controls.Add(this.btnx);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnlogin);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtpassword);
            this.Controls.Add(this.txtusername);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelcaptcha.ResumeLayout(false);
            this.panelcaptcha.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtusername;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtpassword;
        private System.Windows.Forms.Button btnlogin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Button btnx;
        private System.Windows.Forms.Label lusername;
        private System.Windows.Forms.Label lpassword;
        private System.Windows.Forms.Button btnverify;
        private System.Windows.Forms.Button btngenerate;
        private System.Windows.Forms.TextBox txtcapcha;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panelcaptcha;
        private System.Windows.Forms.TextBox txtcode;
        private System.Windows.Forms.Button btnsubmit;
        private System.Windows.Forms.LinkLabel linkLabel2;
    }
}