using Blas.Containers.Base.OneDimension;

namespace Blas.Containers.Base.TwoDimensions;

public interface IColumnFormatter<T> : IElementFormatter<T>
{
    public OutputFormatter ColumnFormatter { get; set; }
}