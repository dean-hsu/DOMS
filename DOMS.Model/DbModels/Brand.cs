using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DOMS.Model.DbModels
{
    [Table("DOMS_Brand")]
    public class Brand : BaseModel
    {
        [Key]
        public int BrandId { get; set; }

        [Required]
        [Display(Name = "Name")]
        public string BrandName { get; set; }

        [Display(Name = "Logo")]
        public string BrandLogo { get; set; }

        [Display(Name = "Country")]
        public int CountryId { get; set; }

        [Display(Name = "Description")]
        public string BrandDescription { get; set; }

        public Country Country { get; set; }
    }
}
