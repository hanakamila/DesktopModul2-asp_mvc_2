﻿using System.Web.Mvc;
using asp_mvc_2.Security;   
 
namespace asp_mvc_2.Controllers   
{ 
    public class HomeController : Controller 
    { 
        public ActionResult Index() {
            return View();
        }

        [AuthorizeRoles("Admin")] 
        public ActionResult AdminOnly() {   
        return View(); 
}
 
public ActionResult UnAuthorized() {   
            return View();
        }
    }
}