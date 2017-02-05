using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVClab3.Models.Northwind
{

    [MetadataType(typeof(CustomerMetaData))]
    public partial class Customer { }

    public class CustomerMetaData
    {

        [Required]
        [Display(Name = "Cust ID")]
        [StringLength(5, ErrorMessage = "The {0} must be a unique id between {2} and {1} characters.", MinimumLength = 1)]
        public string CustomerID { get; set; }
        [Required]
        [Display(Name = "Company Name")]
        public string CompanyName { get; set; }
        [Required]
        [Display(Name = "Contact Name")]

        public string ContactName { get; set; }
        [Required]
        [Display(Name = "Title")]
        public string ContactTitle { get; set; }
        [Required]
        [Display(Name = "City")]
        public string City { get; set; }

    }
}