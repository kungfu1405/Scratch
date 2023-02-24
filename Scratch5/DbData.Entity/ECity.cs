using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DbData.Entity
{
    [Table("City")]
    public class ECity
    {
        public int Id { get; set; }
        [Required]
        [StringLength(50)]
        public string Name { get; set; }
        [Column(TypeName ="decimal(18,6)")]
        public decimal Latitude { get; set; }
        [Column(TypeName ="decimal(18,6)")]
        public decimal Longitude { get; set; }
    }
}
