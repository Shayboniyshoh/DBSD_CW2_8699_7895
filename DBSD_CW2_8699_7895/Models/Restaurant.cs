using System.ComponentModel;

namespace DBSD_CW2_8699_7895.Models
{
    public class Restaurant
    {
        [DisplayName("RestaurantId")]
        public int RestaurantId { get; set; }
        [DisplayName("[Name]")]
        public string Name { get; set; }
        [DisplayName("Street")]
        public string Street { get; set; }
        [DisplayName("City")]
        public string City { get; set; }
    }
}
