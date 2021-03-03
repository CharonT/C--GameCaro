using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameCaro1
{
    class SocketManager
    {
        #region Client
        Socket client;
        
        public bool connectServer() {
            IPEndPoint ep = new IPEndPoint(IPAddress.Parse(IP), PORT);
            client = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            try {
                client.Connect(ep); 
                return true;
            }

            catch (Exception e) {
                return false;
            }

        }
        #endregion

        #region Server
        Socket server;
        
        public void createServer()
        {
            IPEndPoint ep = new IPEndPoint(IPAddress.Parse(IP), PORT);
            server = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

            server.Bind(ep);
            server.Listen(10);//cho ket noi trong 10s

            Thread acceptClient = new Thread(()=>
            {
                client = server.Accept();
            });
            acceptClient.IsBackground = true;
            acceptClient.Start();
           
        }
        public void close(SocketManager socket) {

            if (socket.isServer)
                server.Close();
            else client.Close(); 
        }
        #endregion

        #region Both
        public string IP = "127.0.0.1";
        public int PORT = 999;
        public bool isServer = true;
        public const int BUFFER = 1024;
       
        public bool send(object data) {
            byte[] _sendData = SerializeData(data);
           
             return sendData(client, _sendData);
        
           
        }
        public object receive() {
            byte[] _receivedData = new byte[BUFFER];
            bool isOk = receiveData(client,_receivedData);
            return DeserializeData(_receivedData);

        }
       private bool sendData(Socket target,byte[] data) {

            return target.Send(data) == 1 ? true : false; 
        }
        
        private bool receiveData(Socket target, byte[] data) {
            return target.Receive(data) == 1 ? true : false;
        }

        /// <summary>
        /// Nén đối tượng thành mảng byte[]
        /// </summary>
        /// <param></param>
        /// <returns></returns>
        public byte[] SerializeData(Object o)
        {
            MemoryStream ms = new MemoryStream();
            BinaryFormatter bf1 = new BinaryFormatter();
            bf1.Serialize(ms, o);
            return ms.ToArray();
        }

        /// <summary>
        /// Giải nén mảng byte[] thành đối tượng object
        /// </summary>
        /// <param name="theByteArray"></param>
        /// <returns></returns>
        public object DeserializeData(byte[] theByteArray)
        {
            MemoryStream ms = new MemoryStream(theByteArray);
            BinaryFormatter bf1 = new BinaryFormatter();
            ms.Position = 0;
            return bf1.Deserialize(ms);
        }

        /// <summary>
        /// Lấy ra IP V4 của card mạng đang dùng
        /// </summary>
        /// <param name="_type"></param>
        /// <returns></returns>
        public string GetLocalIPv4(NetworkInterfaceType _type)
        {
            string output = "";
            foreach (NetworkInterface item in NetworkInterface.GetAllNetworkInterfaces())
            {
                if (item.NetworkInterfaceType == _type && item.OperationalStatus == OperationalStatus.Up)
                {
                    foreach (UnicastIPAddressInformation ip in item.GetIPProperties().UnicastAddresses)
                    {
                        if (ip.Address.AddressFamily == AddressFamily.InterNetwork)
                        {
                            output = ip.Address.ToString();
                        }
                    }
                }
            }
            return output;
        }

        #endregion
    }
}
