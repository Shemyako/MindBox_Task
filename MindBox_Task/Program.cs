using MindBox_Libary;
class Program
{
    static void Main(string[] args)
    {
        Circle circle = new Circle(5);
        Console.WriteLine($"Периметр круга: {circle.Perimeter()}");
        Console.WriteLine($"Площадь круга: {circle.Square()}");
        Console.WriteLine(circle);

        Triangle abc = new Triangle(3, 4, 5);
        Console.WriteLine($"Периметр квадрата: {abc.Perimeter()}");
        Console.WriteLine($"Площадь квадрата: {abc.Square()}");
        Console.WriteLine(abc);
    }
}