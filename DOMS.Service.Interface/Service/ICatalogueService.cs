using System;
using System.Collections.Generic;
using System.Text;
using DOMS.Model.DbModels;

namespace DOMS.Interface.Service
{
    public interface ICatalogueService
    {
        IList<Catalogue> GetCatalogues();
        bool AddCatalogue(Catalogue catalogue);
    }
}
