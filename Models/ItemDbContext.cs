using System;
using Microsoft.EntityFrameworkCore;

namespace YarnShop.Models;

public class ItemDbContext : DbContext // defines that itemDbContext inherits fram DbContext
{
    public ItemDbContext(DbContextOptions<ItemDbContext> options) : base(options)
    {
        Database.EnsureCreated(); // Create a databse in case it dosent exist
    }

    public DbSet<Item> Items { get; set; } 
}
