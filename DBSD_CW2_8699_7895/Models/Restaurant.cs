using System.ComponentModel;

namespace DBSD_CW2_8699_7895.Models
{
    public class Restaurant
    {
        [DisplayName("Restaurant Id")]
        public int RestaurantId { get; set; }
        [DisplayName("Restaurant Name")]
        public string Name { get; set; }
        [DisplayName("Street")]
        public string Street { get; set; }
        [DisplayName("City")]
        public string City { get; set; }
    }
}
