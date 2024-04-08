using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Net.Sockets;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Diagnostics;
using System.IO;
using System.ComponentModel;

namespace chat_wind_forms
{
    public class Comunication
    {

        string sender;
        int port;
        string host;
        string key;

        public string Username { get { return sender; } }

        StreamWriter sw;
        StreamReader sr;
        TcpClient client;

        public bool is_connected = false;
        Connect con;


        public Comunication(string host, int port, string sender, string key, Connect con)
        {
            this.host = host;
            this.port = port;
            this.key = key;
            this.sender = sender;
            this.con = con;
            ConnectToServer();
        }
        public void disconnect()
        {
            sw.Close();
            sr.Close();
            client.Close();
            is_connected = false;
        }
        public void ConnectToServer()
        {
            // conecting
            try
            {
                con.RaiseProgresChangeEvent(this, 25);
                client = new TcpClient(host, port);
                sw = new StreamWriter(client.GetStream());
                sr = new StreamReader(client.GetStream());

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            // try to authorize
            bool res = Authorize();
            if (res)
            {
                con.RaiseProgresChangeEvent(this, 100);
                MessageBox.Show("Connected", "Connected", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                con.RaiseProgresChangeEvent(this, 0);
                MessageBox.Show("Failed to authorize", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
        public bool SendMessage(Messages.Message message)
        {
            if (!is_connected) return false;
            string jsonString = JsonSerializer.Serialize(message);
            sw.WriteLine(jsonString);
            sw.Flush();
            return true;
        }
        public bool Authorize()
        {
            Messages.Authorization auth = new Messages.Authorization(sender, key);
            string jsonString = JsonSerializer.Serialize(auth);

            con.RaiseProgresChangeEvent(this, 50);
            sw.WriteLine(jsonString);
            sw.Flush();

            is_connected = true; // just to get response
            Messages.Message response = ReadMessage();
            con.RaiseProgresChangeEvent(this, 75);
            is_connected = false;

            if (response == null)
                return false;
            is_connected = (response.Text == Messages.Message.Authorized);
            return is_connected;
        }
        public Messages.Message? ReadMessage()
        {
            if (!is_connected) return null;
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
                
            Messages.Message msg = JsonSerializer.Deserialize<Messages.Message>(lineRecived);
            return msg;
        }
    }
}
