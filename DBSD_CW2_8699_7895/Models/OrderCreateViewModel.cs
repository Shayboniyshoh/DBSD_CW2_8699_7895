using Microsoft.AspNetCore.Http;
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace DBSD_CW2_8699_7895.Models
{
    public class OrderCreateViewModel
    {
        [DisplayName("Order Id")]
        public int OrderId { get; set; }
        [DisplayName("Pizza Name")]
        public string PizzaName { get; set; }
        [DisplayName("Order Date")]
        public DateTime OrderDate { get; set; }
        [DisplayName("Size")]
        public string Size { get; set; }
        [DisplayName("Is Discount Available")]
        public bool IsDiscountAvailable { get; set; }
        [DisplayName("Discount")]
        public decimal Discount { get; set; }
        [DisplayName("Restaurant Id")]
        public int RestaurantId { get; set; }
        [DisplayName("Customer Id")]
        public int CustomerId { get; set; }
        [DisplayName("Waiter Id")]
        public int WaiterId { get; set; }
        [DisplayName("Chef Id")]
        public int ChefId { get; set; }
        [DataType(DataType.Upload)]
        public IFormFile Photo { get; set; }
    }
}
