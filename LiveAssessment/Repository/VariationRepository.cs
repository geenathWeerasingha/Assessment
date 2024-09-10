using LiveAssessment.Data;
using LiveAssessment.Interfaces;
using LiveAssessment.Models;

namespace LiveAssessment.Repository
{
    public class VariationRepository : IVariationRepository
    {

        private readonly DataContext _context; // Use your actual data context class name

        public VariationRepository(DataContext context)
        {
            _context = context;
        }

        public bool CreateVariation(Variation Variation)
        {
            _context.Add(Variation);
            return Save();
        }

        public Variation GetVariationById(int VariationId)
        {
            return _context.Variations.FirstOrDefault(a => a.VariationId == VariationId);
        }

        public bool Save()
        {
            var saved = _context.SaveChanges();
            return saved > 0 ? true : false;
        }

        public bool UpdateVariation(Variation variation)
        {
            _context.Update(variation);
            return Save();
        }
    }
}

 