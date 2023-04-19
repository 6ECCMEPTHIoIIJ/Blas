using Blas.Containers.Base.OneDimension;

namespace Blas.Containers.Base.TwoDimensions;

public interface IColumnAccessor<TColumn, in T> where TColumn : IVectorBase<T>
{
    public TColumn LastColumn { get; set; }
    
    public TColumn FirstColumn { get; set; }

    public TColumn ColumnAt(Int32 columnIndex);

    public void SetColumn(Int32 columnIndex, IEnumerable<T> column);
}