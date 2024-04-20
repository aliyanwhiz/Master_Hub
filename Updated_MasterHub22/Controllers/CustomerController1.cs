using DashBoard2.Data;
using DashBoard2.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DashBoard2.Controllers
{
	public class CustomerController : Controller
	{
		private readonly MyAppDb _context;
		public CustomerController(MyAppDb context)
		{
			_context = context;
		}

		// Index View :

		public IActionResult Index()
		{
			var dataimg = _context.tbl_services.ToList();
	        return View(dataimg);

		}

		// Signup page Display :

		public IActionResult SignUp()
		{
			return View();
		}
		[HttpPost]
		public IActionResult SignUp(Customer cust)
		{
			_context.tbl_cus1.Add(cust);
			_context.SaveChanges();
			return RedirectToAction("Login");
		}


		// login page Display :

		public IActionResult Login()
		{
			//ViewBag.message = "Test";
			return View();
		}
		[HttpPost]
		public IActionResult Login(Customer customer, string Cus_email, string Cus_password)
		{
			var record = _context.tbl_cus1.FirstOrDefault(a => a.Cus_email == Cus_email);
			if (record != null && record.Cus_password == Cus_password)
			{
				HttpContext.Session.SetString("customer_id", record.Cus_id.ToString());
                return RedirectToAction("Index");
			}
			else
			{

				ViewBag.message = "Incorrect User Name And Password";
				return View();
			}
		}


		// login page Display :
		
		public IActionResult Logout()
		{
			HttpContext.Session.Remove("customer_id");
			return RedirectToAction("Login");
		}


		// About Page Display :

		public IActionResult About()
		{ 
			return View();
		}


		// AllServices Page Display :

		public IActionResult ServiceBooking(int myid)
		{
            var checksession = HttpContext.Session.GetString("customer_id");
            if (checksession != null)
            {
                var serviceid = _context.tbl_services.FirstOrDefault(option => option.Service_Id == myid);

				List<City> cities = _context.tbl_city.ToList();
				ViewBag.servicename = serviceid.Services_Name;
				ViewData["cities"] = cities;
				return View();
            }
            else
            {
                return RedirectToAction("Login");
            }
       
		}
		[HttpPost]
		public IActionResult ServiceBooking(Bookingservice book)
		{
				_context.tbl_bookingservice.Add(book);
				_context.SaveChanges();
				return RedirectToAction("Index");
		}

		// Contact Page Display :


		public IActionResult ContactUs()
		{
			return View();
		}
		[HttpPost]
		public IActionResult ContactUs(Feedback fee)
		{
			_context.tbl_feed.Add(fee);
			_context.SaveChanges();
			return RedirectToAction("Index");
		}

		// booking Page Display :

		public IActionResult AllServices()
		{

			var servicesdata = _context.tbl_services.ToList();
			return View(servicesdata);

			return RedirectToAction("Login");

			
		}
	}
}
