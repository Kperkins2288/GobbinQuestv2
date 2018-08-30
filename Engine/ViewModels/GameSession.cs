using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Engine.Models;

namespace Engine.ViewModels
{
    public class GameSession
    {
        public Player CurrentPlayer { get; set; }
        public Location CurrentLocation { get; set; }

        public GameSession()
        {
            CurrentPlayer = new Player();
            CurrentPlayer.Name = "Gob";
            CurrentPlayer.CharacterClass = "Warrior";
            CurrentPlayer.Health = 20;
            CurrentPlayer.Gold = 1000;
            CurrentPlayer.Exp = 0;
            CurrentPlayer.Level = 1;

            CurrentLocation = new Location();
            CurrentLocation.Name = "Home";
            CurrentLocation.Xcoord = 0;
            CurrentLocation.Ycoord = -1;
            CurrentLocation.Description = "Home sweet home";
        }
    }
}
