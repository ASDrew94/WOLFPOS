using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Spatial;


namespace ASD.Models
{
    [Table("Customer")]
    public partial class Customer
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Customer_ID { get; set; }

        [Required]
        [Display(Name = "First Name")]
        [StringLength(25)]
        public string Customer_Firstname { get; set; }

        [Required]
        [Display(Name = "Last Name")]
        [StringLength(25)]
        public string Customer_Lastname { get; set; }

        [StringLength(15)]
        [Display(Name = "Cell")]
        public string Customer_Cell { get; set; }

        [StringLength(15)]
        [Display(Name = "Home")]
        public string Customer_Home { get; set; }

        [StringLength(100)]
        [Display(Name = "Address")]
        public string Customer_Address { get; set; }

        [StringLength(15)]
        [Display(Name = "State")]
        public string Customer_State { get; set; }

        [StringLength(5)]
        [Display(Name = "Zip Code")]
        public string Customer_Zip { get; set; }
    }
}
