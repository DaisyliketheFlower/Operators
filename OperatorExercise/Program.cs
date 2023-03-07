namespace OperatorExercise;
class Program
{
    static void Main(string[] args)
    {
        int b = 24;
        int a = 3;

        int sum = a + b;
        Console.WriteLine($"a - b = {sum}");

        int diff = a - b;
        Console.WriteLine($"a + b = {diff}");

        Console.WriteLine($"a x b = {a * b}");

        int quotient = a / b;
        int remainder = a % b;

        Console.WriteLine($"{a} / {b} is {quotient} remainder {remainder}");
        Console.WriteLine();


        //Exercise 2

        Console.WriteLine("What is the radius of your circle?");
        var radius = double.Parse(Console.ReadLine());
        var area = AreaOfCircle(radius);
        Console.WriteLine($"Area of Circle{area}");
    }

    public static double AreaOfCircle(Double Radius)
    {
        var area = Math.PI * Math.Pow(Radius, 2);
        return area;
    }
}

