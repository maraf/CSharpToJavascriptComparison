using Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server
{
    public class ProductWebService
    {
        public List<ProductModel> GetList()
        {
            return new List<ProductModel>() 
            {
                new ProductModel() 
                {
                    Id = 1,
                    Name = "Product A",
                    Price = 100
                },
                new ProductModel() 
                {
                    Id = 2,
                    Name = "Product B",
                    Price = 200
                }
            };
        }

        public ProductModel Get(int id)
        {
            return new ProductModel()
            {
                Id = id,
                Name = "Product A",
                Price = 100
            };
        }
    }
}
