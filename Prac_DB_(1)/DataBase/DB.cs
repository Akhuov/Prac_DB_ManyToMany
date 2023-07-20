using Microsoft.EntityFrameworkCore;
using Prac_DB__1_.Models;

namespace Prac_DB__1_.DataBase
{
    public class DB : DbContext
    {
        private readonly string connectionString = "Server=localhost;Port=5432;User Id=postgres;Password=password;Database=HM18DB";

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql(connectionString);
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            AddData(modelBuilder);
            base.OnModelCreating(modelBuilder);
        }



        public DbSet<Book> Books { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Staff> Staffs { get; set; }


        public void AddData(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Staff>().HasData(
                new Staff()
                {
                    Id = 1,
                    Name = "HR b`limi"
                },
                new Staff()
                {
                    Id = 2,
                    Name = "Moliya bo`limi"
                },
                new Staff()
                {
                    Id = 3,
                    Name = "O`quv bo`limi"
                }
            );

            modelBuilder.Entity<User>().HasData(
                new User()
                {
                    Id = 1,
                    Name = "Rustam",
                    StaffId = 1
                },
                new User()
                {
                    Id = 2,
                    Name = "Dilmurod",
                    StaffId = 2
                },
                new User()
                {
                    Id = 3,
                    Name = "Sanjar",
                    StaffId = 2
                }
            );

            modelBuilder.Entity<Book>().HasData(
                new Book()
                {
                    Id = 1,
                    Name = "O`tkan kunlar",

                },
                new Book()
                {
                    Id = 2,
                    Name = "Ikki eshik orasi",

                },
                new Book()
                {
                    Id = 3,
                    Name = "Chinor",
                }
            );

        }

    }
}
