using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YB_MelihEfeOmer_RezervasyonApp.Business.Abstractions;
using YB_MelihEfeOmer_RezervasyonApp.DataAccess.Repositories;
using YB_MelihEfeOmer_RezervasyonApp.Entity.Models;

namespace YB_MelihEfeOmer_RezervasyonApp.Business.Services
{
    public class PaymentService : IService<Payment>
    {
        private readonly PaymentRepository _paymentRepository;
        public PaymentService(PaymentRepository pRep)
        {
            _paymentRepository = pRep;
        }
        public void Add(Payment entity)
        {
            _paymentRepository.Add(entity);
        }

        public void Delete(Guid id)
        {
            _paymentRepository.Delete(id);
        }

        public IEnumerable<Payment>? GetAll()
        {
            return _paymentRepository.GetAll();
        }

        public IQueryable<Payment> GetAllQueryable()
        {
            return _paymentRepository.GetAllQueryable();
        }

        public Payment? GetById(Guid id)
        {
            return _paymentRepository.GetById(id);
        }

        public void Update(Payment entity)
        {
            _paymentRepository.Update(entity);
        }
    }
}
