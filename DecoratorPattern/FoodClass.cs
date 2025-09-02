namespace DecoratorPattern
{
    //所有的食物都要繼承這個抽象類別
    public abstract class FoodClass
    {
        protected int Price = 0;
        protected string Descript = "";

        public abstract int GetPrice();
        public abstract string GetDescript();

    }

    /*********************主食系列*****************************/
    public class Hamburger : FoodClass
    {
        public Hamburger()
        {
            this.Price = 35;
            this.Descript = "漢堡";
        }

        public override int GetPrice()
        {
            return Price;
        }

        public override string GetDescript()
        {
            return Descript;
        }
    }

    public class Rice : FoodClass
    {
        public Rice()
        {
            this.Price = 10;
            this.Descript = "飯";
        }

        public override int GetPrice()
        {
            return Price;
        }

        public override string GetDescript()
        {
            return Descript;
        }
    }
}
