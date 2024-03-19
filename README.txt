#resgistration system

Prototype made in Visual Studio C# .net Winform framework
User can login if they dont have an accout else register an account.
To store the user information I have used Microsoft Sql. You can find the code in regissystem_db.sql.

here the user cannot register new account with an email adress if it already exist in the database. Username cannot be same for two diffterent account. Password security is the priority. 
Password is hidden by pass char. The combination of character of password determines the strength of the password. Weak passwords turn strength meter red meaing password unacceptable, strong password turnd strength mete green and average turns yellow. passworsd cannot be from a blocklist i.e. strings that are banned from being used as password.  without confirm password validation password is unacceptable. 
before storing the user information in databse the password is encrypted into cipher text by aes encryption. also, for the information to be registers in the data base, user must pass the captcha test.  

login has multi factor authentication of 6 digit otp sent via email. 

user can reset their password with forgot password options. this send an otp in the email. ui asks the user enter the code. if the code matches, the password can be changed but can be same as the old one. 


