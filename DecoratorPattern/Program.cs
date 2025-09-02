using DecoratorPattern;

//今天來寫個熟食專賣店

//起司漢堡
FoodClass CheeseHamburger = new Hamburger();
CheeseHamburger = new Cheese(CheeseHamburger);

//起司豬排漢堡
FoodClass CPHamburger = new Hamburger();
CPHamburger = new PorkChop(CPHamburger);
CPHamburger = new Cheese(CPHamburger);

//爌肉豬排飯(雙主菜)
FoodClass SPHamburger = new Rice();
SPHamburger = new PorkChop(SPHamburger);
SPHamburger = new StewedPork(SPHamburger);

Console.WriteLine("項名: " + CheeseHamburger.GetDescript());
Console.WriteLine("金額: " + CheeseHamburger.GetPrice());
Console.WriteLine("-------------------------------------------");
Console.WriteLine("項名: " + CPHamburger.GetDescript());
Console.WriteLine("金額: " + CPHamburger.GetPrice());
Console.WriteLine("-------------------------------------------");
Console.WriteLine("項名: " + SPHamburger.GetDescript());
Console.WriteLine("金額: " + SPHamburger.GetPrice());
Console.WriteLine("-------------------------------------------");

Console.ReadLine();
