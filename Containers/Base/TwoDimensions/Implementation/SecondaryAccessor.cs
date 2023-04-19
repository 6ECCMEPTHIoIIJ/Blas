using Blas.Containers.Base.OneDimension;

namespace Blas.Containers.Base.TwoDimensions;

public class SecondaryAccessor<TSecondaryDimension, T> :
    IElementAccessor<TSecondaryDimension>
    where TSecondaryDimension : class, IVectorBase<T>, new()
{
    private readonly IVectorBase<IVectorBase<T>> _data;

    public SecondaryAccessor(IVectorBase<IVectorBase<T>> data)
    {
        _data = data;
    }


    public TSecondaryDimension Last
    {
        get => At(_data.IndexLast);
        set => Set(_data.IndexLast, value);
    }

    public TSecondaryDimension First 
    {
        get => At(_data.IndexFirst);
        set => Set(_data.IndexFirst, value);
    }

    public TSecondaryDimension At(Int32 columnIndex)
    {
        var column = new TSecondaryDimension();
        for (var rowIndex = 0; rowIndex < _data.NElements; ++rowIndex)
        {
            column.PushBack(_data.At(rowIndex).At(columnIndex));
        }
        
        return column;
    }

    public void Set(Int32 columnIndex, TSecondaryDimension column)
    {
        for (var rowIndex = 0; rowIndex < _data.NElements; ++rowIndex)
        {
            _data.At(rowIndex).Set(columnIndex, column.At(rowIndex));
        }
    }

    public TSecondaryDimension this[Int32 index]
    {
        get => At(index);
        set => Set(index, value);
    }
}