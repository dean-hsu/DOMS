using System.Linq;
using System.Collections.Generic;
using DOMS.Interface.Repository;
using DOMS.Model.DbModels;
using DOMS.Repository.DbContext;

namespace DOMS.Repository
{
    public class OrderRepository : BaseRepository, IOrderRepository
    {
        public OrderRepository(ApplicationDbContext db)
            :base(db)
        {

        }

        public IList<Order> GetOrders(string userName)
        {
            return _db.Orders.Where(x => x.UserName == userName).ToList();
        }
    }
}
