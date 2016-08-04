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
            IrcClient irc = new IrcClient("irc.twitch.tv", 6667, "galacticflashbot", "");
            irc.joinRoom("galactic_flash");
            while (true)
            {
                string message = irc.readMessage();
                if (message.Contains("!hello"))
                {
                    irc.sendChatMessage("Hello there!");
                }
            }
        }
    }
}
