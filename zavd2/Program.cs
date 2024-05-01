using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введіть координату x:");
        double x = double.Parse(Console.ReadLine());

        Console.WriteLine("Введіть координату y:");
        double y = double.Parse(Console.ReadLine());

        if (x > 0 && y > 0)
        {
            Console.WriteLine("Точка знаходиться в першій координатній чверті.");
        }
        else if (x < 0 && y > 0)
        {
            Console.WriteLine("Точка знаходиться в другій координатній чверті.");
        }
        else if (x < 0 && y < 0)
        {
            Console.WriteLine("Точка знаходиться в третій координатній чверті.");
        }
        else if (x > 0 && y < 0)
        {
            Console.WriteLine("Точка знаходиться в четвертій координатній чверті.");
        }
        else
        {
            Console.WriteLine("Точка знаходиться на вісі або в початковому положенні.");
        }
    }
}
