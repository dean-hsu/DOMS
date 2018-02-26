using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DOMS.Model.DbModels
{
    [Table("DOMS_Customer")]
    public class Customer: BaseModel
    {
        [Key]
        public int CustomerId { get; set; }
        [Required]
        public string Name { get; set; }
        public string Address { get; set; }
        [Display(Name = "Phone Name")]
        [Phone]
        public string PhoneNumber { get; set; }
        [Display(Name = "Wechat Account")]
        public string WechatAccount { get; set; }
        [Display(Name = "Wechat Name")]
        public string WechatName { get; set; }
        [Display(Name = "Alipay")]
        public string AlipayAccount { get; set; }
        [Display(Name = "ID Card Number")]
        public string IdCard { get; set; }
        public string UserName { get; set; }
    }
}
