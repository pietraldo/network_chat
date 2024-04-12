using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace chat_wind_forms
{
    public partial class MessageSmoke : UserControl
    {
        IntPtr flowPanelHandle;
        [DllImport("user32.dll")]
        static extern bool HideCaret(IntPtr hWnd);
        public void HideCaret()
        {
            HideCaret(this.txtMsg.Handle);
        }
        public MessageSmoke(string msgText, string senderText, string timeText, IntPtr flowPanel)
        {
            flowPanelHandle = flowPanel;
            InitializeComponent();
            SetRegion();
            //txtMsg.Cursor = Cursors.Arrow;
            txtMsg.Text = msgText;
            lblSender.Text = senderText;
            lblTime.Text = timeText;
            SetWidthTextBox();
        }
        private void SetRegion()
        {
            GraphicsPath path = new GraphicsPath();
            int radius = 20;

            path.AddArc(0, 0, radius * 2, radius * 2, 180, 90);
            path.AddArc(this.Width - (radius * 2), 0, radius * 2, radius * 2, 270, 90);
            path.AddArc(this.Width - (radius * 2), this.Height - (radius * 2), radius * 2, radius * 2, 0, 90);
            path.AddArc(0, this.Height - (radius * 2), radius * 2, radius * 2, 90, 90);
            path.CloseFigure();

            this.Region = new Region(path);
        }

        protected override void OnSizeChanged(EventArgs e)
        {
            base.OnSizeChanged(e);
            SetWidthTextBox();
            SetRegion();

        }

        public string MessageText
        {
            get { return txtMsg.Text; }
            set { txtMsg.Text = value; }
        }
        public string SenderText
        {
            get { return lblSender.Text; }
            set { lblSender.Text = value; }
        }
        public string TimeText
        {
            get { return lblTime.Text; }
            set { lblTime.Text = value; }
        }
        public void SetWidthTextBox()
        {
            Size size = TextRenderer.MeasureText(txtMsg.CreateGraphics(), txtMsg.Text, txtMsg.Font,
                new Size(txtMsg.Width, 0), TextFormatFlags.TextBoxControl | TextFormatFlags.WordBreak);
            
/*            
            int lines = size.Width / (this.Width - 20) + 1;

            txtMsg.Size = new Size(txtMsg.Width, size.Height * lines);
            txtMsg.Margin = new Padding(0, 0, 0, 20);*/

            txtMsg.Height = size.Height;
        }

        private void txtMsg_Click(object sender, EventArgs e)
        {
           HideCaret();
        }

    }
    public class TextBoxEx : System.Windows.Forms.TextBox
    {
        IntPtr flowPanelHandle;
        public TextBoxEx(IntPtr flow)
        {
            flowPanelHandle= flow;
        }
        private const int WM_MOUSEWHEEL = 0x020A;

        [DllImport("user32.dll")]
        private static extern IntPtr SendMessage(IntPtr hWnd, int msg, IntPtr wp, IntPtr lp);

        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);

            if (m.Msg == WM_MOUSEWHEEL)
            {
                SendMessage(flowPanelHandle, m.Msg, m.WParam, m.LParam);                
            }
        }
    }
}
