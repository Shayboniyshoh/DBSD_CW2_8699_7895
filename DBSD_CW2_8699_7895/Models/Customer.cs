using System.ComponentModel;

namespace DBSD_CW2_8699_7895.Models
{
    /*
create table Customer (
  CustomerId int identity (1,1) not null,
  FirstName nvarchar(50) not null,
  LastName nvarchar(50) not null,
  RestaurantId int not null,
  WaiterId int not null,
  constraint pk_Customer_CustomerId primary key(CustomerId),
  constraint fk_Customer_RestaurantId foreign key(RestaurantId) references Restaurant(RestaurantId),
  constraint fk_Customer_WaiterId foreign key(WaiterId) references Waiter(WaiterId)
)*/
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
