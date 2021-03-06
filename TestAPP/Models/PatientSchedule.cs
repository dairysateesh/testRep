//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TestAPP.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class PatientSchedule
    {
        public int Id { get; set; }
        [Required(ErrorMessage ="Please enter first name")]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "Please enter last name")]
        public string LastName { get; set; }
        public Nullable<System.DateTime> DOB { get; set; }
        public string PhoneNumber { get; set; }
        public string IsInsured { get; set; }
        public string InsuranceCarrier_ { get; set; }
        public string InsuranceID { get; set; }
        public System.DateTime CreatedDate { get; set; }
    }
}
