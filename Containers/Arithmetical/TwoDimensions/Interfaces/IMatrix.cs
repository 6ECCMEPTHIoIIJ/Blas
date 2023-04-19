using System.Collections;
using Blas.Containers.Arithmetical.Base;
using Blas.Containers.Arithmetical.OneDimension;
using Blas.Containers.Base.TwoDimensions;

namespace Blas.Containers.Arithmetical.TwoDimensions;

public interface IMatrix<T> :
    IMatrixBase<T>,
    IArithmeticalContainer<T>
    where T : System.Numerics.INumber<T>
{
    public Int32 Rank { get; }

    public T Determinant { get;  }
    
    public static IColumnedVector<T> operator *(IMatrix<T> left, IColumnedVector<T> right)
        => left.Multiply(right);

    public static IMatrix<T> operator *(IMatrix<T> left, IMatrix<T> right)
        => left.Multiply(right);

    public IColumnedVector<T> Multiply(IColumnedVector<T> right);

    public IMatrix<T> Multiply(IMatrix<T> right);

    public IMatrix<T>? ToReversed();
}