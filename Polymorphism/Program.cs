namespace Polymorphism
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Geometri geometryObject;

            geometryObject = new Rectangle();
            Console.WriteLine($"Rectangle Area: {geometryObject.Aera()}");

            geometryObject = new square();
            Console.WriteLine($"Square Area: {geometryObject.Aera()}");

            geometryObject = new circle();
            Console.WriteLine($"Circle Area: {geometryObject.Aera()}");


        }
    }
}