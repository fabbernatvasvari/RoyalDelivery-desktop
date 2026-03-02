using System;
using System.Collections.Generic;

namespace RoyalDelivery.Models.DbMysqlModels;

public partial class Restaurant
{
    public int Id { get; set; }

    public string Name { get; set; } = string.Empty;

    public int Ownerid { get; set; }
}
