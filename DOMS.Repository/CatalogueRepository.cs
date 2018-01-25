using System;
using System.Collections.Generic;
using System.Text;
using DOMS.Interface.Repository;
using DOMS.Repository.DbContext;

namespace DOMS.Repository
{
    public class CatalogueRepository : BaseRepository, ICatalogueRepository
    {
        public CatalogueRepository(ApplicationDbContext db) : base(db)
        {
        }
    }
}
