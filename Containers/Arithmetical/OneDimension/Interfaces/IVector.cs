using Blas.Containers.Arithmetical.Base;
using Blas.Containers.Base.OneDimension;

namespace Blas.Containers.Arithmetical.OneDimension;

public interface IVector<T> :
    IVectorBase<T>,
    IArithmeticalContainer<T>
    where T : System.Numerics.INumber<T>
{
    
}