using System.Globalization;

namespace BlazingPizza;

/// <summary>
/// Single place that controls how prices are displayed (currency symbol and format).
/// Change the culture here to change the currency everywhere.
/// </summary>
public static class PriceFormatter
{
    private static readonly CultureInfo Culture = new("en-US");

    public static string Format(decimal price) => price.ToString("C", Culture);
}
