using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DOMS.Model.DbModels
{
    [Table("DOMS_Catalogue")]
    public class Catalogue
    {
        [Key]
        public int CatalogueId { get; set; }
        public int FamilyId { get; set; }
        [Required]
        public string Name { get; set; }
        public string Memo { get; set; }
        public Family Family { get; set; }
    }
}
