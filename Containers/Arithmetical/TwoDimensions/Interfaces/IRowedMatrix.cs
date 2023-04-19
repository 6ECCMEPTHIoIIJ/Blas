using Blas.Containers.Arithmetical.OneDimension;
using Blas.Containers.Base.TwoDimensions;

namespace Blas.Containers.Arithmetical.TwoDimensions;

public interface IRowedMatrix<T> : 
    IMatrix<T>, 
    IRowedMatrixBase<T>
    where T : System.Numerics.INumber<T>
{
}