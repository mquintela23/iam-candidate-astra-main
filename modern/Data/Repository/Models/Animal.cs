using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Business.Data.Repository.Models
{
    [Table("Animal")]
    public partial class Animal
    {
        [Key]
        [Column("ID")]
        public Guid Id { get; set; }
        [StringLength(50)]
        public string CommonName { get; set; } = null!;
        public int LegCount { get; set; }
        public int WingCount { get; set; }
        public bool CanFly { get; set; }
        [StringLength(50)]
        public string TaxPhylum { get; set; } = null!;
        [StringLength(50)]
        public string TaxClass { get; set; } = null!;
        [StringLength(50)]
        public string TaxOrder { get; set; } = null!;
        [StringLength(50)]
        public string TaxFamily { get; set; } = null!;
        [StringLength(50)]
        public string TaxGenus { get; set; } = null!;
        [StringLength(50)]
        public string TaxSpecies { get; set; } = null!;
    }
}
