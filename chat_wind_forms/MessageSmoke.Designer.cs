namespace chat_wind_forms
{
    public partial class MessageSmoke
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblSender = new Label();
            lblTime = new Label();
            txtMsg = new TextBoxEx(flowPanelHandle);
            SuspendLayout();
            // 
            // lblSender
            // 
            lblSender.AutoSize = true;
            lblSender.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSender.ForeColor = SystemColors.ButtonHighlight;
            lblSender.Location = new Point(3, 9);
            lblSender.Name = "lblSender";
            lblSender.Size = new Size(27, 15);
            lblSender.TabIndex = 0;
            lblSender.Text = "You";
            // 
            // lblTime
            // 
            lblTime.Dock = DockStyle.Bottom;
            lblTime.Font = new Font("Segoe UI", 6.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTime.ForeColor = SystemColors.ControlDarkDark;
            lblTime.Location = new Point(0, 58);
            lblTime.Name = "lblTime";
            lblTime.Padding = new Padding(0, 0, 10, 0);
            lblTime.Size = new Size(155, 11);
            lblTime.TabIndex = 1;
            lblTime.Text = "label2";
            lblTime.TextAlign = ContentAlignment.MiddleRight;
            // 
            // txtMsg
            // 
            txtMsg.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtMsg.BackColor = Color.FromArgb(255, 128, 0);
            txtMsg.BorderStyle = BorderStyle.None;
            txtMsg.ForeColor = SystemColors.Window;
            txtMsg.Location = new Point(3, 28);
            txtMsg.Margin = new Padding(3, 2, 3, 15);
            txtMsg.Multiline = true;
            txtMsg.Name = "txtMsg";
            txtMsg.ReadOnly = true;
            txtMsg.Size = new Size(130, 26);
            txtMsg.TabIndex = 2;
            txtMsg.TabStop = false;
            txtMsg.Click += txtMsg_Click;
            // 
            // MessageSmoke
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.FromArgb(255, 128, 0);
            Controls.Add(txtMsg);
            Controls.Add(lblTime);
            Controls.Add(lblSender);
            Name = "MessageSmoke";
            Size = new Size(155, 69);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblSender;
        private Label lblTime;
        private TextBox txtMsg;
    }
}
