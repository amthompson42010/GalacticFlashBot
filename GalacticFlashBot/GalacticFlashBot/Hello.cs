using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GalacticFlashBot
{
    class Hello
    {
        public static void hello(IrcClient irc)
        {
            Info info = new Info();
            irc.sendChatMessage("Hello my name is " + info.HOST() + ". Welcome to my stream! Do '!commands' to list the commands for the channel.");
        }
    }
}
