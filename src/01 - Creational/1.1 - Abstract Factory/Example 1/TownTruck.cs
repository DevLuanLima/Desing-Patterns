namespace DesignPatterns._01___Creational._1._1___Abstract_Factory.Example_1
{
    public abstract class TownTruck
    {
        // AbstractProduct   
        public abstract void Rescue (Vehicle veiculo);
        public Size Size { get; set; }
        public TownTruck(Size size)
        {
            Size = size;
        }

        // Small Wrecker
        public class SmallTownTruck : TownTruck
        {
            public SmallTownTruck(Size size) : base(size) { }

            public override void Rescue(Vehicle vehicle)
            {
                // Rescue Process
                Console.WriteLine("Rescuing small car - Model " + vehicle.Model);
            }
        }

        //Medium Wrecker
        public class MediumTownTruck : TownTruck
        {
            public MediumTownTruck(Size size) : base(size) { }

            public override void Rescue(Vehicle vehicle)
            {
                // Rescue Process
                Console.WriteLine("Rescuing medium car - Model " + vehicle.Model);
            }
        }

        //Big Wrecker
        public class BigTownTruck : TownTruck
        {
            public BigTownTruck(Size size) : base(size) { }

            public override void Rescue(Vehicle vehicle)
            {
                // Rescue Process
                Console.WriteLine("Rescuing Big car - Model " + vehicle.Model);
            }
        }

        public class CreateTownTruck
        {
            public static TownTruck Create(Size size)
            {
                switch (size)
                {
                    case Size.Small:
                        return new SmallTownTruck(size);
                    case Size.Medium:
                        return new MediumTownTruck(size);
                    case Size.Big:
                        return new BigTownTruck(size);
                    default:
                        throw new ApplicationException("Unknown Town Truck size!");
                }
            }
        }
    } 
}
