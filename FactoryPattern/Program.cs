namespace FactoryPattern
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many wheels does your vehicle have?");
            var numberOfWheels = Console.ReadLine();

            IVehicle vehicle = VehicleFactory.GetVehicle(numberOfWheels);

            Console.WriteLine();
            vehicle.Drive();
        }
    }
}
