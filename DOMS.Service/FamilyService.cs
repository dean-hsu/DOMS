using System;
using System.Collections.Generic;
using System.Text;
using DOMS.Interface.Repository;
using DOMS.Interface.Service;
using DOMS.Model.DbModels;
using Microsoft.Extensions.Logging;

namespace DOMS.Service
{
    public class FamilyService : IFamilyService
    {
        private readonly ILogger<FamilyService> _logger;
        private readonly IFamilyRepository _familyRepository;

        public FamilyService(ILogger<FamilyService> logger, IFamilyRepository familyRepository)
        {
            _logger = logger;
            _familyRepository = familyRepository;
        }

        public bool AddFamily(Family family)
        {
            return _familyRepository.CreateFamily(family);
        }

        public IList<Family> GetFamilies()
        {
            return _familyRepository.GetFamilies();
        }
    }
}
