using Microsoft.AspNetCore.Mvc;
using System.Linq;
using SportsStore.Models;
using SportsStore.Models.ViewModels;


namespace SportsStore.Controllers
{
    public class ProductController : Controller
    {
        //public int PageSize = 2;

        private IProductRepository repository;

        public ProductController(IProductRepository repo)
        {
            repository = repo;
        }

        public ViewResult List() => View(repository.Products);

        //public ViewResult List(int productPage = 3) => View(repository.Products
        //    .OrderBy(p => p.ProductId)
        //    .Skip((productPage - 1) * PageSize)
        //    .Take(PageSize));

        //public ViewResult List(int productPage = 1) =>
        //    View(new ProductListViewModel
        //    {
        //        Products = repository.Products
        //        .OrderBy(p => p.ProductId)
        //        .Skip((productPage - 1) * PageSize)
        //        .Take(PageSize),
        //        PagingInfo = new()
        //        {
        //            CurrentPage = productPage,
        //            ItemsPerPage = PageSize,
        //            TotalItems = repository.Products.Count()
        //        }
        //    });
    }
}
