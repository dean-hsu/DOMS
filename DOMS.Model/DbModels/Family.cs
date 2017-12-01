using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace DOMS.Model.DbModels
{
    [Table("DOMS_Family")]
    public class Family
    {
        [Key]
        public int FamilyId { get; set; }
        [Required]
        public string Name { get; set; }
        public string Memo { get; set; }
        public ICollection<Catalogue> Catalogues { get; set; }
    }
}
