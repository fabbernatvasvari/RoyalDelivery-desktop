using System;
using System.Collections.Generic;

namespace RoyalDelivery.Models.DbMysqlModels;

public partial class Meal
{
    public int Id { get; set; }

    public string Name { get; set; } = string.Empty;

    public string Description { get; set; } = string.Empty;

    public int Price { get; set; }

    public int Restaurantid { get; set; }
}
