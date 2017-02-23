using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace JSON_Payment_Portal.Models
{
    public class DB : DbContext
    {
        public DB() : base(){}

        public DbSet<User> Users { get; set; }
        public DbSet<Applicant> Applicants { get; set; }
        public DbSet<ApprovalStatus> Approvals { get; set; }
        public DbSet<LoanLeaseOption> LoanLeaseOptions { get; set; }
        public DbSet<Project> Projects { get; set; }

    }
}