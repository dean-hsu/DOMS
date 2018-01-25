using System.Collections.Generic;
using System.Linq;
using DOMS.Interface.Repository;
using DOMS.Model.DbModels;
using DOMS.Repository.DbContext;

namespace DOMS.Repository
{
    public class ProductRepository : BaseRepository, IProductRepository
    {
        public ProductRepository(ApplicationDbContext db)
            :base(db)
        {

        }

        public IList<Product> GetProducts(string userName)
        {
            return _db.Products.Where(x => x.CreatedUser.UserName == userName).ToList();
        }
    }
}
