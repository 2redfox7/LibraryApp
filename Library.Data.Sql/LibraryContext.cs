using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Library.Data.Sql
{
    internal class LibraryContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=Library.db");
        }

        public DbSet<BookEntity> Books => Set<BookEntity>();
        public DbSet<CheckEntity> Checks => Set<CheckEntity>();
        public DbSet<UserEntity> Users => Set<UserEntity>();
        public LibraryContext() => Database.EnsureCreated();

    }
}
