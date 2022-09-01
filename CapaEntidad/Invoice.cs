using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Invoice
    {
        public int Number { get; set; }

        public int Date { get; set; }

        public int IdClient { get; set; }

        public int TotalValue { get; set; }

        public int IdE { get; set; }
    }
}
