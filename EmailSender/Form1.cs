using System.Net.Mail;
using System.IO;
using System.Net;

namespace EmailSender
{
    public partial class Form1 : Form
    {
        private string path = "config.data";
        private bool showStartupMessage = true;
        ChangeCredentialsForm credentialForm = new ChangeCredentialsForm();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (!File.Exists(path))
            {
                try
                {
                    File.Create(path);
                    using (StreamWriter sw = new StreamWriter(path))
                    {
                        sw.WriteLine("1");
                        sw.Close();
                    }
                }
                catch (Exception ex) { }

            }
            using (StreamReader sr = new StreamReader(path))
            {
                int number;
                if (int.TryParse(sr.ReadLine(), out number))
                {
                    if (number >= 1)
                        showStartupMessage = true;
                    else
                        showStartupMessage = false;
                }
            }

            if (showStartupMessage)
            {
                DialogResult result = MessageBox.Show("Test", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (result == DialogResult.OK)
                {
                    using (StreamWriter sw = new StreamWriter(path))
                    {
                        sw.Write("0");
                        sw.Close();
                    }
                }
            }
        }

        private void sendB_Click(object sender, EventArgs e)
        {
            using (SmtpClient client = new SmtpClient())
            {
                client.Host = "smtp.gmail.com";
                client.Port = 587;
                client.DeliveryMethod = SmtpDeliveryMethod.Network;
                client.UseDefaultCredentials = false;
                client.EnableSsl = true;
                client.Credentials = new NetworkCredential(credentialForm.email, credentialForm.appPassword);

                try
                {
                    using (MailMessage message = new MailMessage(from: new MailAddress(credentialForm.email, fromTBox.Text), to: new MailAddress(toEmailTBox.Text, toTBox.Text)))
                    {
                        message.Subject = subjectTbox.Text;
                        message.Body = bodyTBox.Text;

                        client.Send(message);
                        MessageBox.Show("Successfully send email!");
                    }
                }catch (SmtpException ex)
                {
                    MessageBox.Show("Unable to send email!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void changeCredentialsB_Click(object sender, EventArgs e)
        {
            credentialForm.ShowDialog();
        }
    }
}