using System;
using System.Collections.Generic;
using System.Text;
using DOMS.Interface.Repository;
using DOMS.Model.DbModels;
using DOMS.Repository.DbContext;
using System.Linq;

namespace DOMS.Repository
{
    public class FamilyRepository : BaseRepository, IFamilyRepository
    {
        public FamilyRepository(ApplicationDbContext db) : base(db)
        {
        }

        public bool CreateFamily(Family family)
        {
            _db.Families.Add(family);
            _db.SaveChanges();
            return true;
        }

        public IList<Family> GetFamilies()
        {
            return _db.Families.ToList();
        }

        public bool UpdateFamily(Family family)
        {
            throw new NotImplementedException();
        }
    }
}
