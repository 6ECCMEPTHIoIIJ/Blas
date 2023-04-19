using System.Collections;

namespace Blas.Containers.Arithmetical.Base;

public interface IArithmeticalContainer<T> where T : System.Numerics.INumber<T>
{
    public static virtual IArithmeticalContainer<T> operator +(IArithmeticalContainer<T> left,
        IArithmeticalContainer<T> right) => left.Add(right);

    public static virtual IArithmeticalContainer<T> operator -(IArithmeticalContainer<T> left,
        IArithmeticalContainer<T> right) => left.Subtract(right);

    public static virtual IArithmeticalContainer<T> operator *(T left, IArithmeticalContainer<T> right) 
        => right.Multiply(left);

    public static virtual IArithmeticalContainer<T> operator *(IArithmeticalContainer<T> left, T right)
        => left.Multiply(right);

    public static virtual IArithmeticalContainer<T> operator /(IArithmeticalContainer<T> left, T right)
        => left.Divide(right);

    public IArithmeticalContainer<T> Add(IArithmeticalContainer<T> right);

    public IArithmeticalContainer<T> Subtract(IArithmeticalContainer<T> right);

    public IArithmeticalContainer<T> Multiply(T right);

    public IArithmeticalContainer<T> Divide(T right);

    public IArithmeticalContainer<T> MultiplyElementByElement(IArithmeticalContainer<T> right);

    public IArithmeticalContainer<T> DivideElementByElement(IArithmeticalContainer<T> right);
}