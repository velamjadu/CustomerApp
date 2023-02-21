using CustomerWeb_App.Data.DataModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerWeb_App.Repository.Contracts
{
    public interface ICustomerRepository : IDisposable
    {
        int AddNewCustomer(Customer model);
        List<Customer> GetAllCustomers();
    }
}
