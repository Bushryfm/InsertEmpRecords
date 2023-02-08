using InsertRecord.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace InsertRecord.Controllers
{
    public class HomeController : Controller
    {
        Employeedb dbop = new Employeedb();
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index([Bind] Employee emp)
        {
            try
            {
                
                    if (ModelState.IsValid)
                    {
                      string res =  dbop.Saverecord(emp);
                       TempData["msg"] = res;
                    }
                

            }
            catch (Exception ex )
           
            {
                TempData["msg"] = ex.Message;
            }
            
            return View();
        }
    }
}