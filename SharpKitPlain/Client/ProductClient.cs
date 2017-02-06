using Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client
{
    public class ProductClient
    {
        public void GetList(Action<List<ProductModel>> onSuccess)
        {
        }

        public void Get(int id, Action<ProductModel> onSuccess)
        {
        }
    }
}
