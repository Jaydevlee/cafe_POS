using System;
using System.Collections.Generic;
using System.Text;

namespace Cafe_Pos.Models
{
    public class OrderChart
    {
        public DateTime order_date { get; set; }
        public long daily_total { get; set; }
    }
}
