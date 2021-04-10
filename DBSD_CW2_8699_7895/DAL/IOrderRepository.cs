using DBSD_CW2_8699_7895.Models;
using System;
using System.Collections.Generic;

namespace DBSD_CW2_8699_7895.DAL
{
    public interface IOrderRepository
    {
        public List<Order> GetOrders();
        public List<Order> Filter(
              string pizzaName,
              DateTime orderDate,
              string size,
              decimal discount,
              int restaurantId,
              string sortColumn,
              bool sortDesc = false,
              int? page = 1,
              int pageSize = 2
          );

        public void Insert(Order item);

        public void Update(Order item);

        public Order GetById(int id);

        public void Delete(int id);
    }

}
}
