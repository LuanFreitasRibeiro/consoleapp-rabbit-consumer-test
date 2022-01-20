using System;
using System.Collections.Generic;
using System.Text;

namespace AppOrderWorker.Domain
{
    public sealed class Order
    {
        public int OrderNumber { get; set; }
        public string ItemName { get; set; }
        public float Price { get; set; }
    }
}
