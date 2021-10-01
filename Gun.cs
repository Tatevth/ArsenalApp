using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArsenalApp
{
    class Gun : Weapon
    {
        public override int Damage
        {
            get
            {
                return 60;
            }
        }
        public override void Fire()
        {
            Console.WriteLine("Gun fire");
        }
    }
}
