using Blas.Containers.Base.OneDimension;

namespace Blas.Containers.Base.TwoDimensions;

public interface IColumnedMatrixBase<TRow, TColumn, T> : 
    IRowAccessor<TRow, T>,
    IColumnAccessor<TColumn, T>,
    IRowInserter<T>,
    IColumnInserter<T>,
    IRowFormatter<T>,
    IColumnFormatter<T>,
    IEnumerable<TColumn>
    where TColumn : IVectorBase<T>
    where TRow : IVectorBase<T>
{
    public IRowedMatrixBase<TRow, TColumn, T> ToRowed();
    
    public TColumn this[Int32 columnIndex] { get; set; }
    
    public T this[Int32 columnIndex, Int32 rowIndex]{ get; set; }

    public T At(Int32 columnIndex, Int32 rowIndex);

    public void Set(Int32 columnIndex, Int32 rowIndex, T value);

    public void Resize(Int32 nColumns, Int32 nRows);
}