using FirstProgram.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc; 

namespace FirstProgram.Controllers
{
    public class DataController : Controller
    {
        /*static IList<Mess> MessList = new List<Mess>{
                new Mess() { Message = "Message from Model 1" } ,
                new Mess() { Message = "Message from Model 2" }                
            };*/
        // GET: Data
        public ActionResult Index()
        {
            ViewBag.Message = "Message from ViewBag"; 
            ViewBag.CurrentTime = DateTime.Now;
            return View();
        }
        public ActionResult About()
        {
            return View();
        }
    }
}