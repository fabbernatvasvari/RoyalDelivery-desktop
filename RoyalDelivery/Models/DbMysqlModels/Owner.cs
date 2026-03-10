using System;
using System.Collections.Generic;

namespace RoyalDelivery.Models.DbMysqlModels;

public partial class Owner
{
    public int Id { get; set; }

    public string Username { get; set; } = null!;

    public string Email { get; set; } = null!;

    public string Password { get; set; } = null!;

    public int UserId { get; set; }
}
