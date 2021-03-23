using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace shopping_cart.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public List<Item> Products { get; set; }


        public void OnGet()
        {
            var items = new List<Item>() {
                new Item() {
                    Name = "Bearded Oil",
                    Description = "Lorem ipsum dolor sit amet consectetur adipisicing elit. Consequuntur dolor ratione culpa! Deleniti vel",
                    ImageUrl = "https://images.unsplash.com/photo-1564020426549-fabfb8c467ad?ixid=MXwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHw%3D&ixlib=rb-1.2.1&auto=format&fit=crop&w=1234&q=80",
                    Price = 7000
                },
                new Item() {
                    Name = "Whole Wheat Bread",
                    Description = "Lorem ipsum dolor sit amet consectetur adipisicing elit. Consequuntur dolor ratione culpa! Deleniti vel",
                    ImageUrl = "https://images.unsplash.com/photo-1593668387570-52c91ffb4d74?ixid=MXwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHw%3D&ixlib=rb-1.2.1&auto=format&fit=crop&w=2250&q=80",
                    Price = 3000
                }
            };

            Products = items;
        }
    }

    public class Item
    {
        public string Id { get; set; } = Guid.NewGuid().ToString();
        public string Name { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
        public Decimal Price { get; set; }
    }
}
