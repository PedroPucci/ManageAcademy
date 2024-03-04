using ManageAcademyWeb.Domain.Entity;
using Microsoft.EntityFrameworkCore;

namespace ManageAcademyWeb.Repository
{
    public class DataBaseContext : DbContext
    {
        public DataBaseContext(DbContextOptions options) : base(options){}
    }
}