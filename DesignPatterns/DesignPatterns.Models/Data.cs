using System.Data.Entity;
namespace DesignPatterns.Models
{
    public partial class Data:DbContext
    {
        public Data()
        {
        }
        public DbSet<UserTable> Users { get;set; }
    }
}
