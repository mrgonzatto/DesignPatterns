using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory.FactoryMethod.Levels
{
    public static class LevelFactory
    {
        public static Level CreateLevel(int levelNumber)
        {
            return levelNumber switch
            {
                1 => new CaveLevel(),
                2 => new HauntedHouseLevel(),
                _ => throw new Exception()
            };
        }
    }
}
