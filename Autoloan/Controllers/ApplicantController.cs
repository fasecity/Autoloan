using Autoloan.Models;
using Autoloan.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Autoloan.Controllers
{
    public class ApplicantController : Controller
    {
        private ApplicationDbContext _context;
        public ApplicantController()
        {
            _context = new ApplicationDbContext();
        }
        // GET: Applicant
        public ActionResult Create()
        {
            var viewModels = new ApplicantFormViewModel
            {

                //car insurances comes from view model
                CarInsurances = _context.CarInsurancs.ToList()

            };

            return View(viewModels);

        }
        [HttpPost]
        public ActionResult Create(ApplicantFormViewModel viewModel)
        {
            
            if (!ModelState.IsValid)
            {
                return RedirectToAction("Index", "Home");
            }
           
            try
            {

              var  carInsu = _context.CarInsurancs.Single(m => m.Id == viewModel.CarInsurance);
                var applicant = new Applicant
                {

                FirstName = viewModel.FirstName,
                    LastName = viewModel.LastName,
                    Age = viewModel.Age,
                    PhoneNumber = viewModel.PhoneNumber,
                    CarInsurance = carInsu,
                    Carkilometer = viewModel.Carkilometer,
                    DesiredLoanAmmount = viewModel.DesiredLoanAmmount,
                    DateTime = DateTime.Now,
                    MonthlyIncome = viewModel.MonthlyIncome,
                    CarMake = viewModel.CarMake,
                    CarModel = viewModel.CarModel,
                    CarYear = viewModel.CarYear,
                    Email = viewModel.Email,
                    Province = viewModel.Province

                };
                _context.Applicants.Add(applicant);
                _context.SaveChanges();

            }
            catch (Exception)
            {

                throw;
            }

            return View();
        }
    }
}