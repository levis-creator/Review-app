using Review_app.Data;
using Review_app.Models;
using Review_app.Repositories.Interfaces;

namespace Review_app.Repositories
{
    public class PokomonRepository : IPokomonRepository
    {
        private readonly DataContext _dataContext;
        public PokomonRepository(DataContext context)
        {
            _dataContext = context;
        }
        public ICollection<Pokomon> GetPokomons()
        {
            return _dataContext.Pokomons.OrderBy(p => p.Id).ToList();
        }
    }
}
