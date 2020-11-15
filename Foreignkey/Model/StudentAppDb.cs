using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Foreignkey.Model
{
    public class StudentAppDb : DbContext
    {

        public DbSet<Student> Students { get; set; }
        public DbSet<MarkList> MarkLists { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=localhost\SQLEXPRESS;Database=SchoolDB10;Trusted_Connection=True;");
        }




    }
}
