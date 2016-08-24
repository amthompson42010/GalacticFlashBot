using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GalacticFlashBot
{
    class Program
    {
        static void Main(string[] args)
        {
            Info info = new Info();
            Commands command = new Commands();
            IrcClient irc = new IrcClient(info.IP(), info.PORT(), info.USERNAME(), info.SECRET());
            irc.joinRoom(info.HOST());
            while(true)
            {
                string message = irc.readMessage();
                foreach (string i in command.CommandsArray())
                {
                    if (message.Contains(i))
                    {
                        switch (i)
                        {
                            case "!hello":
                                Hello.hello(irc);
                                break;
                            case "!github":
                                break;
                            case "!facebook":
                                break;
                            case "!twitter":
                                break;
                            case "!social":
                                break;
                            case "!commands":
                                command.twitchCommand(irc);
                                break;
                        }
                    }
                }
            }
        }
    }
}
