using System;
using System.Collections.Generic;
using System.Text;
using DOMS.Model.DbModels;

namespace DOMS.Interface.Repository
{
    public interface IBrandRepository
    {
        IList<Brand> GetBrands();
        bool CreateBrand(Brand brand);
        bool UpdateBrand(Brand brand);
    }
}
