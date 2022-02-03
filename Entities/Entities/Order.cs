using Entities.Entities.Enums;
using Entities.Notifications;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Entities.Entities
{
    [Table("Order")]
    public class Order : Notifies
    {
        [Column("ORDER_ID")]
        [Display(Name = "Código")]
        public int Id { get; set; }

        [Display(Name = "Product")]
        [ForeignKey("Product")]
        [Column(Order = 1)]
        public int ProductId { get; set; }
        public virtual Product Product { get; set; }

        [Column("ORDER_STATUS")]
        [Display(Name = "Fase")]
        public OrderStatus status { get; set; }

        [Column("ORDER_QUANTITY")]
        [Display(Name = "QUANTITY")]
        public int Quantity { get; set; }

        [Column("ORDER_PRICE")]
        [Display(Name = "Price")]
        public decimal Price { get; set; }

        [Display(Name = "User")]
        [ForeignKey("ApplicationUser")]
        [Column(Order = 1)]
        public string UserId { get; set; }
        public virtual ApplicationUser ApplicationUser { get; set; }

        [Column("ORDER_DATE_CREATE")]
        [Display(Name = "Date Create")]
        public DateTime DateCreate { get; set; }

        [Column("ORDER_DATE_UPDATE")]
        [Display(Name = "Date Update")]
        public DateTime DateUpdate { get; set; }
    }
}
