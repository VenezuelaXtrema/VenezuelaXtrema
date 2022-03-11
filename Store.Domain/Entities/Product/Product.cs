using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Domain.Entities.Product
{
    [Table(nameof(Product), Schema = "Products")]
    public class Product
    {
        [Column(Order = 0)]
        [Required]
        [Key]
        public int ProductId { get; set; }

        [Column(Order = 1)]
        [Required]
        [MaxLength(85)]
        public string Name { get; set; }

        [Column(Order = 2)]
        [Required]
        [MaxLength(500)]
        public string Description { get; set; }

        [Column(Order = 3)]
        [Required]
        public decimal Price { get; set; }

        [Column(Order = 4)]
        [Required]
        public DateTime CreatedAt { get; set; }

        [Column(Order = 5)]
        [Required]
        public DateTime ModifyAt { get; set; }

        [Column(Order = 6)]
        [Required]
        public Guid CreatedBy { get; set; }

        [Column(Order = 7)]
        public Guid ModifyBy { get; set; }

        [Column(Order = 8)]
        public bool IsDeleted { get; set; }
    }
}
