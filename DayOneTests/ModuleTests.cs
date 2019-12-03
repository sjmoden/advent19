using NUnit.Framework;
using DayOne;

namespace DayOneTests
{
    public class ModuleTests
    {
        [SetUp]
        public void Setup()
        {
        }

        private int GetFuelAmount(int mass)
        {
            var module = new RocketModule(mass);
            return module.FuelRequired;
        }

        private int GetTotalFuelAmount(int mass)
        {
            var module = new RocketModule(mass);
            return module.TotalFuelRequired;
        }

        [Test]
        public void The_fuel_for_module_mass_12_is_correct()
        {
            Assert.That(GetFuelAmount(12), Is.EqualTo(2));
        }

        [Test]
        public void The_total_fuel_for_module_mass_12_is_correct()
        {
            Assert.That(GetTotalFuelAmount(12), Is.EqualTo(2));
        }

        [Test]
        public void The_fuel_for_module_mass_14_is_correct()
        {
            Assert.That(GetFuelAmount(14), Is.EqualTo(2));
        }

        [Test]
        public void The_fuel_for_module_mass_1969_is_correct()
        {
            Assert.That(GetFuelAmount(1969), Is.EqualTo(654));
        }

        [Test]
        public void The_total_fuel_for_module_mass_1969_is_correct()
        {
            Assert.That(GetTotalFuelAmount(1969), Is.EqualTo(966));
        }

        [Test]
        public void The_fuel_for_module_mass_100756_is_correct()
        {
            Assert.That(GetFuelAmount(100756), Is.EqualTo(33583));
        }

        [Test]
        public void The_total_fuel_for_module_mass_100756_is_correct()
        {
            Assert.That(GetTotalFuelAmount(100756), Is.EqualTo(50346));
        }

        [Test]
        public void The_fuel_for_module_mass_0_is_correct()
        {
            Assert.That(GetFuelAmount(0), Is.EqualTo(0));
        }
    }
}
