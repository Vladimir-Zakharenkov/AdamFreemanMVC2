using Microsoft.AspNetCore.Mvc;
using SportsStore.Models;
using System.Linq;

namespace SportsStore.Controllers
{
    public class ProductController : Controller
    {
        public int PageSize = 2;

        private IProductRepository repository;

        public ProductController(IProductRepository repo)
        {
            repository = repo;
        }

        public ViewResult List(int productPage = 3) => View(repository.Products
            .OrderBy(p => p.ProductId)
            .Skip((productPage - 1) * PageSize)
            .Take(PageSize));
    }
}
