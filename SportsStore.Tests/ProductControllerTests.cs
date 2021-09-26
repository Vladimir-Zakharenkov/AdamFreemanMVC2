using System.Collections.Generic;
using System.Linq;
using Moq;
using SportsStore.Controllers;
using SportsStore.Models;
using SportsStore.Models.ViewModels;
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

            ProductController controller = new(mock.Object);
            controller.PageSize = 3;

            // Действие
            IEnumerable<Product> result = controller.List(2).ViewData.Model as IEnumerable<Product>;

            // Утверждение
            Product[] prodArray = result.ToArray();
            Assert.True(prodArray.Length == 2);
            Assert.Equal("P4", prodArray[0].Name);
            Assert.Equal("P5", prodArray[1].Name);
        }

        [Fact]
        public void Can_Send_Pagination_View_Model()
        {
            // Организация
            Mock<IProductRepository> mock = new();
            mock.Setup(m => m.Products).Returns((new Product[]
            {
                new Product { ProductId = 1, Name = "P1"},
                new Product { ProductId = 2, Name = "P2"},
                new Product { ProductId = 3, Name = "P3"},
                new Product { ProductId = 4, Name = "P4"},
                new Product { ProductId = 5, Name = "P5"}
            }).AsQueryable<Product>());

            // Организация
            ProductController controller = new(mock.Object)
            {
                PageSize = 3
            };

            // Действие
            ProductListViewModel result = controller.List(2).ViewData.Model as ProductListViewModel;

            // Утверждение
            PagingInfo pageInfo = result.PagingInfo;
            Assert.Equal(2, pageInfo.CurrentPage);
            Assert.Equal(3, pageInfo.ItemsPerPage);
            Assert.Equal(5, pageInfo.TotalItems);
            Assert.Equal(2, pageInfo.TotalPages);
        }
    }
}
