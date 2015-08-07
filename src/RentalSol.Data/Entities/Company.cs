using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentalSol.Data.Entities
{
    class Company
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string EmailAddress { get; set; }
        public string BusinessPhone { get; set; }
        public string FaxPhone { get; set; }
        public string AlernativePhone { get; set; }
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
        public ICollection<Contact> CompanyContact { get; set; }
    }
}
