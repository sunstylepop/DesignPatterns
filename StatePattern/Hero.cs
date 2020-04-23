using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern
{
    class Hero
    {

        private SkillBase _skill { get; set; }
        public int Energy { get; set; }
        
        public Hero()
        {
            _skill = new SkillA(this);
        }

        public void ShowSkill()
        {
            _skill.ShowSkill();
        }

        public void ChargeEnergy(int secondTime)
        {
            //每5秒加10能量
            for(int i = 0; i< secondTime; i = i + 5)
            {
                _skill.ChargeEnergy(10);
            }

            Console.WriteLine(string.Format($"集氣中.....當前能量: {Energy}"));
        }

        public void SetSkill(SkillBase skill)
        {
            _skill = skill;
        }
    }
}
