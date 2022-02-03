using Entities.Notifications;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Entities.Entities
{
    [Table("Product")]
    public class Product : Notifies
    {
        [Column("PROD_ID")]
        [Display(Name = "ID")]
        public int Id { get; set; }

        [Column("PROD_NAME")]
        [MaxLength(255)]
        [Display(Name = "NAME")]
        public string Name { get; set; }

        [Column("PROD_DESCRIPTION")]
        [MaxLength(150)]
        [Display(Name = "DESCRIPTION")]
        public string Description { get; set; }

        [Column("PROD_NOTE")]
        [MaxLength(20000)]
        [Display(Name = "NOTE")]
        public string Note{ get; set; }

        [Column("PROD_QUANTITY")]
        [Display(Name = "QUANTITY")]
        public int Quantity { get; set; }

        [Display(Name = "USER")]
        [ForeignKey("ApplicationUser")]
        [Column(Order = 1)]
        public string UserId { get; set; }
        public virtual ApplicationUser ApplicationUser { get; set; }

        [Column("PROD_PRICE")]
        [Display(Name = "Price")]
        public decimal Price { get; set; }

        [Column("PROD_STATUS")]
        [Display(Name = "Status")]
        public bool Status { get; set; }

        [Column("PROD_DATE_CREATE")]
        [Display(Name = "Date Create")]
        public DateTime DateCreate{ get; set; }

        [Column("PROD_DATE_UPDATE")]
        [Display(Name = "Date Update")]
        public DateTime DateUpdate{ get; set; }

    }
}
