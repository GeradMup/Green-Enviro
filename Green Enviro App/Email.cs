using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Web;
using System.Net;
using System.Net.Mail;

namespace Green_Enviro_App
{
    public partial class Email : Form
    {
        /*
         * This class is made to send the pdf generated after creating a Destruction Certificate
         * It is to be improved, authentification with Google is required and adding the pdf attachment as a 
         * criteria as well is required.
         * Linking pdf generated and any pdf with the attachment is a suggestion to ease selection of pdf's
        */
        public Email()
        {
            InitializeComponent();
            //Lets generate the SMTP different servers so as to ease the process for ppl making the emails
            SMTPServers();
            //Hiding the password with the '*' character
            emailAddressPasswordField.PasswordChar = '*';

        }
        private void SMTPServers()
        {
            //These are the different SMTP Servers where users have their emails
            
            emailAddressSMTPServerList.Items.Insert(0, "smtp.mail.yahoo.com");//This is for yahoo users
            emailAddressSMTPServerList.Items.Insert(1, "smtp.gmail.com");//This is for gmail users
            emailAddressSMTPServerList.Items.Insert(2, "smtp.live.com");//This is for hotmail users
            emailAddressSMTPServerList.Items.Insert(3, "smtp.outlook.com");//This is for outlook users
        }

        private void SendAnEmail()
        {
            try
            {
                MailMessage _message = new MailMessage(emailAddressFromField.Text, emailAddressToField.Text, emailAddressSubjectField.Text, emailBodyField.Text);
                // This line is use to define the type of email we are sending the information to seen in the function SMTPServers
                SmtpClient _smtp_server = new SmtpClient(emailAddressSMTPServerList.SelectedItem.ToString());
                // SMTP Port for all email
                _smtp_server.Port = 587;
                //Here its the credentials of the account that is sending to the client preferably Green Enviro itself but
                // for testing purposes we leaving the textbox open and writing our own emails afterwards it will be an
                // Green enviro email always with the Green Enviro account password which will never change so as to make it
                // Simple in the future
                _smtp_server.Credentials = new System.Net.NetworkCredential(emailAddressUsernameField.Text, emailAddressPasswordField.Text);
                //Through the use of port 587 we can use an SSL
                _smtp_server.EnableSsl = true;
                _smtp_server.Send(_message);
                MessageBox.Show("Email Sent!", "Success", MessageBoxButtons.OK);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Email Not sent due to " + ex, "Failure");
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SendAnEmail();
            this.Hide();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void emailAddressUsernameField_TextChanged(object sender, EventArgs e)
        {
            // Here uncomment when finalising as usually username and the email that are sending from are the same
            //emailAddressUsernameField.Text = emailAddressFromField.Text;
        }
    }
}
