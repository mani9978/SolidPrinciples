﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciples
{
    public class MessageReader : IMessageReader
    {
        public MessageReader()
        {

        }

        public string ReadMessage()
        {
            return "Hello World!";
        }
    }
}
