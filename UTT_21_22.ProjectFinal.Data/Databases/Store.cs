using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace UTT_21_22.ProjectFinal.Data.Databases
{
    public class Store
    {
        [Key]
        public string StoreId { get; set; }

        [Required]
        [Column(TypeName = "nvarchar")]
        [MaxLength(80)]
        public string StoreName { get; set; }

        public int? CategoryShopId { get; set; }

        [ForeignKey("CategoryShopId")]
        public CategoryShop CategoryShop { get; set; }

        [Required]
        [Column(TypeName = "nvarchar")]
        [MaxLength(30)]
        public string Owner { get; set; }

        public int? GetStatus { get; set; }

        [Required]
        [Column(TypeName = "nvarchar")]
        [MaxLength(150)]
        public string Address { get; set; }

        [Required]
        [Column(TypeName = "varchar")]
        [MaxLength(20)]
        public string HotLine { get; set; }

        [Column(TypeName = "varchar")]
        [MaxLength(50)]
        public string Email { get; set; }

        [Required]
        [Column(TypeName = "varchar")]
        [MaxLength(50)]
        public string Website { get; set; }

        public byte[] Image { get; set; }
    }
}