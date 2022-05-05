using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Databaseconnectivity2.model
{
    public class ApplicationDbContext :DbContext
    {
      public ApplicationDbContext():base ("Data Source = CHETUIWK258\\SQLEXPRESS; " +
            "Initial Catalog = employee_data; Integrated Security = True")
        { }
        public DbSet<Employee> Employee
        { get; set; }

    }

}