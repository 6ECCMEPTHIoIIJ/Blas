using System.Collections;
using System.Text;
using Blas.Containers.Base.OneDimension;

namespace Blas.Containers.Base.TwoDimensions;

public class RowedMatrixBase<TColumn, TRow, T> :
    IRowedMatrixBase<TRow, TColumn, T>
    where TColumn : IVectorBase<T>
    where TRow : IVectorBase<T>
{
}