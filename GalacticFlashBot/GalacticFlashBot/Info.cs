using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GalacticFlashBot
{
    public class Info
    {
        string username = "galactic_flash";
        string ip = "irc.twitch.tv";
        int port = 6667;
        string secret = "oauth:s0zgvlabz9v9icdqyiunw3o7650k1a";
        string host = "galactic_flash";

        public string USERNAME()
        {
            return username;
        }

        public string IP()
        {
            return ip;
        }

        public int PORT()
        {
            return port;
        }

        public string SECRET()
        {
            return secret;
        }

        public string HOST()
        {
            return host;
        }
    }
}
