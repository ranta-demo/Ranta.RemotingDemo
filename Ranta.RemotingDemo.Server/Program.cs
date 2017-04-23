using Ranta.RemotingDemo.Server.Objects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Tcp;
using System.Text;
using System.Threading.Tasks;

namespace Ranta.RemotingDemo.Server
{
    class Program
    {
        static void Main(string[] args)
        {
            TcpChannel tcpChannel = new TcpChannel(8080);

            ChannelServices.RegisterChannel(tcpChannel, false);

            RemotingConfiguration.RegisterWellKnownServiceType(typeof(Student), "RemotingSayHiService", WellKnownObjectMode.Singleton);
            //RemotingConfiguration.RegisterWellKnownServiceType(typeof(Student), "RemotingSayHiService", WellKnownObjectMode.SingleCall);

            Console.WriteLine("Press any key to end.");

            Console.ReadKey();
        }
    }
}
