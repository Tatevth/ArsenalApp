using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArsenalApp
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Weapon> weapons = new List<Weapon>();
            weapons.Add(new Gun());
            weapons.Add(new LaserGun());
            weapons.Add(new Bow());
            List<Player> players = new List<Player>();
            players.Add(new Player(1, "Poghos"));
            players.Add(new Player(2, "Petros"));
            players.Add(new Player(3, "Anna"));

            for (int i = 0; i < weapons.Count; i++)
            {
                Console.WriteLine($"Players ID - {players[i]._id},\tPlayers name-{players[i]._name}");
                weapons[i].Fire();
                Console.WriteLine($"Damage percent = {weapons[i].Damage}%\n");
            }
            Console.ReadKey();
        }
    }
}
