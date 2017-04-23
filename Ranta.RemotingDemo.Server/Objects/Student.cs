using Ranta.RemotingDemo.Contract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ranta.RemotingDemo.Server.Objects
{
    public class Student : MarshalByRefObject, ISayHiService
    {
        public Student()
        {
            Console.WriteLine("Student instance is created.");
        }

        public string SayHi()
        {
            string returnValue = "SayHi() is called";

            Console.WriteLine(returnValue);

            return returnValue;
        }

        public string SayHi(string name)
        {
            string returnValue = string.Format("Hi, {0}", name);

            Console.WriteLine(returnValue);

            return returnValue;
        }
    }
}
