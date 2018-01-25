using System;
using System.Collections.Generic;
using System.Linq;
using DOMS.Interface.Repository;
using DOMS.Model.DbModels;
using DOMS.Repository.DbContext;

namespace DOMS.Repository
{
    public class BrandRepository : BaseRepository, IBrandRepository
    {
        public BrandRepository(ApplicationDbContext db) : base(db)
        {
        }

        public bool CreateBrand(Brand brand)
        {
            AddCreateTime(brand);

            _db.Brands.Add(brand);
            _db.SaveChanges();
            return true;
        }

        public IList<Brand> GetBrands()
        {
            return _db.Brands.Where(x => !x.Deleted).ToList();
        }

        public bool UpdateBrand(Brand brand)
        {
            throw new NotImplementedException();
        }
    }
}
