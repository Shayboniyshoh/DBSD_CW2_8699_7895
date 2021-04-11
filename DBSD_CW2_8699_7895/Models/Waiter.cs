using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace DBSD_CW2_8699_7895.Models
{
    public class Waiter
    {
        [DisplayName("Waiter Id")]
        public int WaiterId { get; set; }
        
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
        public string PhoneNumber { get; set; }
        
        [DisplayName("Restaurant Id")]
        public int RestaurantId  {get;set;}
    }
}
