namespace WebApi.Models
{
    public class Option
    {
        public int Id { get; set; }
        public required string Name { get; set; }

        // Relación inversa
        public ICollection<RoundsGames> RoundsGames { get; set; } = new List<RoundsGames>(); // Colección de RoundsGames
    }
}
