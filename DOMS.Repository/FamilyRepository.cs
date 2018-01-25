using System;
using System.Collections.Generic;
using System.Text;
using DOMS.Interface.Repository;
using DOMS.Repository.DbContext;

namespace DOMS.Repository
{
    public class FamilyRepository : BaseRepository, IFamilyRepository
    {
        public FamilyRepository(ApplicationDbContext db) : base(db)
        {
        }
    }
}
