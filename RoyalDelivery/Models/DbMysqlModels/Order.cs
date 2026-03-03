using System;
using System.Collections.Generic;

namespace RoyalDelivery.Models.DbMysqlModels;

public partial class Order
{
    public int Id { get; set; }

    public string Restaurantid { get; set; } = string.Empty;

    public string Userid { get; set; } = string.Empty;

    public string Date { get; set; } = string.Empty;
}
