internal class Program
{
    private static void Main(string[] args)
    {
        Website web = new Website();
        web.ShowData();
        Console.Write("Change website's name: ");
        web.Name = Console.ReadLine();
        Console.WriteLine("New website's name = " + web.Name);

        Journal jour = new Journal();
        jour.ShowData();
        Console.Write("Change name: ");
        jour.Name = Console.ReadLine();
        Console.WriteLine("New journal's name = " + jour.Name + ", found in " + jour.FoundationYear);

        Shop shop = new Shop();
        shop.ShowData();
        Console.Write("Change shop's address: ");
        shop.Address = Console.ReadLine();
        Console.WriteLine("New shop's address = " + shop.Address);
    }
}