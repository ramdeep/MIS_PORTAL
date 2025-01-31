using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using mohua_web_.Entities;
using mohua_web_.Models;
using Npgsql;
using System.Diagnostics;

namespace mohua_web_.Controllers
{
    public class ReportController : Controller
    {
        private readonly ILogger<ReportController> _logger;
        private readonly DsuContext _dbContext;


        public ReportController(ILogger<ReportController> logger, DsuContext _Dbcontext)
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
        public IActionResult Index()
        {
			//
			ViewBag.chkpmay = _dbContext.TblPmays.ToList().Count().ToString();
            // var states = _dbContext.Tbl_master_lgds.ToList();

            var states = _dbContext.TblMasterLgds
                        .GroupBy(s => s.StateCode)
                        .Select(g => new {
                            StateCode = g.Key,
                            StateName = g.First().StateName
                        })
                         .OrderBy(s => s.StateName)
                         .ToList();
            ViewBag.States = new SelectList(states, "StateCode", "StateName");
   
            // var lst = _dbContext.Infos.ToList();
            return View();
        }
        //
        //end con test
        public IActionResult pmsvanidhi()
        {
            //
            ViewBag.chkpmay = _dbContext.TblPmsvanidhis.ToList().Count().ToString();
            // var states = _dbContext.Tbl_master_lgds.ToList();

            var states = _dbContext.TblMasterLgds
                        .GroupBy(s => s.StateCode)
                        .Select(g => new {
                            StateCode = g.Key,
                            StateName = g.First().StateName
                        })
                         .OrderBy(s => s.StateName)
                         .ToList();
            ViewBag.States = new SelectList(states, "StateCode", "StateName");

            // var lst = _dbContext.Infos.ToList();
            return View();
        }
        //
        public IActionResult amrutdetail()
        {
            //
            ViewBag.chkamrutdetail = _dbContext.TblAmrutprojectdetails.ToList().Count().ToString();
            // var states = _dbContext.Tbl_master_lgds.ToList();

            var states = _dbContext.TblMasterLgds
    .GroupBy(s => s.StateCode)
    .Select(g => new {
        StateCode = g.Key,
        StateName = g.First().StateName
    })
    .OrderBy(s => s.StateName)
    .ToList();

            ViewBag.States = new SelectList(states, "StateCode", "StateName");

            // var lst = _dbContext.Infos.ToList();
            return View();
        }
        //
        public IActionResult amrutsummery()
        {
            //
            ViewBag.chkamrutsummery = _dbContext.TblAmrutsummaries.ToList().Count().ToString();
            return View();
        }
        //NULM
        public IActionResult nulm_sepgroup()
        {
            try
            {
                // Fetching and counting SEP group entries
                ViewBag.chknulmsepgroup = _dbContext.TblNulmApiSepgroups.ToList().Count().ToString();

                // Grouping and fetching states
                var states = _dbContext.TblMasterLgds
                    .GroupBy(s => s.StateCode)
                    .Select(g => new {
                        StateCode = g.Key,
                        StateName = g.First().StateName
                    })
                    .OrderBy(s => s.StateName)
                    .ToList();

                ViewBag.States = new SelectList(states, "StateCode", "StateName");

                return View();
            }
            catch (Exception ex)
            {
                // Log the exception (use a logging framework or custom logging)
                // Example: _logger.LogError(ex, "An error occurred while fetching data in nulm_sepgroup.");

                // Optionally: Show an error view or return an error message
                ViewBag.ErrorMessage = "An error occurred while processing your request. Please try again later.";
                return View("Error"); // Replace "Error" with your error view name if you have one.
            }
        }

        //    public IActionResult nulm_sepgroup()
        //    {
        //        //
        //        ViewBag.chknulmsepgroup = _dbContext.TblNulmApiSepgroups.ToList().Count().ToString();
        //        var states = _dbContext.TblMasterLgds
        //.GroupBy(s => s.StateCode)
        //.Select(g => new {
        //    StateCode = g.Key,
        //    StateName = g.First().StateName
        //})
        //.OrderBy(s => s.StateName)
        //.ToList();
        //        ViewBag.States = new SelectList(states, "StateCode", "StateName");
        //        return View();
        //    }
        //
        //sep beneficiary
        public IActionResult nulm_sepbeneficiary()
        {
            try
            {
                // Fetch and count SEP beneficiary entries
                ViewBag.chknulmsepbeneficiary = _dbContext.TblNulmApiSepbeneficiaries.ToList().Count().ToString();

                // Grouping and fetching states
                var states = _dbContext.TblMasterLgds
                    .GroupBy(s => s.StateCode)
                    .Select(g => new {
                        StateCode = g.Key,
                        StateName = g.First().StateName
                    })
                    .OrderBy(s => s.StateName)
                    .ToList();

                ViewBag.States = new SelectList(states, "StateCode", "StateName");

                return View();
            }
            catch (Exception ex)
            {
                // Log the exception (use a logging framework or custom logging)
                // Example: _logger.LogError(ex, "An error occurred while fetching data in nulm_sepbeneficiary.");

                // Optionally: Set an error message in the ViewBag
                ViewBag.ErrorMessage = "An error occurred while processing your request. Please try again later.";

                // Return an error view or fallback view
                return View("Error"); // Replace "Error" with the name of your error view if you have one.
            }
        }

        //    public IActionResult nulm_sepbeneficiary()
        //    {
        //        //
        //        ViewBag.chknulmsepbeneficiary = _dbContext.TblNulmApiSepbeneficiaries.ToList().Count().ToString();
        //        var states = _dbContext.TblMasterLgds
        //.GroupBy(s => s.StateCode)
        //.Select(g => new {
        //    StateCode = g.Key,
        //    StateName = g.First().StateName
        //})
        //.OrderBy(s => s.StateName)
        //.ToList();
        //        ViewBag.States = new SelectList(states, "StateCode", "StateName");
        //        return View();
        //    }
        //
        //sep smidshg
        public IActionResult nulm_smidshg()
        {
            try
            {
                // Fetch and count SMID SHG entries
                ViewBag.chknulmsmidshg = _dbContext.TblNulmApiSmidshgs.ToList().Count().ToString();

                // Grouping and fetching states
                var states = _dbContext.TblMasterLgds
                    .GroupBy(s => s.StateCode)
                    .Select(g => new {
                        StateCode = g.Key,
                        StateName = g.First().StateName
                    })
                    .OrderBy(s => s.StateName)
                    .ToList();

                ViewBag.States = new SelectList(states, "StateCode", "StateName");

                return View();
            }
            catch (Exception ex)
            {
                // Log the exception (use a logging framework like ILogger)
                // Example: _logger.LogError(ex, "An error occurred in nulm_smidshg.");

                // Pass a user-friendly error message to the view
                ViewBag.ErrorMessage = "An error occurred while processing your request. Please try again later.";

                // Return an error view or a fallback view
                return View("Error"); // Replace "Error" with the actual name of your error view, if any.
            }
        }

        //    public IActionResult nulm_smidshg()
        //    {
        //        //
        //        ViewBag.chknulmsmidshg = _dbContext.TblNulmApiSmidshgs.ToList().Count().ToString();
        //        var states = _dbContext.TblMasterLgds
        //.GroupBy(s => s.StateCode)
        //.Select(g => new {
        //    StateCode = g.Key,
        //    StateName = g.First().StateName
        //})
        //.OrderBy(s => s.StateName)
        //.ToList();
        //        ViewBag.States = new SelectList(states, "StateCode", "StateName");
        //        return View();
        //    }
        //sep smidalf
        public IActionResult nulm_smidalf()
        {
            //
            ViewBag.chknulmsmidalf = _dbContext.TblNulmApiSmidalves.ToList().Count().ToString();
            var states = _dbContext.TblMasterLgds
                            .GroupBy(s => s.StateCode)
                            .Select(g => new {
                             StateCode = g.Key,
                             StateName = g.First().StateName
                             })
                             .OrderBy(s => s.StateName)
                             .ToList();
            ViewBag.States = new SelectList(states, "StateCode", "StateName");
            return View();
        }
        //sep suh
        public IActionResult nulm_suh()
        {
            //
            ViewBag.chknulmsuh = _dbContext.TblNulmApiSuhs.ToList().Count().ToString();
            var states = _dbContext.TblMasterLgds
                            .GroupBy(s => s.StateCode)
                            .Select(g => new {
                                StateCode = g.Key,
                                StateName = g.First().StateName
                            })
                             .OrderBy(s => s.StateName)
                             .ToList();
            ViewBag.States = new SelectList(states, "StateCode", "StateName");
            return View();
        }
        //sep suh
        public IActionResult nulm_susvcov()
        {
            //
            ViewBag.chknulmsusvcov = _dbContext.TblNulmApiSusvcovs.ToList().Count().ToString();
            var states = _dbContext.TblMasterLgds
                            .GroupBy(s => s.StateCode)
                            .Select(g => new {
                                StateCode = g.Key,
                                StateName = g.First().StateName
                            })
                             .OrderBy(s => s.StateName)
                             .ToList();
            ViewBag.States = new SelectList(states, "StateCode", "StateName");
            return View();
        }

        //SCM
        public IActionResult scm()
        {
            //
            ViewBag.chkscm = _dbContext.TblScms.ToList().Count().ToString();
            var states = _dbContext.TblMasterLgds
                            .GroupBy(s => s.StateCode)
                            .Select(g => new {
                                StateCode = g.Key,
                                StateName = g.First().StateName
                            })
                             .OrderBy(s => s.StateName)
                             .ToList();
            ViewBag.States = new SelectList(states, "StateCode", "StateName");
            return View();
        }
        //SBM
        public IActionResult sbm()
        {
            //
            ViewBag.chksbm = _dbContext.TblApiSbms.ToList().Count().ToString();
            var states = _dbContext.TblMasterLgds
                            .GroupBy(s => s.StateCode)
                            .Select(g => new {
                                StateCode = g.Key,
                                StateName = g.First().StateName
                            })
                             .OrderBy(s => s.StateName)
                             .ToList();
            ViewBag.States = new SelectList(states, "StateCode", "StateName");
            return View();
        }
        //SBM_odf
        public IActionResult sbm_odf()
        {
            //
            ViewBag.chksbm_odf = _dbContext.TblApiSbmGfcs.ToList().Count().ToString();
            var states = _dbContext.TblMasterLgds
                            .GroupBy(s => s.StateCode)
                            .Select(g => new {
                                StateCode = g.Key,
                                StateName = g.First().StateName
                            })
                             .OrderBy(s => s.StateName)
                             .ToList();
            ViewBag.States = new SelectList(states, "StateCode", "StateName");
            return View();
        }
        //SBM_odf
        public IActionResult sbm_gfc()
        {
            //
            ViewBag.chksbm_gfc = _dbContext.TblApiSbmGfcs.ToList().Count().ToString();
            var states = _dbContext.TblMasterLgds
                            .GroupBy(s => s.StateCode)
                            .Select(g => new {
                                StateCode = g.Key,
                                StateName = g.First().StateName
                            })
                             .OrderBy(s => s.StateName)
                             .ToList();
            ViewBag.States = new SelectList(states, "StateCode", "StateName");
            return View();
        }

        public IActionResult Login()
        {

            return View();
        }
        //start login post
        // POST: Login
        [HttpPost]
        public IActionResult Login(string userName, string password)
        {
            // Static credentials for demonstration purposes
            const string staticUserName = "admin";
            const string staticPassword = "password123";

            if (userName == staticUserName && password == staticPassword)
            {
                // Redirect to a dashboard or another secure page after successful login
                TempData["AlertMessage"] = null; // Clear any previous alerts
                return RedirectToAction("dashboard", "Report");
            }
            else
            {
                // If credentials are invalid, return to the login page with an error message
                TempData["AlertMessage"] = "Invalid username or password.";
                return RedirectToAction("Index");
            }
        }
        //end login post
        public IActionResult dashboard()
        {
            return View();
        }
        //for tablleau dashboard
        public IActionResult dashboard_home()
        {
            return View();
        }
        //

        public IActionResult Reports()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        //get district
        public JsonResult GetDistricts(int StateCode)
        {
            // Fetch the districts based on StateCode from the database
            var districts = _dbContext.TblMasterLgds
                            .Where(d => d.StateCode == StateCode && d.DistrictName != "") // Add condition for non-null DistrictName
                            .GroupBy(d => new { d.DistrictCode, d.DistrictName })
                            .Select(g => new { g.Key.DistrictCode, g.Key.DistrictName }) // Explicitly select the grouped keys
                            .OrderBy(d => d.DistrictName) // Sort by DistrictName
                            .ToList();

            // Return the districts as JSON response
            return Json(districts);
        }
        //
        //get ulb
        //get district
        public JsonResult GetUlb(int StateCode, int DistrictCode)
        {
            var ulbs = _dbContext.TblMasterLgds
                .Where(d => d.StateCode == StateCode && d.DistrictCode == DistrictCode && d.UlbName !="") // Ensure UlbName is not null
                .Select(d => new { d.UlbCode, d.UlbName })
                .OrderBy(d => d.UlbName) // Sort by UlbName
                .ToList();

            return Json(ulbs);
        }
        //generate report 
        // Method to generate the report based on the selected parameters
        // Method to generate the report and return the report HTML
        [HttpPost]
        public ActionResult GenerateReport(int stateCode, int districtCode, int ulbCode)
        {
            // Fetch report data based on selected parameters
            // var reportData = _dbContext.Pmays.Where(r => r.StateCode == stateCode && r.DistrictCode == districtCode && r.UlbCode == ulbCode).ToList();

            var reportData = _dbContext.TblPmays.Where(r => r.Statecode == stateCode && r.Districtlgcode == districtCode && r.Lgdcode==ulbCode).ToList();

            // Return the report as a partial view
            return PartialView("_rptpmay", reportData);
        }
        //
        [HttpPost]
        public ActionResult GenerateReportpmsvanidhi(int stateCode, int districtCode, int ulbCode)
        {
            // Fetch report data based on selected parameters
           // var reportData = _dbContext.Pmays.Where(r => r.StateCode == stateCode && r.DistrictCode == districtCode && r.UlbCode == ulbCode).ToList();

            var reportData = _dbContext.TblPmsvanidhis.Where(r => r.Statecode == stateCode && r.Localbodycode==ulbCode).ToList();

            // Return the report as a partial view
            return PartialView("_rptpmsvanidhi", reportData);
        }
        //
        //get amrut detail
        [HttpPost]
        public ActionResult GenerateReportamrutdetail(int stateCode, int districtCode, int ulbCode)
        {
            // Fetch report data based on selected parameters
             var reportData = _dbContext.TblAmrutprojectdetails.Where(r => r.StateCode == stateCode && r.DistrictCode == districtCode && r.UlbCode == ulbCode).ToList();

            //var reportData = _dbContext.TblAmrutprojectdetails.ToList();

            // Return the report as a partial view
            return PartialView("_rptamrutdetail", reportData);
        }

        //
        //get amrut summery
        [HttpPost]
        public ActionResult GenerateReportamrutsummery()
        {
            // Fetch report data based on selected parameters
            // var reportData = _dbContext.Pmays.Where(r => r.StateCode == stateCode && r.DistrictCode == districtCode && r.UlbCode == ulbCode).ToList();

            var reportData = _dbContext.TblAmrutsummaries.ToList();

            // Return the report as a partial view
            return PartialView("_rptamrutsummery", reportData);
        }
        //
        //get nulm sep group
        [HttpPost]
        public ActionResult GenerateReportnulmsepgroup(int stateCode, int districtCode, int ulbCode)
        {
            try
            {
                // Fetch report data based on selected parameters
                var reportData = _dbContext.TblNulmApiSepgroups
                    .Where(r => r.StateCode == stateCode && r.DistrictCode == districtCode && r.UlbCode == ulbCode)
                    .ToList();

                // Return the report as a partial view
                return PartialView("_rptnulm_sepgroup", reportData);
            }
            catch (Exception ex)
            {
                // Log the exception using a logging framework
                // Example: _logger.LogError(ex, "Error generating NULM SEP group report.");

                // Provide an error message or handle the error gracefully
                ViewBag.ErrorMessage = "An error occurred while generating the report. Please try again later.";

                // Optionally return an empty partial view or an error-specific partial view
                return PartialView("_ErrorPartial"); // Replace with a specific error partial view if available
            }
        }

        //[HttpPost]
        //public ActionResult GenerateReportnulmsepgroup(int stateCode, int districtCode, int ulbCode)
        //{
        //    // Fetch report data based on selected parameters
        //     var reportData = _dbContext.TblNulmApiSepgroups.Where(r => r.StateCode == stateCode && r.DistrictCode == districtCode && r.UlbCode == ulbCode).ToList();

        //    // var reportData = _dbContext.TblNulmApiSepgroups.ToList(); 

        //    // Return the report as a partial view
        //    return PartialView("_rptnulm_sepgroup", reportData);
        //}
        // get nulm sepbeneficary
        [HttpPost]
        public ActionResult GenerateReportnulmsepbeneficiary(int stateCode, int districtCode, int ulbCode)
        {
            // Fetch report data based on selected parameters
            var reportData = _dbContext.TblNulmApiSepbeneficiaries.Where(r => r.StateCode == stateCode && r.DistrictCode == districtCode && r.UlbCode == ulbCode).ToList();

            // var reportData = _dbContext.TblNulmApiSepgroups.ToList(); 

            // Return the report as a partial view
            return PartialView("_rptnulm_sepbeneficiary", reportData);
        }
        //
        // get nulm smidshg
        [HttpPost]
        public ActionResult GenerateReportnulmsmidshg(int stateCode, int districtCode, int ulbCode)
        {
            // Fetch report data based on selected parameters
            var reportData = _dbContext.TblNulmApiSmidshgs.Where(r => r.StateCode == stateCode && r.DistrictCode == districtCode && r.UlbCode == ulbCode).ToList();

            // var reportData = _dbContext.TblNulmApiSepgroups.ToList(); 

            // Return the report as a partial view
            return PartialView("_rptnulm_smidshg", reportData);
        }
        // get nulm smidshg
        [HttpPost]
        public ActionResult GenerateReportnulmsimdalf(int stateCode, int districtCode, int ulbCode)
        {
            // Fetch report data based on selected parameters
            var reportData = _dbContext.TblNulmApiSmidalves.Where(r => r.StateCode == stateCode && r.DistrictCode == districtCode && r.UlbCode == ulbCode).ToList();

            // var reportData = _dbContext.TblNulmApiSepgroups.ToList(); 

            // Return the report as a partial view
            return PartialView("_rptnulm_smidalf", reportData);
        }
        // get nulm suh
        [HttpPost]
        public ActionResult GenerateReportnulmsuh(int stateCode, int districtCode, int ulbCode)
        {
            // Fetch report data based on selected parameters
            var reportData = _dbContext.TblNulmApiSuhs.Where(r => r.StateCode == stateCode && r.DistrictCode == districtCode && r.UlbCode == ulbCode).ToList();

            // var reportData = _dbContext.TblNulmApiSepgroups.ToList(); 

            // Return the report as a partial view
            return PartialView("_rptnulm_suh", reportData);
        }
        // get nulm susvcov
        [HttpPost]
        public ActionResult GenerateReportnulmsusvcov(String stateCode, string districtCode, string ulbCode)
        {
            // Fetch report data based on selected parameters
            var reportData = _dbContext.TblNulmApiSusvcovs.Where(r => r.StateCode == stateCode && r.DistrictCode == districtCode && r.UlbCode == ulbCode).ToList();

            // var reportData = _dbContext.TblNulmApiSepgroups.ToList(); 

            // Return the report as a partial view
            return PartialView("_rptnulm_susvcov", reportData);
        }
        // get SBM
        [HttpPost]
        public ActionResult GenerateReportsbm(int stateCode, int districtCode, int ulbCode,int Year)
        {
            var reportData = _dbContext.TblApiSbms.Where(r => r.Statecode == stateCode && r.Year == Year).ToList();
            return PartialView("_rptsbm", reportData);
            //var mergedData = _dbContext.TblSbmBacklogs
            //    .Where(b => b.Year >= 2021 && b.Year <= 2023) // 2021-2023 data from tbl_sbm_backlog
            //    .Select(b => new
            //    {
            //        b.Statename,
            //        b.Year,
            //        b.Processedmtd // Replace 'SomeField' with actual fields in tbl_sbm_backlog
            //    })
            //    .Union(
            //        _dbContext.TblApiSbms
            //        .Where(a => a.Year == 2024) // 2024 data from tbl_api_sbm
            //        .Select(a => new
            //        {
            //            a.Statecode,
            //            a.Year,
            //            a.SomeField // Replace 'SomeField' with actual fields in tbl_api_sbm
            //        })
            //    )
            //    .OrderBy(r => r.Year) // Optional: Sort by Year
            //    .ToList();



        }
        // get SBM
        [HttpPost]
        public ActionResult GenerateReportsbm_odf(int stateCode, int districtCode, int ulbCode)
        {
            // Fetch report data based on selected parameters
            //var reportData = _dbContext.TblApiSbms.Where(r => r.Statecode == stateCode && r.Districtcode == districtCode && r.UlbCode == ulbCode).ToList();
           // var reportData = _dbContext.TblApiSbmOdfs.Where(r => r.Statecode == stateCode).ToList();
            var reportData = _dbContext.TblApiSbmOdfs.Where(r => r.Stateid == stateCode).ToList();

            // var reportData = _dbContext.TblNulmApiSepgroups.ToList(); 

            // Return the report as a partial view
            return PartialView("_rptsbm_odf", reportData);
        }
        // get SBM
        [HttpPost]
        public ActionResult GenerateReportsbm_gfc(int stateCode, int districtCode, int ulbCode)
        {
            // Fetch report data based on selected parameters
            //var reportData = _dbContext.TblApiSbms.Where(r => r.Statecode == stateCode && r.Districtcode == districtCode && r.UlbCode == ulbCode).ToList();
            // var reportData = _dbContext.TblApiSbmOdfs.Where(r => r.Statecode == stateCode).ToList();
            var reportData = _dbContext.TblApiSbmGfcs.ToList();

            // var reportData = _dbContext.TblNulmApiSepgroups.ToList(); 

            // Return the report as a partial view
            return PartialView("_rptsbm_gfc", reportData);
        }
        // get SCM
        [HttpPost]
        public ActionResult GenerateReportscm(String stateCode, int districtCode, int ulbCode)
        {
            // Fetch report data based on selected parameters
            // var reportData = _dbContext.TblScms.Where(r => r.Statecode == stateCode && r.Districtcode == districtCode && r.UlbCode == ulbCode).ToList();
            // var reportData = _dbContext.TblApiSbmOdfs.Where(r => r.Statecode == stateCode).ToList();
            //var reportData = _dbContext.TblScms.Where(r => r.StateName == stateCode).ToList();
            Thread.Sleep(5000); // Simulate delay
            var reportData = _dbContext.TblScms.ToList(); 

            // Return the report as a partial view
            return PartialView("_rptscm", reportData);
        }

    }
}
