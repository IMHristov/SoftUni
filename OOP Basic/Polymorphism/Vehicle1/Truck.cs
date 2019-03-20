namespace _1.Vehicles
{
    public class Truck : Vehicle
    {
        private const double takenFuelInCharging = 0.95;

        public Truck(double fuelAmount, double fuelConsumption)
            : base(fuelAmount, fuelConsumption)
        {
        }

        public override void Refuel(double fuel)
        {
            fuel *= takenFuelInCharging;
            base.Refuel(fuel);
        }
    }
}