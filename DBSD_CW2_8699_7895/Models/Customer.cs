using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace DBSD_CW2_8699_7895.Models
{
    public class Customer
    {
        [DisplayName("Customer Id")]
        public int CustomerId { get; set; }
        
        [DisplayName("First Name")]
        [Required]
        [MinLength(3)]
        public string FirstName { get; set; }
        
        [DisplayName("Last Name")]
        [Required]
        [MinLength(3)]
        public string LastName { get; set; }
        
        [DisplayName("Restaurant Id")]
        public int RestaurantId { get; set; }
        
        [DisplayName("Waiter Id")]
        public int WaiterId { get; set; }

    }
}
