using YB_MelihEfeOmer_RezervasyonApp.DataAccess.Context;
using YB_MelihEfeOmer_RezervasyonApp.Entity.Models;

namespace YB_MelihEfeOmer_RezervasyonApp.DataAccess.Repositories
{
    public class PaymentRepository : GenericRepository<Payment>
    {
        public PaymentRepository(ApplicationDbContext context) : base(context)
        {

        }
    }
}
