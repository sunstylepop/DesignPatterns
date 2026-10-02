using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    interface ISpawner
    {
        IMonster CreateMonster();
    }

    public class ForestSpawner : ISpawner
    {
        public IMonster CreateMonster()
        {
            return new Slime();
        }
    }

    public class VolcanoSpawner : ISpawner
    {
        public IMonster CreateMonster()
        {
            return new FireElemental();
        }
    }

    public class GlacierSpawner : ISpawner
    {
        public IMonster CreateMonster()
        {
            return new IceGolem();
        }
    }
}
