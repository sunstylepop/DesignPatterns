using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern
{
    abstract class SkillBase
    {
        public abstract string skillName { get; }

        protected Hero _hero;

        protected void _ShowSkill(int CurEnergy)
        {
            Console.WriteLine(string.Format($"當前能量: {CurEnergy}, 釋放 -> {skillName}"));

            _hero.Energy = 0;

            if(GetType().Name != nameof(SkillA))
                _hero.SetSkill(new SkillA(_hero));

        }

        public abstract void ShowSkill();

        public abstract void ChargeEnergy(int Energy);
    }

    interface ISkill
    {
        void ShowSkill();

        void ChargeEnergy(int Energy);
    }

    class SkillA : SkillBase
    {
        public override string skillName => "半月斬";

        public SkillA(Hero hero)
        {
            _hero = hero;
        }

        public override void ShowSkill()
        {
            _ShowSkill(_hero.Energy);
        }

        public override void ChargeEnergy(int Energy)
        {
            _hero.Energy += Energy;
            if(_hero.Energy >= 30)
            {
                _hero.SetSkill(new SkillB(_hero));
            }

        }
    }

    class SkillB : SkillBase
    {
        public override string skillName => "龍捲風";

        public SkillB(Hero hero)
        {
            _hero = hero;
        }

        public override void ShowSkill()
        {
            _ShowSkill(_hero.Energy);
        }

        public override void ChargeEnergy(int Energy)
        {
            _hero.Energy += Energy;
            if (_hero.Energy >= 60)
            {
                _hero.SetSkill(new SkillC(_hero));
            }

        }
    }

    class SkillC : SkillBase
    {
        public override string skillName => "流星雨";

        public SkillC(Hero hero)
        {
            _hero = hero;
        }

        public override void ShowSkill()
        {
            _ShowSkill(_hero.Energy);
        }

        public override void ChargeEnergy(int Energy)
        {
            _hero.Energy += Energy;

        }
    }
}
