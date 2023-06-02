using System;
using System.Collections.Generic;

public class InventoryItem
{
    public string Name { get; }
    public double Weight { get; } 
    public double Volume { get; }

    public InventoryItem(string name, double weight, double volume)
    {
        Name = name;
        Weight = weight;
        Volume = volume;
    }
}

public class Pack
{
    private List<InventoryItem> items;
    private int maxCount;
    private double maxVolume;
    private double maxWeight;

    public Pack(int maxCount, double maxVolume, double maxWeight)
    {
        this.maxCount = maxCount;
        this.maxVolume = maxVolume;
        this.maxWeight = maxWeight;
        items = new List<InventoryItem>();
    }

    public bool Add(InventoryItem item)
    {
        if (items.Count >= maxCount || GetTotalVolume() + item.Volume > maxVolume || GetTotalWeight() + item.Weight > maxWeight)
            return false;

        items.Add(item);
        return true;
    }

    public override string ToString()
    {
        string packInfo = $"Pack Contents ({items.Count} items):\n";

        foreach (var item in items)
            packInfo += $"{item.Name} - Weight: {item.Weight}, Volume: {item.Volume}\n";

        packInfo += $"Max Count: {maxCount}, Max Volume: {maxVolume}, Max Weight: {maxWeight}\n";
        packInfo += $"Total Weight: {GetTotalWeight()}, Total Volume: {GetTotalVolume()}";

        return packInfo;
    }

    private double GetTotalWeight()
    {
        double totalWeight = 0;

        foreach (var item in items)
            totalWeight += item.Weight;

        return totalWeight;
    }

    private double GetTotalVolume()
    {
        double totalVolume = 0;

        foreach (var item in items)
            totalVolume += item.Volume;

        return totalVolume;
    }
}

public static class PackTester
{
    public static void AddEquipment(Pack pack)
    {
        Console.WriteLine("Welcome to the Pack Tester!");
        Console.WriteLine("Available items: ");
        Console.WriteLine("1. Arrow");
        Console.WriteLine("2. Bow");
        Console.WriteLine("3. Rope");
        Console.WriteLine("4. Water");
        Console.WriteLine("5. Food");
        Console.WriteLine("6. Sword");
        Console.WriteLine("Enter 'q' to quit.");

        while (true)
        {
            Console.WriteLine();
            Console.WriteLine(pack.ToString());
            Console.WriteLine();
            Console.Write("Choose an item to add: ");

            string choice = Console.ReadLine();
            Console.WriteLine();

            if (choice == "q")
                break;

            InventoryItem item;
            switch (choice)
            {
                case "1":
                    item = new InventoryItem("Arrow", 0.1, 0.05);
                    break;
                case "2":
                    item = new InventoryItem("Bow", 1, 4);
                    break;
                case "3":
                    item = new InventoryItem("Rope", 1, 1.5);
                    break;
                case "4":
                    item = new InventoryItem("Water", 2, 3);
                    break;
                case "5":
                    item = new InventoryItem("Food", 1, 0.5);
                    break;
                case "6":
                    item = new InventoryItem("Sword", 5, 3);
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    continue;
            }

            if (pack.Add(item))
                Console.WriteLine($"Added {item.Name} to the pack.");
            else
                Console.WriteLine("Cannot add item. Pack constraints exceeded.");
        }

        Console.WriteLine("Exiting Pack Tester. Goodbye!");
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        Pack pack = new Pack(10, 20, 30);
        PackTester.AddEquipment(pack);
    }
}
