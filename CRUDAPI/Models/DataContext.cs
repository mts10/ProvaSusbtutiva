using Microsoft.EntityFrameworkCore;
namespace CRUDAPI {
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : 
         base(options)
        { }
    }
}