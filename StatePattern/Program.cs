using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern
{
    /// <summary>狀態模式</summary>
    //與策略模式類似, 但差再策略模式彼此不知道彼此的存在
    //適合[有限狀態機]使用
    class Program
    {
        //根據能量不一樣, 放出的招式也不一樣
        //每5秒累加10能量
        //能量 < 30  => 半月斬
        //能量 >30 and < 60 => 龍捲風
        //能量 > 60 => 流星雨
        //釋放後能量一律歸0

        static void Main(string[] args)
        {
            Hero myHero = new Hero();

            myHero.ChargeEnergy(20);
            myHero.ShowSkill();

            myHero.ChargeEnergy(30);
            myHero.ShowSkill();

            myHero.ChargeEnergy(10);
            myHero.ShowSkill();

            myHero.ChargeEnergy(50);
            myHero.ShowSkill();

            myHero.ShowSkill();

            Console.ReadLine();
        }
    }
}
