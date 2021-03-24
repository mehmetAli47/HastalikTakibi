﻿using HastalikTakibi.Models;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using HastalikTakibi.DAL;
using Microsoft.EntityFrameworkCore;

namespace HastalikTakibi.Controllers
{
    public class UserController : Controller
    {
        HastlikTakipDbContext _hastlikTakipDbContext;
        public UserController(HastlikTakipDbContext hastlikTakipDbContext)
        {
            _hastlikTakipDbContext = hastlikTakipDbContext;
        }
        public IActionResult LoginUser()
        {
            return View();
        }
        [HttpPost]
        public IActionResult LoginUser(User user)
        {
            var taskUser = _hastlikTakipDbContext.User.Where(a => a.username == user.UserName && a.password == user.Password).FirstOrDefaultAsync();
            var userDb = taskUser.GetAwaiter().GetResult();

            //var userDb =await _hastlikTakipDbContext.User.Where(a => a.username==user.UserName && a.password==user.Password).FirstOrDefaultAsync();

            if (userDb != null)
            {
                //return to admin mangement
                return RedirectToAction("Anasayfa", "Anasayfa");
            }
            ViewBag.Error = "Kullanıcı Bulunamadı";
            return View(user);


        }
    }
}

