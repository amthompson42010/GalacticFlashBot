using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GalacticFlashBot
{
    class Commands
    {
        string[] commands = new string[] {"!hello", "!commands", "!github", "!facebook", "!twitter", "!social"};

        public string[] CommandsArray()
        {
            return commands;
        }

        public void twitchCommand(IrcClient irc)
        {
            irc.sendChatMessage("The following are commands that may be entered: " + CommandsArray()[0] + " " + CommandsArray()[1] + " " + CommandsArray()[2] + " " + CommandsArray()[3] + " " + CommandsArray()[4] + " " + CommandsArray()[5]);
        }
    }
}
