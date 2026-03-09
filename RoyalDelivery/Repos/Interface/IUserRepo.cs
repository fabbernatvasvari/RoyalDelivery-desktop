using RoyalDelivery.Models.DbMysqlModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace RoyalDelivery.Repos.Interface
{
    public interface IUserRepo
    {
        public List<User> GetAll();
    }
}
