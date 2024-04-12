namespace DefaultNamespace;

public class Zadanie1
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Hello World");
        Console.WriteLine("Hello! Im World.");
        Console.WriteLine("Who am i?");
        
        Console.WriteLine("You are a git noob");
    }
    public static double CalculateAverage(int[] numbers)
    {
        if (numbers == null || numbers.Length == 0)
        {
            throw new ArgumentException("Array is null or empty.");
        }

        int sum = 0;
        foreach (int num in numbers)
        {
            sum += num;
        }

        return (double)sum / numbers.Length;
    }
}