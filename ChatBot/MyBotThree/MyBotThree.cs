using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BotSDK;

namespace MyBotThree
{
    public class MyBotThree : IBot
    {
        string name = "Doni";

        public string Answer(string message)
        {
            string msg = message;
            if (msg.Equals("how are you?"))
            {
                string reply = "busy as hell";
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
