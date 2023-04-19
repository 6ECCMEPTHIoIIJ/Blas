using System.Numerics;
using Blas.Containers.Arithmetical.Base;
using Blas.Containers.Arithmetical.TwoDimensions;
using Blas.Containers.Base.OneDimension;

namespace Blas.Containers.Arithmetical.OneDimension;

public class ColumnedVector<T> : VectorBase<T>, IColumnedVector<T> where T : INumber<T>
{
    public ColumnedVector()
    {
        ElementDataFormatter = ArithmeticalContainerElementDataFormatter<T>.Data!;
        Formatter = ColumnedVectorFormatter.Data;
    }

    public ColumnedVector(IEnumerable<T> enumerable) : base(enumerable)
    {
        ElementDataFormatter = ArithmeticalContainerElementDataFormatter<T>.Data!;
        Formatter= ColumnedVectorFormatter.Data;
    }

    public ColumnedVector(Int32 nElements) : base(nElements)
    {
        ElementDataFormatter = ArithmeticalContainerElementDataFormatter<T>.Data!;
        Formatter= ColumnedVectorFormatter.Data;
    }

    public IArithmeticalContainer<T> Add(IArithmeticalContainer<T> right) => throw new NotImplementedException();

    public IArithmeticalContainer<T> Subtract(IArithmeticalContainer<T> right) => throw new NotImplementedException();

    public IArithmeticalContainer<T> Multiply(T right) => throw new NotImplementedException();

    public IArithmeticalContainer<T> Divide(T right) => throw new NotImplementedException();

    public IArithmeticalContainer<T> MultiplyElementByElement(IArithmeticalContainer<T> right) =>
        throw new NotImplementedException();

    public IArithmeticalContainer<T> DivideElementByElement(IArithmeticalContainer<T> right) =>
        throw new NotImplementedException();

    static IMatrix<T> IColumnedVector<T>.operator *(IColumnedVector<T> left, IRowedVector<T> right) =>
        throw new NotImplementedException();

    public IMatrix<T> Multiply(IRowedVector<T> right) => throw new NotImplementedException();

    public IRowedVector<T> ToRowed() => new RowedVector<T>(this);
}