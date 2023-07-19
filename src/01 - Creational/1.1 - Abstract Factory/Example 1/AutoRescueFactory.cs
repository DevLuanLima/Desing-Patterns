namespace DesignPatterns._01___Creational._1._1___Abstract_Factory.Example_1
{
    public abstract class AutoRescueFactory
    {
        // Abstract Factory
        public abstract TownTruck CreateTownTrucks();
        public abstract Vehicle CreateVehicles(string model, Size size);
    }
}
