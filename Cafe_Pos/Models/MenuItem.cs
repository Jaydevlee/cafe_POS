using System;
using System.Collections.Generic;
using System.Text;

namespace Cafe_Pos.Models
{
    public class MenuItem
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }
        public int Price { get; set; }
        public int Is_active { get; set; }

    }
}
