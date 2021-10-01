using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArsenalApp
{
    class LaserGun : Weapon
    {
        public override int Damage
        {
            get
            {
                return 50;
            }
        }

        public override void Fire()
        {
            Console.WriteLine("LaserGun fire");
        }
    }
}
