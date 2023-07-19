namespace DesignPatterns._01___Creational._1._1___Abstract_Factory.Example_1
{
    public class AutoRescue
    {
        private readonly Vehicle _vehicle;
        private readonly TownTruck _townTruck;

        public AutoRescue(AutoRescueFactory factory, Vehicle vehicle )
        {
            _vehicle = factory.CreateVehicles(vehicle.Model, vehicle.Size);
            _townTruck = factory.CreateTownTrucks();
        }

        public void PerformService()
        {
            _townTruck.Rescue(_vehicle);
        }

        public static AutoRescue CreateAutoRescue(Vehicle vehicle)
        {
            switch (vehicle.Size)
            {
                case Size.Small:
                    return new AutoRescue(new RescueSmallVehicleFactory(), vehicle);
                case Size.Medium:
                    return new AutoRescue(new RescueMediumVehicle(), vehicle);
                case Size.Big:
                    return new AutoRescue(new RescueBigVehicle(), vehicle);
                default:
                    throw new ApplicationException("Unable to identify vehicle!");
            }
        }


    }
}
