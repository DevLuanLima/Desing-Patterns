namespace DesignPatterns._01___Creational._1._1___Abstract_Factory.Example_1
{
    public class ExecuteAbstractFactory
    {
        public static void Execute()
        {
            var rescueVehicles = new List<Vehicle>
            {
                CreatorVehicle.Create("Corsa", Size.Small),
                CreatorVehicle.Create("Corolla", Size.Medium),
                CreatorVehicle.Create("BMW X6", Size.Big)
            };

            rescueVehicles.ForEach(v => AutoRescue.CreateAutoRescue(v).PerformService());
        }
    }
}
