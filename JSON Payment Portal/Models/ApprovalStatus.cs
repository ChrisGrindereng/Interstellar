using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace JSON_Payment_Portal.Models
{
    public class ApprovalStatus
    {
        public int Id { get; set; }

        public int AuthorizationNum { get; set; }

        public int ReturnCode { get; set; }

        public string Message { get; set; }

        public int ProjectId { get; set; }
    }
}