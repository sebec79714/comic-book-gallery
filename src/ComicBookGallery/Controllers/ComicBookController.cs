﻿using System;
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
            ViewBag.SeriesTitle = "The Amazing Spider-Man";
            ViewBag.IssueNumber = 700;
            ViewBag.Description = "<p>Final issue! Witness the final hours of Doctor Octopus' life and his one, last, great act of revenge! Even if Spider-Man survives... <strong>will Peter Parker?</strong></p>";
            ViewBag.Artists = new string[]
            {
                "Script: Dan Slott",
                "Pencils: Humberto Ramos",
                "Inks: Victor Olazaba",
                "Colors: Edgar Delgado",
                "Letters: Chris Eliopoulos"
            };

            return View();

        //    if (DateTime.Today.DayOfWeek == DayOfWeek.Thursday)
        //    {
        //        return Redirect("/");
         //       return new RedirectResult("/");

         //   }
         //   return Content("HELLO from the comic book controller");
     //       return new ContentResult
     //       {
     //           Content = "HELLO from the comic book controller"
     //       };
               

           
        }
    }
}