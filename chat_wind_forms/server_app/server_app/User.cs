using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace server_app
{
    public class User
    {

        public string UserName;
        private static int id_counter=1;
        public int Id;

        public TcpClient Client;
        public StreamWriter sw;
        public StreamReader sr;
        
        public User(TcpClient tcpClient, string UserName) 
        { 
            this.Client = tcpClient;
            this.UserName = UserName;

            sw=new StreamWriter(this.Client.GetStream());
            sr=new StreamReader(this.Client.GetStream());
            Id = id_counter++;
        }
        public User( string UserName)
        {
            
            this.UserName = UserName;

            
        }
    }
}
