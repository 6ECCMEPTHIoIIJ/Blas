namespace Blas.Containers.Base.OneDimension;

public class ElementInserter<T> : IElementInserter<T>
{
    private readonly IList<T> _data;

    public ElementInserter(IList<T> data) => _data = data;

    public void Insert(Int32 index, T element) => _data.Insert(index, element);

    public void PushBack(T element) => Insert(_data.Count, element);

    public void PushFront(T element) => Insert(0, element);

    public void InsertRange(Int32 index, IEnumerable<T> elements)
    {
        elements = elements.Reverse();
        foreach (T element in elements)
        {
            Insert(index, element);
        }
    }

    public void PushBackRange(IEnumerable<T> elements) => InsertRange(_data.Count, elements);

    public void PushFrontRange(IEnumerable<T> elements) => InsertRange(0, elements);

    public void Remove(Int32 index) => _data.RemoveAt(index);

    public void PopBack() => Remove(_data.Count - 1);

    public void PopFront() => Remove(0);

    public void RemoveRange(Int32 index, Int32 nElements)
    {
        for (var _ = 0; _ < nElements; ++_)
        {
            Remove(index);
        }
    }

    public void PopBackRange(Int32 nElements) => RemoveRange(_data.Count - nElements - 1, nElements);

    public void PopFrontRange(Int32 nElements) => RemoveRange(0, nElements);
}