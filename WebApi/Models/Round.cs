using System.ComponentModel.DataAnnotations;

namespace WebApi.Models
{
    public class Round
    {
        public int Id { get; set; }

        [Required] // Id_Game sigue siendo obligatorio
        public int Id_Game { get; set; }

        // No marcamos Game como requerido en el modelo ya que lo asignaremos en el servidor
        public Game? Game { get; set; }

        public ICollection<RoundsGames> RoundsGames { get; set; } = new List<RoundsGames>();
    }

}

