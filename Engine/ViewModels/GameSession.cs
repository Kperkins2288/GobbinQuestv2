using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Engine.Models;
using Engine.Factories;

namespace Engine.ViewModels
{
    public class GameSession
    {
        public World CurrentWorld { get; set; }
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

            //CurrentLocation = new Location();
            //CurrentLocation.Name = "Home";
            //CurrentLocation.Xcoord = 0;
            //CurrentLocation.Ycoord = -1;
            //CurrentLocation.Description = "Home sweet home";

            WorldFactory factory = new WorldFactory();
            CurrentWorld = factory.CreateWorld();

            CurrentLocation = CurrentWorld.LocationAt(0, 0);
        }

        public void MoveNorth()
        {
            CurrentLocation = CurrentWorld.LocationAt(CurrentLocation.Xcoord, CurrentLocation.Ycoord + 1);
        }

        public void MoveEast()
        {
            CurrentLocation = CurrentWorld.LocationAt(CurrentLocation.Xcoord + 1, CurrentLocation.Ycoord);
        }

        public void MoveSouth()
        {
            CurrentLocation = CurrentWorld.LocationAt(CurrentLocation.Xcoord, CurrentLocation.Ycoord - 1);
        }

        public void MoveWest()
        {
            CurrentLocation = CurrentWorld.LocationAt(CurrentLocation.Xcoord - 1, CurrentLocation.Ycoord);
        }
    }
}
