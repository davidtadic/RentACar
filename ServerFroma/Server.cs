using KontorlerAplikacioneLogike;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ServerForma
{
    public class Server
    {

        Socket socket;
        BinaryFormatter formatter = new BinaryFormatter();
        KontrolerAL kal;
        

        public Server()
        {
            kal = new KontrolerAL();
        }


        public void PokreniServer()
        {
            socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            socket.Bind(new IPEndPoint(IPAddress.Any, 50000));

            ThreadStart ts = OsluskivanjeKlijenta;
            Thread nit = new Thread(ts);
            nit.Start();
        }

        private void OsluskivanjeKlijenta()
        {
            socket.Listen(0);
            while (true)
            {
                Socket klijent = socket.Accept();
                NetworkStream tok = new NetworkStream(klijent);

                new ObradaZahtevaKlijenta(tok);


            }
        }

        

        
    }
}
