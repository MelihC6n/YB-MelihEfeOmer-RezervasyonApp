using Microsoft.EntityFrameworkCore;
using YB_MelihEfeOmer_RezervasyonApp.DataAccess.Context;
using YB_MelihEfeOmer_RezervasyonApp.Entity.Models;

namespace YB_MelihEfeOmer_RezervasyonApp.DataAccess.Repositories
{
    public class BookingRepository : GenericRepository<Booking>
    {
        private readonly ApplicationDbContext _context;
        private readonly DbSet<Booking> _dbSet;

        public BookingRepository(ApplicationDbContext context) : base(context)
        {
            _context = context;
            _dbSet = _context.Set<Booking>();
        }
        public void BookingDelete(Guid id)
        {
            Booking booking = GetById(id);
            booking.IsDeleted = true;
            _dbSet.Update(booking);
            _context.SaveChanges();
        }
    }
}
