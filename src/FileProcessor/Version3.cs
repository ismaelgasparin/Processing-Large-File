namespace FileProcessor;

public static class Version3
{
    public static IEnumerable<Sale> Read()
    {
        using var file = File.OpenRead("sales.csv");
        using var sr = new StreamReader(file);

        while (!sr.EndOfStream)
        {
            var line = sr.ReadLine();
            if (line is null || line.StartsWith("Region")) continue;

            yield return Sale.Map(line);
        }
    }
}