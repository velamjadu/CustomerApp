using AutoMapper;
using AutoMapper.Internal.Mappers;
using CustomerWeb_App.ViewModels;
using CustomerWeb_App.Repository;
using System;
using CustomerWeb_App.Repository.Contracts;
using CustomerWeb_App.Repository.Repositories;
using static CustomerWeb_App.Business.MappingBusiness;
using CustomerWeb_App.Data.DataModels;

namespace CustomerWeb_App.Business
{
    public class CustomerBusiness
    {
        public SubmitCustomerViewModel SubmitNewCustomer(SubmitCustomerViewModel model)
        {
            using var repo = new CustomersRepository();
            var dbModel = ObjectMapper.Mapper.Map<Customer>(model);
            var result = repo.AddNewCustomer(dbModel);
            return ObjectMapper.Mapper.Map<SubmitCustomerViewModel>(result);
        }
        
        public List<GetAllCustomersViewModel> GetAllCustomers()
        {
            using var repo = new CustomersRepository();
            var result = repo.GetAllCustomers();
            return ObjectMapper.Mapper.Map<List<GetAllCustomersViewModel>>(result);
        }

    }
}