using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace GeneralStore.MVC.Models
{
    public class Transaction
    {
        [Key]
        public int TransactionID { get; set; }

        [ForeignKey(nameof(Customer))]  // or [ForeignKey("Customer")]
        public int CustomerID { get; set; }
        public virtual Customer Customer { get; set; }

       
        
        public int ProductId { get; set; }
        
        [Display(Name = "Product ID")]
        [ForeignKey(nameof(Product))] // or [ForeignKey("Product")]
        public virtual List<Product> ProductList { get; set; }



        [Required]
        public int ProductPurchased { get; set; }

        //[Required]
        public DateTime DateOfTransaction { get; set; }

    }
}