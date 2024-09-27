using Review_app.Models;

namespace Review_app.Repositories.Interfaces
{
    public interface IPokomonRepository
    {
        IEnumerable<Pokomon> GetPokomons();
        Pokomon GetPokomon(int id);
        Pokomon GetPokomon(string id);
        decimal GetPokomonRating(int pokoId);
        bool PokemonExists(int pokoId);


    }
}
