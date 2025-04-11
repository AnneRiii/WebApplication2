using Microsoft.EntityFrameworkCore;

namespace WebApplication2.Models
{
    public partial class StudInfoSysContext
    {
        public StudInfoSysContext() 
        {
            
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=DESKTOP-9F8R6T5\\SQLEXPRESS;Initial Catalog=StudInfoSys;Integrated Security=True;Trust Server Certificate=True");
        }

    }
}
