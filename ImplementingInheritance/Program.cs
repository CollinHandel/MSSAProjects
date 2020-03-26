using System;
using ImplementingInheritanceClassLibrary;

namespace ImplementingInheritance
{
    class Program
    {
        static void Main()
        {
            Vehicles vehicles = new Vehicles();
            Humvee humvee = new Humvee();
            Helicopter helicopter = new Helicopter();
            Weapons weapons = new Weapons();
            LargeCaliberWeapon largeCaliberWeapon = new LargeCaliberWeapon();
            SmallCaliberWeapon smallCaliberWeapon = new SmallCaliberWeapon();

            Console.WriteLine($"Default Vehicle: {vehicles.Start()} -- {vehicles.Move()}");
            Console.WriteLine($"Humvee: {humvee.Start()} -- {humvee.Move()}");
            Console.WriteLine($"Helicopter: {helicopter.Start()} -- {helicopter.Move()}");
            Console.WriteLine($"Default Weapon: {weapons.Load()} -- {weapons.Fire()}");
            Console.WriteLine($"LG Caliber Weapon: {largeCaliberWeapon.Load()} -- {largeCaliberWeapon.Fire()}");
            Console.WriteLine($"SM Caliber Weapon: {smallCaliberWeapon.Load()} -- {smallCaliberWeapon.Fire()}");
        }
    }
}
