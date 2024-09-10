using System;

public static class RandomGenerator
{
    public static int GetRandomInt(int minValue, int maxValue, int seed)
    {
        int range = maxValue - minValue + 1;
        int randomSeed = seed;
        int randomNumber;

        do
        {
            randomSeed = (randomSeed * 9301 + 49297) % 233280;
            randomNumber = randomSeed % range;
        } while (randomNumber >= range);

        return minValue + randomNumber;
    }
}

public class Program
{
    public static void Main()
    {
        int minValue;
        int maxValue;
        int seed;

        Console.Write("Enter the minimum value: ");
        minValue = int.Parse(Console.ReadLine());

        Console.Write("Enter the maximum value: ");
        maxValue = int.Parse(Console.ReadLine());

        Console.Write("Enter the seed: ");
        seed = int.Parse(Console.ReadLine());

        int randomValue = RandomGenerator.GetRandomInt(minValue, maxValue, seed);
        Console.WriteLine(randomValue);
    }
}
