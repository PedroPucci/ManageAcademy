using Microsoft.EntityFrameworkCore;

namespace ManageAcademyWeb.Repository
{
    public class DataBaseContext : DbContext
    {
        public DataBaseContext(DbContextOptions<DataBaseContext> options) : base(options) { }

        //TODO: Add DbSets
    }
}