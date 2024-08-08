namespace Review_app.Models
{
    public class Pokomon
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime BirthDate { get; set; }
        public ICollection<Review> Reviews { get; set; }
        public ICollection<PokomonOwner> PokomonOwners { get; set; }
        public ICollection<PokomonCategory> PokomonCategories { get; set; }
    }
}
