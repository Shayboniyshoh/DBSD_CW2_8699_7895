using System.ComponentModel;

namespace DBSD_CW2_8699_7895.Models
{
    public class Customer
    {
        [DisplayName("CustomerId")]
        public int CustomerId { get; set; }
        [DisplayName("FirstName")]
        public string FirstName { get; set; }
        [DisplayName("LastName")]
        public string LastName { get; set; }
        [DisplayName("RestaurantId")]
        public int RestaurantId { get; set; }
        [DisplayName("WaiterId")]
        public int WaiterId { get; set; }

    }
}
