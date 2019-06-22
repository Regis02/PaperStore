using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PaperStore.Models
{
    public class InvoiceSupplies
    {
        public Supplies Supplies { get; set; }
        public Invoice Invoice { get; set; }
        public int SuppliesId { get; set; }
        public int InvoiceId { get; set; }
    }
}
