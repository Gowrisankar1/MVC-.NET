using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC.NET.Models;

namespace MVC.NET.Controllers
{
    public class insertDBController : Controller
    {
        MVCREGEntities dbob = new MVCREGEntities();
        public ActionResult Insert_pageload()
        {
            return View();
        }
        public ActionResult Insert_click(INSERTCS objcls)
        {
            if(ModelState.IsValid)
            {
                dbob.sp_testtabinsert(objcls.name,objcls.age,objcls.address);
                objcls.msg = "inserted";
                return View("Insert_pageload",objcls);
            }
            else
            {
                objcls.msg = "not inserted";
                return View("Insert_pageload", objcls);
            }
          
        }
    }
}