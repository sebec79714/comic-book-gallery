using ComicBookGallery.Data;
using ComicBookGallery.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ComicBookGallery.Controllers 
{
    public class ComicBookController : Controller
    {
        private ComicBookRepository _comicBookRepository = null;

        public ComicBookController()
        {
            _comicBookRepository = new ComicBookRepository();
        }
        public ActionResult Detail(int? Id) //int? means its nullable
        {
            if (Id == null)
            {
                return HttpNotFound();
            }
            var comicBook = _comicBookRepository.GetComicBook(Id.Value); //can also do an impliciate cast (int)Id

  /*          var comicBook = new ComicBook()
            {
                SeriesTitle = "The Amazing Spider-Man",
                IssueNumber = 700,
                DescriptionHtml = "<p>Final issue! Witness the final hours of Doctor Octopus' life and his one, last, great act of revenge! Even if Spider-Man survives... <strong>will Peter Parker?</strong></p>",
                Artists = new Artist[]
                {
                    new Artist() {Name = "Dan Slott",Role = "Script"},
                    new Artist() {Name = "Humberto Ramos",Role = "Pencils"},
                    new Artist() {Name = "Victor Olazaba",Role = "Inks"},
                    new Artist() {Name = "Edgar Delgado",Role = "Colors"},
                    new Artist() {Name = "Chris Eliopoulos",Role = "Letters"}
                }

            

  //          ViewBag.SeriesTitle = "The Amazing Spider-Man";
  //          ViewBag.IssueNumber = 700;
  //          ViewBag.Description = "<p>Final issue! Witness the final hours of Doctor Octopus' life and his one, last, great act of revenge! Even if Spider-Man survives... <strong>will Peter Parker?</strong></p>";
  //          ViewBag.Artists = new string[]
  //          {
  //              "Script: Dan Slott",
  //              "Pencils: Humberto Ramos",
  //              "Inks: Victor Olazaba",
  //              "Colors: Edgar Delgado",
  //              "Letters: Chris Eliopoulos"
            };
            */
            return View(comicBook);

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