using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace JSON_Payment_Portal.Models
{

    //Loan Lease Option Model
    
    public class LoanLeaseOption 

    {
        [Required]
        public int Id { get; set; }
        [Required]
        public double percentDown { get; set; }
        [Required]

        public double MonthlyPayment { get; set; }

        public int LoanTerm { get; set; }

        public int ProjectListId { get; set; }
    }
}