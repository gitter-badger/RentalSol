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

using System.Collections.Generic;

namespace RentalSol.Data.Entities
{
    class ServiceProvider
    {
        public int Id { get; set; }
        public int Name { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string Website { get; set; }

        public int TypeId { get; set; }
        public virtual ListOfValue Type { get; set; }

        public ICollection<Contact> ServiceProviderContact { get; set; }

    }
}
