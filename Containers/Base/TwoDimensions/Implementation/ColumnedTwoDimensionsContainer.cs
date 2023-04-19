using System.Collections;
using Blas.Containers.Base.OneDimension;

namespace Blas.Containers.Base.TwoDimensions;

public class ColumnedTwoDimensionsContainer<T> :
    ITwoDimensionsContainer<T>
{
    private readonly IVectorBase<IVectorBase<T>> _data;

    public ColumnedTwoDimensionsContainer(IVectorBase<IVectorBase<T>> data)
    {
        _data = data;
    }

    public IEnumerator<IVectorBase<T>> GetEnumerator() => _data.GetEnumerator();

    IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();

    public Int32 NRows => NColumns == 0 ? 0 : _data[0].NElements;
    
    public Int32 NColumns => _data.NElements;
    
    public Int32 RowIndexLast => NRows - 1;

    public Int32 RowIndexFirst => 0;

    public Int32 ColumnIndexLast => NColumns - 1;

    public Int32 ColumnIndexFirst => 0;

    public void ResizeColumns(Int32 nColumns) => _data.Resize(nColumns);

    public void ResizeRows(Int32 nRows)
    {
        for (var columnIndex = 0; columnIndex < NColumns; ++columnIndex)
        {
            // ReSharper disable once NullCoalescingConditionIsAlwaysNotNullAccordingToAPIContract
            _data[columnIndex] ??= new VectorBase<T>();
            _data[columnIndex].Resize(nRows);
        }
    }
}