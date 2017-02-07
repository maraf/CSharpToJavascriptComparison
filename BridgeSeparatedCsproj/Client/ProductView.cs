using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shared;
using Bridge.jQuery2;

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
            root.Html("Loading...");
            ProductClient client = new ProductClient();
            client.GetList(OnListLoaded);
        }

        private void OnListLoaded(List<ProductModel> models)
        {
            root.Html("Product count: " + models.Count);
        }
    }
}
