using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace JustChatting.Client.Models
{
    [Serializable]
    public class LogIn
    {
        [XmlAttribute()]
        public string Username { get; set; }
        [XmlAttribute()]
        public string Password { get; set; }
        public LogIn(string username, string password)
        {
            Username = username;
            Password = password;
        }
        public LogIn()
        {

        }
    }
}
