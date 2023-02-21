using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace CustomerWeb_App.Data.DataModels
{
    [Table("Customer_tbl")]
    public class Customer
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Cell_Number { get; set; }
        public string Physical_Address { get; set; }
        public string Postal_Address { get; set; }
        public string Comment { get; set; }

    }
}
