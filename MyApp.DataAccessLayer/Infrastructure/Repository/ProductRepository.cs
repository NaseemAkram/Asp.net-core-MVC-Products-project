using Asp.net_core_MVC_Products_project.Data;
using MyApp.DataAccessLayer.Infrastructure.IRepository;
using MyApp.Models;

namespace MyApp.DataAccessLayer.Infrastructure.Repository
{
    public class ProductRepository : Repository<Product>, IProductRepository
    {
        public ApplicationDbContext _context;
        public ProductRepository(ApplicationDbContext context) : base(context)
        {
            _context = context;
        }

        public void Update(Product product)
        {
            var productDb = _context.Products.FirstOrDefault(x => x.Id == product.Id);
            if (productDb != null)
            {
                productDb.Name = product.Name;
                productDb.Description = product.Description;
                productDb.Price = product.Price;
                if (productDb.ImageUrl != null)
                {
                    productDb.ImageUrl = product.ImageUrl;
                }
            }
        }
    }
}
