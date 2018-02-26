using System;
using System.Collections.Generic;
using System.Text;
using DOMS.Model.DbModels;

namespace DOMS.Interface.Repository
{
    public interface ICatalogueRepository
    {
        IList<Catalogue> GetCatalogues();
        IList<Catalogue> GetCatalogues(int familyId);
        bool CreateCatalogue(Catalogue catalogue);
        bool UpdateCatalogue(Catalogue catalogue);
    }
}
