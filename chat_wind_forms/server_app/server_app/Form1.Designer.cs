namespace server_app
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tableLayoutPanel1 = new TableLayoutPanel();
            dataGridView1 = new DataGridView();
            id = new DataGridViewTextBoxColumn();
            name = new DataGridViewTextBoxColumn();
            tableLayoutPanel2 = new TableLayoutPanel();
            panel1 = new Panel();
            panel5 = new Panel();
            checkBoxShowKey = new CheckBox();
            txtPort = new TextBox();
            label4 = new Label();
            txtKey = new TextBox();
            label3 = new Label();
            txtName = new TextBox();
            label2 = new Label();
            txtHost = new TextBox();
            label5 = new Label();
            btnStart = new Button();
            panel2 = new Panel();
            panel4 = new Panel();
            btnSend = new Button();
            txtMsg = new TextBox();
            panel3 = new Panel();
            btnDisconectAll = new Button();
            label1 = new Label();
            btnClear = new Button();
            txtLog = new TextBox();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            tableLayoutPanel2.SuspendLayout();
            panel1.SuspendLayout();
            panel5.SuspendLayout();
            panel2.SuspendLayout();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 55.8375626F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 44.1624374F));
            tableLayoutPanel1.Controls.Add(dataGridView1, 1, 0);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Margin = new Padding(3, 4, 3, 4);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(870, 523);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView1.BackgroundColor = SystemColors.Control;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { id, name });
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(488, 4);
            dataGridView1.Margin = new Padding(3, 4, 3, 4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(379, 515);
            dataGridView1.TabIndex = 0;
            // 
            // id
            // 
            id.HeaderText = "ID";
            id.MinimumWidth = 6;
            id.Name = "id";
            id.ReadOnly = true;
            // 
            // name
            // 
            name.HeaderText = "Name";
            name.MinimumWidth = 6;
            name.Name = "name";
            name.ReadOnly = true;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(panel1, 0, 0);
            tableLayoutPanel2.Controls.Add(panel2, 0, 1);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(3, 4);
            tableLayoutPanel2.Margin = new Padding(3, 4, 3, 4);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 32.675045F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 67.32496F));
            tableLayoutPanel2.Size = new Size(479, 515);
            tableLayoutPanel2.TabIndex = 1;
            // 
            // panel1
            // 
            panel1.Controls.Add(panel5);
            panel1.Controls.Add(btnStart);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(3, 4);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(473, 160);
            panel1.TabIndex = 0;
            // 
            // panel5
            // 
            panel5.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            panel5.Controls.Add(checkBoxShowKey);
            panel5.Controls.Add(txtPort);
            panel5.Controls.Add(label4);
            panel5.Controls.Add(txtKey);
            panel5.Controls.Add(label3);
            panel5.Controls.Add(txtName);
            panel5.Controls.Add(label2);
            panel5.Controls.Add(txtHost);
            panel5.Controls.Add(label5);
            panel5.Location = new Point(155, 4);
            panel5.Name = "panel5";
            panel5.Size = new Size(313, 172);
            panel5.TabIndex = 1;
            // 
            // checkBoxShowKey
            // 
            checkBoxShowKey.AutoSize = true;
            checkBoxShowKey.Location = new Point(210, 73);
            checkBoxShowKey.Margin = new Padding(3, 4, 3, 4);
            checkBoxShowKey.Name = "checkBoxShowKey";
            checkBoxShowKey.Size = new Size(93, 24);
            checkBoxShowKey.TabIndex = 17;
            checkBoxShowKey.Text = "Show key";
            checkBoxShowKey.UseVisualStyleBackColor = true;
            // 
            // txtPort
            // 
            txtPort.Location = new Point(219, 3);
            txtPort.Margin = new Padding(3, 4, 3, 4);
            txtPort.Name = "txtPort";
            txtPort.Size = new Size(83, 27);
            txtPort.TabIndex = 15;
            txtPort.Text = "9000";
            txtPort.TextAlign = HorizontalAlignment.Center;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(178, 7);
            label4.Name = "label4";
            label4.Size = new Size(38, 20);
            label4.TabIndex = 16;
            label4.Text = "Port:";
            // 
            // txtKey
            // 
            txtKey.Location = new Point(219, 37);
            txtKey.Margin = new Padding(3, 4, 3, 4);
            txtKey.Name = "txtKey";
            txtKey.PasswordChar = '*';
            txtKey.Size = new Size(83, 27);
            txtKey.TabIndex = 11;
            txtKey.TextAlign = HorizontalAlignment.Center;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(178, 41);
            label3.Name = "label3";
            label3.Size = new Size(36, 20);
            label3.TabIndex = 13;
            label3.Text = "Key:";
            // 
            // txtName
            // 
            txtName.Location = new Point(89, 41);
            txtName.Margin = new Padding(3, 4, 3, 4);
            txtName.Name = "txtName";
            txtName.Size = new Size(83, 27);
            txtName.TabIndex = 10;
            txtName.Text = "server";
            txtName.TextAlign = HorizontalAlignment.Center;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(5, 45);
            label2.Name = "label2";
            label2.Size = new Size(78, 20);
            label2.TabIndex = 12;
            label2.Text = "Username:";
            // 
            // txtHost
            // 
            txtHost.Location = new Point(89, 4);
            txtHost.Margin = new Padding(3, 4, 3, 4);
            txtHost.Name = "txtHost";
            txtHost.Size = new Size(83, 27);
            txtHost.TabIndex = 14;
            txtHost.Text = "localhost";
            txtHost.TextAlign = HorizontalAlignment.Center;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(18, 7);
            label5.Name = "label5";
            label5.Size = new Size(65, 20);
            label5.TabIndex = 9;
            label5.Text = "Address:";
            // 
            // btnStart
            // 
            btnStart.Location = new Point(9, 5);
            btnStart.Margin = new Padding(3, 4, 3, 4);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(86, 31);
            btnStart.TabIndex = 0;
            btnStart.Text = "Start";
            btnStart.UseVisualStyleBackColor = true;
            btnStart.Click += btnStart_Click;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.Control;
            panel2.Controls.Add(panel4);
            panel2.Controls.Add(panel3);
            panel2.Controls.Add(txtLog);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(3, 171);
            panel2.Name = "panel2";
            panel2.Size = new Size(473, 341);
            panel2.TabIndex = 1;
            // 
            // panel4
            // 
            panel4.Controls.Add(btnSend);
            panel4.Controls.Add(txtMsg);
            panel4.Dock = DockStyle.Bottom;
            panel4.Location = new Point(0, 306);
            panel4.Name = "panel4";
            panel4.Size = new Size(473, 35);
            panel4.TabIndex = 3;
            // 
            // btnSend
            // 
            btnSend.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnSend.Location = new Point(375, -1);
            btnSend.Name = "btnSend";
            btnSend.Size = new Size(94, 29);
            btnSend.TabIndex = 3;
            btnSend.Text = "Send";
            btnSend.UseVisualStyleBackColor = true;
            btnSend.Click += btnSend_Click;
            // 
            // txtMsg
            // 
            txtMsg.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtMsg.Location = new Point(9, 1);
            txtMsg.Name = "txtMsg";
            txtMsg.Size = new Size(360, 27);
            txtMsg.TabIndex = 2;
            txtMsg.KeyDown += txtMsg_KeyDown;
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.Control;
            panel3.Controls.Add(btnDisconectAll);
            panel3.Controls.Add(label1);
            panel3.Controls.Add(btnClear);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(473, 63);
            panel3.TabIndex = 2;
            // 
            // btnDisconectAll
            // 
            btnDisconectAll.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnDisconectAll.Location = new Point(347, 19);
            btnDisconectAll.Name = "btnDisconectAll";
            btnDisconectAll.Size = new Size(120, 29);
            btnDisconectAll.TabIndex = 2;
            btnDisconectAll.Text = "Disconect all";
            btnDisconectAll.UseVisualStyleBackColor = true;
            btnDisconectAll.Click += btnDisconectAll_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label1.Location = new Point(109, 19);
            label1.Name = "label1";
            label1.Size = new Size(258, 29);
            label1.TabIndex = 0;
            label1.Text = "Log";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(9, 19);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(94, 29);
            btnClear.TabIndex = 1;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // txtLog
            // 
            txtLog.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtLog.BackColor = Color.White;
            txtLog.Location = new Point(6, 69);
            txtLog.Multiline = true;
            txtLog.Name = "txtLog";
            txtLog.ReadOnly = true;
            txtLog.ScrollBars = ScrollBars.Vertical;
            txtLog.Size = new Size(463, 231);
            txtLog.TabIndex = 1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(870, 523);
            Controls.Add(tableLayoutPanel1);
            Margin = new Padding(3, 4, 3, 4);
            MinimumSize = new Size(800, 398);
            Name = "Form1";
            Text = "Server";
            tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            tableLayoutPanel2.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private DataGridView dataGridView1;
        private TableLayoutPanel tableLayoutPanel2;
        private Panel panel1;
        private Button btnStart;
        private Button btnSend;
        private TextBox txtMsg;
        private Panel panel2;
        private TextBox txtLog;
        private Button btnDisconectAll;
        private Button btnClear;
        private Label label1;
        private Panel panel4;
        private Panel panel3;
        private Panel panel5;
        private CheckBox checkBoxShowKey;
        private TextBox txtPort;
        private Label label4;
        private TextBox txtKey;
        private Label label3;
        private TextBox txtName;
        private Label label2;
        private TextBox txtHost;
        private Label label5;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn name;
    }
}
