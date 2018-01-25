using System.Collections.Generic;
using System.Linq;
using DOMS.Interface.Repository;
using DOMS.Model.DbModels;
using DOMS.Repository.DbContext;

namespace DOMS.Repository
{
    public class CountryRepository : BaseRepository, ICountryRepository
    {
        public CountryRepository(ApplicationDbContext db)
            :base(db)
        {

        }

        public IList<Country> GetCountries()
        {
            return _db.Countries.ToList();
        }
    }
}
