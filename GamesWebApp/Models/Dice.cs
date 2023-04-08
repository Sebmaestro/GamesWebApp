namespace GamesWebApp.Models
{
    public class Dice
    {
        public int Id { get; set; }
        public int Number { get; set; }

        public int Roll { get; set; }

        public Dice(int id)
        {
            this.Id = id;
        }
    }
}
