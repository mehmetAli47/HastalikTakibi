using HastalikTakibi.DAL;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace HastalikTakibi.Controllers
{
    public class AnasayfaController : AdminBaseController
    {
        public AnasayfaController(HastlikTakipDbContext hastlikTakipDbContext):base(hastlikTakipDbContext)
        {
        }

        public IActionResult Anasayfa()
        {
            return View();
        }
        
        public IActionResult Covid()
        {
            return View();
        }
        
    }
}




