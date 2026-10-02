// See https://aka.ms/new-console-template for more information


using Factory_Sample;

var weapon1 = WeaponFactory.createWeapon("sword");
weapon1.attack();

var weapon2 = WeaponFactory.createWeapon("bow");
weapon2.attack();

var weapon3 = WeaponFactory.createWeapon("staff");
weapon3.attack();

var weapon4 = WeaponFactory.createWeapon("spear");
weapon4?.attack();
