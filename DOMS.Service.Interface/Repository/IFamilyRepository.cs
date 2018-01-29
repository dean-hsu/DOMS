using System;
using System.Collections.Generic;
using System.Text;
using DOMS.Model.DbModels;

namespace DOMS.Interface.Repository
{
    public interface IFamilyRepository
    {
        IList<Family> GetFamilies();
        bool CreateFamily(Family family);
        bool UpdateFamily(Family family);
    }
}
