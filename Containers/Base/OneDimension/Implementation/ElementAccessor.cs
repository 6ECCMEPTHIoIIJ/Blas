namespace Blas.Containers.Base.OneDimension;

public class ElementAccessor<T> : IElementAccessor<T>
{
    private readonly IList<T> _data;

    public T Last
    {
        get => At(_data.Count - 1);
        set => Set(_data.Count - 1, value);
    }

    public T First
    {
        get => At(0);
        set => Set(0, value);
    }

    public ElementAccessor(IList<T> data)
    {
        _data = data;
    }

    public T At(Int32 index) => _data[index];

    public void Set(Int32 index, T value) => _data[index] = value;

    public T this[Int32 index]
    {
        get => At(index);
        set => Set(index, value);
    }
}