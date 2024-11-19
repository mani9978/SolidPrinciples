using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciples
{
    public class ConsoleMessageWriter : IMessageWriter
    {
        public ConsoleMessageWriter()
        {

        }

        public void Write(string message)
        {
            Console.WriteLine(message);
            Console.ReadLine();
        }
    }
}
