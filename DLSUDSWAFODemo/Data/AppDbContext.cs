using Microsoft.EntityFrameworkCore;
using System.Security.Cryptography.X509Certificates;

namespace DLSUDSWAFODemo.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) 
        {
          
        }
    }
}
