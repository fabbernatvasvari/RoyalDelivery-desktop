using RoyalDelivery.Models.DbMysqlModels;

namespace RoyalDelivery.Repos.Interface
{
    public interface IRestaurantRepo
    {
        public List<Restaurant> GetAll();
    }
}
