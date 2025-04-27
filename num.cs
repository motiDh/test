class Calculator
{
    static void Main()
    {
        Console.Write("first number: ");
        int num1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("second number: ");
        int num2 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine($"Sum: {num1 + num2}");
        Console.WriteLine($"Difference: {num1 - num2}");
        Console.WriteLine($"Product: {num1 * num2}");
        Console.WriteLine($"Quotient: {num1 / num2}");
    }
}