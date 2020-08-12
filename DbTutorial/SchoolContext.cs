using System.Collections.Generic;
using System.Data.Entity;

namespace DbTutorial
{
    public class SchoolContext : DbContext
    {
        public SchoolContext()
        {

        }

        // Entities        
        public DbSet<Student> Students { get; set; }
        //public DbSet<StudentAddress> StudentAddresses { get; set; }
        public DbSet<Grade> Grades { get; set; }
    }
}
