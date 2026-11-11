using System;

namespace TurboRaceGame3
{
    public abstract class Vehicle
    {
        public string Name { get; protected set; }
        public int InitialSpeed { get; protected set; }
        public int CurrentSpeed { get; protected set; }
        public int MaxSpeed { get; protected set; }
        public string PowerName { get; protected set; }
        public int PowerIncrease { get; protected set; }

        public void Start()
        {
            CurrentSpeed = InitialSpeed;
        }

        // Each vehicle drives (accelerates) differently
        public abstract string Drive();

        // Each vehicle has its own special power
        public abstract string UsePower();

        public string Brake()
        {
            CurrentSpeed = Math.Max(0, CurrentSpeed - 10);
            return $"Braked by 10 km/h. Current speed: {CurrentSpeed} km/h.";
        }

        protected void AddSpeed(int amount)
        {
            CurrentSpeed = Math.Min(MaxSpeed, CurrentSpeed + amount);
        }
    }
}