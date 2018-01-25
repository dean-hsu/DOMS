using System;
using System.Collections.Generic;
using System.Text;
using DOMS.Interface.Repository;
using DOMS.Interface.Service;
using DOMS.Model.DbModels;
using Microsoft.Extensions.Logging;

namespace DOMS.Service
{
    public class CountryService : ICountryService
    {
        private readonly ILogger<CountryService> _logger;
        private readonly ICountryRepository _countryRepository;

        public CountryService(ILogger<CountryService> logger, ICountryRepository countryRepository)
        {
            _logger = logger;
            _countryRepository = countryRepository;
        }

        public IList<Country> GetCountries()
        {
            return _countryRepository.GetCountries();
        }
    }
}
