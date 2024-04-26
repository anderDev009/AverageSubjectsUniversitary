

using AvgUniversitary.Core.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Universitary.Infrastructure.Persistence.Context
{
    public class UniversitaryAvgContext : DbContext
    {
        public UniversitaryAvgContext(DbContextOptions<UniversitaryAvgContext> options): base(options) { }

        public DbSet<Subject> Subject {  get; set; }
        public DbSet<University> University { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //funcionalidad base
            base.OnModelCreating(modelBuilder);
            #region renombrando las tablas 
            modelBuilder.Entity<Subject>().ToTable("Subject");
            modelBuilder.Entity<University>().ToTable("University");
            #endregion
            #region configurando Keys 

            modelBuilder.Entity<Subject>().HasKey(x => x.Id);
            modelBuilder.Entity<University>().HasKey(x => x.Id);
            #endregion
            #region Properties
            #region Subject
            modelBuilder.Entity<Subject>().Property(x => x.Credits).IsRequired();
            modelBuilder.Entity<Subject>().Property(x => x.Code)
                .HasMaxLength(40)
                .IsRequired();

            modelBuilder.Entity<Subject>().Property(x => x.IdUniversity).IsRequired();
            modelBuilder.Entity<Subject>().Property(x => x.Name).IsRequired();

            #endregion
            #region University 
            modelBuilder.Entity<University>().Property(x => x.Name)
                .HasMaxLength(50)
                .IsRequired();
            modelBuilder.Entity<University>().Property(x => x.PriceCredits).IsRequired();

            #endregion
            #endregion
            #region Foreign Keys
            #region Subject - Materia
            modelBuilder.Entity<Subject>().HasOne(x => x.University)
                .WithMany(x => x.Subjects)
                .HasForeignKey(x => x.IdUniversity)
                .HasConstraintName("SubjectUniversityFK");

            #endregion
            #endregion

        }
    }
}
