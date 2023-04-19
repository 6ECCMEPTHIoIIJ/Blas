using Blas.Containers.Base.OneDimension;

namespace Blas.Containers.Base.TwoDimensions;

public class ColumnSecondaryInserter<T> : IColumnInserter<T>
{
    private readonly SecondaryInserter<T> _inserter;

    public ColumnSecondaryInserter(IVectorBase<IVectorBase<T>> data)
    {
        _inserter = new SecondaryInserter<T>(data);
    }

    public void InsertColumn(Int32 columnIndex, IEnumerable<T> column) => _inserter.Insert(columnIndex, column);

    public void PushBackColumn(IEnumerable<T> column) => _inserter.PushBack(column);

    public void PushFrontColumn(IEnumerable<T> column) => _inserter.PushFront(column);

    public void InsertColumnsRange(Int32 columnIndex, IEnumerable<IEnumerable<T>> columns) =>
        _inserter.InsertRange(columnIndex, columns);

    public void PushBackColumnsRange(IEnumerable<IEnumerable<T>> columns) => _inserter.PushBackRange(columns);

    public void PushFrontColumnsRange(IEnumerable<IEnumerable<T>> columns) => _inserter.PushFrontRange(columns);

    public void RemoveColumn(Int32 columnIndex) => _inserter.Remove(columnIndex);

    public void PopBackColumn() => _inserter.PopBack();

    public void PopFrontColumn() => _inserter.PopFront();

    public void RemoveColumnsRange(Int32 columnIndex, Int32 nColumns) => _inserter.RemoveRange(columnIndex, nColumns);

    public void PopBackColumnsRange(Int32 nColumns) => _inserter.PopBackRange(nColumns);

    public void PopFrontColumnsRange(Int32 nColumns) => _inserter.PopFrontRange(nColumns);
}