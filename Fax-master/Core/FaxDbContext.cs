using Core.Subjects;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core
{
    public class FaxDbContext : IdentityDbContext<User>
    {
        public FaxDbContext(DbContextOptions<FaxDbContext> options) : base(options)
        {

        }

        public DbSet<Subject> Subjects { get; set; }
        public DbSet<PartOfSubject> PartOfSubjects { get; set; }
        public DbSet<Exam> Exams { get; set; }




        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                    "Server=localhost\\SQLEXPRESS; Database=Faksistent; Trusted_Connection=True;");
        }
    }
}
