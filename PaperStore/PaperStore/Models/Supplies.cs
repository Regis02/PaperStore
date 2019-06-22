using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PaperStore.Models
{
    public class Supplies
    {
        public int Id { get; set; }
        [StringLength(30, MinimumLength = 0)]
        public string Name { get; set; }
        public decimal PurchasePrice { get; set; }
        public decimal NetPrice { get; set; }
        public int Qty { get; set; }

    }
}
