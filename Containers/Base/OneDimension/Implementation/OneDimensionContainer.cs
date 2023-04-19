using System.Collections;

namespace Blas.Containers.Base.OneDimension;

public class OneDimensionContainer<T> : IOneDimensionContainer<T>
{
    private readonly IList<T> _data;

    public OneDimensionContainer(IList<T> data) => _data = data;

    public IEnumerator<T> GetEnumerator() => _data.GetEnumerator();

    IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();

    public Int32 NElements => _data.Count;

    public Int32 IndexLast => NElements - 1;

    public Int32 IndexFirst => 0;

    public void Resize(Int32 nElements)
    {
        while (nElements > NElements)
        {
            _data.Insert(IndexLast, default!);
        }

        while (nElements < NElements)
        {
            _data.RemoveAt(IndexLast);
        }
    }
}