using G4.NetITIEFCoreDay02.Model;
using Microsoft.EntityFrameworkCore;

namespace G4.NetITIEFCoreDay02.Context
{
    public class SchoolContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.;Database=G4.NetITIEFCoreDay02;Trusted_Connection=True;Encrypt=false");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

        //public override int SaveChanges()
        //{
        //    return base.SaveChanges();
        //}

        // Tables
        public virtual DbSet<Student> Students { get; set; }
        public virtual DbSet<Department> Departments { get; set; }
        public virtual DbSet<Course> Courses { get; set; }
        public virtual DbSet<Instructor> Instructors { get; set; }
        public virtual DbSet<Car> Cars { get; set; }
    }
}
