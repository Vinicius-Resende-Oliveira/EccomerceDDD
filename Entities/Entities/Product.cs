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
        [Display(Name = "NAME")]
        public string Name { get; set; }

        [Column("PROD_PRICE")]
        [Display(Name = "Price")]
        public decimal Price { get; set; }

        [Column("PROD_STATUS")]
        [Display(Name = "Status")]
        public bool Status { get; set; }
    }
}
