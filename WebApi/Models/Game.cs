using System.Text.Json.Serialization;

namespace WebApi.Models
{
    public class Game
    {
        public int Id { get; set; }
         
        // Relación inversa

        public ICollection<Round> Rounds { get; set; } = new List<Round>(); // Colección de Rounds
    }
}
