    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

namespace ASD.Models
{
    public class Product
    {
        [Key]
        public int ProductID { get; set; }

        [Required]
        [Display(Name = "Product Name")]
        [StringLength(50)]
        public string Product_name { get; set; }

        [Display(Name = "Product Description")]
        [StringLength(100)]
        public string Product_Description { get; set; }

        [Display(Name = "Product Wholesaler Cost")]
        public decimal Product_Wholesaler_Cost { get; set; }

        [Display(Name = "Min Price")]
        public decimal? Product_Min_Price { get; set; }

        [Display(Name = "Max Price")]
        public decimal? Product_Max_Price { get; set; }

        [Display(Name = "Quantity")]
        public int? Product_Quantity { get; set; }

        public virtual List<OrderDetail> OrderDetails { get; set; }
    }
}
