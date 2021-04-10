using DBSD_CW2_8699_7895.Models;
using System;
using System.Collections.Generic;

namespace DBSD_CW2_8699_7895.DAL
{
    public class OrderRepository : IOrderRepository
    {


        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<Order> Filter(string pizzaName, DateTime orderDate, string size, decimal discount, int restaurantId, string sortColumn, bool sortDesc = false, int? page = 1, int pageSize = 2)
        {
            throw new NotImplementedException();
        }

        public Order GetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Order> GetOrders()
        {
            throw new NotImplementedException();
        }

        public void Insert(Order item)
        {
            throw new NotImplementedException();
        }

        public void Update(Order item)
        {
            throw new NotImplementedException();
        }
    }
}
