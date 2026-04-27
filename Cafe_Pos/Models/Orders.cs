using System;
using System.Collections.Generic;
using System.Text;

namespace Cafe_Pos.Models
{
    public class Orders
    {
        public int Id { get; set; }
        public DateTime Order_date { get; set; }
        public int Total_amount { get; set; }
        public int Received_amount { get; set; }
        public int Change_amount { get; set; }
    }
}
