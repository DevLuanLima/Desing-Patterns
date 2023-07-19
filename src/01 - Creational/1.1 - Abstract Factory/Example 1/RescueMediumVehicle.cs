using static DesignPatterns._01___Creational._1._1___Abstract_Factory.Example_1.TownTruck;

namespace DesignPatterns._01___Creational._1._1___Abstract_Factory.Example_1
{
    public class RescueMediumVehicle : AutoRescueFactory
    {
        public override TownTruck CreateTownTrucks()
        {
            return CreateTownTruck.Create(Size.Medium);
        }

        public override Vehicle CreateVehicles(string model, Size size)
        {
            return CreatorVehicle.Create(model, size);
        }
    }
}
