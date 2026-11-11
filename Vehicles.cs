using System.Xml.Linq;

namespace TurboRaceGame3
{
    public class SportsCar : Vehicle
    {
        public SportsCar()
        {
            Name = "Sports Car"; InitialSpeed = 40; MaxSpeed = 180;
            PowerName = "Nitro Boost"; PowerIncrease = 30;
        }
        public override string Drive()
        {
            AddSpeed(10);
            return $"Accelerated by 10 km/h. Current speed: {CurrentSpeed} km/h.";
        }
        public override string UsePower()
        {
            AddSpeed(PowerIncrease);
            return $"Nitro Boost activated! Current speed: {CurrentSpeed} km/h.";
        }
    }

    public class Motorbike : Vehicle
    {
        public Motorbike()
        {
            Name = "Motorbike"; InitialSpeed = 35; MaxSpeed = 140;
            PowerName = "Wheelie Boost"; PowerIncrease = 20;
        }
        public override string Drive()
        {
            AddSpeed(8);
            return $"Bike sped up by 8 km/h. Current speed: {CurrentSpeed} km/h.";
        }
        public override string UsePower()
        {
            AddSpeed(PowerIncrease);
            return $"Wheelie Boost activated! Current speed: {CurrentSpeed} km/h.";
        }
    }

    public class MonsterTruck : Vehicle
    {
        public MonsterTruck()
        {
            Name = "Monster Truck"; InitialSpeed = 25; MaxSpeed = 100;
            PowerName = "Crush Power"; PowerIncrease = 15;
        }
        public override string Drive()
        {
            AddSpeed(5);
            return $"Truck rumbled forward by 5 km/h. Current speed: {CurrentSpeed} km/h.";
        }
        public override string UsePower()
        {
            AddSpeed(PowerIncrease);
            return $"Crush Power activated! Current speed: {CurrentSpeed} km/h.";
        }
    }

    public class ElectricCar : Vehicle
    {
        public ElectricCar()
        {
            Name = "Electric Car"; InitialSpeed = 30; MaxSpeed = 160;
            PowerName = "Battery Boost"; PowerIncrease = 25;
        }
        public override string Drive()
        {
            AddSpeed(7);
            return $"Silently accelerated by 7 km/h. Current speed: {CurrentSpeed} km/h.";
        }
        public override string UsePower()
        {
            AddSpeed(PowerIncrease);
            return $"Battery Boost activated! Current speed: {CurrentSpeed} km/h.";
        }
    }
}