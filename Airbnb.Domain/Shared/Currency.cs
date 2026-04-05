namespace Airbnb.Domain.Shared;

public sealed record Currency
{
    public static readonly Currency Usd = new("USD");
    public static readonly Currency Euro = new("Euro");
    public static readonly Currency Pound = new("GBP");
    internal static readonly Currency None = new("None");
    private Currency(string code) => Code = code;
    
    public string Code { get; init; }

    public static Currency FromCode(string code)
    {
        return All.FirstOrDefault(x => x.Code == code) ??
            throw new ApplicationException("Currency code is invalid");
    }

    public static IReadOnlyList<Currency> All = [Usd, Euro, Pound];
}
