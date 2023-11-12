using System;

public class Calculator : ICalculatable
{
    public double Add(double a, double b)
    {
        return a + b;
    }

    public double Subtract(double a, double b)
    {
        return a - b;
    }

    public double Multiply(double a, double b)
    {
        return a * b;
    }

    public double Divide(double a, double b)
    {
        if (b == 0)
        {
            throw new ArgumentException("Деление на ноль недопустимо.");
        }
        return a / b;
    }
}

class Program
{
    static void Main()
    {
        ICalculatable calculator = new Calculator();

        double result = calculator.Add(5, 3);
        Console.WriteLine("5 + 3 = " + result);

        result = calculator.Subtract(10, 4);
        Console.WriteLine("10 - 4 = " + result);

        result = calculator.Multiply(7, 2);
        Console.WriteLine("7 * 2 = " + result);

        result = calculator.Divide(9, 3);
        Console.WriteLine("9 / 3 = " + result);
    }
}
