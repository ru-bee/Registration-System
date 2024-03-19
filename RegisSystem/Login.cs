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
using System.Net;
using System.Net.Mail;
namespace RegisSystem
{
    public partial class Login : Form
    {
        string randomcode;
        public static string to;
        public Login()
        {
            InitializeComponent();
            loadCaptchaImage();

        }
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-N6EFHM7\\RUBYSQL;Initial Catalog=regissystem; User Id=sa; Password=1234");

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
            Register register = new Register();
            register.Show();
        }

        private void btnx_Click(object sender, EventArgs e)
        {
            this.Close();
            Home home = new Home();
            home.Show();
            label1.Show();
            linkLabel1.Show();

        }

       
        private void lusername_Click(object sender, EventArgs e)
        {
            lusername.Hide();
        }

        private void lpassword_Click(object sender, EventArgs e)
        {
            lpassword.Hide();
        }

        private void txtpassword_Click(object sender, EventArgs e)
        {
            lpassword.Hide();
            txtpassword.ShortcutsEnabled = false;
        }

        private void txtusername_Click(object sender, EventArgs e)
        {
            lusername.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtusername.Text) || string.IsNullOrEmpty(txtpassword.Text)==true)
            {
                panelcaptcha.Hide();

            }
            else
            {
                panelcaptcha.Show();
            }
           

        }
        private void submission()
        {
            string Password = "";
            bool IsExist = false;
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from users where username='" + txtusername.Text + "'", con);
            SqlDataReader sdr = cmd.ExecuteReader();
            if (sdr.Read())
            {
                Password = sdr.GetString(2);
                IsExist = true;
            }
            if (IsExist)
            {
                if (cryptography.Decrypt(Password).Equals(txtpassword.Text))
                {
                   MessageBox.Show("Login Success", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                   this.Hide();
                    Welcome welcome = new Welcome();
                    welcome.Show();
                }
                else
                {
                    txtcapcha.Clear();
                    txtpassword.Clear();
                    MessageBox.Show("Incorrect Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {
                txtcapcha.Clear();
                txtpassword.Clear();
                MessageBox.Show("Invalid Username or Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            con.Close();
        }

        private void txtusername_TabIndexChanged(object sender, EventArgs e)
        {
            lusername.Hide();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            panelcaptcha.Hide();
            txtcode.Hide();
            btnsubmit.Hide();
        }
        int number = 0;

        private void loadCaptchaImage()
        {
            Random r1 = new Random();
            number = r1.Next(100, 10000);
            var image = new Bitmap(this.pictureBox1.Width, this.pictureBox1.Height);
            var font = new Font("Ewert", 26, FontStyle.Bold | FontStyle.Strikeout, GraphicsUnit.Pixel);
            var graphics = Graphics.FromImage(image);
            graphics.DrawString(number.ToString(), font, Brushes.Yellow, new Point(0, 0));
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
                loadCaptchaImage();
                sendcode();                

            }
            else
            {
                MessageBox.Show("Does not Match Text with Captcha");
                loadCaptchaImage();
            }
        }
        private void sendcode()
        {
            string email, from, pass, messagebody;
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from users where username='" + txtusername.Text + "'", con);
            SqlDataReader sdr = cmd.ExecuteReader();
            if (sdr.Read())
             {
                email = (string)sdr[1];
                Random ran = new Random();
                randomcode = (ran.Next(999999)).ToString();
                MailMessage message = new MailMessage();
                to = email;
                from = "buyin.mailyou@gmail.com";
                pass = "awpbjrennekunojc";
                messagebody = "Your authentication code is " + randomcode;
                message.To.Add(to);
                message.From=new MailAddress(from);
                message.Body = messagebody;
                message.Subject = "Authentication";
                SmtpClient smtp = new SmtpClient("smtp.gmail.com");
                smtp.EnableSsl = true;
                smtp.Port = 587;
                smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                smtp.Credentials = new NetworkCredential(from, pass);
                try
                {
                    smtp.Send(message);
                    MessageBox.Show("Please enter the code sent in your email");
                    txtusername.Hide();
                    txtpassword.Hide();
                    label1.Hide();
                    label2.Hide();
                    lusername.Hide();
                    lpassword.Hide();
                    panelcaptcha.Hide();
                    btnlogin.Hide();
                    txtcode.Show();
                    btnsubmit.Show();                      

                }
                catch(Exception ex)
                {
                    MessageBox.Show("Something went wrong! Please make sure the username and password are correct");
                }

            }
            con.Close();




        }

        private void btnsubmit_Click(object sender, EventArgs e)
        {
            if (randomcode == (txtcode.Text).ToString())
            {
                submission();

            }
            else
            {
                MessageBox.Show("Code not a match");
            }
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
            forgot forgot = new forgot();
            forgot.Show();
        }

        private void txtpassword_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
