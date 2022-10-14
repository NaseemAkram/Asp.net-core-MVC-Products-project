using Asp.net_core_MVC_Products_project.Data;
using MyApp.DataAccessLayer.Infrastructure.IRepository;

namespace MyApp.DataAccessLayer.Infrastructure.Repository
{
    public class UnitOfWork : IUnitOfWork
    {

        private ApplicationDbContext _context;
        public ICategoryRepository Category { get; private set; }
        public IProductRepository Product { get; private set; }

        public UnitOfWork(ApplicationDbContext context)
        {
            _context = context;
            Category = new CategoryRepository(context);
            Product = new ProductRepository(context);
        }

        public void Save()
        {
            _context.SaveChanges();
        }
    }
}
