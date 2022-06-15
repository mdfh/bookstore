﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BulkyBookStore.Data;
using BulkyBookStore.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BulkyBookStore.Controllers
{
    public class CategoryController : Controller
    {

        private readonly ApplicationDbContext _db;

        public CategoryController(ApplicationDbContext db)
        {
            _db = db;
        }

        // GET: /<controller>/
        public IActionResult Index()
        {
            IEnumerable<Category> objCategoriesList = _db.Categories.ToList();
            return View(objCategoriesList);
        }

        public IActionResult Create()
        {
            return View();
        }

        // GET
        public IActionResult Edit(int? Id)
        {
            if (Id == null)
                return NotFound();
            var category = _db.Categories.Find(Id);
            if (category == null)
                return NotFound();
            return View(category);
        }

        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public IActionResult Edit(Category obj)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        _db.Categories.Update(obj);
        //        _db.SaveChanges();
        //        return RedirectToAction("Index");
        //    }
        //    return View(obj);
        //}

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Category obj)
        {
            if(ModelState.IsValid)
            {
                _db.Categories.Add(obj);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(obj);
        }

        public IActionResult Delete(Category obj)
        {
            return RedirectToAction("Index");
        }

        //public IActionResult Edit(int? categoryId)
        //{
        //    if (categoryId == null || categoryId == 0)
        //        return NotFound();
        //    var category = _db.Categories.Find(categoryId);
        //    return View(category);
        //}
    }
}
