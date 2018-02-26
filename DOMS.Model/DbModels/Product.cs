using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DOMS.Model.DbModels
{
    [Table("DOMS_Product")]
    public class Product : BaseModel
    {
        [Key]
        public int ProductId { get; set; }
        [Display(Name = "Name")]
        [Required]
        public string ProductName { get; set; }
        [Display(Name = "Brand")]
        public int BrandId { get; set; }
        public string Description { get; set; }
        [Display(Name = "Current Cost(AUD)")]
        [DataType(DataType.Currency)]
        [Required]
        public decimal CurrentCostAud { get; set; }
        [Display(Name = "Current Cost(RMB)")]
        [DataType(DataType.Currency)]
        public decimal CurrentCostRmb { get; set; }
        [Display(Name = "Current Sell Price(AUD)")]
        [DataType(DataType.Currency)]
        public decimal CurrentSellPriceAud { get; set; }
        [Display(Name = "Current Sell Price(RMB)")]
        [DataType(DataType.Currency)]
        [Required]
        public decimal CurrentSellPriceRmb { get; set; }
        [Display(Name = "Catalogue")]
        public int CatalogueId { get; set; }
        public string Labels { get; set; }
        public string CreatedUserName { get; set; }
        [Display(Name = "Is Public")]
        public bool IsPublic { get; set; }

        public Brand Brand { get; set; }
        public Catalogue Catalogue { get; set; }
        public ApplicationUser CreatedUser { get; set; }
    }
}
