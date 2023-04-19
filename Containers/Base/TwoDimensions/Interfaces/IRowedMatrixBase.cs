using Blas.Containers.Base.OneDimension;

namespace Blas.Containers.Base.TwoDimensions;

public interface IRowedMatrixBase<TRow, TColumn, T> :
    IRowAccessor<TRow, T>,
    IColumnAccessor<TColumn, T>,
    IRowInserter<T>,
    IColumnInserter<T>,
    IRowFormatter<T>,
    IColumnFormatter<T>,
    IEnumerable<TRow>
    where TColumn : IVectorBase<T>
    where TRow : IVectorBase<T>
{
    public IColumnedMatrixBase<TRow, TColumn, T> ToColumned();

    public TRow this[Int32 rowIndex] { get; set; }

    public T this[Int32 rowIndex, Int32 columnIndex] { get; set; }

    public T At(Int32 rowIndex, Int32 columnIndex);

    public void Set(Int32 rowIndex, Int32 columnIndex, T value);

    public void Resize(Int32 nRows, Int32 nColumns);
}