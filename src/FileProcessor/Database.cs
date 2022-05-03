namespace FileProcessor;

public static class Database
{
    public static int Save(IEnumerable<Sale> sales)
    {
        var count = 0;

        foreach (var sale in sales)
        {
            // saves in database
            count++;
        }

        return count;
    }
}