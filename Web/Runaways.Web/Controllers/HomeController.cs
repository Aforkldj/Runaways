namespace Runaways.Web.Controllers
{
    using System;
    using System.Diagnostics;

    using Microsoft.AspNetCore.Mvc;
    using Runaways.Web.ViewModels;
    using Runaways.Web.ViewModels.SearchResults;

    public class HomeController : BaseController
    {
        public HomeController()
        {
            // service
        }
       
        [HttpGet("/")]
        public IActionResult Index()
        {
            this.ViewData["ProjectTitle"] = "Runaways";
            DateTime startDate = DateTime.Parse("23/11/2020");
            this.ViewData["StartDate"] = startDate;
            var today = DateTime.UtcNow;
            TimeSpan elapsed = today - startDate;
            this.ViewData["DaysSinceStarted"] = elapsed.TotalDays;

            return this.View();
        }

        [HttpPost]
        public IActionResult Index(SearchByResortInputModel input)
        {
            
            return this.View();
        }

        public IActionResult Privacy()
        {
            return this.View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return this.View(
                new ErrorViewModel { RequestId = Activity.Current?.Id ?? this.HttpContext.TraceIdentifier });
        }
    }
}
