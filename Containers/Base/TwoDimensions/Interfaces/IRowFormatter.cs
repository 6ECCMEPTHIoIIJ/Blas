using Blas.Containers.Base.OneDimension;

namespace Blas.Containers.Base.TwoDimensions;

public interface IRowFormatter<T> : IElementFormatter<T>
{
    public OutputFormatter RowFormatter { get; set; }
}