using Ranta.RemotingDemo.Contract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Tcp;
using System.Text;
using System.Threading.Tasks;

namespace Ranta.RemotingDemo.Client
{
    class Program
    {
        static void Main(string[] args)
        {
            TcpChannel tcpChannel = new TcpChannel();

            ChannelServices.RegisterChannel(tcpChannel, false);

            ISayHiService service = (ISayHiService)Activator.GetObject(typeof(ISayHiService), "tcp://localhost:8080/RemotingSayHiService");

            if (service == null)
            {
                Console.WriteLine("Failed to create remoting objects.");
            }

            Console.WriteLine("Please enter your name. or 'exit' to exit");
            string name = Console.ReadLine();
            while (!"exit".Equals(name, StringComparison.OrdinalIgnoreCase))
            {
                try
                {
                    string returnValue1 = service.SayHi();

                    Console.WriteLine(returnValue1);

                    string returnValue2 = service.SayHi(name);

                    Console.WriteLine(returnValue2);

                    name = Console.ReadLine();
                }
                catch (SocketException ex)
                {
                    Console.WriteLine(ex.ToString());
                }
            }

            //Console.ReadLine();
        }
    }
}
