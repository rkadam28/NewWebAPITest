using NewWebAPITest.Model;
using System.Data.Entity;

namespace NewWebAPITest.DAL
{
    public class UserContext : DbContext
    {
        public UserContext() : base("UserDataBase")
        {

        }

        public DbSet<User> User { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
