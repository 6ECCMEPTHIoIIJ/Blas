namespace Blas.Containers.Base.OneDimension;

public interface IElementInserter<in T>
{
    public void Insert(Int32 index, T element);
    
    public void PushBack(T element);
    
    public void PushFront(T element);
    
    public void InsertRange(Int32 index, IEnumerable<T> elements);
    
    public void PushBackRange(IEnumerable<T> elements);
    
    public void PushFrontRange(IEnumerable<T> elements);

    public void Remove(Int32 index);
    
    public void PopBack();
    
    public void PopFront();

    public void RemoveRange(Int32 index, Int32 nElements);
    
    public void PopBackRange(Int32 nElements);
    
    public void PopFrontRange(Int32 nElements);
}