using System;
using System.Collections.Generic;
using System.Text;
using DOMS.Model.DbModels;

namespace DOMS.Interface.Service
{
    public interface IFamilyService
    {
        IList<Family> GetFamilies();
        bool AddFamily(Family family);
    }
}
