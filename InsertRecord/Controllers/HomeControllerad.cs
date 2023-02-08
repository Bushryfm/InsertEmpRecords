using InsertRecord.Models;
using Microsoft.AspNetCore.Mvc;

namespace InsertRecord.Controllers
{
    public class HomeControllerad : Controller
    {
        db dbop = new db();
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index([Bind] Ad_login ad)
        {
            int res = dbop.LoginCheck(ad);
            if (res == 1)
            {
                TempData["msg"] = "You are welcome to Admin Section";
            }
            else
            {
                TempData["msg"] = "Admin id or Password is wrong.!";
            }
            return View();
        }
    }
}
