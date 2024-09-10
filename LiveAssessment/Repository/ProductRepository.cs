using LiveAssessment.Data;
using LiveAssessment.Interfaces;
using LiveAssessment.Models;

namespace LiveAssessment.Repository
{
    public class ProductRepository : IProductRepository
    {


        private readonly DataContext _context; // Use your actual data context class name

        public ProductRepository(DataContext context)
        {
            _context = context;
        }



        public bool CreateProduct(Product product)
        {
            _context.Add(product);
            return Save();
        }

        public Product GetProductById(int productId)
        {
            return _context.Products.FirstOrDefault(a => a.Id == productId);
        }

        public bool Save()
        {
            var saved = _context.SaveChanges();
            return saved > 0 ? true : false;
        }


        public bool UpdateProduct(Product product)
        {
            _context.Update(product);
            return Save();
        }
               
               
        
     

        
    }
}
