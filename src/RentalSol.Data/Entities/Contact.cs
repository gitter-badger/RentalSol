using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentalSol.Data.Entities
{
    class Contact
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid ContactId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }
        public string BusinessPhone { get; set; }
        public string HomePhone { get; set; }
        public string FaxPhone { get; set; }
        public string MobilePhone { get; set; }
        public string StreetAddressLine1 { get; set; }
        public string StreetAddressLine2 { get; set; }
        public string StreetCityTown { get; set; }
        public string StreetProvinceState { get; set; }
        public string StreetCode { get; set; }
        public string StreetCountry { get; set; }
        public string PostalAddressLine1 { get; set; }
        public string PostalAddressLine2 { get; set; }
        public string PostalCityTown { get; set; }
        public string PostalProvinceState { get; set; }
        public string PostalCode { get; set; }
        public string PostalCountry { get; set; }
        public string Notes { get; set; }
        public Guid? CompanyId { get; set; }
        public virtual Company Company { get; set; }
    }
}
