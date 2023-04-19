using Blas.Containers.Base.OneDimension;

namespace Blas.Containers.Base.TwoDimensions;

public class ColumnMainAccessor<TColumn, T> :
    IColumnAccessor<TColumn, T>
    where TColumn : class, IVectorBase<T>, new()
{
    private readonly MainAccessor<TColumn, T> _accessor;

    public ColumnMainAccessor(IVectorBase<IVectorBase<T>> data)
    {
        _accessor = new MainAccessor<TColumn, T>(data);
    }

    public TColumn LastColumn
    {
        get => _accessor.Last;
        set => _accessor.Last = value;
    }

    public TColumn FirstColumn
    {
        get => _accessor.First;
        set => _accessor.First = value;
    }

    public TColumn ColumnAt(Int32 columnIndex) => _accessor.At(columnIndex);

    public void SetColumn(Int32 columnIndex, IEnumerable<T> column)
    {
        var newColumn = new TColumn();
        newColumn.PushBackRange(column);
        _accessor.Set(columnIndex, newColumn);
    }
}