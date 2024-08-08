using Review_app.Models;

namespace Review_app.Repositories.Interfaces
{
    public interface IPokomonRepository
    {
        ICollection<Pokomon> GetPokomons();

    }
}
