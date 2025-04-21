using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using interfaces.Interfaces;

namespace interfaces.Implementations
{
    public class SayHelloThree : ISayHello
    {
        void ISayHello.SayHello(string name)
        {
            Console.WriteLine("This is from SayHelloThree");
        }
    }
}
