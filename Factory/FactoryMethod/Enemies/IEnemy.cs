using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory.FactoryMethod.Enemies
{
    public interface IEnemy
    {
        public void Scream();

        public void Attack();
    }
}
