using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    //一般引擎、噴射引擎、渦輪引擎、V型引擎

    public class GeneralEngine : IEngine
    {
        public string EngineName()
        {
            return this.GetType().Name;
        }
    }

    public class JetEngine : IEngine
    {
        public string EngineName()
        {
            return this.GetType().Name;
        }
    }

    public class TurbineEngine : IEngine
    {
        public string EngineName()
        {
            return this.GetType().Name;
        }
    }

    public class VEngine : IEngine
    {
        public string EngineName()
        {
            return this.GetType().Name;
        }
    }
}
