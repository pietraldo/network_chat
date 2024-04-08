namespace chat_wind_forms
{
    partial class Connect
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            txtHost = new TextBox();
            txtName = new TextBox();
            label2 = new Label();
            txtKey = new TextBox();
            label3 = new Label();
            txtPort = new TextBox();
            label4 = new Label();
            checkBoxShowKey = new CheckBox();
            progressBar1 = new ProgressBar();
            btnConnect = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(22, 23);
            label1.Name = "label1";
            label1.Size = new Size(52, 15);
            label1.TabIndex = 0;
            label1.Text = "Address:";
            // 
            // txtHost
            // 
            txtHost.Location = new Point(80, 20);
            txtHost.Name = "txtHost";
            txtHost.Size = new Size(100, 23);
            txtHost.TabIndex = 4;
            txtHost.Text = "localhost";
            txtHost.TextAlign = HorizontalAlignment.Center;
            // 
            // txtName
            // 
            txtName.Location = new Point(80, 60);
            txtName.Name = "txtName";
            txtName.Size = new Size(100, 23);
            txtName.TabIndex = 1;
            txtName.Text = "user";
            txtName.TextAlign = HorizontalAlignment.Center;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(11, 63);
            label2.Name = "label2";
            label2.Size = new Size(63, 15);
            label2.TabIndex = 2;
            label2.Text = "Username:";
            // 
            // txtKey
            // 
            txtKey.Location = new Point(242, 57);
            txtKey.Name = "txtKey";
            txtKey.PasswordChar = '*';
            txtKey.Size = new Size(100, 23);
            txtKey.TabIndex = 2;
            txtKey.TextAlign = HorizontalAlignment.Center;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(207, 60);
            label3.Name = "label3";
            label3.Size = new Size(29, 15);
            label3.TabIndex = 4;
            label3.Text = "Key:";
            // 
            // txtPort
            // 
            txtPort.Location = new Point(242, 20);
            txtPort.Name = "txtPort";
            txtPort.Size = new Size(100, 23);
            txtPort.TabIndex = 5;
            txtPort.Text = "9000";
            txtPort.TextAlign = HorizontalAlignment.Center;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(204, 23);
            label4.Name = "label4";
            label4.Size = new Size(32, 15);
            label4.TabIndex = 6;
            label4.Text = "Port:";
            // 
            // checkBoxShowKey
            // 
            checkBoxShowKey.AutoSize = true;
            checkBoxShowKey.Location = new Point(259, 86);
            checkBoxShowKey.Name = "checkBoxShowKey";
            checkBoxShowKey.Size = new Size(76, 19);
            checkBoxShowKey.TabIndex = 8;
            checkBoxShowKey.Text = "Show key";
            checkBoxShowKey.UseVisualStyleBackColor = true;
            checkBoxShowKey.CheckedChanged += checkBoxShowKey_CheckedChanged;
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(12, 106);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(249, 23);
            progressBar1.TabIndex = 9;
            // 
            // btnConnect
            // 
            btnConnect.Location = new Point(267, 106);
            btnConnect.Name = "btnConnect";
            btnConnect.Size = new Size(75, 23);
            btnConnect.TabIndex = 3;
            btnConnect.Text = "Connect";
            btnConnect.UseVisualStyleBackColor = true;
            btnConnect.Click += btnConnect_Click;
            // 
            // Connect
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(354, 141);
            Controls.Add(btnConnect);
            Controls.Add(progressBar1);
            Controls.Add(checkBoxShowKey);
            Controls.Add(txtPort);
            Controls.Add(label4);
            Controls.Add(txtKey);
            Controls.Add(label3);
            Controls.Add(txtName);
            Controls.Add(label2);
            Controls.Add(txtHost);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Connect";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Connect";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtHost;
        private TextBox txtName;
        private Label label2;
        private TextBox txtKey;
        private Label label3;
        private TextBox txtPort;
        private Label label4;
        private CheckBox checkBoxShowKey;
        private ProgressBar progressBar1;
        private Button btnConnect;
    }
}