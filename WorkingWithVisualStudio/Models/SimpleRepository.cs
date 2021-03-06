using System.Collections.Generic;

namespace WorkingWithVisualStudio.Models
{
    public class SimpleRepository : IRepository
    {
        private Dictionary<string, Product> products = new();

        public static SimpleRepository SharedRepository { get; } = new();

        public SimpleRepository()
        {
            var initialItems = new[]
            {
                new Product{Name = "Kayak", Price = 275M},
                new Product{Name = "Lifejacket", Price = 48.95M},
                new Product{Name = "Soccer ball", Price = 19.50M},
                new Product{Name = "Corner flag", Price = 34.95M}
            };

            foreach (var p in initialItems)
            {
                AddProduct(p);
            }
        }

        public IEnumerable<Product> Products => products.Values;
        public void AddProduct(Product p) => products.Add(p.Name, p);
    }
}
