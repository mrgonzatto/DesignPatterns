using AbstractFactory.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.CaveLevel
{
    public class CaveLevelElementFactory : LevelElementFactory
    {
        public override IEnemy CreateEnemy()
        {
            return new Goblin();
        }

        public override IPowerUp CreatePowerUp()
        {
            return new Crystal();
        }

        public override IWeapon CreateWeapon()
        {
            return new Axe();
        }
    }
}
