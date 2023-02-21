using CustomerWeb_App.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace CustomerWeb_App.Controllers
{
    public class CustomersController : Controller
    {
        public ActionResult SubmitNewCustomer()
        {
            var model = new SubmitCustomerViewModel();

            return View(model);
        }
    }
}
