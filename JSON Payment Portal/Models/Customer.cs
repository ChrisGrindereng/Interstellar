using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace JSON_Payment_Portal.Models
{
    //customer model 
    public class Customer
    {
        //required porperties
        int id { get; set; }
        String FullName { get; set; }
        Address address { get; set; }


        EnergySystem system { get; set; }
        

        //properties for potential future use
        
        //int SocialSecurityNum { get; set; }
        //int DriversLicenceNum { get; set; }
        //int downPayment { get; set; }
        //int desiredSavings { get; set; }


    }
}