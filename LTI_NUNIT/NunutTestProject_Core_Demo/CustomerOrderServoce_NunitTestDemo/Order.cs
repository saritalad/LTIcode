using System;
using System.Collections.Generic;
using System.Text;

namespace CustomerOrderServoce_NunitTestDemo
{
    class Order
    {
        public int OrderId { get; set; }
        public int ProductId { get; set; }
        public int ProductQuantity { get; set; }
        public decimal Amount { get; set; }
    }
}
