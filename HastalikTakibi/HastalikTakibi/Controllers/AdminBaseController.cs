using HastalikTakibi.DAL;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HastalikTakibi.Controllers
{
    public class AdminBaseController : Controller
    {
       protected  HastlikTakipDbContext _hastlikTakipDbContext;
        public AdminBaseController(HastlikTakipDbContext hastlikTakipDbContext)
        {
            _hastlikTakipDbContext = hastlikTakipDbContext;
        }
        public override void OnActionExecuted(ActionExecutedContext context)
        {
            base.OnActionExecuted(context);
            ViewBag.CategoryHasDiseaseList = (from  c in _hastlikTakipDbContext.Category 
                                          where _hastlikTakipDbContext.DiseaseCategory.Any(dc=>dc.CategoryId==c.Id)
                                              select new SelectListItem()
                                          {
                                              Value = c.Id.ToString(),
                                              Text = c.Name

                                          }).ToList();
        }
    }
}
