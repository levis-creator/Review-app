namespace Review_app.Models
{
    public class PokomonOwner
    {
        public int PokomonId { get; set; }
        public int OwnerId { get; set; }
        public Pokomon Pokomon { get; set; }
        public Owner Owner { get; set; }
    }
}
