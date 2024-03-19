namespace RegisSystem
{
    partial class forgot
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
            this.btnsubmit = new System.Windows.Forms.Button();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.btnx = new System.Windows.Forms.Button();
            this.btnverify = new System.Windows.Forms.Button();
            this.txtcode = new System.Windows.Forms.TextBox();
            this.txtconfirmpass = new System.Windows.Forms.TextBox();
            this.txtpassword = new System.Windows.Forms.TextBox();
            this.btnreset = new System.Windows.Forms.Button();
            this.lxemail = new System.Windows.Forms.Label();
            this.lxcode = new System.Windows.Forms.Label();
            this.txtmeter = new System.Windows.Forms.TextBox();
            this.lconfirmpassword = new System.Windows.Forms.Label();
            this.lpassword = new System.Windows.Forms.Label();
            this.lxconfirm = new System.Windows.Forms.Label();
            this.lxpassword = new System.Windows.Forms.Label();
            this.btnwhy = new System.Windows.Forms.Button();
            this.panelwhy = new System.Windows.Forms.Panel();
            this.lsymbol = new System.Windows.Forms.Label();
            this.ldigit = new System.Windows.Forms.Label();
            this.llower = new System.Windows.Forms.Label();
            this.lupper = new System.Windows.Forms.Label();
            this.llength = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.panelwhy.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnsubmit
            // 
            this.btnsubmit.Location = new System.Drawing.Point(144, 73);
            this.btnsubmit.Name = "btnsubmit";
            this.btnsubmit.Size = new System.Drawing.Size(75, 23);
            this.btnsubmit.TabIndex = 36;
            this.btnsubmit.Text = "Submit";
            this.btnsubmit.UseVisualStyleBackColor = true;
            this.btnsubmit.Click += new System.EventHandler(this.btnsubmit_Click);
            // 
            // txtemail
            // 
            this.txtemail.Location = new System.Drawing.Point(94, 48);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(189, 20);
            this.txtemail.TabIndex = 35;
            this.txtemail.TextChanged += new System.EventHandler(this.txtemail_TextChanged);
            // 
            // btnx
            // 
            this.btnx.BackColor = System.Drawing.Color.Red;
            this.btnx.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnx.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnx.ForeColor = System.Drawing.Color.White;
            this.btnx.Location = new System.Drawing.Point(380, 1);
            this.btnx.Name = "btnx";
            this.btnx.Size = new System.Drawing.Size(25, 23);
            this.btnx.TabIndex = 37;
            this.btnx.Text = "X";
            this.btnx.UseVisualStyleBackColor = false;
            this.btnx.Click += new System.EventHandler(this.btnx_Click);
            // 
            // btnverify
            // 
            this.btnverify.Location = new System.Drawing.Point(144, 138);
            this.btnverify.Name = "btnverify";
            this.btnverify.Size = new System.Drawing.Size(75, 23);
            this.btnverify.TabIndex = 39;
            this.btnverify.Text = "Verify";
            this.btnverify.UseVisualStyleBackColor = true;
            this.btnverify.Click += new System.EventHandler(this.btnverify_Click);
            // 
            // txtcode
            // 
            this.txtcode.Location = new System.Drawing.Point(94, 113);
            this.txtcode.Name = "txtcode";
            this.txtcode.Size = new System.Drawing.Size(189, 20);
            this.txtcode.TabIndex = 38;
            // 
            // txtconfirmpass
            // 
            this.txtconfirmpass.Location = new System.Drawing.Point(35, 106);
            this.txtconfirmpass.Name = "txtconfirmpass";
            this.txtconfirmpass.Size = new System.Drawing.Size(161, 20);
            this.txtconfirmpass.TabIndex = 41;
            this.txtconfirmpass.Click += new System.EventHandler(this.txtconfirmpass_Click);
            this.txtconfirmpass.TextChanged += new System.EventHandler(this.txtconfirmpass_TextChanged);
            // 
            // txtpassword
            // 
            this.txtpassword.Location = new System.Drawing.Point(35, 61);
            this.txtpassword.Name = "txtpassword";
            this.txtpassword.Size = new System.Drawing.Size(161, 20);
            this.txtpassword.TabIndex = 40;
            this.txtpassword.Click += new System.EventHandler(this.txtpassword_Click);
            this.txtpassword.TextChanged += new System.EventHandler(this.txtpassword_TextChanged);
            // 
            // btnreset
            // 
            this.btnreset.Location = new System.Drawing.Point(75, 158);
            this.btnreset.Name = "btnreset";
            this.btnreset.Size = new System.Drawing.Size(75, 23);
            this.btnreset.TabIndex = 42;
            this.btnreset.Text = "Reset";
            this.btnreset.UseVisualStyleBackColor = true;
            this.btnreset.Click += new System.EventHandler(this.btnreset_Click);
            // 
            // lxemail
            // 
            this.lxemail.AutoSize = true;
            this.lxemail.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lxemail.Location = new System.Drawing.Point(95, 32);
            this.lxemail.Name = "lxemail";
            this.lxemail.Size = new System.Drawing.Size(82, 13);
            this.lxemail.TabIndex = 43;
            this.lxemail.Text = "Enter your email";
            // 
            // lxcode
            // 
            this.lxcode.AutoSize = true;
            this.lxcode.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lxcode.Location = new System.Drawing.Point(95, 99);
            this.lxcode.Name = "lxcode";
            this.lxcode.Size = new System.Drawing.Size(59, 13);
            this.lxcode.TabIndex = 44;
            this.lxcode.Text = "Enter code";
            // 
            // txtmeter
            // 
            this.txtmeter.Location = new System.Drawing.Point(35, 132);
            this.txtmeter.Name = "txtmeter";
            this.txtmeter.ReadOnly = true;
            this.txtmeter.Size = new System.Drawing.Size(161, 20);
            this.txtmeter.TabIndex = 47;
            // 
            // lconfirmpassword
            // 
            this.lconfirmpassword.AutoSize = true;
            this.lconfirmpassword.BackColor = System.Drawing.Color.White;
            this.lconfirmpassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lconfirmpassword.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lconfirmpassword.Location = new System.Drawing.Point(36, 109);
            this.lconfirmpassword.Name = "lconfirmpassword";
            this.lconfirmpassword.Size = new System.Drawing.Size(107, 15);
            this.lconfirmpassword.TabIndex = 49;
            this.lconfirmpassword.Text = "Confirm Password";
            this.lconfirmpassword.Click += new System.EventHandler(this.lconfirmpassword_Click);
            // 
            // lpassword
            // 
            this.lpassword.AutoSize = true;
            this.lpassword.BackColor = System.Drawing.Color.White;
            this.lpassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lpassword.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lpassword.Location = new System.Drawing.Point(37, 64);
            this.lpassword.Name = "lpassword";
            this.lpassword.Size = new System.Drawing.Size(61, 15);
            this.lpassword.TabIndex = 48;
            this.lpassword.Text = "Password";
            this.lpassword.Click += new System.EventHandler(this.lpassword_Click);
            // 
            // lxconfirm
            // 
            this.lxconfirm.AutoSize = true;
            this.lxconfirm.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lxconfirm.Location = new System.Drawing.Point(36, 93);
            this.lxconfirm.Name = "lxconfirm";
            this.lxconfirm.Size = new System.Drawing.Size(120, 13);
            this.lxconfirm.TabIndex = 51;
            this.lxconfirm.Text = "Password not matching!";
            // 
            // lxpassword
            // 
            this.lxpassword.AutoSize = true;
            this.lxpassword.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lxpassword.Location = new System.Drawing.Point(35, 48);
            this.lxpassword.Name = "lxpassword";
            this.lxpassword.Size = new System.Drawing.Size(89, 13);
            this.lxpassword.TabIndex = 50;
            this.lxpassword.Text = "Password invalid!";
            // 
            // btnwhy
            // 
            this.btnwhy.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnwhy.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnwhy.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnwhy.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnwhy.Location = new System.Drawing.Point(200, 60);
            this.btnwhy.Name = "btnwhy";
            this.btnwhy.Size = new System.Drawing.Size(16, 20);
            this.btnwhy.TabIndex = 53;
            this.btnwhy.Text = "?";
            this.btnwhy.UseVisualStyleBackColor = false;
            this.btnwhy.Click += new System.EventHandler(this.btnwhy_Click);
            // 
            // panelwhy
            // 
            this.panelwhy.BackColor = System.Drawing.Color.Transparent;
            this.panelwhy.Controls.Add(this.lsymbol);
            this.panelwhy.Controls.Add(this.ldigit);
            this.panelwhy.Controls.Add(this.llower);
            this.panelwhy.Controls.Add(this.lupper);
            this.panelwhy.Controls.Add(this.llength);
            this.panelwhy.Location = new System.Drawing.Point(222, 48);
            this.panelwhy.Name = "panelwhy";
            this.panelwhy.Size = new System.Drawing.Size(172, 103);
            this.panelwhy.TabIndex = 52;
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
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.linkLabel1.Location = new System.Drawing.Point(37, 259);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(61, 13);
            this.linkLabel1.TabIndex = 54;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Login Now!";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.linkLabel2.Location = new System.Drawing.Point(37, 290);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(74, 13);
            this.linkLabel2.TabIndex = 55;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "Register Now!";
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // forgot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumPurple;
            this.ClientSize = new System.Drawing.Size(406, 450);
            this.Controls.Add(this.linkLabel2);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.btnwhy);
            this.Controls.Add(this.panelwhy);
            this.Controls.Add(this.lxconfirm);
            this.Controls.Add(this.lxpassword);
            this.Controls.Add(this.lconfirmpassword);
            this.Controls.Add(this.lpassword);
            this.Controls.Add(this.txtmeter);
            this.Controls.Add(this.lxcode);
            this.Controls.Add(this.lxemail);
            this.Controls.Add(this.btnreset);
            this.Controls.Add(this.txtconfirmpass);
            this.Controls.Add(this.txtpassword);
            this.Controls.Add(this.btnverify);
            this.Controls.Add(this.txtcode);
            this.Controls.Add(this.btnx);
            this.Controls.Add(this.btnsubmit);
            this.Controls.Add(this.txtemail);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "forgot";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "forgot";
            this.Load += new System.EventHandler(this.forgot_Load);
            this.Click += new System.EventHandler(this.forgot_Click);
            this.panelwhy.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnsubmit;
        private System.Windows.Forms.TextBox txtemail;
        private System.Windows.Forms.Button btnx;
        private System.Windows.Forms.Button btnverify;
        private System.Windows.Forms.TextBox txtcode;
        private System.Windows.Forms.TextBox txtconfirmpass;
        private System.Windows.Forms.TextBox txtpassword;
        private System.Windows.Forms.Button btnreset;
        private System.Windows.Forms.Label lxemail;
        private System.Windows.Forms.Label lxcode;
        private System.Windows.Forms.TextBox txtmeter;
        private System.Windows.Forms.Label lconfirmpassword;
        private System.Windows.Forms.Label lpassword;
        private System.Windows.Forms.Label lxconfirm;
        private System.Windows.Forms.Label lxpassword;
        private System.Windows.Forms.Button btnwhy;
        private System.Windows.Forms.Panel panelwhy;
        private System.Windows.Forms.Label lsymbol;
        private System.Windows.Forms.Label ldigit;
        private System.Windows.Forms.Label llower;
        private System.Windows.Forms.Label lupper;
        private System.Windows.Forms.Label llength;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.LinkLabel linkLabel2;
    }
}