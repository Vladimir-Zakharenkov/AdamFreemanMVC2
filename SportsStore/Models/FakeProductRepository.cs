using System.Collections.Generic;
using System.Linq;

namespace SportsStore.Models
{
    public class FakeProductRepository : IProductRepository
    {
        public IQueryable<Product> Products => new List<Product>
        {
            new Product { Name = "Football", Price = 25M },
            new Product { Name = "Surf board", Price = 179M },
            new Product { Name = "Running shoes", Price = 95M}
        }.AsQueryable<Product>();
    }
}
