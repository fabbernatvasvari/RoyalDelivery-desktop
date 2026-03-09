using RoyalDelivery.Models.DbMysqlModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace RoyalDelivery.Repos.Interface
{
    public interface IOrderRepo
    {
        public List<Order> GetAll();
    }
}
