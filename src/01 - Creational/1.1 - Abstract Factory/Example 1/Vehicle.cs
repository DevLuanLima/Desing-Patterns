namespace DesignPatterns._01___Creational._1._1___Abstract_Factory.Example_1
{
    // AbstractProduct  
    public abstract class Vehicle
    {
        public string Model { get; set; }
        public Size Size { get; set; }
        protected Vehicle(string model, Size size) {
            Model = model;
            Size = size;
        }
    }

    public enum Size
    {
        Small,
        Medium,
        Big
    }

    //Small Product
    public class SmallVehicle : Vehicle
    {
        public SmallVehicle(string model, Size size) : base (model, size)
        {

        }
    }

    //Medium Product
    public class MediumVehicle : Vehicle
    {
        public MediumVehicle(string model, Size size) : base(model, size)
        {
        }
    }

    // Produto Concreto
    public class BigVehicle : Vehicle
    {
        public BigVehicle(string model, Size size) : base(model, size)
        {
        }
    }

    public class CreatorVehicle
    {
        public static Vehicle Create(string model, Size size)
        {
            switch (size)
            {
                case Size.Small:
                    return new SmallVehicle(model, size);
                case Size.Medium:
                    return new MediumVehicle(model, size);
                case Size.Big:
                    return new BigVehicle(model, size);
                default:
                    throw new ApplicationException("Unknow vehicle size!");
            }
        }
    }

}
