using System;

class Program
{
    static void Main(string[] args)
    {
        string[] names = { "Ace", "Bella", "Clyde", "Donna", "Evan", "Fiona" };
        int[] ages = { 21, 18, 27, 4, 30, 6 };

        Console.WriteLine("1. Ascending");
        Console.WriteLine("2. Descending");
        Console.Write("Choose sorting order: ");

        int choice = Convert.ToInt32(Console.ReadLine());

        switch (choice)
        {
            case 1:
                SortNamesAscending(names);
                SortAgesAscending(ages);
                break;

            case 2:
                SortNamesDescending(names);
                SortAgesDescending(ages);
                break;

            default:
                Console.WriteLine("Invalid choice");
                break;
        }

        Console.WriteLine("\nSorted Arrays:");
        for (int i = 0; i < names.Length; i++)
        {
            Console.WriteLine($"Name: {names[i]}, Age: {ages[i]}");
        }
    }

    static void SortNamesAscending(string[] names)
    {
        int n = names.Length;
        for (int i = 0; i < n - 1; i++)
        {
            for (int j = 0; j < n - i - 1; j++)
            {
                if (names[j].CompareTo(names[j + 1]) > 0)
                {
                    string tempName = names[j];
                    names[j] = names[j + 1];
                    names[j + 1] = tempName;
                }
            }
        }
    }

    static void SortNamesDescending(string[] names)
    {
        int n = names.Length;
        for (int i = 0; i < n - 1; i++)
        {
            for (int j = 0; j < n - i - 1; j++)
            {
                if (names[j].CompareTo(names[j + 1]) < 0)
                {
                    string tempName = names[j];
                    names[j] = names[j + 1];
                    names[j + 1] = tempName;
                }
            }
        }
    }

    static void SortAgesAscending(int[] ages)
    {
        int n = ages.Length;
        for (int i = 0; i < n - 1; i++)
        {
            for (int j = 0; j < n - i - 1; j++)
            {
                if (ages[j] > ages[j + 1])
                {
                    int tempAge = ages[j];
                    ages[j] = ages[j + 1];
                    ages[j + 1] = tempAge;
                }
            }
        }
    }

    static void SortAgesDescending(int[] ages)
    {
        int n = ages.Length;
        for (int i = 0; i < n - 1; i++)
        {
            for (int j = 0; j < n - i - 1; j++)
            {
                if (ages[j] < ages[j + 1])
                {
                    int tempAge = ages[j];
                    ages[j] = ages[j + 1];
                    ages[j + 1] = tempAge;
                }
            }
        }
    }
}