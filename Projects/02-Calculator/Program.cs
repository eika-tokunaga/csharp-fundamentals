using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("== Simple calculator ==");
        Console.WriteLine("Enter equation (e.g., 100 + 1000): ");
        string equation = Console.ReadLine();

        var components = equation.Split(' ');

        while (components.Length != 3)
        {
            Console.WriteLine("Invalid formula entered.\nPlease enter format: value1 operator value2");
            components = Console.ReadLine().Split(' ');
        }

        if (!double.TryParse(components[0], out double value1) ||
            !double.TryParse(components[2], out double value2))
        {
            Console.WriteLine("Both values must be valid numbers.");
            return;
        }

        
        // double value1 = components[0];
        string op = components[1];
        // double value2 = components[2];
        double result;

        switch (op)
        {
            case "+":
                // do x
                result = value1 + value2;
                break;
            case "-":
                result = value1 - value2;
                // do x
                break;
            case "/":
                if (value2 == 0)
                {
                    Console.WriteLine("Dividing by 0 not a valid operation.");
                    return;
                } 
                result = value1 / value2;
                // do x
                break;
            case "*":
                result = value1 * value2;
                // do x
                break;
            default:
                Console.WriteLine($"Invalid operator: '{op}'");
                Console.WriteLine("Accepted operators are '+', '-', '/', '*'");
                // do something
                return;
        }
        Console.WriteLine($"result: {result}");
    }
}


