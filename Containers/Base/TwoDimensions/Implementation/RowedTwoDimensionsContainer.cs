using System.Collections;
using System.Data;
using Blas.Containers.Base.OneDimension;

namespace Blas.Containers.Base.TwoDimensions;

public class RowedTwoDimensionsContainer<T> :
    ITwoDimensionsContainer<T>
{
    private readonly IVectorBase<IVectorBase<T>> _data;

    public RowedTwoDimensionsContainer(IVectorBase<IVectorBase<T>> data)
    {
        _data = data;
    }

    public IEnumerator<IVectorBase<T>> GetEnumerator() => _data.GetEnumerator();

    IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();

    public Int32 NRows => _data.NElements;
    
    public Int32 NColumns => NRows == 0 ? 0 : _data[0].NElements;

    public Int32 RowIndexLast => NRows - 1;

    public Int32 RowIndexFirst => 0;

    public Int32 ColumnIndexLast => NColumns - 1;

    public Int32 ColumnIndexFirst => 0;

    public void ResizeColumns(Int32 nColumns)
    {
        for (var rowIndex = 0; rowIndex < NRows; ++rowIndex)
        {
            // ReSharper disable once NullCoalescingConditionIsAlwaysNotNullAccordingToAPIContract
            _data[rowIndex] ??= new VectorBase<T>();
            _data[rowIndex].Resize(nColumns);
        }
    }

    public void ResizeRows(Int32 nRows) => _data.Resize(nRows);
}