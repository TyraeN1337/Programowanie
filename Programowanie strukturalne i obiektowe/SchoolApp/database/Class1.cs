using System;
using Microsoft.EntityFrameworkCore;
using SchoolApp.database.Entities;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolApp.database
{
    class SchoolDatabase : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("");
            base.OnConfiguring(optionsBuilder);
        }
       public DbSet<SchoolClass> SchoolClasses{ get; set; }


    }
}
