using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArsenalApp
{
    class Bow : Weapon
    {
        public override int Damage
        {
            get
            {
                return 40;
            }
        }

        public override void Fire()
        {
            Console.WriteLine("Bow fire");
        }
    }
}
