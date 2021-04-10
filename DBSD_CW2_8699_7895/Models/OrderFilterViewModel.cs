using X.PagedList;
using System;
using System.ComponentModel;

namespace DBSD_CW2_8699_7895.Models
{
    public class OrderFilterViewModel
    {
        [DisplayName("Pizza Name")]
        public string PizzaName { get; set; }
        [DisplayName("Order Date")]
        public DateTime OrderDate { get; set; }
        [DisplayName("Size")]
        public string Size { get; set; }
        [DisplayName("Discount")]
        public decimal Discount { get; set; }
        [DisplayName("Restaurant Id")]
        public int RestaurantId { get; set; }
        public int CurrentPage { get; set; } = 1;
        public string SortDirection { get; set; } = "ASC";

        public IPagedList<Order> Orders;
    }
}
