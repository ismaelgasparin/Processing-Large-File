namespace FileProcessor;

public static class Version2
{
    public static IEnumerable<Sale> Read()
    {
        using var file = File.OpenRead("sales.csv");
        using var sr = new StreamReader(file);
        var sales = new List<Sale>();

        while (!sr.EndOfStream)
        {
            var line = sr.ReadLine();
            if (line is null || line.StartsWith("Region")) continue;

            var sale = Sale.Map(line);

            sales.Add(sale);
        }

        return sales;
    }
}