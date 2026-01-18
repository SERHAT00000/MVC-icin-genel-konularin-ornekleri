
using Microsoft.EntityFrameworkCore;


namespace WEB_Kursu.Models
{
    public class UyeContext : DbContext
    {
        public UyeContext()
        {
        }

        public UyeContext(DbContextOptions<UyeContext> options) : base(options)
        {

        }

        public DbSet<Uye> Uyeler { get; set; }
    }
}