namespace WebApi.Models
{
    public class RoundsGames
    {
        public int Id { get; set; }

        // Clave foránea para Round
        public int Id_Rounds { get; set; }
        public Round? Round { get; set; } // Relación con Round

        // Clave foránea para Player 
        public int Id_Players { get; set; }
        public Player? Player { get; set; } // Relación con Player

        // Clave foránea para Option 
        public int Id_Options { get; set; }
        public Option? Option { get; set; } // Relación con Option

        public bool Victory { get; set; } // Resultado de la victoria
    }
}
