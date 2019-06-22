using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PaperStore.Models
{
    public class Company
    {
        public int Id { get; set; }
        [StringLength(10, MinimumLength = 10)]
        public string Nip { get; set; }
        [StringLength(50, MinimumLength = 0)]
        public string Address { get; set; }
        [StringLength(50, MinimumLength = 0)]
        public string Name { get; set; }
        [StringLength(50, MinimumLength = 0)]
        public string Email { get; set; }
        [StringLength(20, MinimumLength = 0)]
        public string Phone { get; set; }
        public RelationCode RelationCode { get; set; }

    }
}
