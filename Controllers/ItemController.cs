using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models; // this will identifie the Item Class

namespace WebApplication1.Controllers;

public class ItemController : Controller
{
    public IActionResult Table()
    {
        var items = new List<Item>();
        var item1 = new Item();
        item1.ItemId = 1;
        item1.Name = "Finull";
        item1.Price = 60;

        var item2 = new Item // this way of adding items is prefered by Visual Studio
        {
            ItemId = 2,
            Name = "Alpakka ull",
            Price = 86
        };

        items.Add(item1);
        items.Add(item2);

        ViewBag.CurrentViewName = "Garn ";
        return View(items);
    }
}
