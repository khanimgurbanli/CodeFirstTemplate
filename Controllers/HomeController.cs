﻿using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebStar_.Models;

namespace WebStar_.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            var product = new List<Product>
            {
                new Product{Name="Brokoli",
                    StartPrice=12.4m,
                    Price=15.4m,
                    Rate=4,
                    ProductImages=new List<Images>{
                    new Images{Url="https://www.google.com/imgres?imgurl=https%3A%2F%2Fpost.greatist.com%2Fwp-content%2Fuploads%2Fsites%2F2%2F2021%2F07%2F383439-grt-Broccoli-Benefits-732x549-thumbnail-732x549.jpg&imgrefurl=https%3A%2F%2Fgreatist.com%2Fhealth%2Fsuperfood-broccoli&tbnid=Biu9nLOQaIZhoM&vet=12ahUKEwjPye7146f6AhUPRhoKHacIDz8QMygDegUIARCGAg..i&docid=wlUTnzm9aUaAMM&w=732&h=549&q=broccoli&hl=en&ved=2ahUKEwjPye7146f6AhUPRhoKHacIDz8QMygDegUIARCGAg"},
                    new Images{Url="https://www.google.com/imgres?imgurl=https%3A%2F%2Fwww.healthifyme.com%2Fblog%2Fwp-content%2Fuploads%2F2021%2F12%2FBroccoli.jpg&imgrefurl=https%3A%2F%2Fwww.healthifyme.com%2Fblog%2Fweb-stories%2Fhealth-benefits-of-broccoli%2F&tbnid=NKl1a-YT8yxV_M&vet=12ahUKEwjPye7146f6AhUPRhoKHacIDz8QMygMegUIARCcAg..i&docid=zXIOR3FruGgLNM&w=720&h=1280&q=broccoli&hl=en&ved=2ahUKEwjPye7146f6AhUPRhoKHacIDz8QMygMegUIARCcAg"}
                    }
                },
                new Product{Name="Kiwi",
                    StartPrice=32.4m,
                    Price=38.4m,
                    Rate=4.8,
                    ProductImages=new List<Images>{
                    new Images{Url="https://www.google.com/imgres?imgurl=http%3A%2F%2Fwww.frutas-hortalizas.com%2Fimg%2Ffruites_verdures%2Fpresentacio%2F14.jpg&imgrefurl=https%3A%2F%2Fwww.frutas-hortalizas.com%2FFruits%2FAbout-Kiwi.html&tbnid=PXGfCxEuXBruTM&vet=12ahUKEwjk--So5Kf6AhUL-xoKHdMwDrMQMygBegUIARDnAQ..i&docid=CcBJGXGL60rbGM&w=640&h=480&q=kiwi&hl=en&ved=2ahUKEwjk--So5Kf6AhUL-xoKHdMwDrMQMygBegUIARDnAQ" }
                    }
                },
                 new Product{Name="Brokoli2",
                    StartPrice=22.4m,
                    Price=45.4m,
                    Rate=4,
                    ProductImages=new List<Images>{
                    new Images{Url="https://www.google.com/imgres?imgurl=https%3A%2F%2Fpost.greatist.com%2Fwp-content%2Fuploads%2Fsites%2F2%2F2021%2F07%2F383439-grt-Broccoli-Benefits-732x549-thumbnail-732x549.jpg&imgrefurl=https%3A%2F%2Fgreatist.com%2Fhealth%2Fsuperfood-broccoli&tbnid=Biu9nLOQaIZhoM&vet=12ahUKEwjPye7146f6AhUPRhoKHacIDz8QMygDegUIARCGAg..i&docid=wlUTnzm9aUaAMM&w=732&h=549&q=broccoli&hl=en&ved=2ahUKEwjPye7146f6AhUPRhoKHacIDz8QMygDegUIARCGAg"},
                    new Images{Url="https://www.google.com/imgres?imgurl=https%3A%2F%2Fwww.healthifyme.com%2Fblog%2Fwp-content%2Fuploads%2F2021%2F12%2FBroccoli.jpg&imgrefurl=https%3A%2F%2Fwww.healthifyme.com%2Fblog%2Fweb-stories%2Fhealth-benefits-of-broccoli%2F&tbnid=NKl1a-YT8yxV_M&vet=12ahUKEwjPye7146f6AhUPRhoKHacIDz8QMygMegUIARCcAg..i&docid=zXIOR3FruGgLNM&w=720&h=1280&q=broccoli&hl=en&ved=2ahUKEwjPye7146f6AhUPRhoKHacIDz8QMygMegUIARCcAg"}
                    }
                },
                  new Product{Name="Brokoli3",
                    StartPrice=22.4m,
                    Price=17.4m,
                    Rate=4,
                    ProductImages=new List<Images>{
                    new Images{Url="https://www.google.com/imgres?imgurl=https%3A%2F%2Fpost.greatist.com%2Fwp-content%2Fuploads%2Fsites%2F2%2F2021%2F07%2F383439-grt-Broccoli-Benefits-732x549-thumbnail-732x549.jpg&imgrefurl=https%3A%2F%2Fgreatist.com%2Fhealth%2Fsuperfood-broccoli&tbnid=Biu9nLOQaIZhoM&vet=12ahUKEwjPye7146f6AhUPRhoKHacIDz8QMygDegUIARCGAg..i&docid=wlUTnzm9aUaAMM&w=732&h=549&q=broccoli&hl=en&ved=2ahUKEwjPye7146f6AhUPRhoKHacIDz8QMygDegUIARCGAg"},
                    new Images{Url="https://www.google.com/imgres?imgurl=https%3A%2F%2Fwww.healthifyme.com%2Fblog%2Fwp-content%2Fuploads%2F2021%2F12%2FBroccoli.jpg&imgrefurl=https%3A%2F%2Fwww.healthifyme.com%2Fblog%2Fweb-stories%2Fhealth-benefits-of-broccoli%2F&tbnid=NKl1a-YT8yxV_M&vet=12ahUKEwjPye7146f6AhUPRhoKHacIDz8QMygMegUIARCcAg..i&docid=zXIOR3FruGgLNM&w=720&h=1280&q=broccoli&hl=en&ved=2ahUKEwjPye7146f6AhUPRhoKHacIDz8QMygMegUIARCcAg"}
                    }
                },
                   new Product{Name="Brokol4",
                    StartPrice=12.4m,
                    Price=15.4m,
                    Rate=4,
                    ProductImages=new List<Images>
                    {
                        new Images{Url=""}
                    }


            }};
            return View(product);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}