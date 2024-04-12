using Microsoft.VisualBasic.ApplicationServices;
using System.Net;
using System.Net.Sockets;
using System.Text.Json;

namespace server_app
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            InitializeDataGridView();
            RecivedMessage += RecivedMessagePassForeward;
        }

        private void InitializeDataGridView()
        {
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.AllowUserToAddRows = false;
            DataGridViewButtonColumn buttonColumn = new DataGridViewButtonColumn();
            buttonColumn.HeaderText = "Disconect";
            buttonColumn.Text = "Disconect";
            buttonColumn.Name = "btnColumn";
            buttonColumn.UseColumnTextForButtonValue = true;
            dataGridView1.Columns.Add(buttonColumn);

            UpdateUserListEvent += updateUserGrid;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Check if the clicked cell is in the button column
            if (e.ColumnIndex == dataGridView1.Columns["btnColumn"].Index && e.RowIndex >= 0)
            {

                int userId = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["id"].Value);
                disconectUser(userId);
            }
        }

        public delegate void RecivedMessageHandler(Messages.Message msg, User us);
        public event RecivedMessageHandler RecivedMessage;



        public void RecivedMessagePassForeward(Messages.Message msg, User us)
        {
            if (txtLog.InvokeRequired)
            {
                txtLog.Invoke(new MethodInvoker(delegate { RecivedMessagePassForeward(msg, us); }));
            }
            else
            {
                addToLog(us.UserName + " " + msg.Text);

                foreach (var a in users)
                {
                    if (us == a)
                        continue;
                    SendMessage(msg, a);
                }
            }

        }

        private List<User> users = new List<User>();

        public bool Authorize(Messages.Authorization auth)
        {
            if (auth.Key == txtKey.Text)
            {
                return true;
            }
            return false;
        }

        public bool SendMessage(Messages.Message message, User us)
        {

            string jsonString = JsonSerializer.Serialize(message);
            us.sw.WriteLine(jsonString);
            us.sw.Flush();
            return true;
        }

        public Messages.Authorization? ReadMessageAuthorization(NetworkStream stream)
        {
            StreamReader sr = new StreamReader(stream);
            string lineRecived = "";
            try
            {
                lineRecived = sr.ReadLine();
            }
            catch (Exception ex)
            {
                return null;
            }

            if (lineRecived == null)
            {
                return null;
            }

            Messages.Authorization msg = JsonSerializer.Deserialize<Messages.Authorization>(lineRecived);
            return msg;
        }
        public Messages.Message? ReadMessage(User user)
        {

            string lineRecived = "";
            try
            {
                lineRecived = user.sr.ReadLine();
            }
            catch (Exception ex)
            {
                return null;
            }

            if (lineRecived == null)
            {
               

                User userToRemove = users.Find(u => u.Id == user.Id);
                if (userToRemove != null)
                {
                    userToRemove.Client.Close();
                    users.Remove(userToRemove);
                }

                this.Invoke(new Action(() =>
                {
                    UpdateUserListEvent?.Invoke(this, new EventArgs());
                    addToLog($"{user.UserName} disconnected");
                    
                    Messages.Message message = new Messages.Message(txtName.Text, $"{user.UserName} disconnected", DateTime.Now);
                    RecivedMessage.Invoke(message, new User(txtName.Text));
                }
                
                
                ));
                return null;
            }

            Messages.Message msg = JsonSerializer.Deserialize<Messages.Message>(lineRecived);
            msg.Sender = user.UserName;
            return msg;
        }

        public event EventHandler<EventArgs> UpdateUserListEvent;
        private void updateUserGrid(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            foreach (var user in users)
            {

                dataGridView1.Rows.Add(user.Id, user.UserName);
            }
        }

        private async void listenServer(TcpListener listener)
        {
            while (true)
            {
                try
                {
                    TcpClient handler = await listener.AcceptTcpClientAsync();
                    NetworkStream stream = handler.GetStream();

                    Messages.Authorization auth = ReadMessageAuthorization(stream);

                    User user = new User(handler, auth.Sender);
                    if (Authorize(auth))
                    {
                        Messages.Message message = new Messages.Message(txtName.Text, Messages.Message.Authorized, DateTime.Now);
                        SendMessage(message, user);
                        users.Add(user);
                        updateUserGrid(this, new EventArgs());
                        addToLog($" {user.UserName} connected");


                        Messages.Message mm = new Messages.Message(txtName.Text, $"{user.UserName} connected", DateTime.Now);
                        RecivedMessage.Invoke(mm, user);

                        Task.Run(() =>
                        {
                            while (true)
                            {
                                Messages.Message msg = ReadMessage(user);
                                if (msg != null)
                                    RecivedMessage.Invoke(msg, user);
                                else
                                    break;
                            }
                        });
                    }
                    else
                    {
                        Messages.Message message = new Messages.Message(txtName.Text, Messages.Message.Unauthorized, DateTime.Now);
                        SendMessage(message, user);
                        handler.Close();

                    }



                }
                catch (Exception ex)
                {
                    //addToLog(ex.Message);
                    if (!is_running)
                        break;
                }
            }
        }
        private void addToLog(string txt)
        {

            txtLog.Text += DateTime.Now.ToString("HH:mm") + "| " + txt + "\r\n";
        }

        private bool is_running = false;
        private TcpListener listener;
        private async void btnStart_Click(object sender, EventArgs e)
        {
            if (is_running)
            {
                btnStart.Text = "Start";
                while (users.Count > 0)
                {
                    disconectUser(users.First().Id);
                }
                listener.Dispose();
                addToLog("Stoping server");
                txtHost.Enabled = true;
                txtPort.Enabled = true;
            }
            else
            {
                try
                {
                    txtHost.Enabled = false;
                    txtPort.Enabled = false;
                    btnStart.Text = "Stop";
                    string host = txtHost.Text;
                    if (host == "localhost")
                    {
                        host = "127.0.0.1";
                    }
                    var ipEndPoint = new IPEndPoint(IPAddress.Parse(host), int.Parse(txtPort.Text));
                    addToLog($"Starting host on address: {IPAddress.Parse(host)} on port: {int.Parse(txtPort.Text)}");
                    listener = new(ipEndPoint);
                    listener.Start();
                    listenServer(listener);
                }
                catch (Exception ex)
                {
                    addToLog(ex.Message);
                }

            }
            is_running = !is_running;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtLog.Text = "";
        }


        private void btnSend_Click(object sender, EventArgs e)
        {
            Messages.Message msg = new Messages.Message(txtName.Text, txtMsg.Text, DateTime.Now);
            txtMsg.Text = "";
            RecivedMessage.Invoke(msg, new User(txtName.Text));
        }

        private void txtMsg_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Messages.Message msg = new Messages.Message(txtName.Text, txtMsg.Text, DateTime.Now);
                txtMsg.Text = "";
                RecivedMessage.Invoke(msg, new User(txtName.Text));
            }
        }

        private void disconectUser(int id)
        {
            User userToRemove = users.Find(u => u.Id == id);
            if (userToRemove != null)
            {
                addToLog($"{userToRemove.UserName} disconnected");
                userToRemove.Client.Close();
                users.Remove(userToRemove);

                Messages.Message message = new Messages.Message(txtName.Text, $"{userToRemove.UserName} disconnected", DateTime.Now);
                RecivedMessage.Invoke(message, new User(txtName.Text));

                updateUserGrid(this, new EventArgs());
            }
        }
        private void btnDisconectAll_Click(object sender, EventArgs e)
        {
            while (users.Count > 0)
            {
                disconectUser(users.First().Id);
            }
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
    }
}
