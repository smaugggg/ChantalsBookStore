﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ChantalsBooks.DataAccess.Repository;
using ChantalsBooks.DataAccess.Repository.IRepository;

namespace ChantalsBookStore.Areas.Admin.Controllers {
    [Area("Admin")]
    public class CategoryController : Controller {
        private readonly IUnitOfWork _unitOfWork;

        public CategoryController(IUnitOfWork unitOfWork) {
            _unitOfWork = unitOfWork;
        }

        public IActionResult Index() {
            return View();
        }

        // the errors here have to do with the UnitOfWork stuff and I don't know whats going on with that
        public IActionResult Upsert(int id) {
            Category category = new Category();
            if (id == null) {
                return View(category);
            }
            category = _unitOfWork.Category.Get(id.GetValueOrDefault());
            if(category == null) {
                return NotFound();
            }
            return View();

        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Upsert(Category category) {
            if(ModelState.IsValid) {
                if(category.Id == 0) {
                    _unitOfWork.Category.Add(category);
                } else {
                    _unitOfWork.Category.Update(category);
                }
                _unitOfWork.Save();
                return RedirectToAction(nameof(Index));
            }
            return View(category);
        }


        // API calls here
        # region API CALLS
        [HttpGet]
        public IActionResult GetAll() {
            var allObj = _unitOfWork.Category.GetAll();
            return Json(new { data = allObj });
        }
        #endregion
    }
}
