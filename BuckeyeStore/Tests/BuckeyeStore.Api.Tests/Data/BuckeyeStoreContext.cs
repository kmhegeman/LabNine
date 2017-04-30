using Microsoft.EntityFramwork;
using BuckeyeStore.Core;

namespace BuckeyeStore.Api.Data
{
    public class BuckeyeStoreContext : DbContext
    {
        public BuckeyeStoreContext() { }

        public BuckeyeStoreContext(DbContextOptions<BuckeyeStoreContext> options) : base(options) { }

        public DbSet<Products {get; set; }
    }
}