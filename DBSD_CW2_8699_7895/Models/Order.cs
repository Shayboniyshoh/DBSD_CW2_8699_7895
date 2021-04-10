using System;
using System.ComponentModel;

namespace DBSD_CW2_8699_7895.Models
{
    public class Order
    {
        [DisplayName("OrderId")]
        public int OrderId { get; set; }
        [DisplayName("PizzaName")]
        public string PizzaName { get; set; }
        [DisplayName("OrderDate")]
        public DateTime OrderDate { get; set; }
        [DisplayName("Size")]
        public string Size { get; set; }
        [DisplayName("IsDiscountAvailable")]
        public bool IsDiscountAvailable { get; set; }
        [DisplayName("Discount")]
        public decimal Discount { get; set; }
        [DisplayName("RestaurantId")]
        public int RestaurantId { get; set; }
        [DisplayName("CustomerId")]
        public int CustomerId { get; set; }
        [DisplayName("WaiterId")]
        public int WaiterId { get; set; }
        [DisplayName("ChefId")]
        public int ChefId { get; set; }
        public byte[] Photo { get; set; }
    }
}