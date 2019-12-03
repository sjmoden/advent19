using System;

namespace DayOne
{
    public class RocketModule: FuelableItem
    {
        private readonly int _mass;
        public RocketModule(int mass)
        {
            _mass = mass;
        }

        public int FuelRequired => GetFuelAmount(_mass);

        public int TotalFuelRequired => GetTotalFuel(_mass);
    }
}
