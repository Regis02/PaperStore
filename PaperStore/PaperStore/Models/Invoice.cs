using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PaperStore.Models
{
    public class Invoice
    {
        public int Id { get; set; }
        [StringLength(30, MinimumLength = 0)]
        public string Name { get; set; }
        public decimal Price { get; set; }
        public Company Company { get; set; }
    }
}
