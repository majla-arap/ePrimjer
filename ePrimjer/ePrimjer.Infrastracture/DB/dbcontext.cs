using ePrimjer.Core;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ePrimjer.Infrastracture
{
    public partial class DatabaseContext
    {
     public void Seed(ModelBuilder std)
        {

           std.Entity<Student>().HasData(new Student
            {
                Id = 1,
                FirstName = "admin",
                LastName = "admin",
                indexNumber = "IB190010",
                BirthDate = DateTime.UtcNow,
                IsDeleted = false
            }) ;
        }
    }
}
