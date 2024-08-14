using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumDeneme
{
    public static class Extentions
    {
        public enum OrderStatus
        {
            Pending,
            Processing,
            Shipped,
            Delivered

        }
        public class Order
        {
            public OrderStatus Status { get; set; }
        }


    }
}
