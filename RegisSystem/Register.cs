using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
using System.IO;
using System.Drawing.Imaging;


namespace RegisSystem
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
            loadCaptchaImage();
        }
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-N6EFHM7\\RUBYSQL;Initial Catalog=regissystem; User Id=sa; Password=1234");

        

        private void btnx_Click(object sender, EventArgs e)
        {
            this.Close();
            Home home = new Home();
            home.Show();
            label1.Show();
            linkLabel1.Show();
        }

        
        private void Register_Load(object sender, EventArgs e)
        {
            lxemail.Hide();
            lxusername.Hide();
            lxpassword.Hide();
            lxconfirm.Hide();

            panelwhy.Hide();

            txtmeter.Hide();
            panelcaptcha.Hide();
            checkBoxpolicy.Checked = false;
            
        }
        private void btnwhy_Click(object sender, EventArgs e)
        {
            panelwhy.Show();
        }

        private void Register_Click(object sender, EventArgs e)
        {
            panelwhy.Hide();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
            Login login = new Login();
            login.Show();
        }

        private void lemail_Click(object sender, EventArgs e)
        {
            lemail.Hide();
        }

        private void lusername_Click(object sender, EventArgs e)
        {
            lusername.Hide();
        }

        private void lpassword_Click(object sender, EventArgs e)
        {
            lpassword.Hide();
        }

        private void lconfirmpassword_Click(object sender, EventArgs e)
        {
            lconfirmpassword.Hide();
        }

        private void txtemail_Click(object sender, EventArgs e)
        {
            lemail.Hide();
        }

        
        private void txtusername_Click(object sender, EventArgs e)
        {
            lusername.Hide();

        }

        private void txtpassword_Click(object sender, EventArgs e)
        {
            lpassword.Hide();
            txtpassword.ShortcutsEnabled = false;

        }

        private void txtconfirmpass_Click(object sender, EventArgs e)
        {
            lconfirmpassword.Hide();
            txtpassword.ShortcutsEnabled = false;

        }
        string pattern = "^([0-9a-zA-Z]([-\\.\\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][-\\w]*[0-9a-zA-Z]\\.)+[a-zA-Z]{2,9})$";


        private void txtemail_Leave(object sender, EventArgs e)
        {
            if (Regex.IsMatch(txtemail.Text, pattern) == false)
            {
                errorProvider2.SetError(this.txtemail, "Invalid Email");
                lxemail.Show();
            }
            else
            {
                errorProvider2.Clear(); lxemail.Hide();
            }
        }

        private void txtusername_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtusername.Text) == true)
            {
                errorProvider1.SetError(this.txtusername, "Fill the box!"); lxusername.Show();
            }
            else
            {
                errorProvider1.Clear(); lxusername.Hide();  
            }
        }

        private void txtpassword_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtpassword.Text) == true)
            {
                errorProvider1.SetError(this.txtpassword, "Fill the box!"); lxpassword.Show();
            }
            else
            {
                errorProvider1.Clear(); lxpassword.Hide();
            }
        }

        private void txtconfirmpass_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtconfirmpass.Text) == true)
            {
                errorProvider1.SetError(this.txtconfirmpass, "Fill the box!"); lxconfirm.Show();
            }
            else
            {
                errorProvider1.Clear(); lxconfirm.Hide();
            }
        }

        private void txtemail_TextChanged(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM Users WHERE email = '" + txtemail.Text + "'", con);

            SqlDataReader sdr = cmd.ExecuteReader();

            if ((sdr.Read() == true))

            {
                lxemail.Show();
                errorProvider3.SetError(this.txtemail, "Email in use or invalid");

            }
            else
            {
                errorProvider3.Clear();
                lxemail.Hide();
            }
            con.Close();
        }

        private void txtusername_TextChanged(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM Users WHERE username = '" + txtusername.Text + "'", con);

            SqlDataReader sdr = cmd.ExecuteReader();

            if ((sdr.Read() == true))

            {
                errorProvider3.SetError(this.txtusername, "Username in use or invalid");
                lxusername.Show();

            }
            else
            {
                errorProvider3.Clear();
                lxusername.Hide();
            }
            con.Close();
        }
        int strength;
        private void txtpassword_TextChanged(object sender, EventArgs e)
        {
            txtmeter.Show();
            int len = txtpassword.Text.Length;

            int lower = 0, upper = 0, digit = 0, symbol = 0;

            for (int x = 0; x < len; x++)
            {
                if (char.IsLetter(txtpassword.Text[x]) & char.IsLower(txtpassword.Text[x]))
                {
                    lower++;
                }
                if (char.IsLetter(txtpassword.Text[x]) & char.IsUpper(txtpassword.Text[x]))
                {
                    upper++;
                }
                if (char.IsDigit(txtpassword.Text[x]))
                {
                    digit++;
                }
                if (char.IsSymbol(txtpassword.Text[x]) | char.IsPunctuation(txtpassword.Text[x]))
                {
                    symbol++;
                }

            }
            
            if (Regex.IsMatch(txtpassword.Text, "^(?=.*?[A-Z])(?=.*?[a-z])(?=.*?[0-9])(?=.*?[#?!@$%^&*-]).{8,}$"))
            {
                strength = lower + upper * 2 + digit + symbol * 2;
                panelwhy.Hide();
            }
           
            else
            {
                strength = 8;
                panelwhy.Show();
                 
            }
            if (strength < 10 || len < 8)
            {
                txtmeter.BackColor = Color.Red;
            }

            else if (len > 8 && strength > 14)
            {
                txtmeter.BackColor = Color.Green;
            }
            else
            {
                txtmeter.BackColor = Color.Yellow;
            }
            blocklist();

            if (txtmeter.BackColor == Color.Red)
            {
                lxconfirm.Show();
            }
            else
            {
                lxconfirm.Hide();
                
            }



        }
        public void blocklist ()
        {
            string[] myArray = { "password@123", "p@ssword123","pa$$word123","pa$sword@123", "qwerty.123", "qwerty@123"};

            foreach (string ch in myArray)
            {
                if (txtpassword.Text.ToLower()== ch)
                {
                    txtmeter.BackColor = Color.Red;
                    MessageBox.Show("Please enter a proper password!");
                }
            }
        }

        private void txtconfirmpass_TextChanged(object sender, EventArgs e)
        {
            string pass = txtpassword.Text;
            string config = txtconfirmpass.Text;
            if (pass.Equals(config))
            {
                lxconfirm.Hide();
            }
            else
            {
                lxconfirm.Show();
            }
        }

        private void btnsignup_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtemail.Text) || string.IsNullOrEmpty(txtusername.Text) || string.IsNullOrEmpty(txtpassword.Text) || string.IsNullOrEmpty(txtconfirmpass.Text)  == true)
            {
                panelcaptcha.Hide();
                MessageBox.Show("Connot leave empty!");

            }
            else if(checkBoxpolicy.Checked)
            {
                panelcaptcha.Show();
            }
            else
            {
                MessageBox.Show("You must accept the Buy In's policy in order to continue");
            }
            
        }
        private void submission()
        {
            if (txtmeter.BackColor != Color.Red && lxemail.Visible == false && lxusername.Visible == false && lxpassword.Visible == false && lxconfirm.Visible == false)
            {
                try
                {
                    string password = cryptography.Encrypt(txtpassword.Text.ToString());
                    con.Open();
                    panelwhy.Hide();
                    SqlCommand cmd1 = new SqlCommand("Insert into users(email, username, password) values( '" + txtemail.Text + "'," +
                   " '" + txtusername.Text + "', '" + password + "')", con);
                    cmd1.ExecuteNonQuery();
                    MessageBox.Show("Account Registered! Now login with your details to continue.", "Congratulation!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    con.Close();
                    this.Hide();
                    Login login = new Login();
                    login.Show();

                }
                catch
                {
                    lxusername.Show();
                }
            }
            else
            {
                MessageBox.Show("Please check if all detail are vaild!");
            }
        }

        int number = 0;

        private void loadCaptchaImage()
        {
           
            Random r1 = new Random();
            number = r1.Next(100, 10000);
            var image = new Bitmap(this.pictureBox1.Width, this.pictureBox1.Height);
            var font = new Font("Fancy", 26, FontStyle.Bold | FontStyle.Strikeout|FontStyle.Italic, GraphicsUnit.Pixel);
            var graphics = Graphics.FromImage(image);
            graphics.DrawString(number.ToString(), font, Brushes.Yellow, new Point(10, 0));
            pictureBox1.Image = image;
                        
        }

        private void btngenerate_Click(object sender, EventArgs e)
        {
            loadCaptchaImage();
        }

        private void btnverify_Click(object sender, EventArgs e)
        {
            if (txtcapcha.Text == number.ToString())
            {
                submission();
                loadCaptchaImage();
                txtconfirmpass.Clear();
                txtpassword.Clear();
                   
            }
            else
            {
                MessageBox.Show("Does not Match Text with Captcha");
                loadCaptchaImage();
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string text = File.ReadAllText("policy.txt");
            MessageBox.Show(""+text +"");


        }

        private void panelwhy_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtcapcha_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
