using YB_MelihEfeOmer_RezervasyonApp.DataAccess.Context;
using YB_MelihEfeOmer_RezervasyonApp.Entity.Models;

namespace YB_MelihEfeOmer_RezervasyonApp.DataAccess.Repositories
{
    public class BRBookingGuestRepository : GenericRepository<BRBookingGuest>
    {
        public BRBookingGuestRepository(ApplicationDbContext context) : base(context)
        {
            
        }
    }
}
