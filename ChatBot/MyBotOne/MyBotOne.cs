using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BotSDK;

namespace MyBotOne
{
    public class MyBotOne : IBot
    {
        string name = "Leo";

        public string Answer(string message)
        {
            string msg = message;
            if (msg.Equals("hi"))
            {
                string reply = "hello";
                return reply;
            }
            else { return null; }
        }

        public string Name
        {
            get { return name; }
        }
    }
    //static class Rules
    //{
    //    static string AnswerRules(string input)
    //    {

    //    }
    //}
}