using AbstractFactory.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.HauntedHouseLevel
{
    internal class HauntedHouseLevelElementFactory : LevelElementFactory
    {
        public override IEnemy CreateEnemy()
        {
            return new Ghost();
        }

        public override IPowerUp CreatePowerUp()
        {
            return new Orb();
        }

        public override IWeapon CreateWeapon()
        {
            return new Staff();
        }
    }
}
