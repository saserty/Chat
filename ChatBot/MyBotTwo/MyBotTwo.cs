using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BotSDK;

namespace MyBotTwo
{
    public class MyBotTwo : IBot
    {
        string name = "Mike";

        public string Answer(string message)
        {
            string msg = message;
            if (msg.Equals("bb"))
            {
                string reply = "CYA";
                return reply;
            }
            else { return null; }
        }

        public string Name
        {
            get { return name; }
        }
    }
}
