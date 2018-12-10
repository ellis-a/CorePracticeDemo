using CorePracticeDemo.Entities;
using System.Data.Entity;

namespace CorePracticeDemo.Data
{
    public class DemoDataContext : DbContext
    {
        public DbSet<UserEntity> User { get; set; }

        public DemoDataContext() : this("connectionString")
        {

        }

        public DemoDataContext(string connectionString) : base (connectionString)
        {

        }
    }
}
