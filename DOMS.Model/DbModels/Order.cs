using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DOMS.Model.DbModels
{
    public enum OrderStatus
    {
        Ready,
        Purchased,
        Delivered,
        Received,
        Done,
        Cancelled
    }

    public enum PaymentStatus
    {
        Unpaid,
        Paid
    }

    public enum PaymentMethod
    {
        Wechat,
        Alipay,
        Wedian,
        Other
    }

    [Table("DOMS_Order")]
    public class Order : BaseModel
    {
        [Key]
        public int OrderId { get; set; }
        [Required]
        public Product Product { get; set; }
        [Required]
        public int Quantity { get; set; }
        public decimal SellPriceAud { get; set; }
        [Required]
        public decimal SellPriceRmb { get; set; }
        [Required]
        public OrderStatus Status { get; set; }
        [Required]
        public PaymentStatus PaymentStatus { get; set; }
        public PaymentMethod? PaymentMethod { get; set; }
        [Required]
        public Customer Purchaser { get; set; }
        public Delivery Delivery{ get; set; }
        public string Memo { get; set; }
    }
}
