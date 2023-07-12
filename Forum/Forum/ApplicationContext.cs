using Forum.Models;
using Microsoft.EntityFrameworkCore;

namespace Forum
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext(DbContextOptions<ApplicationContext> options)
            : base(options)
        {
            Database.EnsureCreated();   // создаем базу данных при первом обращении
        }

        public DbSet<Users> Users { get; set; }
        public DbSet<RegistrationBinding> RegistrationBinding { get; set; }
        public DbSet<Roles> Roles { get; set; }
        public DbSet<UsersChanges> UsersChanges { get; set; }
        public DbSet<UsersLogin> UsersLogin { get; set; }
    }
}
