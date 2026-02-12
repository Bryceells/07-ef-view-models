using LuckySpin.Models;
namespace LuckySpin.ViewModels
{
    public class PlayersChoice
    {
        public Player Player { get; set; }
        //TODO: Add  additional properties needed to pre-fill the PlayersChoice View.
        public int GameId { get; set; }
        public int SpinId { get; set; }
        public int Luck { get; set; }

    }
}