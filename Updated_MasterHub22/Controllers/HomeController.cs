using DashBoard2.Data;
using DashBoard2.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using static System.Net.Mime.MediaTypeNames;

namespace DashBoard2.Controllers
{
    
    public class HomeController : Controller
    {
        private IWebHostEnvironment _pic;
        private readonly MyAppDb _db;
        public HomeController(MyAppDb db, IWebHostEnvironment pic)
        {
            _db = db;
            _pic = pic;
        }

        // For Home Page
        public IActionResult Home()
        {
           var count =  _db.tbl_services.Count();
            ViewBag.countservices = count;
			return View();
        }

		// Login Session Satrt

		public IActionResult login()
        {
            return View();
        }
        [HttpPost]

        public IActionResult login(string adminEmail, string adminPassword)
        {
            var rec = _db.tbl_adm1.FirstOrDefault(a => a.Adm_email == adminEmail);
            if (rec != null && rec.Adm_password == adminPassword)
            {
                HttpContext.Session.SetString("ad_session", rec.Adm_id.ToString());
                return RedirectToAction("Admin");
            }
            else
            {
                ViewBag.message = "Incorrect User Name OR Password";
                return View();
            }
        }

		// Login Session End

		//************************************************

		// Logout Session Start

		public IActionResult Logout()
        {
            HttpContext.Session.Remove("ad_session");
            return RedirectToAction("Login");
        }

		// Logout Session End

        //******************************************

		//  Forget Seesion Start
		public IActionResult forget()
        {
            return View();
        }
        [HttpPost]
        public IActionResult forget(string adminEmail, string adminPassword)
        {
            var record2 = _db.tbl_adm1.FirstOrDefault(a => a.Adm_email == adminEmail);
            if (record2 != null)
            {
                record2.Adm_password = adminPassword;
                _db.SaveChanges();
                return RedirectToAction("Login");
            }
            else
            {
                return View();
            }

        }

        // Forget Seesion End

        // ***********************************************

        // Admin Session Start

        public IActionResult addadmin()
        {
            return View();
        }
        [HttpPost]
        public IActionResult addadmin(Admin ad, IFormFile Adm_image)
        {

            String Images = Path.Combine(_pic.WebRootPath, "admin_image", Adm_image.FileName);
            FileStream fs = new FileStream(Images, FileMode.Create);
            Adm_image.CopyTo(fs);
            ad.Adm_image = Adm_image.FileName;


            _db.tbl_adm1.Add(ad);
            _db.SaveChanges();
            return RedirectToAction("Login");
        }

        public IActionResult Admin()
        {
            var admin = HttpContext.Session.GetString("ad_session");
            if (admin != null)
            {
                var admins = HttpContext.Session.GetString("ad_session");
                var admin_data = _db.tbl_adm1.Where(a => a.Adm_id == int.Parse(admins)).ToList();
                return View(admin_data);
            }
            else
            {
                return RedirectToAction("Login");
            }
        }

        // image update

        public IActionResult updateimage(int id)
        {
            var admin = HttpContext.Session.GetString("ad_session");
            if (admin != null)
            {
                var prof1 = _db.tbl_adm1.Find(id);
                return View(prof1);
            }
            else
            {
                return RedirectToAction("Login");
            }
        }
        [HttpPost]
        public IActionResult updateimage(Admin ad, IFormFile Adm_image)
        {

            String Images = Path.Combine(_pic.WebRootPath, "admin_image", Adm_image.FileName);
            FileStream fs = new FileStream(Images, FileMode.Create);
            Adm_image.CopyTo(fs);
            ad.Adm_image = Adm_image.FileName;

            _db.tbl_adm1.Update(ad);
            _db.SaveChanges();
            return RedirectToAction("Admin");
        }

        // update Profile

        public IActionResult updateprofile(int id)
        {
            var admin = HttpContext.Session.GetString("ad_session");
            if (admin != null)
            {
                var prof = _db.tbl_adm1.Find(id);
                return View(prof);
            }
            else
            {
                return RedirectToAction("Login");
            }
        }
        [HttpPost]
        public IActionResult updateprofile(Admin adm)
        {
            _db.tbl_adm1.Update(adm);
            _db.SaveChanges();
            return RedirectToAction("Admin");
        }

        // Admin Seesion End

        //********************************************

        // Customer Session Start

        public IActionResult addcustomer()
        {
            return View();
        }
        [HttpPost]
        public IActionResult addcustomer(Customer Cus)
        {
            _db.tbl_cus1.Add(Cus);
            _db.SaveChanges();
            return RedirectToAction("fetchcustomer");
        }

        public IActionResult fetchcustomer()
        {
            var admin = HttpContext.Session.GetString("ad_session");
            if (admin != null)
            {
                var show = _db.tbl_cus1.ToList();
                return View(show);
            }
            else 
            {
                return RedirectToAction("Login");
            }
        }

        public IActionResult customerdelete(int id)
        {
            var del = _db.tbl_cus1.Find(id);
            _db.tbl_cus1.Remove(del);
            _db.SaveChanges();
            return RedirectToAction("fetchcustomer");
        }

        public IActionResult customerupdate(int id)
        {
            var admin = HttpContext.Session.GetString("ad_session");
            if (admin != null)
            {
                var del = _db.tbl_cus1.Find(id);
                return View(del);
            }
            else
            {
                return RedirectToAction("Login");
            }
        }
        [HttpPost]
        public IActionResult customerupdate(Customer Cus)
        {
            _db.tbl_cus1.Update(Cus);
            _db.SaveChanges();
            return RedirectToAction("fetchcustomer");
        }

        //  Customer Session End

        // *********************************************

        //  City Session Start

        public IActionResult addcity()
        {
            return View();
        }
        [HttpPost]
        public IActionResult addcity(City Ct , IFormFile C_image)
        {
            String File = Path.Combine(_pic.WebRootPath, "city_images", C_image.FileName);
            FileStream fs = new FileStream(File, FileMode.Create);
            C_image.CopyTo(fs);
            Ct.City_image = C_image.FileName;

            _db.tbl_city.Add(Ct);
            _db.SaveChanges();
            return RedirectToAction("fetchcity");
        }

        public IActionResult fetchcity()
        {
            var admin = HttpContext.Session.GetString("ad_session");
            if (admin != null)
            {
                var show = _db.tbl_city.ToList();
                return View(show);
            }
            else 
            {
                return RedirectToAction("Login");
            }
        }

        public IActionResult citydelete(int id)
        {
            var del = _db.tbl_city.Find(id);
            _db.tbl_city.Remove(del);
            _db.SaveChanges();
            return RedirectToAction("fetchcity");
        }

        public IActionResult cityupdatedata(int id)
        {
            var admin = HttpContext.Session.GetString("ad_session");
            if (admin != null)
            {
                var del = _db.tbl_city.Find(id);
                return View(del);
            }
            else
            {
                return RedirectToAction("Login");
            }
        }
        [HttpPost]
        public IActionResult cityupdatedata(City Ct , IFormFile City_image)
        {
            String File =  Path.Combine(_pic.WebRootPath, "city_images", City_image.FileName);
            FileStream fs = new FileStream(File, FileMode.Create);
            City_image.CopyTo(fs);
            Ct.City_image = City_image.FileName;

            _db.tbl_city.Update(Ct);
            _db.SaveChanges();
            return RedirectToAction("fetchcity");
        }

        public IActionResult cityupdateimage(int id)
        {
            var admin = HttpContext.Session.GetString("ad_session");
            if (admin != null)
            {
                var del = _db.tbl_city.Find(id);
                return View(del);
            }
            else
            {
                return RedirectToAction("Login");
            }
        }
        [HttpPost]
        public IActionResult cityupdateimage(City Ct, IFormFile City_image)
        {
            String File = Path.Combine(_pic.WebRootPath, "city_images", City_image.FileName);
            FileStream fs = new FileStream(File, FileMode.Create);
            City_image.CopyTo(fs);
            Ct.City_image = City_image.FileName;

            _db.tbl_city.Update(Ct);
            _db.SaveChanges();
            return RedirectToAction("fetchcity");
        }

        //  City Session End

        // *******************************************

        //  Service Session Start

        public IActionResult addservice()
        {
            return View();
        }
        [HttpPost]
        public IActionResult addservice(Services ser , IFormFile Services_Image)
        {
            String File = Path.Combine(_pic.WebRootPath, "service_image", Services_Image.FileName);
            FileStream fs = new FileStream(File, FileMode.Create);
            Services_Image.CopyTo(fs);
            ser.Services_Image = Services_Image.FileName;
            _db.tbl_services.Add(ser);
            _db.SaveChanges();
            return RedirectToAction("fetchservice");
        }

        public IActionResult fetchservice()
        {
            var admin = HttpContext.Session.GetString("ad_session");
            if (admin != null)
            {
                var show = _db.tbl_services.ToList();
                return View(show);
            }
            else
            {
                return RedirectToAction("Login");
            }
        }

        public IActionResult servicedelete(int id)
        {
            var del = _db.tbl_services.Find(id);
            _db.tbl_services.Remove(del);
            _db.SaveChanges();
            return RedirectToAction("fetchservice");
        }

        public IActionResult serviceupdatedata(int id)
        {
            var admin = HttpContext.Session.GetString("ad_session");
            if (admin != null)
            {
                var del = _db.tbl_services.Find(id);
                return View(del);
            }
            else
            {
                return RedirectToAction("Login");
            }

        }
        [HttpPost]
        public IActionResult serviceupdatedata(Services ser)
        {
            _db.tbl_services.Update(ser);
            _db.SaveChanges();
            return RedirectToAction("fetchservice");

        }

        public IActionResult serviceupdateimage(int id)
        {
            var admin = HttpContext.Session.GetString("ad_session");
            if (admin != null)
            {
                var del = _db.tbl_services.Find(id);
                return View(del);
            }
            else
            {
                return RedirectToAction("Login");
            }

        }
        [HttpPost]
        public IActionResult serviceupdateimage(Services ser, IFormFile Services_Image)
        {
            String File = Path.Combine(_pic.WebRootPath, "service_image", Services_Image.FileName);
            FileStream fs = new FileStream(File, FileMode.Create);
            Services_Image.CopyTo(fs);
            ser.Services_Image = Services_Image.FileName;

            _db.tbl_services.Update(ser);
            _db.SaveChanges();
            return RedirectToAction("fetchservice");

        }

        //  Service Session End

        // *********************************************

        //  Partner  Session Start

        public IActionResult addpartner()
        {
            return View();
        }
        [HttpPost]
        public IActionResult addpartner(Partner par)
        {
            _db.tbl_part.Add(par);
            _db.SaveChanges();
            return RedirectToAction("fetchservice");
        }

        public IActionResult fetchpartner()
        {
            var admin = HttpContext.Session.GetString("ad_session");
            if (admin != null)
            {
                var show = _db.tbl_part.ToList();
                return View(show);
            }
            else 
            {
                return RedirectToAction("Login");
            }
        }

        public IActionResult partnerdelete(int id)
        {
            var del = _db.tbl_part.Find(id);
            _db.tbl_part.Remove(del);
            _db.SaveChanges();
            return RedirectToAction("fetchpartner");
        }

        public IActionResult partnerupdate(int id)
        {
            var admin = HttpContext.Session.GetString("ad_session");
            if (admin != null)
            {
                var del = _db.tbl_part.Find(id);
                return View(del);
            }
            else
            {
                return RedirectToAction("Login");
            }
        }
        [HttpPost]
        public IActionResult partnerupdate(Partner par)
        {
            _db.tbl_part.Update(par);
            _db.SaveChanges();
            return RedirectToAction("fetchcity");
        }

        //  Partner Session End

        //***************************************************

        //  Feedback Session Start

        public IActionResult addfeedback()
        {
            return View();
        }
        [HttpPost]
        public IActionResult addfeedback(Feedback fee)
        {
            _db.tbl_feed.Add(fee);
            _db.SaveChanges();
            return RedirectToAction("fetchfeedback");
        }

        public IActionResult fetchfeedback()
        {
            var admin = HttpContext.Session.GetString("ad_session");
            if (admin != null)
            {
                var show = _db.tbl_feed.ToList();
                return View(show);
            }
            else
            {
                return RedirectToAction("Login");
            }
        }

        public IActionResult feedbackdelete(int id)
        {
            var del = _db.tbl_feed.Find(id);
            _db.tbl_feed.Remove(del);
            _db.SaveChanges();
            return RedirectToAction("fetchfeedback");
        }
        public IActionResult feedbackupdate(int id)
        {
            var admin = HttpContext.Session.GetString("ad_session");
            if (admin != null)
            {
                var del = _db.tbl_feed.Find(id);
                return View(del);
            }
            else
            {
                return RedirectToAction("Login");
            }
        }
        [HttpPost]
        public IActionResult feedbackupdate(Feedback fee)
        {
            _db.tbl_feed.Update(fee);
            _db.SaveChanges();
            return RedirectToAction("fetchfeedback");
        }

        //  Feedback Session End

        // ***********************************************

        // Booking Session Start

        public IActionResult fetchbooking()
        {
            var admin = HttpContext.Session.GetString("ad_session");
            if (admin != null)
            {
                var show = _db.tbl_bookingservice.ToList();
                return View(show);
            }
            else
            {
                return RedirectToAction("Login");
            }
        }

        public IActionResult addbooking()
        {
            List<Services> service = _db.tbl_services.ToList();
            List<City> cities = _db.tbl_city.ToList();
            ViewData["service"] = service;
            ViewData["cities"] = cities;
            return View();
        }
        [HttpPost]
        public IActionResult addbooking(Bookingservice book)
        {
            _db.tbl_bookingservice.Add(book);
            _db.SaveChanges();  
            return RedirectToAction("fetchbooking");
        }

        public IActionResult bookingdelete(int id)
        {
            var del = _db.tbl_bookingservice.Find(id);
            _db.tbl_bookingservice.Remove(del);
            _db.SaveChanges();
            return RedirectToAction("fetchbooking");
        }

        public IActionResult bookingupdate(int id)
        {
            var admin = HttpContext.Session.GetString("ad_session");
            if (admin != null)
            {
                var shws = _db.tbl_bookingservice.Find(id);
                return View(shws);
            }
            else
            {
                return RedirectToAction("Login");
            }
        }
        [HttpPost]
        public IActionResult bookingupdate(Bookingservice book)
        {
            _db.tbl_bookingservice.Update(book);
            _db.SaveChanges();
            return RedirectToAction("fetchbooking");
        }

        // Booking Session End

    }
}