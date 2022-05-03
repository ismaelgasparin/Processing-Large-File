namespace FileProcessor;

public static class Version1
{
    public static IEnumerable<Sale> Read()
    {
        var lines = File.ReadAllLines("sales.csv");

        var sales = new List<Sale>();

        for (var i = 1; i < lines.Length; i++)
        {
            var line = lines[i];
            
            var sale = Sale.Map(line);

            sales.Add(sale);
        }

        return sales;
    }
}