using HastalikTakibi.DAL;
using HastalikTakibi.DAL.Models.Database;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HastalikTakibi.Controllers
{
    public class CategoryController : AdminBaseController
    {
        public CategoryController(HastlikTakipDbContext hastlikTakipDbContext):base(hastlikTakipDbContext)
        {
           
        }
        public IActionResult Index()
        {
            var categoryList = _hastlikTakipDbContext.Category.ToList();
            return View(categoryList);
        }
        public IActionResult CategoryAdd()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CategoryAdd(Category category)
        {
            if(category==null || string.IsNullOrEmpty(category.Name))
            {
                ViewBag.Error = "Lütfen zorunlu alanları doldurun";
                return View(category);
            }
            category.CreateTime = DateTime.Now;
            _hastlikTakipDbContext.Category.Add(category);
            _hastlikTakipDbContext.SaveChangesAsync().GetAwaiter().GetResult();
            return RedirectToAction("Index");
        }
        public IActionResult CategoryUpdate(int id)
        {
            var categoryDb = _hastlikTakipDbContext.Category.FirstOrDefault(a => a.Id == id);

            return View(categoryDb);
        }
        [HttpPost]
        public IActionResult CategoryUpdate(Category category)
        {
            if (category == null || string.IsNullOrEmpty(category.Name) || category.Id<=0)
            {
                ViewBag.Error = "Lütfen zorunlu alanları doldurun";
                return View(category);
            }
            var categoryDb = _hastlikTakipDbContext.Category.FirstOrDefault(a => a.Id == category.Id);
            if (categoryDb == null)
            {
                ViewBag.Error = "Kategori Bulunmadı";
                return View(category);
            }
            categoryDb.Name = category.Name;
            categoryDb.LastUpdateTime = DateTime.Now;
            _hastlikTakipDbContext.Entry(categoryDb).State = Microsoft.EntityFrameworkCore.EntityState.Modified;

            _hastlikTakipDbContext.SaveChangesAsync().GetAwaiter().GetResult();
            return RedirectToAction("Index");
        }

        public IActionResult CategoryDelete(Category category)
        {
            
            _hastlikTakipDbContext.Category.Remove(category);
            _hastlikTakipDbContext.SaveChangesAsync().GetAwaiter().GetResult();
            return RedirectToAction("Index");

        }
       
        
    }
}
