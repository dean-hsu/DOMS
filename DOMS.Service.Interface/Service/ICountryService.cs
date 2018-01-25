using System.Collections.Generic;
using DOMS.Model.DbModels;

namespace DOMS.Interface.Service
{
    public interface ICountryService
    {
        IList<Country> GetCountries();
    }
}
