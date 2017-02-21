using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace JSON_Payment_Portal.Models
{
    public class Project
    {
        [Required]
        public int Id { get; set; }

        public int projectNum { get; set; }

        public int revisionNum { get; set; }

        [Required]
        public LoanLeaseOption LoanOption { get; set; }

        [Required]
        public int FinancialOption { get; set; }

        [Required]
        public int installerXREF { get; set; }

        [Required]
        public Applicant applicant { get; set; }

        [Required]
        public Applicant coapplicant { get; set; }

        [Required]
        public int applicantSSN { get; set; }

        [Required]
        public int applicantDriversLicenceNum { get; set; }

        [Required]
        public string StateOnApplicantLicence { get; set; }

        [Required]
        public double houseHoldIncome { get; set; }

        public ApprovalStatus ReturnApproval { get; set; }
    }
}