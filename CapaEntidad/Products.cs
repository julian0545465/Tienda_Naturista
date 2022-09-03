using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Products
    {
        public int Code { get; set; }
        public string? Description { get; set; }

        public int Value { get; set; }
        public int Quantity { get; set; }
    }
}
