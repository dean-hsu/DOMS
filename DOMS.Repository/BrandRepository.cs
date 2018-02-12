using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
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
            return _db.Brands.Include(x=>x.Country).Where(x => !x.Deleted).ToList();
        }

        public bool UpdateBrand(Brand brand)
        {
            ChangeUpdateTime(brand);
            _db.Brands.Update(brand);
            _db.SaveChanges();
            return true;
        }

        public Brand GetBrand(int brandId)
        {
            return _db.Brands.FirstOrDefault(x => x.BrandId == brandId);
        }
    }
}
