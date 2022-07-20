using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Business.Data.Repository.Models
{
    [Table("Vegetable")]
    public partial class Vegetable
    {
        [Key]
        [Column("ID")]
        public Guid Id { get; set; }
        [StringLength(50)]
        public string Name { get; set; } = null!;
        [StringLength(30)]
        public string EdiblePart { get; set; } = null!;
        public bool IsBotanicalFruit { get; set; }
    }
}
