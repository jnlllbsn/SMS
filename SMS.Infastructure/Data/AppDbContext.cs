using Microsoft.EntityFrameworkCore;
using SMS.Domain;
//removed unnecessary usings
namespace SMS.Infastructure.Data
{
    public class AppDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=db_students;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False"); //copy and paste from localdb connection string
            base.OnConfiguring(optionsBuilder);
        }

        public DbSet<Student> Students { get; set; } //added references
        public DbSet<Programs> Programs { get; set; }
    }
}
