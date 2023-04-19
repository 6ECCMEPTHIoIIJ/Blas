using System.Collections;
using Blas.Containers.Base.OneDimension;

namespace Blas.Containers.Base.TwoDimensions;

public interface ITwoDimensionsContainer<T> :
    IEnumerable<IVectorBase<T>>
{
    public Int32 NRows { get; }

    public Int32 NColumns { get; }

    public Int32 RowIndexLast { get; }

    public Int32 RowIndexFirst { get; }

    public Int32 ColumnIndexLast { get; }

    public Int32 ColumnIndexFirst { get; }

    public void ResizeColumns(Int32 nColumns);

    public void ResizeRows(Int32 nRows);
}