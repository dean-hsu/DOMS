using System;
using System.Collections.Generic;
using System.Text;
using DOMS.Model.DbModels;

namespace DOMS.Interface.Repository
{
    public interface ICatalogueRepository
    {
        IList<Catalogue> GetCatalogues();
        bool CreateCatalogue(Catalogue catalogue);
        bool UpdateCatalogue(Catalogue catalogue);
    }
}
