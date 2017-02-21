using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace JSON_Payment_Portal.Models
{
    //customer model 
    public class Applicant
    {

        [Required]
        public int Id { get; set; }

        [Required]
        [StringLength(40, MinimumLength = 1)]
        public string Name { get; set; }

        [Required]
        [StringLength(40, MinimumLength = 1)]
        public string Address1 { get; set; }

        [Required]
        [StringLength(40, MinimumLength = 1)]
        public string Address2 { get; set; }

        [Required]
        [StringLength(40, MinimumLength = 1)]
        public string City { get; set; }

        [Required]
        [StringLength(30, MinimumLength = 1)]
        public string state { get; set; }

        public int Zip { get; set; }

        public string Country { get; set; }

        [Required]
        [StringLength(40, MinimumLength = 1)]
        public string Email { get; set; }


    }

}