using System.ComponentModel;

namespace DBSD_CW2_8699_7895.Models
{
    public class Customer
    {
        [DisplayName("Customer Id")]
        public int CustomerId { get; set; }
        [DisplayName("First Name")]
        public string FirstName { get; set; }
        [DisplayName("Last Name")]
        public string LastName { get; set; }
        [DisplayName("Restaurant Id")]
        public int RestaurantId { get; set; }
        [DisplayName("Waiter Id")]
        public int WaiterId { get; set; }

    }
}
