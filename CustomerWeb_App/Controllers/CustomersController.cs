using CustomerWeb_App.Business;
using CustomerWeb_App.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace CustomerWeb_App.Controllers
{
    public class CustomersController : Controller
    {
        public ActionResult CustomerDetails()
        {
            var model = new SubmitCustomerViewModel();

            return View(model);
        }

        public ActionResult CustomerComment()
        {
            var model = new SubmitCustomerViewModel();

            return View(model);
        }

        public ActionResult CustomerAddress()
        {
            var model = new SubmitCustomerViewModel();

            return View(model);
        }

        public ActionResult CustomersHomePage() 
        {
            var model = new CustomerBusiness().GetAllCustomers();
            return View(model);
        }
    }
}
