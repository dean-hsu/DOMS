using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DOMS.Model.DbModels
{
    [Table("DOMS_Courier")]
    public class Courier
    {
        [Key]
        [Required]
        public int CourierId { get; set; }
        [Required]
        public string Name { get; set; }
        public string Address { get; set; }
        [Phone]
        public string PhoneNumber { get; set; }
        public string Wechat { get; set; }
        public string QrCode { get; set; }
    }
}
