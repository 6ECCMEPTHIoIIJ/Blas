using System.Collections;

namespace Blas.Containers.Base.OneDimension;

public class VectorBase<T> : IVectorBase<T>
{
    private readonly ElementAccessor<T> _elementAccessor;
    private readonly ElementFormatter<T> _elementFormatter;
    private readonly ElementInserter<T> _elementInserter;
    private readonly OneDimensionContainer<T> _oneDimensionContainer;

    public VectorBase()
    {
        List<T> data = new();
        _elementAccessor = new ElementAccessor<T>(data);
        _elementFormatter = new ElementFormatter<T>(data);
        _elementInserter = new ElementInserter<T>(data);
        _oneDimensionContainer = new OneDimensionContainer<T>(data);
    }

    public VectorBase(IEnumerable<T> enumerable) : this()
    {
        PushBackRange(enumerable);
    }

    public VectorBase(Int32 nElements) : this()
    {
        Resize(nElements);
    }

    public T Last
    {
        get => _elementAccessor.Last;
        set => _elementAccessor.Last = value;
    }

    public T First
    {
        get => _elementAccessor.First;
        set => _elementAccessor.First = value;
    }

    public T At(Int32 index) => _elementAccessor.At(index);

    public void Set(Int32 index, T value) => _elementAccessor.Set(index, value);

    public T this[Int32 index]
    {
        get => _elementAccessor[index];
        set => _elementAccessor[index] = value;
    }

    public OutputFormatter Formatter
    {
        get => _elementFormatter.Formatter;
        set => _elementFormatter.Formatter = value;
    }

    public Func<T, String> ElementDataFormatter
    {
        get => _elementFormatter.ElementDataFormatter;
        set => _elementFormatter.ElementDataFormatter = value;
    }

    public void Insert(Int32 index, T element) => _elementInserter.Insert(index, element);

    public void PushBack(T element) => _elementInserter.PushBack(element);

    public void PushFront(T element) => _elementInserter.PushFront(element);

    public void InsertRange(Int32 index, IEnumerable<T> elements) => _elementInserter.InsertRange(index, elements);

    public void PushBackRange(IEnumerable<T> elements) => _elementInserter.PushBackRange(elements);

    public void PushFrontRange(IEnumerable<T> elements) => _elementInserter.PushFrontRange(elements);

    public void Remove(Int32 index) => _elementInserter.Remove(index);

    public void PopBack() => _elementInserter.PopBack();

    public void PopFront() => _elementInserter.PopFront();

    public void RemoveRange(Int32 index, Int32 nElements) => _elementInserter.RemoveRange(index, nElements);

    public void PopBackRange(Int32 nElements) => _elementInserter.PopBackRange(nElements);

    public void PopFrontRange(Int32 nElements) => _elementInserter.PopFrontRange(nElements);

    IEnumerator IEnumerable.GetEnumerator() => ((IEnumerable)_oneDimensionContainer).GetEnumerator();

    public IEnumerator<T> GetEnumerator() => _oneDimensionContainer.GetEnumerator();

    public Int32 NElements => _oneDimensionContainer.NElements;

    public Int32 IndexLast => _oneDimensionContainer.IndexLast;

    public Int32 IndexFirst => _oneDimensionContainer.IndexFirst;

    public void Resize(Int32 nElements) => _oneDimensionContainer.Resize(nElements);

    public override String ToString() => _elementFormatter.ToString();
}