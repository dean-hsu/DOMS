using System.Collections.Generic;
using DOMS.Model.DbModels;

namespace DOMS.Interface.Repository
{
    public interface ICountryRepository
    {
        IList<Country> GetCountries();
    }
}
