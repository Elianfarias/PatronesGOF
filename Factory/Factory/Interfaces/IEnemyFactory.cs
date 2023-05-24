using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Factory.Enemies.Interfaces;

namespace Factory.Factory.Interfaces
{
    public interface IEnemyFactory
    {
        public IEnemy GetEnemy();
        public void GetRandomEnemies(int cant);
    }
}
