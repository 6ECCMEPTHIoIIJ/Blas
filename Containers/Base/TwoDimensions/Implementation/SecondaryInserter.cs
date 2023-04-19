using Blas.Containers.Base.OneDimension;

namespace Blas.Containers.Base.TwoDimensions;

public class SecondaryInserter<T> :
    IElementInserter<IEnumerable<T>>
{
    private readonly IVectorBase<IVectorBase<T>> _data;

    public SecondaryInserter(IVectorBase<IVectorBase<T>> data)
    {
        _data = data;
    }

    public void Insert(Int32 index, IEnumerable<T> element)
    {
        T[] newElement = element.ToArray();
        for (var secondaryIndex = 0; secondaryIndex < newElement.Length; ++secondaryIndex)
        {
            _data.At(secondaryIndex).Insert(index, newElement[secondaryIndex]);
        }
    }

    public void PushBack(IEnumerable<T> element) => Insert(_data.NElements, element);

    public void PushFront(IEnumerable<T> element) => Insert(_data.IndexFirst, element);

    public void InsertRange(Int32 index, IEnumerable<IEnumerable<T>> elements)
    {
        elements = elements.Reverse();
        foreach (IEnumerable<T> element in elements)
        {
            Insert(index, element);
        }
    }

    public void PushBackRange(IEnumerable<IEnumerable<T>> elements) => InsertRange(_data.NElements, elements);

    public void PushFrontRange(IEnumerable<IEnumerable<T>> elements) => InsertRange(_data.IndexFirst, elements);
    public void Remove(Int32 index) => _data.Remove(index);

    public void PopBack() => _data.PopBack();

    public void PopFront() => _data.PopFront();

    public void RemoveRange(Int32 index, Int32 nElements) => _data.RemoveRange(index, nElements);

    public void PopBackRange(Int32 nElements) => _data.PopBackRange(nElements);

    public void PopFrontRange(Int32 nElements) => _data.PopFrontRange(nElements);
}