using MyApp.Models;

namespace MyApp.DataAccessLayer.Infrastructure.IRepository
{
    public interface IProductRepository : IRepository<Product>
    {


        void Update(Product product);


    }
}
