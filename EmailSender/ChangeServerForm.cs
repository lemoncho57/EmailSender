using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmailSender
{
    public partial class ChangeServerForm : Form
    {
        private string path = "serverSettings.data";
        private bool useCustom = false;
        public string ip { get; private set; }
        public string port { get; private set; }
        private int index = 0;


        public ChangeServerForm()
        {
            InitializeComponent();
            if (!File.Exists(path))
            {
                File.Create(path);
                try
                {
                    using (StreamWriter sw = new StreamWriter(path))
                    {
                        //sw.WriteLine("0"); // Check box status
                        //sw.WriteLine(ip); // Ip
                        //sw.WriteLine(port); // port
                        //sw.WriteLine("0"); // combobox index
                        //sw.Close();
                    }
                }
                catch (IOException)
                {

                }
            }

            try
            {
                using (StreamReader sr = new StreamReader(path))
                {
                    int number;
                    if (int.TryParse(sr.ReadLine(), out number))
                    {
                        if (number >= 1)
                            useCustom = true;
                        else
                            useCustom = false;
                    }

                    ip = sr.ReadLine().ToString();
                    port = sr.ReadLine().ToString();

                    int number1;
                    if (int.TryParse(sr.ReadLine(), out number1))
                    {
                        index = number1;
                    }

                    sr.Close();
                }

            }
            catch (IOException)
            {
                MessageBox.Show("Unable to load ip and port!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ChangeServerForm_Load(object sender, EventArgs e)
        {
            if (!useCustom)
            {
                useCustomCButton.Checked = false;
                defaultPresetsCBox.SelectedIndex = index;
            }
            else
                useCustomCButton.Checked = true;


            serverIpTBox.Text = ip;
            serverPortTBox.Text = port;
        }

        private void changeB_Click(object sender, EventArgs e)
        {
            ip = serverIpTBox.Text;
            port = serverPortTBox.Text;
            try
            {
                CheckSelectedItemComboBox();
                using (StreamWriter sw = new StreamWriter(path))
                {
                    if (!useCustom)
                        sw.WriteLine("0");
                    else
                        sw.WriteLine("1");

                    sw.WriteLine(ip);
                    sw.WriteLine(port);
                    sw.WriteLine(index);
                    sw.Close();
                    MessageBox.Show("Successfully changed server details");
                    this.Close();
                }
            }
            catch (IOException)
            {
                MessageBox.Show("Unable to change server details!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void closeB_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void defaultPresetsCBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            CheckSelectedItemComboBox();
        }

        private void useCustomCButton_CheckedChanged(object sender, EventArgs e)
        {
            if (!useCustomCButton.Checked)
            {
                serverIpTBox.Enabled = false;
                serverPortTBox.Enabled = false;
                defaultPresetsCBox.Enabled = true;
                useCustom = false;
                defaultPresetsCBox.SelectedIndex = index;
            }
            else
            {
                serverIpTBox.Enabled = true;
                serverPortTBox.Enabled = true;
                defaultPresetsCBox.Enabled = false;
                useCustom = true;
                defaultPresetsCBox.SelectedIndex = -1;
            }

            CheckSelectedItemComboBox();
            using (StreamWriter sw = new StreamWriter(path))
            {
                if (!useCustom)
                    sw.WriteLine("0");
                else
                    sw.WriteLine("1");

                sw.WriteLine(ip);
                sw.WriteLine(port);
                sw.WriteLine(index);
                sw.Close();
            }
        }

        private void CheckSelectedItemComboBox()
        {
            if (defaultPresetsCBox.SelectedIndex == 0)
            {
                ip = "smtp.gmail.com";
                port = "587";
                index = 0;
            }
            else if (defaultPresetsCBox.SelectedIndex == 1)
            {
                ip = "smtp-mail.outlook.com";
                port = "587";
                index = 1;
            }
            else if (defaultPresetsCBox.SelectedIndex == 2)
            {
                ip = "smtp.abv.bg";
                port = "465";
                index = 2;
            }


            using (StreamWriter sw = new StreamWriter(path))
            {
                if (!useCustom)
                    sw.WriteLine("0");
                else
                    sw.WriteLine("1");

                sw.WriteLine(ip);
                sw.WriteLine(port);
                sw.WriteLine(index);
                sw.Close();
            }

            serverIpTBox.Text = ip;
            serverPortTBox.Text = port;
        }
    }
}
