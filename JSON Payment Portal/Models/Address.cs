using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace JSON_Payment_Portal.Models
{
    public class Address
    {
        int id { get; set; }
        string streetAddress1 { get; set; }
        string streetAddress2 { get; set; }
        string SuitNum { get; set; }
        int CityId { get; set; }
        int StateId { get; set; }
        int ZipCode { get; set; }

    }
}