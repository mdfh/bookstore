using System.Collections.Generic;
using System.Linq;
using BulkyBook.DataAccess.Repository.IRepository;
using BulkyBook.Models;
using BulkyBook.Models.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BulkyBookStore.Controllers
{
    [Area("Admin")]
    public class ProductController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;

        public ProductController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        // GET: /<controller>/
        public IActionResult Index()
        {
            var objCategoriesList = _unitOfWork.CoverType.GetAll();
            return View(objCategoriesList);
        }

        public IActionResult Upsert(int? id)
        {
            ProductVM productVM = new() {
                Product = new(),
                CategoryList = _unitOfWork.Category.GetAll().Select(
                u => new SelectListItem
                {
                    Text = u.Name,
                    Value = u.Id.ToString()
                }),
                CoverTypeList = _unitOfWork.CoverType.GetAll().Select(
                u => new SelectListItem
                {
                    Text = u.Name,
                    Value = u.Id.ToString()
                })
            };

            if(id == null)
            {
                return View(productVM);
            }
            else
            {

            }

            return View(productVM);
        }

        //public IActionResult Create()
        //{
        //    return View();
        //}

        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public IActionResult Create(CoverType obj)
        //{
        //    if(ModelState.IsValid)
        //    {
        //        _unitOfWork.CoverType.Add(obj);
        //        _unitOfWork.Save();
        //        TempData["success"] = "CoverType created successfully";
        //        return RedirectToAction("Index");
        //    }
        //    return View(obj);
        //}



        #region Delete

        //public IActionResult Delete(int? Id)
        //{
        //    if (Id == null)
        //        return NotFound();
        //    var coverType = _unitOfWork.CoverType.GetFirstOrDefault(u => u.Id == Id);
        //    if (coverType == null)
        //        return NotFound();
        //    return View(coverType);
        //}

        //[HttpPost, ActionName("Delete")]
        //[ValidateAntiForgeryToken]
        //public IActionResult DeleteCategory(CoverType obj)
        //{

        //    _unitOfWork.CoverType.Remove(obj);
        //    _unitOfWork.Save();
        //    TempData["success"] = "CoverType deleted successfully";
        //    return RedirectToAction("Index");
        //}

        #endregion

        #region Edit
        // GET


        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Upsert(ProductVM obj, IFormFile file)
        {
            if (ModelState.IsValid)
            {
                //_unitOfWork.Product.Update(obj);
                //_unitOfWork.Save();
                TempData["success"] = "CoverType updated successfully";
                return RedirectToAction("Index");
            }
            return View(obj);
        }
        #endregion
    }
}
