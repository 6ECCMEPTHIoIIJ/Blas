using Blas.Containers.Base.OneDimension;

namespace Blas.Containers.Base.TwoDimensions;

public class RowSecondaryInserter<T>: IRowInserter<T>
{
    private readonly SecondaryInserter<T> _inserter;

    public RowSecondaryInserter(IVectorBase<IVectorBase<T>> data)
    {
        _inserter = new SecondaryInserter<T>(data);
    }


    public void InsertRow(Int32 rowIndex, IEnumerable<T> row) => _inserter.Insert(rowIndex, row);

    public void PushBackRow(IEnumerable<T> row) => _inserter.PushBack(row);

    public void PushFrontRow(IEnumerable<T> row) => _inserter.PushFront(row);

    public void InsertRowsRange(Int32 rowIndex, IEnumerable<IEnumerable<T>> rows) =>
        _inserter.InsertRange(rowIndex, rows);

    public void PushBackRowsRange(IEnumerable<IEnumerable<T>> rows) => _inserter.PushBackRange(rows);

    public void PushFrontRowsRange(IEnumerable<IEnumerable<T>> rows) => _inserter.PushFrontRange(rows);

    public void RemoveRow(Int32 rowIndex) => _inserter.Remove(rowIndex);

    public void PopBackRow() => _inserter.PopBack();

    public void PopFrontRow() => _inserter.PopFront();

    public void RemoveRowsRange(Int32 rowIndex, Int32 nRows) => _inserter.RemoveRange(rowIndex, nRows);

    public void PopBackRowsRange(Int32 nRows) => _inserter.PopBackRange(nRows);

    public void PopFrontRowsRange(Int32 nRows) => _inserter.PopFrontRange(nRows);
}