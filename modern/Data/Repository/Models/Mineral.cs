using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Business.Data.Repository.Models
{
    [Table("Mineral")]
    public partial class Mineral
    {
        [Key]
        [Column("ID")]
        public Guid Id { get; set; }
        [StringLength(50)]
        public string Name { get; set; } = null!;
        [Column(TypeName = "decimal(3, 1)")]
        public decimal Hardness { get; set; }
        [StringLength(20)]
        public string Luster { get; set; } = null!;
        [StringLength(20)]
        public string Color { get; set; } = null!;
        [StringLength(20)]
        public string Streak { get; set; } = null!;
        [Column(TypeName = "decimal(4, 2)")]
        public decimal SpecificGravity { get; set; }
        [StringLength(40)]
        public string Diaphaneity { get; set; } = null!;
    }
}
