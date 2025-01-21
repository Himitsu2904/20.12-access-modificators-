internal class Program
{
    private static void Main(string[] args)
    {
        Website web = new Website();
        web.ShowData();

        Journal jour1 = new Journal();
        Journal jour2 = new Journal();
        jour2 = 22 + jour1;
        Console.WriteLine($"\n22 + jour1({jour1.EmployeesCount}) = jour2({jour2.EmployeesCount})");
        Console.Write($"jour1({jour1.EmployeesCount}) + 4 = ");
        jour1 += 4;
        Console.WriteLine($"jour1({jour1.EmployeesCount})");
        Console.Write($"jour2({jour2.EmployeesCount}) - 54 = ");
        try
        {
            jour2 -= 54;
        }
        catch (BelowZeroException ex)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write(ex.Message);
            Console.ForegroundColor = ConsoleColor.White;
        }
        Console.WriteLine($"jour2({jour2.EmployeesCount})");
        Console.WriteLine($"17 = jour1({jour1.EmployeesCount}): {17 == jour1}");
        Console.WriteLine($"8 != jour1({jour1.EmployeesCount}): {8 != jour1}");
        Console.WriteLine($"jour2({jour2.EmployeesCount}) = 26: {jour2 == 26}");
        Console.WriteLine($"jour2({jour2.EmployeesCount}) != 49: {jour2 != 49}");
        Console.WriteLine($"jour1({jour1.EmployeesCount}) = jour2({jour2.EmployeesCount}): {jour1 == jour2}");
        Console.WriteLine($"jour1({jour1.EmployeesCount}) != jour2({jour2.EmployeesCount}): {jour1 != jour2}");
        Console.WriteLine($"17 < jour1({jour1.EmployeesCount}): {17 < jour1}");
        Console.WriteLine($"8 > jour1({jour1.EmployeesCount}): {8 > jour1}");
        Console.WriteLine($"jour2({jour2.EmployeesCount}) < 26: {jour2 < 26}");
        Console.WriteLine($"jour2({jour2.EmployeesCount}) > 49: {jour2 > 49}");
        Console.WriteLine($"jour1({jour1.EmployeesCount}) < jour2({jour2.EmployeesCount}): {jour1 < jour2}");
        Console.WriteLine($"jour1({jour1.EmployeesCount}) > jour2({jour2.EmployeesCount}): {jour1 > jour2}");
        Console.WriteLine($"jour1.Equals(jour2): {jour1.Equals(jour2)}");

        Shop shop1 = new Shop();
        Shop shop2 = new Shop();
        shop2 = 22 + shop1;
        Console.WriteLine($"\n22 + shop1({shop1.Area}) = shop2({shop2.Area})");
        Console.Write($"shop1({shop1.Area}) + 4 = ");
        shop1 += 4;
        Console.WriteLine($"shop1({shop1.Area})");
        Console.Write($"shop2({shop2.Area}) - 54 = ");
        try
        {
            shop2 -= 54;
        }
        catch (BelowZeroException ex)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write(ex.Message);
            Console.ForegroundColor = ConsoleColor.White;
        }
        Console.WriteLine($"shop2({shop2.Area})");
        Console.WriteLine($"shop1({shop1.Area}) = shop2({shop2.Area}): {shop1 == shop2}");
        Console.WriteLine($"shop1({shop1.Area}) != shop2({shop2.Area}): {shop1 != shop2}");
        Console.WriteLine($"17 < shop1({shop1.Area}): {17 < shop1}");
        Console.WriteLine($"8 > shop1({shop1.Area}): {8 > shop1}");
        Console.WriteLine($"shop2({shop2.Area}) < 26: {shop2 < 26}");
        Console.WriteLine($"shop2({shop2.Area}) > 49: {shop2 > 49}");
        Console.WriteLine($"shop1({shop1.Area}) < shop2({shop2.Area}): {shop1 < shop2}");
        Console.WriteLine($"shop1({shop1.Area}) > shop2({shop2.Area}): {shop1 > shop2}");
        Console.WriteLine($"shop1.Equals(shop2): {shop1.Equals(shop2)}");

        ReadingList list = new ReadingList("My Reading list.");
        list.ShowList();
        Book b1 = new Book("Harry Potter", "J. K. Rowling", ReadingStatus.NotStarted);
        list += b1;
        Book b2 = new Book("Hamlet", "William Shakespeare", ReadingStatus.InProgress);
        list += b2;
        Console.WriteLine();
        list.ShowList();
        list -= b1;
        list.ShowList();
        Console.WriteLine("\"War and peace\" is present: " + list.Contains("War and peace"));
        Console.WriteLine("Indexer test: " + list[0].Author);
    }
}