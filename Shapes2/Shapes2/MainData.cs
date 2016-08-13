using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Shapes2
{
    public static class MainData
    {
        


            public static string myName { get; set; }
            public static string myIp { get; set; }
            public static string enemyName { get; set; }
            public static string enemyIp { get; set; }

            public static IPEndPoint senderEp = null;
            public static UdpClient senderUdp = new UdpClient();

            public static IPEndPoint ReceiveIpEndPoint = null;
            public static UdpClient receiverUdp = new UdpClient();




        
    }
}
