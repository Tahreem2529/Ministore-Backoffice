using App.Core.Contracts;
using App.Core.Models;
using App.Core.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Core.Services
{
    public class InMemoryProductService : IProductService
    {
        private List<Product> _products;
        public InMemoryProductService()
        {
            _products = new List<Product>();
            GenerateFakeProducts();
        }
       
        public List<Product> GetAll()
        {
            return _products.OrderBy(p => p.Name).ToList();
        }

        void IProductService.Add(Product product)
        {
            throw new NotImplementedException();
        }

        bool IProductService.Delete(string id)
        {
            throw new NotImplementedException();
        }

        private void GenerateFakeProducts()
        {
         _products.Clear();
            _products.Add(new Product
            {
                Id = GenerateId(),
                Name = "Laptop",
                Category = ProductCategoryEnum.Electronics,
                Price = 150000.00m,
                Stock = 10,
                Status = ProductStatusEnum.Active

            });
            _products.Add(new Product
            {
                Id = GenerateId(),
                Name = "Jacket",
                Category = ProductCategoryEnum.Clothing,
                Status = ProductStatusEnum.Active,
                Price = 4500m,
                Stock = 18
            });


        }
        private string GenerateId()
        {
         //o.g.,p-142B3C
         return "p-" + Guid.NewGuid().ToString("N").Substring(0,6);
        }

        Product IProductService.GetById(string id)
        {
            throw new NotImplementedException();
        }

        List<Product> IProductService.Search(string text, ProductCategoryEnum? category, ProductStatusEnum? status)
        {
            throw new NotImplementedException();
        }

        bool IProductService.Update(Product product)
        {
            throw new NotImplementedException();
        }
    }

}
