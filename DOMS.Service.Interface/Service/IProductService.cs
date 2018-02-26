using System;
using System.Collections.Generic;
using System.Text;
using DOMS.Model.DbModels;

namespace DOMS.Interface.Service
{
    public interface IProductService
    {
        IList<Product> GetProducts(string userName);
        bool CreateProduct(Product product);
    }
}
