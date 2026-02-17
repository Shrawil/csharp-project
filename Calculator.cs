using System;

public class Calculator
{
    public static void Main(string[] args)
    {
        Console.Write("Enter value for num1 : ");
        int num1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter value for num2 : ");
        int num2 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter an operation (+, -, *, /) : ");
        char opr = Convert.ToChar(Console.ReadLine());
        switch (opr) {
            case '+': 
                Console.WriteLine($"{num1} + {num2} = {num1+num2}");
                break;
            case '-': 
                Console.WriteLine($"{num1} - {num2} = {num1-num2}");
                break;
            case '*': 
                Console.WriteLine($"{num1} * {num2} = {num1*num2}");
                break;
            case '/': 
                Console.WriteLine($"{num1} / {num2} = {num1/num2}");
                break;
            default:
                Console.WriteLine("Invalid Input!");
                break;
        }
    }
}
