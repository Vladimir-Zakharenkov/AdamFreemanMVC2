using System.Collections.Generic;
using System.Linq;
using Moq;
using SportsStore.Controllers;
using SportsStore.Models;
using Xunit;

namespace SportsStore.Tests
{
    public class ProductControllerTests
    {
        [Fact]
        public void Can_Paginate()
        {
            // Организация
            Mock<IProductRepository> mock = new();

            mock.Setup(x => x.Products).Returns((new Product[]
            {
                new Product { ProductId = 1, Name = "P1" },
                new Product { ProductId = 2, Name = "P2"},
                new Product { ProductId = 3, Name = "P3"},
                new Product { ProductId = 4, Name = "P4"},
                new Product { ProductId = 5, Name = "P5"}
            }).AsQueryable<Product>);

            ProductController controller = new (mock.Object);
            controller.PageSize = 3;

            // Действие
            IEnumerable<Product> result = controller.List(2).ViewData.Model as IEnumerable<Product>;

            // Утверждение
            Product[] prodArray = result.ToArray();
            Assert.True(prodArray.Length == 2);
            Assert.Equal("P4", prodArray[0].Name);
            Assert.Equal("P5", prodArray[1].Name);
        }
    }
}
