using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LibAppOrzechowski.Models;

namespace LibAppOrzechowski.Controllers
{
  

    public class BookController : Controller
    {
        public IActionResult Random()
        {
            var firstBook = new Book() { Id = 1, Name = "English" };
            return View(firstBook);
            
        }

        public IActionResult Edit(int id)
        {
            return Content("id=" + id);
        }

        public IActionResult Index(int? pageIndex, string sortBy)
        {
            if (!pageIndex.HasValue)
            {
                pageIndex = 1;
            }

            if (String.IsNullOrEmpty(sortBy))
            {
                sortBy = "Name";
            }

            //return Content(String.Format("pageIndex={0}&sortby={1}",pageIndex,sortBy));
            return Content($"pageIndex={pageIndex}&sortby={sortBy}");
        }


    }
}
