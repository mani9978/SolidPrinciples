using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciples
{
    public class SocialMediaMessageWriter : IMessageWriter
    {
        public SocialMediaMessageWriter()
        {

        }

        public void Write(string message)
        {
            Console.WriteLine("Post to Social Media: {0}", message);
            Console.ReadLine();
        }
    }
}
