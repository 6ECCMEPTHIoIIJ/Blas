namespace Blas.Containers.Base.TwoDimensions;

public interface IColumnInserter<in T>
{
    public void InsertColumn(Int32 columnIndex, IEnumerable<T> column);
    
    public void PushBackColumn(IEnumerable<T> columnIndex);
    
    public void PushFrontColumn(IEnumerable<T> columnIndex);
    
    public void InsertColumnsRange(Int32 columnIndex, IEnumerable<IEnumerable<T>> columns);
    
    public void PushBackColumnsRange(IEnumerable<IEnumerable<T>> columns);
    
    public void PushFrontColumnsRange(IEnumerable<IEnumerable<T>> columns);

    public void RemoveColumn(Int32 columnIndex);
    
    public void PopBackColumn();
    
    public void PopFrontColumn();

    public void RemoveColumnsRange(Int32 columnIndex, Int32 nColumns);
    
    public void PopBackColumnsRange(Int32 nColumns);
    
    public void PopFrontColumnsRange(Int32 nColumns);
}