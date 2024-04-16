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
        private string path = "cred.data";

        public string email { get; private set; }
        public string appPassword { get; private set; }

        public ChangeCredentialsForm()
        {
            InitializeComponent();
        }

        private void ChangeCredentialsForm_Load(object sender, EventArgs e)
        {
            if (!File.Exists(path))
            {
                File.Create(path);
            }
            using (StreamReader sr = new StreamReader(path))
            {
                emailTBox.Text = sr.ReadLine().ToString();
                appPasswordTBox.Text = sr.ReadLine().ToString();
                email = emailTBox.Text;
                appPassword = appPasswordTBox.Text;
                sr.Close();
            }
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
