using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace calcMVC.Controllers
{
    public class calcController : Controller
    {
        // GET: calc
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult total(string operation, int num1,int num2)
        {
            int total = 0;
            switch (operation) {
                case "+" :
                    total = num1 + num2;
                    break;

                case "-" :
                    total = num1 - num2;
                    break;

                case "*" :
                    total = num1 * num2;
                    break;

                case  "/" :
                    total = num1 / num2;
                    break;
            }
            ViewBag.num1 = num1;
            ViewBag.num2 = num2;
            ViewBag.operation = operation;
            ViewBag.result = total;
            return View();
        }
    }
}