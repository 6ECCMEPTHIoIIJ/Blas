using Blas.Containers.Base.OneDimension;

namespace Blas.Containers.Base.TwoDimensions;

public interface ITwoDimensionFormatter<T>
{
    public OutputFormatter RowFormatter { get; set; }
    
    public OutputFormatter ColumnFormatter { get; set; }
    
    public Func<T, String> ElementDataFormatter { get; set; }
}