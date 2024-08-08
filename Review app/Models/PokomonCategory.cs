namespace Review_app.Models
{
    public class PokomonCategory
    {
        public int PokomonId { get; set; }
        public int CategoryId { get; set; }
        public Pokomon Pokomon{get; set;}
        public Category Category { get; set;}
    }
}
