﻿using Factory.FactoryMethod.Enemies;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory.FactoryMethod.Levels
{
    public class HauntedHouseLevel : Level
    {
        public override IEnemy CreateEnemy()
        {
            return new Ghost();
        }
    }
}
