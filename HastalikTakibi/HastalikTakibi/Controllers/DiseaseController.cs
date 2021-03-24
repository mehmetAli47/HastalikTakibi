using HastalikTakibi.DAL;
using HastalikTakibi.DAL.Models.Database;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HastalikTakibi.Controllers
{
    public class DiseaseController : AdminBaseController
    {
        public DiseaseController(HastlikTakipDbContext hastlikTakipDbContext) : base(hastlikTakipDbContext)
        {

        }
        public IActionResult Index(int? categoryId)
        {
            List<DAL.Models.Database.DiseaseView> diseaseList = new List<DiseaseView>();
            if (categoryId == null)
            {
                diseaseList = _hastlikTakipDbContext.DiseaseView.ToList();
            }
            else
            {
                diseaseList = (from d in _hastlikTakipDbContext.DiseaseView
                               join dc in _hastlikTakipDbContext.DiseaseCategory on d.Id equals dc.DisaeaseId
                               where dc.CategoryId==categoryId
                               select d).ToList();
            }
            return View(diseaseList);
        }

        public void SetCategory()
        {
            var categoryList = new List<SelectListItem>();
            
            foreach (var item in _hastlikTakipDbContext.Category.ToList())
            {
                categoryList.Add(new SelectListItem
                {
                    Text = item.Name,
                    Value = item.Id.ToString()
                });
            }
            ViewBag.CategoryList = categoryList;
        }
        public IActionResult DiseaseAdd()
        {
            SetCategory();
            return View();
        }
        public IActionResult DiseaseDelete(int id)
        {
           SetCategory();
            var disease = _hastlikTakipDbContext.Disease.Where(a => a.Id == id).Select(a => new HastalikTakibi.Models.DiseaseVm()
            {
                Id=a.Id,
                 FirstSeenDate=a.FirstSeenDate,
                  Name=a.Name
            }).FirstOrDefault();
            if (disease != null)
            {
                ViewBag.DisaseCategoryList = (from dc in _hastlikTakipDbContext.DiseaseCategory
                                              join c in _hastlikTakipDbContext.Category on dc.CategoryId equals c.Id
                                              where dc.DisaeaseId == id
                                              select new SelectListItem()
                                              {
                                                  Value = c.Id.ToString(),
                                                  Text = c.Name

                                              }).ToList();
            }
            else
            {
                ViewBag.Error = "Hastalık Bulunamadı";
                return RedirectToAction("Index");
            }
            return View(disease);
        }
      
        [HttpPost]
        public IActionResult DiseaseDeleteConfirm(int id)
        {
            var disease = _hastlikTakipDbContext.Disease.FirstOrDefault(a => a.Id == id);
            var diseasecategory = _hastlikTakipDbContext.DiseaseCategory.Where(a => a.DisaeaseId == id).ToList();
            _hastlikTakipDbContext.DiseaseCategory.RemoveRange(diseasecategory);
            _hastlikTakipDbContext.Disease.Remove(disease);
            _hastlikTakipDbContext.SaveChangesAsync().GetAwaiter().GetResult();
            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult DiseaseAdd(HastalikTakibi.Models.DiseaseVm disease)
        {

            if (disease == null || string.IsNullOrEmpty(disease.Name))
            {
                ViewBag.Error = "Lütfen zorunlu alanları doldurun";
                return View(disease);
            }
            var diseaseDb = new Disease()
            {
                 CreateTime=DateTime.Now,
                 FirstSeenDate=disease.FirstSeenDate,
                 Name=disease.Name
            };
            if (disease.CategoryIdList != null)
            {
                diseaseDb.DiseaseCategory = new List<DiseaseCategory>();
                foreach (var item in disease.CategoryIdList)
                {
                    diseaseDb.DiseaseCategory.Add(new DiseaseCategory()
                    {
                         CreateTime=DateTime.Now,
                         CategoryId=item,

                    });
                }

            }
            _hastlikTakipDbContext.Disease.Add(diseaseDb);
            _hastlikTakipDbContext.SaveChangesAsync().GetAwaiter().GetResult();
            return RedirectToAction("Index");
        }
        
        public IActionResult DiseaseUpdate(int id)
        {
            SetCategory();
            var disease = _hastlikTakipDbContext.Disease.Where(a => a.Id == id).Select(a => new HastalikTakibi.Models.DiseaseVm()
            {
                Id=a.Id,
                 FirstSeenDate=a.FirstSeenDate,
                  Name=a.Name
            }).FirstOrDefault();
            if (disease != null)
            {
                ViewBag.DisaseCategoryList = (from dc in _hastlikTakipDbContext.DiseaseCategory
                                              join c in _hastlikTakipDbContext.Category on dc.CategoryId equals c.Id
                                              where dc.DisaeaseId == id
                                              select new SelectListItem()
                                              {
                                                  Value = c.Id.ToString(),
                                                  Text = c.Name

                                              }).ToList();
            }
            else
            {
                ViewBag.Error = "Hastalık Bulunamadı";
                return RedirectToAction("Index");
            }
            return View(disease);
        }

        [HttpPost]
        public IActionResult DiseaseUpdate(HastalikTakibi.Models.DiseaseVm disease)
        {
            var diseaseDb = _hastlikTakipDbContext.Disease.Where(a => a.Id == disease.Id).FirstOrDefault();
            if (diseaseDb == null)
            {
                ViewBag.Error = "Hastalık Bulunamadı";
                return RedirectToAction("Index");
            }
            if (disease == null || string.IsNullOrEmpty(disease.Name))
            {
                ViewBag.Error = "Lütfen zorunlu alanları doldurun";
                SetCategory();
                disease.CategoryIdList = disease.CategoryIdList == null ? new List<int>() : disease.CategoryIdList;
                ViewBag.DisaseCategoryList = (from  c in _hastlikTakipDbContext.Category 
                                              where disease.CategoryIdList.Contains(c.Id)
                                              select new SelectListItem()
                                              {
                                                  Value = c.Id.ToString(),
                                                  Text = c.Name

                                              }).ToList();
                return View(disease);
            }
            diseaseDb.Name = disease.Name;
            diseaseDb.FirstSeenDate = disease.FirstSeenDate;
            diseaseDb.LastUpdateTime = DateTime.Now;
            _hastlikTakipDbContext.Entry(diseaseDb).State = Microsoft.EntityFrameworkCore.EntityState.Modified;

            var diseaseCategoryDbList = _hastlikTakipDbContext.DiseaseCategory.Where(a => a.DisaeaseId == disease.Id).ToList();
            foreach (var item in diseaseCategoryDbList)
            {
                if(!disease.CategoryIdList.Contains(item.Id))
                    _hastlikTakipDbContext.Entry(item).State = Microsoft.EntityFrameworkCore.EntityState.Deleted;
                else
                {
                    item.LastUpdateTime = DateTime.Now;
                    _hastlikTakipDbContext.Entry(item).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                    disease.CategoryIdList.Remove(item.Id);
                }
            }
            foreach (var item in disease.CategoryIdList)
            {
                _hastlikTakipDbContext.Entry(new DiseaseCategory()
                {
                    CreateTime = DateTime.Now,
                    CategoryId = item,
                    DisaeaseId=disease.Id

                }).State = Microsoft.EntityFrameworkCore.EntityState.Added;
            }
            _hastlikTakipDbContext.SaveChangesAsync().GetAwaiter().GetResult();
            return RedirectToAction("Index");
        }

    }
}
