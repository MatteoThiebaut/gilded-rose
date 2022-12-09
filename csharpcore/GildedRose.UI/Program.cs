using GildedRose;
using System.IO;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Les items ont été ajouté !");
        Shop shop = new Shop(new FileItemsRepository());
        shop.updateInventory();

        
    }
}