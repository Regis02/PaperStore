using System.ComponentModel.DataAnnotations;

namespace PaperStore.Models
{
    public class RelationCode
    {
        public int Id { get; set; }
        [StringLength(30, MinimumLength = 0)]
        public string Name { get; set; }
    }
}