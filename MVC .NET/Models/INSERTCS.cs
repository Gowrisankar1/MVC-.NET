using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVC.NET.Models
{
    public class INSERTCS
    {
        [Required(ErrorMessage ="Enter the name")]
        public string name { set; get; }
        [Range(20,60, ErrorMessage = "Enter the age between 20 to 60")]
        public int age { set; get; }
        [Required(ErrorMessage = "Enter the address")]
        public string address { set; get; }
        public string msg { set; get; }
    }
}