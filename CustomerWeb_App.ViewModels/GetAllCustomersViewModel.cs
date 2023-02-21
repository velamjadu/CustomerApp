using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerWeb_App.ViewModels
{
    public class GetAllCustomersViewModel
    {
        public string Name { get; set; }

        public string Surname { get; set; }

        public string Cell_Number { get; set; }

        public string Physical_Address { get; set; }

        public string Postal_Address { get; set; }

        public string Comment { get; set; }
    }
}
