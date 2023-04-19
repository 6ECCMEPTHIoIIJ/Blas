using Blas.Containers.Base.OneDimension;

namespace Blas.Containers.Base.TwoDimensions;

public interface IRowAccessor<TRow, in T> where TRow : IVectorBase<T>
{
    public TRow LastRow { get; set; }
    
    public TRow FirstRow { get; set; }

    public TRow RowAt(Int32 rowIndex);

    public void SetRow(Int32 rowIndex, IEnumerable<T> row);
}