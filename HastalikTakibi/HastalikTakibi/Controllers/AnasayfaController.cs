using HastalikTakibi.DAL;
using HastalikTakibi.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
namespace HastalikTakibi.Controllers
{
    public class AnasayfaController : AdminBaseController
    {
        public AnasayfaController(HastlikTakipDbContext hastlikTakipDbContext):base(hastlikTakipDbContext)
        {
        }

        public IActionResult Anasayfa()
        {
            User usersession=null;
            try
            {
                usersession = JsonConvert.DeserializeObject<Models.User>(HttpContext.Session.GetString("SessionUser"));
            }
            catch{ } 
                return View(usersession);
        }
        
        public IActionResult Covid()
        {
            return View();
        }
        
    }
}




