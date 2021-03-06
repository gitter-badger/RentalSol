﻿// Copyright 2015 Terence van Schalkwyk
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//    http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
//   limitations under the License.
//
using System.Collections.Generic;

namespace RentalSol.Data.Entities
{
    class Company
    {
        public int Id { get; set; }
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
