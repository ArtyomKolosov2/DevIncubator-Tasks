using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module10.Data
{
    public class Rack<T> where T: Product
    {
        private List<T> ProductList { get; set; }
        public static int Count { get; set; } = 0;
        public Rack()
        {
            ProductList = new List<T>();
        }
        public void AddProduct(T product)
        {
            ProductList.Add(product);
            Count += 1;
        }
        public void AddProducts(IEnumerable<T> products)
        {
            ProductList.AddRange(products);
            Count += products.Count();
        }
    }
}
