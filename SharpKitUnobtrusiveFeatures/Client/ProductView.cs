using SharpKit.jQuery;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shared;

namespace Client
{
    public class ProductView
    {
        private jQuery root;

        public ProductView(jQuery root)
        {
            this.root = root;
        }

        public void Render()
        {
            root.html("Loading...");
            ProductClient client = new ProductClient();
            client.GetList(OnListLoaded);
        }

        private void OnListLoaded(List<ProductModel> models)
        {
            root.html("Product count: " + models.Count);
        }
    }
}
