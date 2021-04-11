using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace DBSD_CW2_8699_7895.Models
{
    public class Order
    {
        [DisplayName("Order Id")]
        public int OrderId { get; set; }
        
        [DisplayName("Pizza Name")]
        [MinLength(3)]
        [Required]
        public string PizzaName { get; set; }
        
        [DisplayName("Order Date")]        
        [Required]
        public DateTime OrderDate { get; set; }
       
        [DisplayName("Size")]
        [MinLength(3)]
        [Required]
        public string Size { get; set; }
        
        [DisplayName("Quantity")]
        [Range(1, int.MaxValue)]
        [Required]
        public int Quantity { get; set; }
        
        [DisplayName("Total Cost")]
        [Range(1, int.MaxValue)]
        [Required]
        public int TotalCost { get; set; }
        
        [DisplayName("Discount Available")]        
        public bool IsDiscountAvailable { get; set; }
        
        [Range(0, 9999.99)]
        public decimal Discount { get; set; }
        
        [DisplayName("Restaurant Id")]
        public int RestaurantId { get; set; }
        
        [DisplayName("Customer Id")]
        [Range(1, int.MaxValue)]
        public int CustomerId { get; set; }
        
        [DisplayName("Waiter Id")]
        [Range(1, int.MaxValue)]
        public int WaiterId { get; set; }
        
        [DisplayName("Chef Id")]
        [Range(1, int.MaxValue)]
        public int ChefId { get; set; }
        public byte[] Photo { get; set; }
    }
}