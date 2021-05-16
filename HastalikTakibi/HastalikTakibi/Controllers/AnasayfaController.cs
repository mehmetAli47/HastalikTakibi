using HastalikTakibi.DAL;
using HastalikTakibi.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;

namespace HastalikTakibi.Controllers
{
    public class AnasayfaController : AdminBaseController
    {
        public AnasayfaController(HastlikTakipDbContext hastlikTakipDbContext) : base(hastlikTakipDbContext)
        {
        }
        public void SetDisease()
        {
            var diseaseList = new List<SelectListItem>();
            var disease = _hastlikTakipDbContext.Disease.ToList();
            foreach(var item in disease)
            {
                diseaseList.Add(new SelectListItem
                {
                    Text = item.Name,
                    Value = item.Id.ToString()
                }); 

            }
            ViewBag.DiseaseList = diseaseList;
        }
        public IActionResult Anasayfa()
        {
            SetDisease();
            return View();
        }
    }
 }



