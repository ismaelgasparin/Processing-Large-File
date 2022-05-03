namespace FileProcessor;

public static class Program
{
    public static void Main()
    {
        var start = DateTime.Now;

        var sales = Version3.Read();

        var salesAsia = sales
            .Where(s => s.Region == "Asia")
            .Where(s => s.TotalCost > 50000);

        var count = Database.Save(salesAsia);

        var ms = (int)(DateTime.Now - start).TotalMilliseconds;

        Console.WriteLine($"{count} sales processed in {ms}ms!");
    }
}