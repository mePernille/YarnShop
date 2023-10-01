using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using YarnShop.ViewModels;
using YarnShop.Models;

namespace YarnShop.Controllers;

public class ItemController : Controller
{

    private readonly ItemDbContext _itemDbContext;

    public ItemController(ItemDbContext itemDbContext)
    { 
        _itemDbContext = itemDbContext;
    }
    public IActionResult Table()
    {
        List<Item> items = _itemDbContext.Items.ToList(); // Getting the items from the database now
        var itemListViewModel = new ItemListViewModel(items, "Table");
        return View(itemListViewModel);
    }

    public IActionResult Grid()
    {
        List<Item> items = _itemDbContext.Items.ToList(); //var items = GetItems();
        var itemListViewModel = new ItemListViewModel(items, "Grid");
        return View(itemListViewModel);
    }

    public IActionResult Details(int id)
    {
        List<Item> items = _itemDbContext.Items.ToList();
        var item = items.FirstOrDefault(item => item.ItemId == id);
        if (item == null) // chekking if it exist.
            return NotFound();
        return View(item);
    }

    public List<Item> GetItems()
    {

        var items = new List<Item>();
        var item1 = new Item
        {
            ItemId = 1,
            Name = "Finull",
            Price = 60,
            Description = "Dejlig varmt og blødt uld garn",
            ImageUrl = "/images/fancyGarn.jpg"
        };

        var item2 = new Item // this way of adding items is prefered by Visual Studio
        {
            ItemId = 2,
            Name = "Alpakka ull",
            Price = 86,
            Description = "Super flot og dyrt garn",
            ImageUrl = "/images/masseGarn.jpg"
        };

        items.Add(item1);
        items.Add(item2);
        return items;
    }
}
