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
using RentalSol.Data.Entities;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace RentalSol.Data
{
    class RentalSolContext : DbContext
    {
        public RentalSolContext()
            : base("RentalSolContext")
        {
            Configuration.ProxyCreationEnabled = false;
            Configuration.LazyLoadingEnabled = false;
        }

        //Database Tables
        public DbSet<Company> Company { get; set; }
        public DbSet<Contact> Contact { get; set; }
        public DbSet<Property> Property { get; set; }
        public DbSet<Lease> Lease { get; set; }
        public DbSet<ServiceProvider> ServiceProvider { get; set; }
        public DbSet<Account> Account { get; set; }

        //OnModelCreating
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
        }

    }
}
