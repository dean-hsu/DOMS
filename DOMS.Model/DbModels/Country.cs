
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DOMS.Model.DbModels
{
    [Table("DOMS_Country")]
    public class Country
    {
        [Key]
        public int CountryId { get; set; }
        [Required]
        public string CountryCode { get; set; }
        [Required]
        public string CountryName { get; set; }
    }
}
