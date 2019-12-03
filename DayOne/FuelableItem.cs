using System;

namespace DayOne
{
    public abstract class FuelableItem
    {
        protected int GetFuelAmount(int mass)
        {
            return Math.Max((int)Math.Floor((decimal)mass / 3) - 2,0);
        }

        protected int GetTotalFuel(int mass)
        {
            var total = 0;
            var fuel = GetFuelAmount(mass);

            total += fuel > 0 ? fuel + GetTotalFuel(fuel) : fuel;

            return total;
        }
    }
}
