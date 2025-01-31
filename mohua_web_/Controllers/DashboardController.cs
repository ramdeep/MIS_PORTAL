using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using mohua_web_.Entities;
using mohua_web_.Models;
using Npgsql;
using System.Diagnostics;

namespace mohua_web_.Controllers
{
    public class DashboardController : Controller
    {
        private readonly ILogger<DashboardController> _logger;
        private readonly DsuContext _dbContext;


        public DashboardController(ILogger<DashboardController> logger, DsuContext _Dbcontext)
        {
            _logger = logger;
            _dbContext = _Dbcontext;
        }
        //con test
        public IActionResult pgcontest()
        {
			string connectionString = "Host=mohua.905418336779.ap-south-1.redshift-serverless.amazonaws.com;Database=dev;Username=admin;Port=5439;Password=DSUmohua$1234;SSL Mode=Require";

			try
			{
				using (var conn = new NpgsqlConnection(connectionString))
				{
					conn.Open();
					ViewBag.Message = "Connection successful!";
					ViewBag.Status = "success";
				}
			}
			catch (Exception ex)
			{
				ViewBag.Message = $"Connection failed: {ex.Message}";
				ViewBag.Status = "error";
			}
			return View();
		}
        //end con test
        public IActionResult Dashboard()
        {

            return View();
        }

        public IActionResult pmay()
        {

            return View();
        }
        //
        public IActionResult pmsvanidhi()
        {

            return View();
        }
  
        public IActionResult amrut()
        {

            return View();
        }
        //
        public IActionResult nulm()
        {

            return View();
        }
        public IActionResult scm()
        {

            return View();
        }
        //
        public IActionResult sbm()
        {

            return View();
        }
        //end login post
        public IActionResult dashboard()
        {
            return View();
        }
        

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
