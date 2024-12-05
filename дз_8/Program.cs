using System;

enum CustomDayOfWeek { Monday, Tuesday, Wednesday, Thursday, Friday, Saturday, Sunday }

class Program
{
    static void Main()
    {
        Random random = new Random();

        // 1. 
        int[] array = new int[10];
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = random.Next(-10, 11);
        }

        Console.WriteLine("Array elements:");
        Console.WriteLine(string.Join(", ", array));

        Console.WriteLine("\nElements with even indices:");
        for (int i = 0; i < array.Length; i += 2)
        {
            Console.WriteLine($"array[{i}] = {array[i]}");
        }

        // 2. 
        int sum = 0;
        foreach (int num in array)
        {
            sum += num;
        }

        Console.WriteLine($"\nThe sum of array elements: {sum}");
        Console.WriteLine(sum >= 0 ? "The amount is integral" : "The amount is negative");

        // 3. 
        int[,] multiplicationTable = new int[9, 9];
        for (int i = 0; i < 9; i++)
        {
            for (int j = 0; j < 9; j++)
            {
                multiplicationTable[i, j] = (i + 1) * (j + 1);
            }
        }

        Console.WriteLine("\nMultiplication table:");
        for (int i = 0; i < 9; i++)
        {
            for (int j = 0; j < 9; j++)
            {
                Console.Write($"{multiplicationTable[i, j],3} ");
            }
            Console.WriteLine();
        }

        // 4. 
        int[,] matrix = new int[5, 5];
        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < 5; j++)
            {
                matrix[i, j] = random.Next(-100, 101);
                Console.Write($"{matrix[i, j],4} ");
            }
            Console.WriteLine();
        }

        int max = matrix[0, 0], min = matrix[0, 0];
        int maxRow = 0, maxCol = 0, minRow = 0, minCol = 0;

        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < 5; j++)
            {
                if (matrix[i, j] > max)
                {
                    max = matrix[i, j];
                    maxRow = i;
                    maxCol = j;
                }
                if (matrix[i, j] < min)
                {
                    min = matrix[i, j];
                    minRow = i;
                    minCol = j;
                }
            }
        }

        Console.WriteLine($"\nMaximum element: {max} (string: {maxRow}, column: {maxCol})");
        Console.WriteLine($"Minimal element: {min} (string: {minRow}, column: {minCol})");

        // 5. 
        Console.Write("\nEnter the number of days: ");
        int inputDays = int.Parse(Console.ReadLine());
        CustomDayOfWeek currentDay = CustomDayOfWeek.Monday;
        CustomDayOfWeek resultDay = (CustomDayOfWeek)((inputDays % 7 + (int)currentDay) % 7);

        Console.WriteLine($"The day after {inputDays} day: {resultDay}");
    }
}
