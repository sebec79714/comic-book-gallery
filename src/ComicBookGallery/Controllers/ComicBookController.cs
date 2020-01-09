using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ComicBookGallery.Controllers 
{
    public class ComicBookController : Controller
    {
        public ActionResult Detail()
        {

            if (DateTime.Today.DayOfWeek == DayOfWeek.Thursday)
            {
                return Redirect("/");
         //       return new RedirectResult("/");

            }
            return Content("HELLO from the comic book controller");
     //       return new ContentResult
     //       {
     //           Content = "HELLO from the comic book controller"
     //       };
               

           
        }
    }
}