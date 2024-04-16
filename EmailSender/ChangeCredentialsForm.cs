using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmailSender
{
    public partial class ChangeCredentialsForm : Form
    {
        public string path { get; private set; } = "cred.data";

        public string email { get; private set; }
        public string appPassword { get; private set; }

        public ChangeCredentialsForm()
        {
            InitializeComponent();
            if (!File.Exists(path))
            {
                File.Create(path);
            }
            using (StreamReader sr = new StreamReader(path))
            {
                email = sr.ReadLine().ToString();
                appPassword = sr.ReadLine().ToString();
                sr.Close();
            }
        }

        private void ChangeCredentialsForm_Load(object sender, EventArgs e)
        {
            emailTBox.Text = email;
            appPasswordTBox.Text = appPassword;
        }

        private void changeB_Click(object sender, EventArgs e)
        {

            try
            {
                using (StreamWriter sw = new StreamWriter(path))
                {
                    sw.WriteLine(emailTBox.Text);
                    sw.WriteLine(appPasswordTBox.Text);
                    sw.Close();
                    MessageBox.Show("Successfully changed credentials");
                    email = emailTBox.Text;
                    appPassword = appPasswordTBox.Text;
                }
            }
            catch (IOException ex)
            {
                MessageBox.Show("Unable to change credentials", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            email = emailTBox.Text;
            appPassword = appPasswordTBox.Text;
            this.Close();
        }

        private void closeB_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
