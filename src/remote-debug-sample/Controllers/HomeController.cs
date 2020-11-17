using System;
using Microsoft.AspNetCore.Mvc;

namespace remote_debug_sample
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            Model1 rct = new Model1("hello, world!", System.DateTime.Now);
            return Json(rct);
        }

        public class Model1
        {
            public Model1(string description, DateTime time)
            {
                this.Description = description;
                this.Time = time;

            }
            public string Description { get; set; }

            public DateTime Time { get; set; }

        }

    }
}