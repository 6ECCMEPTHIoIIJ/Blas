using System.Collections;
using System.Text;
using Blas.Containers.Base.OneDimension;

namespace Blas.Containers.Base.TwoDimensions;

public class ColumnedMatrixBase<TRow, TColumn, T> : 
    IColumnedMatrixBase<TRow, TColumn, T>
    where TColumn : IVectorBase<T>
    where TRow : IVectorBase<T>
{
    
}