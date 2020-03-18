using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HPlus.Ecommerce.Controllers
{
    public class AccountController : Controller
    {
        [Authorize]
        // GET: Account
        public ActionResult Index()
        {
            return View();
        }
    }
}