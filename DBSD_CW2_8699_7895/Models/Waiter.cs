using System;
using System.ComponentModel;

namespace DBSD_CW2_8699_7895.Models
{
    public class Waiter
    {
        [DisplayName("Waiter Id")]
        public int WaiterId { get; set; }
        [DisplayName("First Name")]
        public string FirstName { get; set; }
        [DisplayName("Last Name")]
        public string LastName { get; set; }
        [DisplayName("DoB")]
        public DateTime DoB { get; set; }
        [DisplayName("Salary")]
        public int Salary { get; set; }
        [DisplayName("Phone Number")]
        public string PhoneNumber { get; set; }
        [DisplayName("Restaurant Id")]
        public int RestaurantId  {get;set;}
    }
}
