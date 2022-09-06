using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Invoice
    {
        public int Code { get; set; }

        public DateTime Date { get; set; }

        public int IdClient { get; set; }

        public int TotalValue { get; set; }

        public int IdE { get; set; }

    }
}
