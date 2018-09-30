using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace UmbracoBlogSite.Models
{
    public class Contact
    {
        //[Required]
        //[Display(Name = "First Name:")]
        //public string FirstName { get; set; }

        [Required]
        [Display(Name = "Name:")]
        public string Name { get; set; }

        [Required]
        [EmailAddress]
        [Display(Name = "Email Address:")]
        public string EmailAddress { get; set; }

        [Required]
        //[DataType(DataType.MultilineText)]
        [Display(Name = "Message:")]
        public string Message { get; set; }
    }
}