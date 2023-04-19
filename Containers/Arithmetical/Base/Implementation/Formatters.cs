using System.Globalization;
using System.Numerics;
using Blas.Containers.Base;

namespace Blas.Containers.Arithmetical.Base;

internal static class ArithmeticalContainerElementDataFormatter<T> where T : INumber<T>
{
    public static readonly Func<T, String>? Data = number =>
    {
        return number switch
        {
            Decimal decimalNumber => Math.Round(decimalNumber, 3).ToString(CultureInfo.InvariantCulture),
            Double doubleNumber => Math.Round(doubleNumber, 3).ToString(CultureInfo.InvariantCulture),
            Single singleNumber => Math.Round(singleNumber, 3).ToString(CultureInfo.InvariantCulture),
            _ => number.ToString()
        } ?? String.Empty;
    };
}

internal static class ColumnedVectorFormatter
{
    public static readonly OutputFormatter Data = new("[ ", " ]\n[ ", " ]\n");
}

internal static class RowedVectorFormatter
{
    public static readonly OutputFormatter Data = new("[ ", " | ", " ]\n");
}