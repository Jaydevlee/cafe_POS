using System;
using System.Collections.Generic;
using System.Text;

namespace Cafe_Pos.Models
{
    public class DbConnect
    {
        public string Server { get; set; }
        public string Port { get; set; }
        public string Database { get; set; }
        public string Uid { get; set; }
        public string Pwd { get; set; }
        public string Charset { get; set; }
    }
}
