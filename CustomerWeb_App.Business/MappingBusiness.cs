using AutoMapper;
using CustomerWeb_App.Data.DataModels;
using CustomerWeb_App.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerWeb_App.Business
{
    public class MappingBusiness
    {
        public static class ObjectMapper
        {
            private static readonly Lazy<IMapper> Lazy = new Lazy<IMapper>(() =>
            {
                var config = new MapperConfiguration(cfg =>
                {
                    cfg.CreateMap<SubmitCustomerViewModel, Customer>().ReverseMap();
                    cfg.CreateMap<GetAllCustomersViewModel, Customer>().ReverseMap();
                });
                
                var mapper = config.CreateMapper();
                return mapper;
            });

            public static IMapper Mapper => Lazy.Value;
        }
    }
}
 
