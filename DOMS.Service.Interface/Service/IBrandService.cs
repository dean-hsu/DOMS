using System;
using System.Collections.Generic;
using System.Text;
using DOMS.Model.DbModels;

namespace DOMS.Interface.Service
{
    public interface IBrandService
    {
        IList<Brand> GetBrands();
        bool AddBrand(Brand brand);
    }
}
