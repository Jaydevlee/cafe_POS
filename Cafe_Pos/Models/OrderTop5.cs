using System;
using System.Collections.Generic;
using System.Text;

namespace Cafe_Pos.Models
{
    public class OrderTop5
    {
        public string name { get; set; }
        public int quantity { get; set; }
        public decimal subtotal { get; set; }
        public double ratio { get; set; }
    }
}
