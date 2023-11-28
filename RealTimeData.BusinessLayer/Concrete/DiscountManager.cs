using RealTimeData.DataAccessLayer.Abstract;
using RealTimeData.EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealTimeData.BusinessLayer.Concrete
{
    public class DiscountManager : IDiscountDal
    {
        private readonly IDiscountDal _discountDal;

        public DiscountManager(IDiscountDal discountDal)
        {
            _discountDal = discountDal;
        }

        public void Add(Discount entity)
        {
            _discountDal.Add(entity);
        }

        public void Delete(Discount entity)
        {
            _discountDal.Delete(entity);
        }

        public Discount GetByID(int id)
        {
            return _discountDal.GetByID(id);
        }

        public List<Discount> GetListAll()
        {
            return _discountDal.GetListAll();
        }

        public void Update(Discount entity)
        {
            _discountDal.Update(entity);
        }
    }
}
