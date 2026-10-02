using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    public interface IMonster
    {
        public void Appear();
    }


    public class Slime : IMonster
    {
        public void Appear() {
            Console.WriteLine(string.Format("黏呼呼的史萊姆從草叢中跳了出來！"));
        }
    }

    public class FireElemental : IMonster
    {
        public void Appear() {
            Console.WriteLine(string.Format("熱，是火元素！"));
        }
    }

    public class IceGolem : IMonster
    {
        public void Appear() {
            Console.WriteLine(string.Format("一陣冷風吹過，冰巨魔出現在眼前！"));
        }
    }
}
