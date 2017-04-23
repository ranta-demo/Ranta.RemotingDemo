using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ranta.RemotingDemo.Contract
{
    public interface ISayHiService
    {
        string SayHi(string name);

        string SayHi();
    }
}
