using Microsoft.EntityFrameworkCore;
using YB_MelihEfeOmer_RezervasyonApp.DataAccess.Context;
using YB_MelihEfeOmer_RezervasyonApp.Entity.Models;

namespace YB_MelihEfeOmer_RezervasyonApp.DataAccess.Repositories
{
    public class GuestRepository : GenericRepository<Guest>
    {
        private readonly ApplicationDbContext _context;
        private readonly DbSet<Guest> _dbSet;

        public GuestRepository(ApplicationDbContext context) : base(context)
        {
            _context = context;
            _dbSet = _context.Set<Guest>();
        }

        public Guest? GetByIdentityNumber(string kimlikNo)
        {
            return _dbSet.FirstOrDefault(x => x.IdentityNumber == kimlikNo);
        }
    }
}
