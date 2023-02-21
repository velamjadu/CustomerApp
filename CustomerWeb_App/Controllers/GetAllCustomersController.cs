using CustomerWeb_App.Business;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CustomerWeb_App.Controllers
{
    public class GetAllCustomersController : Controller
    {
        public ActionResult GetAllCustomers()
        {
            var business = new CustomerBusiness();
            var customer = business.GetAllCustomers();
            return View(customer);
        }
    }
}
