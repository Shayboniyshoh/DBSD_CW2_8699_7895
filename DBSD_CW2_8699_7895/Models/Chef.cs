using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace DBSD_CW2_8699_7895.Models
{
    public class Chef
    {
        [DisplayName("Chef Id")]
        public int ChefId { get; set; }
        
        [DisplayName("First Name")]
        [Required]
        [MinLength(3)]
        public string FirstName { get; set; }
        
        [DisplayName("Last Name")]
        [Required]
        [MinLength(3)]
        public string LastName { get; set; }
        
        [DisplayName("DoB")]
        [Required]
        public DateTime DoB { get; set; }
        
        [DisplayName("Salary")]
        [Range(1, int.MaxValue)]
        [Required]
        public int Salary { get; set; }
        
        [DisplayName("Phone Number")]
        [Phone]
        [Required]
        public string PhoneNumber { get; set; }
        
        [DisplayName("Restaurant Id")]
        [Range(1, int.MaxValue)]
        public int RestaurantId { get; set; }
    }
}
