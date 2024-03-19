
namespace RegisSystem
{
    partial class Register
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
            this.btnx = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label2 = new System.Windows.Forms.Label();
            this.btnsignup = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtusername = new System.Windows.Forms.TextBox();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.txtpassword = new System.Windows.Forms.TextBox();
            this.lpassword = new System.Windows.Forms.Label();
            this.lusername = new System.Windows.Forms.Label();
            this.lconfirmpassword = new System.Windows.Forms.Label();
            this.lemail = new System.Windows.Forms.Label();
            this.txtconfirmpass = new System.Windows.Forms.TextBox();
            this.panelwhy = new System.Windows.Forms.Panel();
            this.lsymbol = new System.Windows.Forms.Label();
            this.ldigit = new System.Windows.Forms.Label();
            this.llower = new System.Windows.Forms.Label();
            this.lupper = new System.Windows.Forms.Label();
            this.llength = new System.Windows.Forms.Label();
            this.btnwhy = new System.Windows.Forms.Button();
            this.lxemail = new System.Windows.Forms.Label();
            this.lxusername = new System.Windows.Forms.Label();
            this.lxpassword = new System.Windows.Forms.Label();
            this.lxconfirm = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider3 = new System.Windows.Forms.ErrorProvider(this.components);
            this.txtmeter = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtcapcha = new System.Windows.Forms.TextBox();
            this.btngenerate = new System.Windows.Forms.Button();
            this.btnverify = new System.Windows.Forms.Button();
            this.panelcaptcha = new System.Windows.Forms.Panel();
            this.checkBoxpolicy = new System.Windows.Forms.CheckBox();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.panelwhy.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelcaptcha.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnx
            // 
            this.btnx.BackColor = System.Drawing.Color.Red;
            this.btnx.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnx.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnx.ForeColor = System.Drawing.Color.White;
            this.btnx.Location = new System.Drawing.Point(364, 2);
            this.btnx.Name = "btnx";
            this.btnx.Size = new System.Drawing.Size(25, 23);
            this.btnx.TabIndex = 12;
            this.btnx.Text = "X";
            this.btnx.UseVisualStyleBackColor = false;
            this.btnx.Click += new System.EventHandler(this.btnx_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.linkLabel1.Location = new System.Drawing.Point(24, 410);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(61, 13);
            this.linkLabel1.TabIndex = 11;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Login Now!";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(24, 388);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Already have an account? ";
            // 
            // btnsignup
            // 
            this.btnsignup.Location = new System.Drawing.Point(28, 274);
            this.btnsignup.Name = "btnsignup";
            this.btnsignup.Size = new System.Drawing.Size(75, 23);
            this.btnsignup.TabIndex = 9;
            this.btnsignup.Text = "Signup";
            this.btnsignup.UseVisualStyleBackColor = true;
            this.btnsignup.Click += new System.EventHandler(this.btnsignup_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(95, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Enter details to login.";
            // 
            // txtusername
            // 
            this.txtusername.Location = new System.Drawing.Point(28, 122);
            this.txtusername.Name = "txtusername";
            this.txtusername.Size = new System.Drawing.Size(161, 20);
            this.txtusername.TabIndex = 1;
            this.txtusername.Click += new System.EventHandler(this.txtusername_Click);
            this.txtusername.TextChanged += new System.EventHandler(this.txtusername_TextChanged);
            this.txtusername.Leave += new System.EventHandler(this.txtusername_Leave);
            // 
            // txtemail
            // 
            this.txtemail.Location = new System.Drawing.Point(28, 76);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(161, 20);
            this.txtemail.TabIndex = 0;
            this.txtemail.Click += new System.EventHandler(this.txtemail_Click);
            this.txtemail.TextChanged += new System.EventHandler(this.txtemail_TextChanged);
            this.txtemail.Leave += new System.EventHandler(this.txtemail_Leave);
            // 
            // txtpassword
            // 
            this.txtpassword.Location = new System.Drawing.Point(28, 167);
            this.txtpassword.Name = "txtpassword";
            this.txtpassword.Size = new System.Drawing.Size(161, 20);
            this.txtpassword.TabIndex = 2;
            this.txtpassword.Click += new System.EventHandler(this.txtpassword_Click);
            this.txtpassword.TextChanged += new System.EventHandler(this.txtpassword_TextChanged);
            this.txtpassword.Leave += new System.EventHandler(this.txtpassword_Leave);
            // 
            // lpassword
            // 
            this.lpassword.AutoSize = true;
            this.lpassword.BackColor = System.Drawing.Color.White;
            this.lpassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lpassword.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lpassword.Location = new System.Drawing.Point(30, 169);
            this.lpassword.Name = "lpassword";
            this.lpassword.Size = new System.Drawing.Size(61, 15);
            this.lpassword.TabIndex = 14;
            this.lpassword.Text = "Password";
            this.lpassword.Click += new System.EventHandler(this.lpassword_Click);
            // 
            // lusername
            // 
            this.lusername.AutoSize = true;
            this.lusername.BackColor = System.Drawing.Color.White;
            this.lusername.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lusername.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lusername.Location = new System.Drawing.Point(29, 124);
            this.lusername.Name = "lusername";
            this.lusername.Size = new System.Drawing.Size(65, 15);
            this.lusername.TabIndex = 13;
            this.lusername.Text = "Username";
            this.lusername.Click += new System.EventHandler(this.lusername_Click);
            // 
            // lconfirmpassword
            // 
            this.lconfirmpassword.AutoSize = true;
            this.lconfirmpassword.BackColor = System.Drawing.Color.White;
            this.lconfirmpassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lconfirmpassword.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lconfirmpassword.Location = new System.Drawing.Point(29, 214);
            this.lconfirmpassword.Name = "lconfirmpassword";
            this.lconfirmpassword.Size = new System.Drawing.Size(107, 15);
            this.lconfirmpassword.TabIndex = 16;
            this.lconfirmpassword.Text = "Confirm Password";
            this.lconfirmpassword.Click += new System.EventHandler(this.lconfirmpassword_Click);
            // 
            // lemail
            // 
            this.lemail.AutoSize = true;
            this.lemail.BackColor = System.Drawing.Color.White;
            this.lemail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lemail.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lemail.Location = new System.Drawing.Point(31, 78);
            this.lemail.Name = "lemail";
            this.lemail.Size = new System.Drawing.Size(43, 15);
            this.lemail.TabIndex = 15;
            this.lemail.Text = "E-mail";
            this.lemail.Click += new System.EventHandler(this.lemail_Click);
            // 
            // txtconfirmpass
            // 
            this.txtconfirmpass.Location = new System.Drawing.Point(28, 212);
            this.txtconfirmpass.Name = "txtconfirmpass";
            this.txtconfirmpass.Size = new System.Drawing.Size(161, 20);
            this.txtconfirmpass.TabIndex = 3;
            this.txtconfirmpass.Click += new System.EventHandler(this.txtconfirmpass_Click);
            this.txtconfirmpass.TextChanged += new System.EventHandler(this.txtconfirmpass_TextChanged);
            this.txtconfirmpass.Leave += new System.EventHandler(this.txtconfirmpass_Leave);
            // 
            // panelwhy
            // 
            this.panelwhy.BackColor = System.Drawing.Color.Transparent;
            this.panelwhy.Controls.Add(this.lsymbol);
            this.panelwhy.Controls.Add(this.ldigit);
            this.panelwhy.Controls.Add(this.llower);
            this.panelwhy.Controls.Add(this.lupper);
            this.panelwhy.Controls.Add(this.llength);
            this.panelwhy.Location = new System.Drawing.Point(217, 116);
            this.panelwhy.Name = "panelwhy";
            this.panelwhy.Size = new System.Drawing.Size(172, 103);
            this.panelwhy.TabIndex = 17;
            this.panelwhy.Paint += new System.Windows.Forms.PaintEventHandler(this.panelwhy_Paint);
            // 
            // lsymbol
            // 
            this.lsymbol.BackColor = System.Drawing.Color.Thistle;
            this.lsymbol.Location = new System.Drawing.Point(3, 72);
            this.lsymbol.Name = "lsymbol";
            this.lsymbol.Size = new System.Drawing.Size(165, 16);
            this.lsymbol.TabIndex = 4;
            this.lsymbol.Text = "Must have atlease 1 Symbol";
            // 
            // ldigit
            // 
            this.ldigit.BackColor = System.Drawing.Color.Thistle;
            this.ldigit.Location = new System.Drawing.Point(3, 55);
            this.ldigit.Name = "ldigit";
            this.ldigit.Size = new System.Drawing.Size(165, 16);
            this.ldigit.TabIndex = 3;
            this.ldigit.Text = "Must have atlease 1 Digit";
            // 
            // llower
            // 
            this.llower.BackColor = System.Drawing.Color.Thistle;
            this.llower.Location = new System.Drawing.Point(3, 38);
            this.llower.Name = "llower";
            this.llower.Size = new System.Drawing.Size(165, 16);
            this.llower.TabIndex = 2;
            this.llower.Text = "Must have atlease 1 Lowercase";
            // 
            // lupper
            // 
            this.lupper.BackColor = System.Drawing.Color.Thistle;
            this.lupper.Location = new System.Drawing.Point(3, 20);
            this.lupper.Name = "lupper";
            this.lupper.Size = new System.Drawing.Size(165, 16);
            this.lupper.TabIndex = 1;
            this.lupper.Text = "Must have atlease 1 Uppercase letter";
            // 
            // llength
            // 
            this.llength.BackColor = System.Drawing.Color.Thistle;
            this.llength.Location = new System.Drawing.Point(3, 3);
            this.llength.Name = "llength";
            this.llength.Size = new System.Drawing.Size(165, 16);
            this.llength.TabIndex = 0;
            this.llength.Text = "Must be atleast 8 characters long";
            // 
            // btnwhy
            // 
            this.btnwhy.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnwhy.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnwhy.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnwhy.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnwhy.Location = new System.Drawing.Point(195, 167);
            this.btnwhy.Name = "btnwhy";
            this.btnwhy.Size = new System.Drawing.Size(16, 20);
            this.btnwhy.TabIndex = 18;
            this.btnwhy.Text = "?";
            this.btnwhy.UseVisualStyleBackColor = false;
            this.btnwhy.Click += new System.EventHandler(this.btnwhy_Click);
            // 
            // lxemail
            // 
            this.lxemail.AutoSize = true;
            this.lxemail.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lxemail.Location = new System.Drawing.Point(31, 60);
            this.lxemail.Name = "lxemail";
            this.lxemail.Size = new System.Drawing.Size(69, 13);
            this.lxemail.TabIndex = 19;
            this.lxemail.Text = "Invalid Email!";
            // 
            // lxusername
            // 
            this.lxusername.AutoSize = true;
            this.lxusername.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lxusername.Location = new System.Drawing.Point(28, 106);
            this.lxusername.Name = "lxusername";
            this.lxusername.Size = new System.Drawing.Size(131, 13);
            this.lxusername.TabIndex = 20;
            this.lxusername.Text = "Username inuse or invalid!";
            // 
            // lxpassword
            // 
            this.lxpassword.AutoSize = true;
            this.lxpassword.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lxpassword.Location = new System.Drawing.Point(28, 154);
            this.lxpassword.Name = "lxpassword";
            this.lxpassword.Size = new System.Drawing.Size(89, 13);
            this.lxpassword.TabIndex = 21;
            this.lxpassword.Text = "Password invalid!";
            // 
            // lxconfirm
            // 
            this.lxconfirm.AutoSize = true;
            this.lxconfirm.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lxconfirm.Location = new System.Drawing.Point(28, 196);
            this.lxconfirm.Name = "lxconfirm";
            this.lxconfirm.Size = new System.Drawing.Size(120, 13);
            this.lxconfirm.TabIndex = 22;
            this.lxconfirm.Text = "Password not matching!";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // errorProvider2
            // 
            this.errorProvider2.ContainerControl = this;
            // 
            // errorProvider3
            // 
            this.errorProvider3.ContainerControl = this;
            // 
            // txtmeter
            // 
            this.txtmeter.Location = new System.Drawing.Point(28, 248);
            this.txtmeter.Name = "txtmeter";
            this.txtmeter.ReadOnly = true;
            this.txtmeter.Size = new System.Drawing.Size(161, 20);
            this.txtmeter.TabIndex = 23;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(5, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(157, 60);
            this.pictureBox1.TabIndex = 24;
            this.pictureBox1.TabStop = false;
            // 
            // txtcapcha
            // 
            this.txtcapcha.Location = new System.Drawing.Point(1, 102);
            this.txtcapcha.Name = "txtcapcha";
            this.txtcapcha.Size = new System.Drawing.Size(161, 20);
            this.txtcapcha.TabIndex = 25;
            this.txtcapcha.TextChanged += new System.EventHandler(this.txtcapcha_TextChanged);
            // 
            // btngenerate
            // 
            this.btngenerate.Location = new System.Drawing.Point(5, 70);
            this.btngenerate.Name = "btngenerate";
            this.btngenerate.Size = new System.Drawing.Size(75, 23);
            this.btngenerate.TabIndex = 26;
            this.btngenerate.Text = "Generate";
            this.btngenerate.UseVisualStyleBackColor = true;
            this.btngenerate.Click += new System.EventHandler(this.btngenerate_Click);
            // 
            // btnverify
            // 
            this.btnverify.Location = new System.Drawing.Point(35, 128);
            this.btnverify.Name = "btnverify";
            this.btnverify.Size = new System.Drawing.Size(75, 23);
            this.btnverify.TabIndex = 27;
            this.btnverify.Text = "Verify";
            this.btnverify.UseVisualStyleBackColor = true;
            this.btnverify.Click += new System.EventHandler(this.btnverify_Click);
            // 
            // panelcaptcha
            // 
            this.panelcaptcha.Controls.Add(this.btnverify);
            this.panelcaptcha.Controls.Add(this.btngenerate);
            this.panelcaptcha.Controls.Add(this.txtcapcha);
            this.panelcaptcha.Controls.Add(this.pictureBox1);
            this.panelcaptcha.Location = new System.Drawing.Point(217, 234);
            this.panelcaptcha.Name = "panelcaptcha";
            this.panelcaptcha.Size = new System.Drawing.Size(165, 167);
            this.panelcaptcha.TabIndex = 28;
            // 
            // checkBoxpolicy
            // 
            this.checkBoxpolicy.ForeColor = System.Drawing.Color.Yellow;
            this.checkBoxpolicy.Location = new System.Drawing.Point(27, 309);
            this.checkBoxpolicy.Name = "checkBoxpolicy";
            this.checkBoxpolicy.Size = new System.Drawing.Size(184, 31);
            this.checkBoxpolicy.TabIndex = 29;
            this.checkBoxpolicy.Text = "I accept the terms of Buy In\'s policies.";
            this.checkBoxpolicy.UseVisualStyleBackColor = true;
            this.checkBoxpolicy.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.linkLabel2.Location = new System.Drawing.Point(42, 343);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(90, 13);
            this.linkLabel2.TabIndex = 30;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "View Policy Here!";
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumPurple;
            this.ClientSize = new System.Drawing.Size(392, 450);
            this.Controls.Add(this.linkLabel2);
            this.Controls.Add(this.checkBoxpolicy);
            this.Controls.Add(this.panelcaptcha);
            this.Controls.Add(this.txtmeter);
            this.Controls.Add(this.lxconfirm);
            this.Controls.Add(this.lxpassword);
            this.Controls.Add(this.lxusername);
            this.Controls.Add(this.lxemail);
            this.Controls.Add(this.btnwhy);
            this.Controls.Add(this.panelwhy);
            this.Controls.Add(this.lconfirmpassword);
            this.Controls.Add(this.lemail);
            this.Controls.Add(this.lpassword);
            this.Controls.Add(this.lusername);
            this.Controls.Add(this.btnx);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnsignup);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtconfirmpass);
            this.Controls.Add(this.txtpassword);
            this.Controls.Add(this.txtusername);
            this.Controls.Add(this.txtemail);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Register";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Register_Load);
            this.Click += new System.EventHandler(this.Register_Click);
            this.panelwhy.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelcaptcha.ResumeLayout(false);
            this.panelcaptcha.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnx;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnsignup;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtusername;
        private System.Windows.Forms.TextBox txtemail;
        private System.Windows.Forms.TextBox txtpassword;
        private System.Windows.Forms.Label lpassword;
        private System.Windows.Forms.Label lusername;
        private System.Windows.Forms.Label lconfirmpassword;
        private System.Windows.Forms.Label lemail;
        private System.Windows.Forms.TextBox txtconfirmpass;
        private System.Windows.Forms.Panel panelwhy;
        private System.Windows.Forms.Button btnwhy;
        private System.Windows.Forms.Label lxemail;
        private System.Windows.Forms.Label lxusername;
        private System.Windows.Forms.Label lxpassword;
        private System.Windows.Forms.Label lxconfirm;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider errorProvider2;
        private System.Windows.Forms.ErrorProvider errorProvider3;
        private System.Windows.Forms.TextBox txtmeter;
        private System.Windows.Forms.Button btnverify;
        private System.Windows.Forms.Button btngenerate;
        private System.Windows.Forms.TextBox txtcapcha;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panelcaptcha;
        private System.Windows.Forms.Label lsymbol;
        private System.Windows.Forms.Label ldigit;
        private System.Windows.Forms.Label llower;
        private System.Windows.Forms.Label lupper;
        private System.Windows.Forms.Label llength;
        private System.Windows.Forms.CheckBox checkBoxpolicy;
        private System.Windows.Forms.LinkLabel linkLabel2;
    }
}