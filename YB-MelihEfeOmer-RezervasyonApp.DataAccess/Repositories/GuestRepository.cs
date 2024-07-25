using YB_MelihEfeOmer_RezervasyonApp.DataAccess.Context;
using YB_MelihEfeOmer_RezervasyonApp.Entity.Models;

namespace YB_MelihEfeOmer_RezervasyonApp.DataAccess.Repositories
{
    public class GuestRepository : GenericRepository<Guest>
    {

        public GuestRepository(ApplicationDbContext context) : base(context)
        {

        }
    }
}
