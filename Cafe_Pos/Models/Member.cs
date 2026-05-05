using System;
using System.Collections.Generic;
using System.Text;

namespace Cafe_Pos.Models
{
    public class Member
    {
        public long id { get; set; }
        public string name { get; set; }
        public string phone { get; set; }
        public int points { get; set; }
        public int addPoints { get; set; }
    }
}
