using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory.FactoryMethod.Enemies
{
    public class Goblin : IEnemy
    {
        public void Attack()
        {
            throw new NotImplementedException();
        }

        public void Scream()
        {
            throw new NotImplementedException();
        }
    }
}
