using Blas.Containers.Arithmetical.OneDimension;
using Blas.Containers.Base.TwoDimensions;

namespace Blas.Containers.Arithmetical.TwoDimensions;

public interface IColumnedMatrix<T> : 
    IMatrix<T>, 
    IColumnedMatrixBase<T>
    where T : System.Numerics.INumber<T>
{
}