using System;
using System.Collections.Generic;
using System.Text;

namespace Cafe_Pos.Models
{
    public class OrderItems
    {
        public int Id { get; set; }
        public int Order_id { get; set; }
        public int Menu_id { get; set; }
        public string Menu_name { get; set; }
        public int Price { get; set; }
        public int Quantity { get; set; }
        public int Subtotal { get; set; }
    }
}
