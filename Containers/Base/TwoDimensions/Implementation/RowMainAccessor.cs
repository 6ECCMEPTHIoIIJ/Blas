using Blas.Containers.Base.OneDimension;

namespace Blas.Containers.Base.TwoDimensions;

public class RowMainAccessor<TRow, T> :
    IRowAccessor<TRow, T>
    where TRow : class, IVectorBase<T>, new()
{
    private readonly MainAccessor<TRow, T> _accessor;

    public RowMainAccessor(IVectorBase<IVectorBase<T>> data)
    {
        _accessor = new MainAccessor<TRow, T>(data);
    }

    public TRow LastRow
    {
        get => _accessor.Last;
        set => _accessor.Last = value;
    }

    public TRow FirstRow
    {
        get => _accessor.First;
        set => _accessor.First = value;
    }

    public TRow RowAt(Int32 rowIndex)  => _accessor.At(rowIndex);

    public void SetRow(Int32 rowIndex, IEnumerable<T> row)   
    {
        var newRow = new TRow();
        newRow.PushBackRange(newRow);
        _accessor.Set(rowIndex, newRow);
    }
}