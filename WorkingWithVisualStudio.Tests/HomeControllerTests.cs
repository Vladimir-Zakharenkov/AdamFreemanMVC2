using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using WorkingWithVisualStudio.Controllers;
using WorkingWithVisualStudio.Models;
using Xunit;

namespace WorkingWithVisualStudio.Tests
{
    public class HomeControllerTests
    {
        class ModelCompleteFakeRepository : IRepository
        {
            public IEnumerable<Product> Products { get; set; }

            public void AddProduct(Product p)
            {
                // Ничего не делать - для теста не требуется
            }
        }

        [Theory]
        [ClassData(typeof(ProductTestData))]
        public void IndexActionIsComplete(Product[] products)
        {
            // Организация
            var controller = new HomeController();
            controller.Repository = new ModelCompleteFakeRepository
            {
                Products = products
            };

            // Действие
            var model = (controller.Index() as ViewResult)?.ViewData.Model as IEnumerable<Product>;

            // Утверждение
            Assert.Equal(controller.Repository.Products, model, Comparer.Get<Product>((p1, p2) =>
                p1.Name == p2.Name && p1.Price == p2.Price));
        }

        class PropertyOnceFakeRepository : IRepository
        {
            public int PropertyCounter { get; set; } = 0;

            public IEnumerable<Product> Products
            {
                get
                {
                    PropertyCounter++;
                    return new[] { new Product { Name = "P1", Price = 100 } };
                }
            }

            public void AddProduct(Product p)
            {
                // Ничего не делать - для теста не требуется
            }
        }

        [Fact]
        public void RepositoryPropertyCalledOnce()
        {
            // Организация
            var repo = new PropertyOnceFakeRepository();
            var controller = new HomeController { Repository = repo };

            // Действие
            var result = controller.Index();

            // Утверждение
            Assert.Equal(1, repo.PropertyCounter);

        }
    }
}
