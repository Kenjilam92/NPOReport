using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using reportNPO.Models;

namespace reportNPO.Controllers
{
    public class HomeController : Controller
    {
        private Context database {get;set;}
        public HomeController(Context context)
        {
            database= context;
        }
        //////////////////////////
        
        [HttpGet("")]
        public IActionResult Index()
        {
            ViewBag.NPOReport = database.Orders;
            return View();
        }

        [HttpPost("api/newOrder")]
        public JsonResult addOrder([FromBody]Order newOrder){
            if (ModelState.IsValid) 
            {
                database.Orders.Add(newOrder);
                database.SaveChanges();
                return Json(new { msg = "success"});
            }
            return Json(new { msg = "failed"});
        }



        // public IActionResult Index()
        // {
        //     return View();
        // }

        // public IActionResult Privacy()
        // {
        //     return View();
        // }

        // [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        // public IActionResult Error()
        // {
        //     return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        // }
    }
}
