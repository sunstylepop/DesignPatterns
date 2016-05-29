using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    public abstract class CarModel
    {
        protected IEngine _Engine;
        public string EngineName
        {
            get
            {
                return "I use " + _Engine.EngineName();
            }
        }

        public CarModel()
        {
            //預設一般引擎
            _Engine = new GeneralEngine();
        }

        public void SetEngine(IEngine e)
        {
            this._Engine = e;
        }
    }

    public class Car : CarModel
    {
        public Car()
        {
            _Engine = new VEngine();
        }
    }
}
