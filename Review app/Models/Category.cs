namespace Review_app.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<PokomonCategory> PokomonCategories { get; set; }
    }
}
