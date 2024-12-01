using Factory.FactoryMethod.Enemies;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory.FactoryMethod.Levels
{
    public abstract class Level
    {
        public abstract IEnemy CreateEnemy();

        public void EncounterEnemy()
        {
            IEnemy enemy = CreateEnemy();
            enemy.Scream();
            enemy.Attack();
        }
    }
}
