using Dapper;
using DBSD_CW2_8699_7895.Models;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SqlClient;

namespace DBSD_CW2_8699_7895.DAL
{
    public class OrderRepository : IOrderRepository
    {
        private const string SELECT = @"SELECT [OrderId],
                                               [PizzaName],
                                               [OrderDate],
                                               [Size],
                                               [Quantity],
                                               [TotalCost],
                                               [IsDiscountAvailable],
                                               [Discount],           
                                               [RestaurantId],
                                               [CustomerId],
                                               [WaiterId],
                                               [ChefId],
                                               [Photo]
                                               FROM [dbo].[Order]";
        private readonly string connStr;
        public OrderRepository(string connStr)
        {
            this.connStr = connStr;
        }
        public List<Order> GetOrders_ADO()
        {
            var list = new List<Order>();

            using (var conn = new SqlConnection(connStr))
            {
                using (var cmd = conn.CreateCommand())
                {
                    cmd.CommandText = SELECT;
                    cmd.CommandType = System.Data.CommandType.Text;

                    conn.Open();

                    using (var rdr = cmd.ExecuteReader())
                    {
                        while (rdr.Read())
                        {
                            var item = MapReaderToOrder(rdr);

                            list.Add(item);
                        }
                    }
                }

            }

            return list;
        }
        public List<Order> GetOrders()
        {
            return GetOrders_Dapper();
        }
        private List<Order> GetOrders_Dapper()
        {
            using (var conn = new SqlConnection(connStr))
                return conn.Query<Order>(SELECT).AsList();
        }
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

        public void Insert(Order item)
        {
            throw new NotImplementedException();
        }

        public void Update(Order item)
        {
            throw new NotImplementedException();
        }


        private Order MapReaderToOrder(DbDataReader rdr)
        {
            var item = new Order();

            item.OrderId = rdr.GetInt32(rdr.GetOrdinal("OrderId"));
            item.PizzaName = rdr.GetString(rdr.GetOrdinal("PizzaName"));
            item.OrderDate = rdr.GetDateTime(rdr.GetOrdinal("OrderDate"));
            item.Size = rdr.GetString(rdr.GetOrdinal("Size"));
            item.Quantity = rdr.GetInt32(rdr.GetOrdinal("Quantity"));
            item.TotalCost = rdr.GetInt32(rdr.GetOrdinal("TotalCost"));
            item.IsDiscountAvailable = rdr.GetBoolean(rdr.GetOrdinal("IsDiscountAvailable"));
            item.Discount = rdr.GetDecimal(rdr.GetOrdinal("Discount"));

            item.RestaurantId = rdr.GetInt32(rdr.GetOrdinal("RestaurantId"));
            item.CustomerId = rdr.GetInt32(rdr.GetOrdinal("CustomerId"));
            item.WaiterId = rdr.GetInt32(rdr.GetOrdinal("WaiterId"));
            item.ChefId = rdr.GetInt32(rdr.GetOrdinal("ChefId"));

            if (!rdr.IsDBNull(rdr.GetOrdinal("Photo")))
                item.Photo = (byte[])rdr["Photo"];

            return item;
        }
    }
}
