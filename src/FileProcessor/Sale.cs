namespace FileProcessor;

public record Sale
{
    private static readonly string[] DateFormats = { "MM/dd/yyyy", "M/dd/yyyy", "MM/d/yyyy", "M/d/yyyy" };

    public string? Region { get; init; }
    public string? Country { get; init; }
    public string? ItemType { get; init; }
    public DateOnly OrderDate { get; init; }
    public string? OrderID { get; init; }
    public decimal TotalCost { get; init; }

    public static Sale Map(string line)
    {
        var values = line.Split(",");

        return new Sale
        {
            Region = values[0],
            Country = values[1],
            ItemType = values[2],
            OrderDate = DateOnly.ParseExact(values[5], DateFormats),
            OrderID = values[6],
            TotalCost = decimal.Parse(values[12])
        };
    }
}