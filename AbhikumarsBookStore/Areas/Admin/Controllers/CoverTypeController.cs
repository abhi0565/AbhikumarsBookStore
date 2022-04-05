using AbhikumarsBooks.DataAccess.Repository.IRepository;
using AbhikumarsBookStore.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using AbhikumarsBooks.Models;


namespace AbhikumarsBookStore.Area.Admin.Controllers
{
    [Area("Admin")]

    public class CoverTypeController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;

        public CoverTypeController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult upsert(int? id)
        {
            CoverType CoverType = new CoverType();
            if (id == null)
            {
                return View(CoverType);

            }
            CoverType = _unitOfWork.CoverType.Get(id.GetValueOrDefault());
            if (CoverType == null)
            {
                return NotFound();
            }
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Upsert(CoverType covertype)
        {
            if (ModelState.IsValid)
            { 
                if(covertype.Id == 0)
               
            {
                _unitOfWork.CoverType.Add(covertype);

            }
            else
            {
                    _unitOfWork.CoverType.Update(covertype);
            }
               _unitOfWork.Save();
                return RedirectToAction(nameof(Index));
        }
        return View(covertype);
    }





        #region API CALLS
        [HttpGet]

        public IActionResult GetAll()
        {
            var allobj = _unitOfWork.CoverType.GetAll();
            return Json(new { data = allobj });
        }
        [HttpDelete]
        public IActionResult Delete(int id)
        {
            var objFromDb = _unitOfWork.CoverType.Get(id);
            if(objFromDb == null)
            {
                return Json(new { success = false, message = "Error while deleting" });

            }
            _unitOfWork.CoverType.Remove(objFromDb);
            _unitOfWork.Save();
            return Json(new { success = true, messasge = "Delete successful" });
        }

        #endregion
    }


}
