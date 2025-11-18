using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsDemo
{
    public class ProductInfo
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public decimal Price { get; set; }
        public double Rating { get; set; }
    }

    public class SortByPriceAscending: IComparer<ProductInfo>
    {
        public int Compare(ProductInfo x, ProductInfo y)
        {
            return x.Price.CompareTo(y.Price);
        }
    }
    public class SortByPriceDescending : IComparer<ProductInfo>
    {
        public int Compare(ProductInfo x, ProductInfo y)
        {
            return y.Price.CompareTo(x.Price);
        }
    }
    public class SortByName : IComparer<ProductInfo>
    {
        public int Compare(ProductInfo x, ProductInfo y)
        {
            return x.ProductName.CompareTo(y.ProductName);
        }
    }
    public class SortByRating : IComparer<ProductInfo>
    {
        public int Compare(ProductInfo x, ProductInfo y)
        {
            return x.Rating.CompareTo(y.Rating);
        }
    }

    internal class IComparerInterfaceDemo
    {
        static void Main(string[] args)
        {
            List<ProductInfo> list = new List<ProductInfo>()
            { new ProductInfo {ProductId =1,ProductName="Laptop",Price=450000,Rating=4.5},
            new ProductInfo {ProductId =2,ProductName="Monitor",Price=350000,Rating=4.2},
            new ProductInfo {ProductId =3,ProductName="Tablet",Price=250000,Rating=4.0},
            new ProductInfo {ProductId =4,ProductName="Mouse",Price=5000,Rating=3.6}
            };

            Console.WriteLine("1. Sort by price");
            list.Sort(new SortByPriceAscending());
            DisplayProducts(list);

            Console.WriteLine("2. Sort by price descending");
            list.Sort(new SortByPriceDescending());
            DisplayProducts(list);

            Console.WriteLine("3. Sort by name");
            list.Sort(new SortByName());
            DisplayProducts(list);

            Console.WriteLine("4. Sort by rating");
            list.Sort(new SortByRating());
            DisplayProducts(list);
        }

        static void DisplayProducts(List<ProductInfo> products)
        {
            foreach (var product in products)
            {
                Console.WriteLine($"ProductId: {product.ProductId}, ProductName: {product.ProductName}, Price: {product.Price}, Rating: {product.Rating}");
            }
        }
    }
}
