using Blas.Containers.Arithmetical.TwoDimensions;

namespace Blas.Containers.Arithmetical.OneDimension;

public interface IRowedVector<T> : IVector<T> where T : System.Numerics.INumber<T>
{
    public static abstract T operator *(IRowedVector<T> left, IColumnedVector<T> right);

    public static abstract IRowedVector<T> operator *(IRowedVector<T> left, IMatrix<T> right);

    public T Multiply(IColumnedVector<T> right);

    public IRowedVector<T> Multiply(IMatrix<T> right);

    public IColumnedVector<T> ToColumned();
}