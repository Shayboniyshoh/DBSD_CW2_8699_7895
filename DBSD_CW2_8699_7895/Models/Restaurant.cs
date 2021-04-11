using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace DBSD_CW2_8699_7895.Models
{
    public class Restaurant
    {
        [DisplayName("Restaurant Id")]
        public int RestaurantId { get; set; }
        
        [DisplayName("Restaurant Name")]
        [Required]
        [MinLength(3)]
        public string Name { get; set; }
        
        [DisplayName("Street")]
        [Required]
        [MinLength(3)]
        public string Street { get; set; }
        
        [DisplayName("City")]
        [Required]
        [MinLength(3)]
        public string City { get; set; }
    }
}
