using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UFPCore.Configuration
{
    public class SmtpConfiguration
    {
        public string Server { get; set; }
        public int Port { get; set; }
        public string EmailAddress { get; set; }
        public string Password { get; set; }
        public string DefaultEmailTo { get; set; }
    }
}
