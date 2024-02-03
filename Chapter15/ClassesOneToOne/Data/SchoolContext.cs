using Microsoft.EntityFrameworkCore;

using ClassesManyToMany.Models;

namespace ClassesManyToMany.Data
{
    internal class SchoolContext : DbContext
    {
        public DbSet<Student> Students { get; set; } = null!;
        public DbSet<Subject> Subjects { get; set; } = null!;
        public DbSet<StudentSubject> StudentSubject { get; set; } = null!;
        public DbSet<StudentData> StudentData { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (optionsBuilder.IsConfigured)
                return;

            optionsBuilder.UseSqlServer("Data Source=.;Initial Catalog=efcoresamples;Trusted_Connection=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Student>()
                .HasOne(sd => sd.StudentData)
                .WithOne(s => s.Student)
                .HasForeignKey<StudentData>(s => s.Id);
        }
    }
}
