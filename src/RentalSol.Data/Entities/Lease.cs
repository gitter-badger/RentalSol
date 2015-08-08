// Copyright 2015 Terence van Schalkwyk
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
using System;

namespace RentalSol.Data.Entities
{
    class Lease
    {
        public int Id { get; set; }
        public string LeaseName { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public decimal Deposit { get; set; }
        public decimal LeaseFee { get; set; }
        public decimal Rate { get; set; }
        public string Frequency { get; set; }
        public string Note { get; set; }

        public int LessorId { get; set; }
        public virtual Contact Lessor { get; set; }

        public int LesseeId { get; set; }
        public virtual Contact Lessee { get; set; }

        public int PropertyId { get; set; }
        public virtual Property Property { get; set; }
    }
}
