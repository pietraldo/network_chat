using Messages;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace chat_wind_forms
{
    public delegate void progresChangeEvent(object sender, int proges);
    public partial class Connect : Form
    {
        public Comunication comunication1;
        public event progresChangeEvent progresChangeEventHandler;
        public Connect()
        {
            InitializeComponent();
            progresChangeEventHandler += changeProgres;
        }

        private void checkBoxShowKey_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxShowKey.Checked == true)
            {
                txtKey.PasswordChar = '\0';
            }
            else
                txtKey.PasswordChar = '*';
        }

        private void changeProgres(object sender, int progres)
        {
            Debug.WriteLine("aaa");
            progressBar1.Value = progres;
            this.Refresh();
        }
        public void RaiseProgresChangeEvent(object sender, int progress)
        {
            Debug.WriteLine("progggggggggggggres");
            this.Invoke(new Action(() => progresChangeEventHandler?.Invoke(this, progress)));
        }

        private async void btnConnect_Click(object sender, EventArgs e)
        {
            btnConnect.Enabled = false;
            comunication1 = await Task.Run(() =>
                new Comunication(txtHost.Text, int.Parse(txtPort.Text), txtName.Text, txtKey.Text,this));

            this.Invoke(new Action(() => this.DialogResult = DialogResult.OK));
            btnConnect.Enabled = true;
        }
    }
}
