using System;
using System.ComponentModel;

namespace DBSD_CW2_8699_7895.Models
{
    public class Waiter
    {
        [DisplayName("WaiterId")]
        public int WaiterId { get; set; }
        [DisplayName("FirstName")]
        public string FirstName { get; set; }
        [DisplayName("LastName")]
        public string LastName { get; set; }
        [DisplayName("DoB")]
        public DateTime DoB { get; set; }
        [DisplayName("Salary")]
        public int Salary { get; set; }
        [DisplayName("PhoneNumber")]
        public string PhoneNumber { get; set; }
        [DisplayName("RestaurantId")]
        public int RestaurantId  {get;set;}
    }
}
