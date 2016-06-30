using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using System.Windows.Forms;
using MyBotOne;
using MyBotTwo;
using MyBotThree;

namespace ChatBot
{
    public class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());

            
        }


        string message;// = "hi";

        string BotsLocation = @"BotsLocation";

        public Type fillBotsList()
        {
            string[] files = Directory.GetFiles(BotsLocation, "*.dll");
            List<string> lst = new List<string>();
            lst.AddRange(files);
            Type type = null;
            Assembly myAsm = Assembly.LoadFrom(BotsLocation);
            foreach(Type t in myAsm.GetTypes())
            {
                return type;
            }
            return type;
        }

            public List<Type> ChatBots;
            

        public string botNames(Type inputtype)
        {
            string name = null;
            object obj2 = Activator.CreateInstance(inputtype);
            foreach(PropertyInfo property in inputtype.GetProperties())
            {
                if(property.Name.Equals("Name"))
                {
                    name = property.GetValue(obj2).ToString();
                }
            }
            return name;
        }
            
        public string Answers(string input)
        {
            string answer = null;
            foreach(var bot in ChatBots)
            {
                object obj1;
                obj1 = Activator.CreateInstance(bot);
                foreach (MethodInfo method in bot.GetMethods())
                {
                    if(method.Name.Equals("Answer"))
                    {
                        string responce = method.Invoke(obj1, null).ToString();
                        if(responce != null)
                        {
                            if(bot == ChatBots.Last())
                            {return null;}
                        }
                        answer = botNames(bot) + ": " + responce;//"{0} : {1}", botNames(bot), responce);
                        return answer;
                    }
                }
            }
            return answer;
        }
    }
}