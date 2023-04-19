using Blas.Containers.Base.OneDimension;

namespace Blas.Containers.Base.TwoDimensions;

public interface IRowInserter<in T>
{
    public void InsertRow(Int32 rowIndex, IEnumerable<T> row);
    
    public void PushBackRow(IEnumerable<T> row);
    
    public void PushFrontRow(IEnumerable<T> row);
    
    public void InsertRowsRange(Int32 rowIndex, IEnumerable<IEnumerable<T>> rows);
    
    public void PushBackRowsRange(IEnumerable<IEnumerable<T>> rows);
    
    public void PushFrontRowsRange(IEnumerable<IEnumerable<T>> rows);

    public void RemoveRow(Int32 rowIndex);
    
    public void PopBackRow();
    
    public void PopFrontRow();

    public void RemoveRowsRange(Int32 rowIndex, Int32 nRows);
    
    public void PopBackRowsRange(Int32 nRows);
    
    public void PopFrontRowsRange(Int32 nRows);
}