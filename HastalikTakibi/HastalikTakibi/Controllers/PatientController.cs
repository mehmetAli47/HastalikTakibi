using HastalikTakibi.DAL;
using HastalikTakibi.DAL.Models.Database;
using HastalikTakibi.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace HastalikTakibi.Controllers
{
    public class PatientController : AdminBaseController
    {
        public PatientController(HastlikTakipDbContext hastlikTakipDbContext) : base(hastlikTakipDbContext)
        {
        }
        public int SetCategory()
        {
            int firstId = 0;
            var categoryList = new List<SelectListItem>();

            var categories = _hastlikTakipDbContext.Category.OrderBy(a => a.Name).ToList();
            for (int i = 0; i < categories.Count; i++)
            {
                
                var item = categories[i];
                if (i == 0)
                    firstId = item.Id;
                categoryList.Add(new SelectListItem
                {
                    Text = item.Name,
                    Value = item.Id.ToString()
                });
            }
            ViewBag.CategoryList = categoryList;
            return firstId;
        }
        public void SetDisease(int categoryId)
        {
            var diseaseList = new List<SelectListItem>();
            var diseases = (from d in _hastlikTakipDbContext.Disease
                            join dc in _hastlikTakipDbContext.DiseaseCategory on d.Id equals dc.DisaeaseId
                            where dc.CategoryId == categoryId
                            orderby d.Name
                            select d).ToList();
            foreach (var item in diseases)
            {
                diseaseList.Add(new SelectListItem
                {
                    Text = item.Name,
                    Value = item.Id.ToString()
                });
            }
            ViewBag.DiseaseList = diseaseList;
        }

        public void SetDistrict(int plateNumber)
        {
            var districtList = new List<SelectListItem>();
            var districts = (from d in _hastlikTakipDbContext.Districts
                             join p in _hastlikTakipDbContext.Provinces on d.PlateNumber equals p.ProvinceNumber
                             where p.ProvinceNumber == plateNumber
                             orderby d.DistrictName
                             select d).ToList();
            foreach (var item in districts)
            {
                districtList.Add(new SelectListItem
                {
                    Text = item.DistrictName,
                    Value = item.Id.ToString()
                });
            }
            ViewBag.DistrictList = districtList;
        }
        public int SetProvince()
        {
            int firstId = 0;
            var provinceList = new List<SelectListItem>();
            var provinces = _hastlikTakipDbContext.Provinces.OrderBy(a => a.ProvinceName).ToList();
            for (int i = 0; i < provinces.Count; i++)
            {
                var item= provinces[i];
                if (i == 0)
                    firstId = item.ProvinceNumber;
                provinceList.Add(new SelectListItem
                {
                    Text = item.ProvinceName,
                    Value = item.ProvinceNumber.ToString()
                });
            }
            ViewBag.ProvinceList = provinceList;
            return firstId;
        }
        
        
        public IActionResult Index()
        {
            var patientList = _hastlikTakipDbContext.Patient.ToList();

            return View( patientList);
        }

        public IActionResult PatientInformation(int id )
        {
            ViewBag.PatientId = id;
            var patientName = _hastlikTakipDbContext.Patient.FirstOrDefault(a => a.Id==id);
            ViewBag.PatientName = patientName.Name+"   " + patientName.Surname +"   " + patientName.TC; 
           var patientinformationList = (from p in _hastlikTakipDbContext.PatientInformationView
                                      join d in _hastlikTakipDbContext.Disease on p.DiseaseId  equals d.Id
                                      where p.PatientId == id
                                      select p).ToList();
                
               

            return View(patientinformationList);
        }
       
        public IActionResult PatientAdd()
        {
            return View();
        }
       
     

        [HttpPost]
        public JsonResult GetDiseasByCategoryId(int categoryId)
        {
            var diseasList = (from ds in _hastlikTakipDbContext.Disease
                                   join hc in _hastlikTakipDbContext.DiseaseCategory on ds.Id equals hc.DisaeaseId
                                   where  hc.CategoryId==categoryId
                                   select new KeyValueVM
                                   {
                                       Text = ds.Name,
                                       Id = ds.Id

                                   }).ToList();
            return Json(diseasList);
        }
        [HttpPost]
        public JsonResult GetDistrictByProvinceId( int provinceId)
        {
            var districtList = (from ds in _hastlikTakipDbContext.Districts
                                join pv in _hastlikTakipDbContext.Provinces on ds.PlateNumber equals pv.ProvinceNumber
                                where pv.ProvinceNumber == provinceId
                                select new KeyValueVM
                                {
                                    Text = ds.DistrictName,
                                    Id=ds.Id
                                });
            return Json(districtList);
        }

        [HttpPost]
        public IActionResult PatientAdd(HastalikTakibi.Models.PatientVm patient)
        {

            if (patient == null || string.IsNullOrEmpty(patient.Name))
            {
                ViewBag.Error = "Lütfen zorunlu alanları doldurun";
                return View(patient);
            }
            var patientDb = new Patient()
            {
                CreateTime = DateTime.Now,
                Name = patient.Name,
                Surname=patient.Surname,
                Address=patient.Address,
                EMail=patient.EMail,
                TC=patient.TC,
                Phone=patient.Phone,
                Province=patient.Province,
                District=patient.District
            };
            
            _hastlikTakipDbContext.Patient.Add(patientDb);
            _hastlikTakipDbContext.SaveChangesAsync().GetAwaiter().GetResult();
            return RedirectToAction("Index");

        }

        public IActionResult PatientInformationAdd(int id)
        {
            int categoryId = SetCategory();
            SetDisease(categoryId);
            int plateNumber=SetProvince();
            SetDistrict(plateNumber);
            ViewBag.PatientId = id;
            return View();
        }

        [HttpPost]
        public IActionResult PatientInformationAdd(HastalikTakibi.Models.PatientInformationVM patientInformation)
        {
            if (patientInformation == null || patientInformation.DiseaseId <= 0 || patientInformation.PatientId <= 0)
            {
                ViewBag.eror = "zorunlu alanları doldurunuz";
                int categoryId = SetCategory();
                SetDisease(categoryId);
                int plateNumber = SetProvince();
                SetDistrict(plateNumber);
                return View(patientInformation);
            }
            var patientknownDb = new PatientInformation()
            {
                PatientId = patientInformation.PatientId,
                DiseaseId = patientInformation.DiseaseId,
                WhenIll = patientInformation.WhenIll,
                RecoveryTime = patientInformation.RecoveryTime,
                ProvinceId = patientInformation.ProvinceId,
                DistrictId = patientInformation.DistrictId,
                Latitude = patientInformation.Latitude,
                Longitude = patientInformation.Longitude,
                Symptoms = patientInformation.Symptoms,
                CategoryId = patientInformation.CategoryId
            };

            _hastlikTakipDbContext.PatientInformation.Add(patientknownDb);
            _hastlikTakipDbContext.SaveChangesAsync().GetAwaiter().GetResult();
            return RedirectToAction("PatientInformation", new { id =patientknownDb.PatientId});
        }
        public IActionResult PatientDelete(int id)
        {
            var patient = _hastlikTakipDbContext.Patient.Where(a => a.Id == id).Select(a => new HastalikTakibi.Models.PatientVm()
            {
                Id = a.Id,
                Name = a.Name,
                Surname = a.Surname,
                Address = a.Address,
                EMail = a.EMail,
                TC = a.TC,
                Phone = a.Phone,
                Province = a.Province,
                District = a.District

            }).FirstOrDefault();
            return View(patient);
        }
        public IActionResult PatientInformationDelete( int id)
        {
            var information = _hastlikTakipDbContext.PatientInformation.Where(a => a.Id == id).Select(a => new HastalikTakibi.Models.PatientInformationVM()
            {
                Id = a.Id,
                CategoryId=a.CategoryId,
                DiseaseId=a.DiseaseId,
                DistrictId=a.DistrictId,
                Latitude=a.Latitude,
                Longitude=a.Longitude,
                PatientId=a.PatientId,
                ProvinceId=a.ProvinceId,
                RecoveryTime=a.RecoveryTime,
                Symptoms=a.Symptoms,
                WhenIll=(DateTime)a.WhenIll
                });
            return View();
        }
        [HttpPost]
        public IActionResult PatientInformationDeleteConfirm(int id)
        {
            var patientInformation = _hastlikTakipDbContext.PatientInformationView.FirstOrDefault(a => a.Id == id);
            _hastlikTakipDbContext.PatientInformationView.Remove(patientInformation);
            _hastlikTakipDbContext.SaveChangesAsync().GetAwaiter().GetResult();
            return RedirectToAction("PatientInformation", new { id = patientInformation.PatientId});
        }

        [HttpPost]
        public IActionResult PatientDeleteConfirm( int id)
        {
            var patient = _hastlikTakipDbContext.Patient.FirstOrDefault( a =>a.Id==id);
            _hastlikTakipDbContext.Patient.Remove(patient);
            _hastlikTakipDbContext.SaveChangesAsync().GetAwaiter().GetResult();

            return RedirectToAction("Index");       
        }
        public IActionResult PatientUpdate(int id)
        {
            var patient = _hastlikTakipDbContext.Patient.Where(a => a.Id == id).Select(a => new HastalikTakibi.Models.PatientVm()
            {
                Id = a.Id,
                Name = a.Name,
                Surname = a.Surname,
                Address = a.Address,
                EMail = a.EMail,
                TC = a.TC,
                Phone = a.Phone,
                Province = a.Province,
                District = a.District
            }).FirstOrDefault();

            return View(patient);
        }

        [HttpPost]
        public IActionResult PatientUpdate(HastalikTakibi.Models.PatientVm patient)
        {
            var patientDb = _hastlikTakipDbContext.Patient.Where(a => a.Id == patient.Id).FirstOrDefault();
            if (patientDb == null)
            {
                ViewBag.Error = "Hasta Bulunamadı";
                return RedirectToAction("Index");
            }
            if (patient == null || string.IsNullOrEmpty(patient.Name))
            {
                ViewBag.Error = "Lütfen zorunlu alanları doldurun";


                return View(patient);
            }
            patientDb.Name = patient.Name;
            patientDb.Surname = patient.Surname;
            patientDb.Address = patient.Address;
            patientDb.EMail = patient.EMail;
            patientDb.TC = patient.TC;
            patientDb.Phone = patient.Phone;
            patientDb.Province = patient.Province;
            patientDb.District = patient.District;
            patientDb.LastUpdateTime = DateTime.Now;
            _hastlikTakipDbContext.Entry(patientDb).State = Microsoft.EntityFrameworkCore.EntityState.Modified;



            _hastlikTakipDbContext.SaveChangesAsync().GetAwaiter().GetResult();
            return RedirectToAction("Index");
        }

        public IActionResult PatientInformationUpdate(int id)
        {
            var information = _hastlikTakipDbContext.PatientInformation.Where(a => a.Id == id).Select(a => new HastalikTakibi.Models.PatientInformationVM()
            {
                Id = a.Id,
                PatientId = a.PatientId,
                CategoryId = a.CategoryId,
                DiseaseId = a.DiseaseId,
                WhenIll = (DateTime)a.WhenIll,
                RecoveryTime = a.RecoveryTime,
                ProvinceId = a.ProvinceId,
                DistrictId = a.DistrictId,
                Latitude = a.Latitude,
                Longitude = a.Longitude,
                Symptoms = a.Symptoms
                
            }).FirstOrDefault();
            int categoryId = SetCategory();
            SetDisease(categoryId);
            int plateNumber = SetProvince();
            SetDistrict(plateNumber);
            return View(information);
        }
        [HttpPost]
        public IActionResult PatientInformationUpdate(HastalikTakibi.Models.PatientInformationVM patientInformation)
        {
            var patientInformationDb = _hastlikTakipDbContext.PatientInformation.Where(a => a.Id == patientInformation.Id).FirstOrDefault();
            if (patientInformationDb == null)
            {
                ViewBag.Error = "Hasta Bulunamadı";
                return RedirectToAction("Index");
            }
            patientInformationDb.Id = patientInformation.Id;
            patientInformation.CategoryId = patientInformation.CategoryId;
            patientInformationDb.DiseaseId = patientInformation.DiseaseId;
            patientInformationDb.DistrictId = patientInformation.DistrictId;
            patientInformationDb.Latitude = patientInformation.Latitude;
            patientInformationDb.Longitude = patientInformation.Longitude;
            patientInformationDb.PatientId = patientInformation.PatientId;
            patientInformationDb.ProvinceId = patientInformation.ProvinceId;
            patientInformationDb.RecoveryTime = patientInformation.RecoveryTime;
            patientInformationDb.Symptoms = patientInformation.Symptoms;
            patientInformationDb.WhenIll = patientInformation.WhenIll;
            _hastlikTakipDbContext.Entry(patientInformationDb).State = Microsoft.EntityFrameworkCore.EntityState.Modified;



            _hastlikTakipDbContext.SaveChangesAsync().GetAwaiter().GetResult();
            return RedirectToAction("PatientInformation" ,new { id = patientInformationDb.PatientId });

           
        }

    }
}
