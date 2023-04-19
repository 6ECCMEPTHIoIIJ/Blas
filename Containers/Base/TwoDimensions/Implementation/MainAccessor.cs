using Blas.Containers.Base.OneDimension;

namespace Blas.Containers.Base.TwoDimensions;

public class MainAccessor<TMainDimension, T> :
    IElementAccessor<TMainDimension>
    where TMainDimension : class, IVectorBase<T>, new()
{
    private readonly IVectorBase<IVectorBase<T>> _data;

    public MainAccessor(IVectorBase<IVectorBase<T>> data)
    {
        _data = data;
    }

    public TMainDimension Last
    {
        get => At(_data.IndexLast);
        set => Set(_data.IndexLast, value);
    }

    public TMainDimension First
    {
        get => At(_data.IndexFirst);
        set => Set(_data.IndexFirst, value);
    }

    public TMainDimension At(Int32 index)
    {
        var column = new TMainDimension();
        column.PushBackRange(_data.At(index));

        return column;
    }

    public void Set(Int32 index, TMainDimension value) => _data.Set(index, value);


    public TMainDimension this[Int32 index]
    {
        get => At(index);
        set => Set(index, value);
    }
}