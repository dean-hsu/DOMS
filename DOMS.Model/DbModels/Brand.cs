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
        public string BrandName { get; set; }
        public string BrandLogo { get; set; }
        public Country Country { get; set; }
        public string BrandDescription { get; set; }
    }
}
