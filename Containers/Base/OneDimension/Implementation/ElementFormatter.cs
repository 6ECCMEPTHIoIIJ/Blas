using System.Text;

namespace Blas.Containers.Base.OneDimension;

public class ElementFormatter<T> : IElementFormatter<T>
{
    private readonly IList<T> _data;

    public ElementFormatter(IList<T> data)
    {
        _data = data;
    }

    public OutputFormatter Formatter { get; set; } = new();

    public Func<T, String> ElementDataFormatter { get; set; } = arg => arg?.ToString() ?? String.Empty;

    public override String ToString()
    {
        Int32 elementLength = _data.Max(el => ElementDataFormatter(el).Length);
        var formattedCell = $"{{0, {elementLength}}}";
        var stringBuilder = new StringBuilder();

        stringBuilder.Append(Formatter.Prefix);
        for (var index = 0; index < _data.Count; ++index)
        {
            stringBuilder.AppendFormat(formattedCell, ElementDataFormatter(_data[index]));
            stringBuilder.Append(index == _data.Count - 1
                ? Formatter.Suffix
                : Formatter.Separator);
        }

        return stringBuilder.ToString();
    }
}