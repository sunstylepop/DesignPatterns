using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    public abstract class SideDish : FoodClass
    {
        //顧名思義就是多一個property用來裝飾food
        FoodClass food;

        public SideDish(FoodClass f)
        {
            this.food = f;
        }

        public override int GetPrice()
        {
            return this.Price + food.GetPrice();
        }

        public override string GetDescript()
        {
            return this.Descript + food.GetDescript();
        }
    }

    /*********************附加食物系列*****************************/
    public class Cheese : SideDish
    {
        public Cheese(FoodClass f) : base(f)
        {
            this.Price = 10;
            this.Descript = "起司";
        }
    }

    public class PorkChop : SideDish
    {
        public PorkChop(FoodClass f) : base(f)
        {
            this.Price = 50;
            this.Descript = "豬排";
        }
    }

    public class StewedPork  : SideDish
    {
        public StewedPork(FoodClass f) : base(f)
        {
            this.Price = 30;
            this.Descript = "焢肉";
        }
    }
}
