using Messages;
using System;
using System.Diagnostics;
using System.Reflection.Metadata.Ecma335;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace chat_wind_forms
{
    public delegate void GotMessageEvent(object sender, Messages.Message msg);
    public partial class Form1 : Form
    {
        public event GotMessageEvent GotMessageEventHandler;

        private Connect connect1 = null;
        public Form1()
        {
            InitializeComponent();
            setPanelsScrolBars();

            GotMessageEventHandler += GotMessageHandlerMethod;
        }
        private void setPanelsScrolBars()
        {
            flowLayoutPanel1.AutoScroll = false;
            flowLayoutPanel1.VerticalScroll.Enabled = true;
            flowLayoutPanel1.VerticalScroll.Visible = true;
            flowLayoutPanel1.HorizontalScroll.Enabled = false;
            flowLayoutPanel1.HorizontalScroll.Visible = false;
            flowLayoutPanel1.AutoScroll = true;
        }
        List<Control> controls = new List<Control>();

        private void GotMessageHandlerMethod(object sender, Messages.Message message)
        {
            dodajDymek(message.Sender, message.Time.ToString("HH:mm"), message.Text, false);
        }
        private void dodajDymek(string senderText, string timeText, string messageText, bool senderYou)
        {
            MessageSmoke nowaKontrolka = new MessageSmoke(messageText, senderText, timeText, flowLayoutPanel1.Handle);

            if (senderYou)
            {
                Padding newPadding = new Padding(50, 10, 0, 10);
                nowaKontrolka.Margin = newPadding;
            }
            else
            {
                Padding newPadding = new Padding(0, 10, 50, 10);
                nowaKontrolka.Margin = newPadding;
            }

            nowaKontrolka.Width = flowLayoutPanel1.Width - 90;
            controls.Add(nowaKontrolka);

            flowLayoutPanel1.Controls.Add(nowaKontrolka);

            flowLayoutPanel1.ScrollControlIntoView(nowaKontrolka);
            setPanelsScrolBars();
        }

        private void SendOurMessage()
        {
            string senderText = "You";
            DateTime currentTime = DateTime.Now;
            string timeText = currentTime.ToString("HH:mm");


            dodajDymek(senderText, timeText, txtMsg.Text, true);


            if (connect1 != null && connect1.comunication1.is_connected)
            {
                Messages.Message mes = new Messages.Message(connect1.comunication1.Username, txtMsg.Text, DateTime.Now);
                Task.Run(() => connect1.comunication1.SendMessage(mes));
                Debug.WriteLine("after sneding");

            }
            txtMsg.Text = "";
        }

        private async void ReadMessagesFromServer()
        {
            if (connect1 == null) return;
            while (true)
            {
                Messages.Message message = connect1.comunication1.ReadMessage();
                if (message == null)
                {
                    if (connect1.comunication1.is_connected)
                    disconect();
                    return;
                }

                this.Invoke(new Action(() => GotMessageEventHandler?.Invoke(this, message)));
            }
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            SendOurMessage();
        }

        private void txtMsg_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendOurMessage();
            }
        }

        private void Form1_SizeChanged(object sender, EventArgs e)
        {
            foreach (Control control in controls)
            {
                if (control is Label label)
                    control.Width = flowLayoutPanel1.Width-40;
                else
                    control.Width = flowLayoutPanel1.Width - 70;
            }
            setPanelsScrolBars();
        }


       
       

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void disconect()
        {
            connect1.comunication1.disconnect();
            btnConect.Enabled = true;
            btnDisconect.Enabled = false;
            InformStatus("Disconnected");
        }

        private void btnDisconect_Click(object sender, EventArgs e)
        {
            disconect();
        }

        private void InformStatus(string info)
        {
            if (flowLayoutPanel1.InvokeRequired)
            {
                flowLayoutPanel1.Invoke((Action)(() => InformStatus(info)));
                return;
            }



            Label label = new Label();

            label.Size = new Size(flowLayoutPanel1.Width-40, 20);
            label.Text = info;
            label.TextAlign = ContentAlignment.MiddleCenter;
            label.ForeColor = SystemColors.GrayText;

            controls.Add(label);
            
            flowLayoutPanel1.Controls.Add(label);
            flowLayoutPanel1.ScrollControlIntoView(label);
        }

        private void btnConect_Click(object sender, EventArgs e)
        {

            connect1 = new Connect();
            if (connect1.ShowDialog() == DialogResult.OK)
            {
                InformStatus("Conncected");
                btnConect.Enabled = false;
                btnDisconect.Enabled = true;
                Task.Run(() => ReadMessagesFromServer());
            }
        }
    }
}
