using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace JSON_Payment_Portal.Models
{
    // New Energy System that the customer will choose
    public class EnergySystem
    {
        int id { get; set; }
        string name { get; set; }
        int EnergyOutput { get; set; }
        int cost { get; set; }
    }
}