using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Factory_Sample
{
    interface IWeapon
    {
        public void attack();
    }

    public class Sword : IWeapon
    {
        public void attack()
        {
            Console.WriteLine(string.Format("揮舞長劍砍擊！"));
        }
    }

    public class Bow : IWeapon
    {
        public void attack()
        {
            Console.WriteLine(string.Format("射出穿甲箭矢！"));
        }
    }

    public class Staff : IWeapon
    {
        public void attack()
        {
            Console.WriteLine(string.Format("發射火球！"));
        }
    }
}
