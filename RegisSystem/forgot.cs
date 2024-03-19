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
using System.Text.RegularExpressions;


namespace RegisSystem
{
    public partial class forgot : Form
    {
        public forgot()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-N6EFHM7\\RUBYSQL;Initial Catalog=regissystem; User Id=sa; Password=1234");
        string randomcode;
        public static string to;

        private void btnx_Click(object sender, EventArgs e)
        {
            this.Close();
            Login login = new Login();
            login.Show();
        }

        private void btnsubmit_Click(object sender, EventArgs e)
        {
            string email, from, pass, messagebody;
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from users where email='" + txtemail.Text + "'", con);
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
                message.From = new MailAddress(from);
                message.Body = messagebody;
                message.Subject = "Did you forget your password";
                SmtpClient smtp = new SmtpClient("smtp.gmail.com");
                smtp.EnableSsl = true;
                smtp.Port = 587;
                smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                smtp.Credentials = new NetworkCredential(from, pass);
                try
                {
                    smtp.Send(message);
                    MessageBox.Show("Please enter the code sent in your email");
                    btnsubmit.Hide();
                    txtcode.Show();
                    btnverify.Show();
                    lxcode.Show();


                }
                catch (Exception ex)
                {
                    MessageBox.Show("Something went wrong! Please make sure email entered is correct");
                }


            }
            else
            {
                MessageBox.Show("Invalid email");
            }
            con.Close();
        }

        private void btnverify_Click(object sender, EventArgs e)
        {
            if (randomcode == (txtcode.Text).ToString())
            {
                txtpassword.Show();
                txtconfirmpass.Show();
                lpassword.Show();  
                lconfirmpassword.Show();
                btnwhy.Show();
                btnreset.Show();

                txtemail.Hide();
                txtcode.Hide();
                lxemail.Hide();
                btnsubmit.Hide();
                btnverify.Hide();
                lxcode.Hide();

            }
            else
            {
                MessageBox.Show("Code not a match");
            }
        }
        int strength;

        private void txtpassword_TextChanged(object sender, EventArgs e)
        {
            txtpassword.MaxLength = 20;
            txtmeter.Show();
            int len = txtpassword.Text.Length;
            panelwhy.Show();

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

            else if (len > 8 && strength > 15)
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
        public void blocklist()
        {
            string[] myArray = { "password@123", "p@ssword123", "pa$$word123", "pa$sword@123", "qwerty.123", "qwerty@123" };

            foreach (string ch in myArray)
            {
                if (txtpassword.Text.ToLower() == ch)
                {
                    txtmeter.BackColor = Color.Red;
                    MessageBox.Show("Please enter a proper password!");
                }
            }
            string Password = "";
            bool IsExist = false;
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from users where email='" + txtemail.Text + "'", con);
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
                    MessageBox.Show("You cannot use old password again");
                    txtpassword.Clear(); txtconfirmpass.Clear();
                    txtmeter.BackColor = Color.Red;
                }
               

            }            
            con.Close();
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

        private void lpassword_Click(object sender, EventArgs e)
        {
            lpassword.Hide();

        }

        private void lconfirmpassword_Click(object sender, EventArgs e)
        {
            lconfirmpassword.Hide();

        }

        private void btnwhy_Click(object sender, EventArgs e)
        {
            panelwhy.Show();

        }

        private void btnreset_Click(object sender, EventArgs e)
        {

            
                    if (txtmeter.BackColor != Color.Red && lxpassword.Visible == false && lxconfirm.Visible == false)
                    {
                        try
                        {
                            string password = cryptography.Encrypt(txtpassword.Text.ToString());
                            con.Open();
                            panelwhy.Hide();
                            SqlCommand cmd1 = new SqlCommand("update users set password='" + password + "' where email ='" + txtemail.Text + "'", con);

                            cmd1.ExecuteNonQuery();
                            MessageBox.Show("Password reset sucessfull.", "Congratulation!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            con.Close();
                            this.Hide();
                            Login login = new Login();
                            login.Show();

                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Please check if all detail are vaild!");
                    }
                   

        }




        private void forgot_Load(object sender, EventArgs e)
        {
            txtcode.Hide();
            btnverify.Hide();
            txtpassword.Hide(); 
            txtconfirmpass.Hide();
            lxpassword.Hide();
            lxconfirm.Hide();
            btnwhy.Hide();
            panelwhy.Hide();
            btnreset.Hide();
            txtmeter.Hide();
            lpassword.Hide();
            lconfirmpassword.Hide();
            lxcode.Hide();

        }

        private void forgot_Click(object sender, EventArgs e)
        {
            panelwhy.Hide();

        }

        private void txtpassword_Click(object sender, EventArgs e)
        {
            lpassword.Hide();
        }

        private void txtconfirmpass_Click(object sender, EventArgs e)
        {
            lconfirmpassword.Hide();
        }

        private void txtemail_TextChanged(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
            Login login = new Login();
            login.Show();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
            Register register = new Register();
            register.Show();
        }
    }
}
