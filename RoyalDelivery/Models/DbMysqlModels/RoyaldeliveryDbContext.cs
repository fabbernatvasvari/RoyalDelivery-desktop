using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Pomelo.EntityFrameworkCore.MySql.Scaffolding.Internal;

namespace RoyalDelivery.Models.DbMysqlModels;

public partial class RoyaldeliveryDbContext : DbContext
{
    public RoyaldeliveryDbContext()
    {
    }

    public RoyaldeliveryDbContext(DbContextOptions<RoyaldeliveryDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Meal> Meals { get; set; }

    public virtual DbSet<Order> Orders { get; set; }

    public virtual DbSet<Owner> Owners { get; set; }

    public virtual DbSet<Restaurant> Restaurants { get; set; }

    public virtual DbSet<User> Users { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseMySql("server=localhost;database=royaldelivery_db;user=root", Microsoft.EntityFrameworkCore.ServerVersion.Parse("10.4.32-mariadb"));

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder
            .UseCollation("latin2_hungarian_ci")
            .HasCharSet("latin2");

        modelBuilder.Entity<Meal>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("meals")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnType("int(2)")
                .HasColumnName("id");
            entity.Property(e => e.Description)
                .HasMaxLength(52)
                .HasColumnName("description");
            entity.Property(e => e.Name)
                .HasMaxLength(20)
                .HasColumnName("name");
            entity.Property(e => e.Price)
                .HasColumnType("int(4)")
                .HasColumnName("price");
            entity.Property(e => e.Restaurantid)
                .HasColumnType("int(1)")
                .HasColumnName("restaurantid");
        });

        modelBuilder.Entity<Order>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("orders")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnType("int(2)")
                .HasColumnName("id");
            entity.Property(e => e.Date)
                .HasMaxLength(10)
                .HasColumnName("date");
            entity.Property(e => e.Restaurantid)
                .HasMaxLength(10)
                .HasColumnName("restaurantid");
            entity.Property(e => e.Userid)
                .HasMaxLength(10)
                .HasColumnName("userid");
        });

        modelBuilder.Entity<Owner>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("owners")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnType("int(1)")
                .HasColumnName("id");
            entity.Property(e => e.Email)
                .HasMaxLength(22)
                .HasColumnName("email");
            entity.Property(e => e.Password)
                .HasMaxLength(15)
                .HasColumnName("password");
            entity.Property(e => e.Username)
                .HasMaxLength(16)
                .HasColumnName("username");
        });

        modelBuilder.Entity<Restaurant>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("restaurants")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnType("int(2)")
                .HasColumnName("id");
            entity.Property(e => e.Name)
                .HasMaxLength(15)
                .HasColumnName("name");
            entity.Property(e => e.Ownerid)
                .HasColumnType("int(1)")
                .HasColumnName("ownerid");
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("users")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnType("int(2)")
                .HasColumnName("id");
            entity.Property(e => e.Address)
                .HasMaxLength(32)
                .HasColumnName("address");
            entity.Property(e => e.Email)
                .HasMaxLength(30)
                .HasColumnName("email");
            entity.Property(e => e.FirstName)
                .HasMaxLength(9)
                .HasColumnName("firstName");
            entity.Property(e => e.LastName)
                .HasMaxLength(7)
                .HasColumnName("lastName");
            entity.Property(e => e.Password)
                .HasMaxLength(15)
                .HasColumnName("password");
            entity.Property(e => e.Username)
                .HasMaxLength(11)
                .HasColumnName("username");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
