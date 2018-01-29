using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DOMS.Interface.Repository;
using DOMS.Model.DbModels;
using DOMS.Repository.DbContext;

namespace DOMS.Repository
{
    public class CatalogueRepository : BaseRepository, ICatalogueRepository
    {
        public CatalogueRepository(ApplicationDbContext db) : base(db)
        {
        }

        public IList<Catalogue> GetCatalogues()
        {
            return _db.Catalogues.ToList();
        }

        public bool CreateCatalogue(Catalogue catalogue)
        {
            _db.Catalogues.Add(catalogue);
            _db.SaveChanges();
            return true;
        }

        public bool UpdateCatalogue(Catalogue catalogue)
        {
            throw new NotImplementedException();
        }
    }
}
