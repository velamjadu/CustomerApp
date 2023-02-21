using CustomerWeb_App.Data;
using CustomerWeb_App.Data.DataModels;
using CustomerWeb_App.Repository.Contracts;
using CustomerWeb_App.ViewModels;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore.SqlServer;
using System.Data;
using System.Dynamic;
using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace CustomerWeb_App.Repository.Repositories
{
    public class CustomersRepository : ICustomerRepository

    {
        private DataContext _dbContext = null;

        public CustomersRepository()
        {
            _dbContext = new DataContext();
        }
        public int AddNewCustomer(Customer model)
        {
            var parameters = new SqlParameter[]
            {
                new SqlParameter("@Name", model.Name),
                new SqlParameter("@Surname", model.Surname),
                new SqlParameter("@Cell_Number", model.Cell_Number),
                new SqlParameter("@Physical_Address", model.Physical_Address),
                new SqlParameter("@Postal_Address", model.Postal_Address),
                new SqlParameter("@Comment", model.Comment)
            };

            var query = "EXEC [Customer_tbl] @Name,@Surname,@Cell_Number,@Physical_Address,@Postal_Address,@Comment";
            return _dbContext.Database.ExecuteSqlRawAsync(query, parameters).GetAwaiter().GetResult();
        }
        
        public List<Customer> GetAllCustomers()
        {
            var query = "EXEC [GetAllCustomers]";
            return _dbContext.Set<Customer>().FromSqlRaw(query).ToList();
        }
        
        public void Dispose()
        {
            _dbContext.Dispose();
            _dbContext = null;
        }
    }
}
