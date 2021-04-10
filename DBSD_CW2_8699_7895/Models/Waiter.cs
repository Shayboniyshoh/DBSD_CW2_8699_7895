using System;
using System.ComponentModel;

namespace DBSD_CW2_8699_7895.Models
{
    public class Waiter
    {
        [DisplayName("WaiterId")]
        public int? WaiterId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DoB { get; set; }
        public int? Salary { get; set; }
        public string PhoneNumber { get; set; }
        public int? RestaurantId  {get;set;}
        public Restaurant Restaurant { get; set; }
    }
}
