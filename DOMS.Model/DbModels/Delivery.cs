using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DOMS.Model.DbModels
{
    [Table("DOMS_Delivery")]
    public class Delivery : BaseModel
    {
        [Key]
        public int DeliveryId { get; set; }
        [Required]
        public int CourierId { get; set; }
        [Required]
        public string TrackNumber { get; set; }
        public Courier Courier { get; set; }
    }
}
