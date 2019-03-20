namespace _1.Vehicles
{
    public abstract class Vehicle
    {
        private double fuelAmount;
        private double fuelConsumption;
        

        public Vehicle(double fuelAmount, double fuelConsumption)
        {
            this.fuelAmount = fuelAmount;
            this.fuelConsumption = fuelConsumption;
            
        }

        public virtual void Refuel(double fuel)
        {
            this.fuelAmount += fuel;
        }

        public string Drive(double distance)
        {
            var neededFuel = this.fuelConsumption  * distance;

            if (neededFuel > this.fuelAmount)
            {
                return $"{this.GetType().Name} needs refueling";
            }

            this.fuelAmount -= neededFuel;
            return $"{this.GetType().Name} travelled {distance} km";
        }

        public override string ToString()
        {
            return $"{this.GetType().Name}: {this.fuelAmount:F2}";
        }
    }
}