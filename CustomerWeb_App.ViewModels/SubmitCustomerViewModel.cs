using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerWeb_App.ViewModels
{
    public class SubmitCustomerViewModel
    {
        [Required(ErrorMessage = "Please enter Customer's Name")]
        [DisplayName("Name")]
        public string? Name { get; set; }
        [Required(ErrorMessage = "Please enter Customer's Surname")]
        [DisplayName("Surname")]
        public string? Surname  { get; set; }
        [Required(ErrorMessage = "Please enter Valid Number")]
        [DisplayName("Cell Number")]
        public string? Cell_Number { get; set; }

        [Required(ErrorMessage = "Please enter Customer's Physical Address")]
        [DisplayName("Physical Address")]
        public string? Physical_Address { get; set; }

        [Required(ErrorMessage = "Please enter Customer's Postal Address")]
        [DisplayName("Postal Address")]
        public string? Postal_Address { get; set; }

        [Required(ErrorMessage = "Please enter Comment")]
        [DisplayName("Comment")]
        public string? Comment { get; set; }
    }
}
