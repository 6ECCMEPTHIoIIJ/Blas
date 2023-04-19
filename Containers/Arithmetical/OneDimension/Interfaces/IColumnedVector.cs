using Blas.Containers.Arithmetical.TwoDimensions;

namespace Blas.Containers.Arithmetical.OneDimension;

public interface IColumnedVector<T> : IVector<T> where T : System.Numerics.INumber<T>
{
    public static abstract IMatrix<T> operator *(IColumnedVector<T> left, IRowedVector<T> right);
    
    public IMatrix<T> Multiply(IRowedVector<T> right);
    
    public IRowedVector<T> ToRowed();
}