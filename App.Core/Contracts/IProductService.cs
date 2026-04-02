using App.Core.Models;
using App.Core.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Core.Contracts
{
  public   interface IProductService
    {
        Product Add(Product product);
        bool Update(Product product);
         bool Delete(string id);
         Product GetById(string id);
         List<Product> GetAll();
         List<Product> Search(string text, ProductCategoryEnum? category, ProductStatusEnum? status);
       // public bool Exists(string id);
    }
}
