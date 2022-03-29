using AbhikumarsBookStore.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace AbhikumarsBookStore.Area.Admin.Controllers
{
   
    public class CategoryController : Controller
    {
        

        public IActionResult Index()
        {
            return View();
        }
        #region API CALLS
        [HttpGet]

        public IActionResult GetAll()
        {
            var allobj = unitOfWork.Category.GetAll();
            return Json(new { data = allobj });
        }
       
    }
}
