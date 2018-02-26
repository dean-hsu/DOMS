using System;
using System.Collections.Generic;
using System.Text;
using DOMS.Model.DbModels;

namespace DOMS.Interface.Service
{
    public interface ICatalogueService
    {
        IList<Catalogue> GetCatalogues();
        IList<Catalogue> GetCatalogues(int familyId);
        bool AddCatalogue(Catalogue catalogue);
    }
}
