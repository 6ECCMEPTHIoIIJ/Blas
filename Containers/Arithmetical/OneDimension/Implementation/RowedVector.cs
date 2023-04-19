using System.Collections;
using Blas.Containers.Arithmetical.Base;
using Blas.Containers.Arithmetical.TwoDimensions;
using Blas.Containers.Base;
using Blas.Containers.Base.OneDimension;

namespace Blas.Containers.Arithmetical.OneDimension;

public class RowedVector<T> : VectorBase<T>, IRowedVector<T> where T : System.Numerics.INumber<T>
{
    public RowedVector()
    {
        ElementDataFormatter = ArithmeticalContainerElementDataFormatter<T>.Data!;
        Formatter = RowedVectorFormatter.Data;
    }

    public RowedVector(IEnumerable<T> enumerable) : base(enumerable)
    {
        ElementDataFormatter = ArithmeticalContainerElementDataFormatter<T>.Data!;
        Formatter = RowedVectorFormatter.Data;
    }

    public RowedVector(Int32 nElements) : base(nElements)
    {
        ElementDataFormatter = ArithmeticalContainerElementDataFormatter<T>.Data!;
        Formatter = RowedVectorFormatter.Data;
    }

    public IArithmeticalContainer<T> Add(IArithmeticalContainer<T> right) => throw new NotImplementedException();

    public IArithmeticalContainer<T> Subtract(IArithmeticalContainer<T> right) => throw new NotImplementedException();

    public IArithmeticalContainer<T> Multiply(T right) => throw new NotImplementedException();

    public IArithmeticalContainer<T> Divide(T right) => throw new NotImplementedException();

    public IArithmeticalContainer<T> MultiplyElementByElement(IArithmeticalContainer<T> right) => throw new NotImplementedException();

    public IArithmeticalContainer<T> DivideElementByElement(IArithmeticalContainer<T> right) => throw new NotImplementedException();

    static T IRowedVector<T>.operator *(IRowedVector<T> left, IColumnedVector<T> right) => throw new NotImplementedException();

    static IRowedVector<T> IRowedVector<T>.operator *(IRowedVector<T> left, IMatrix<T> right) => throw new NotImplementedException();

    public T Multiply(IColumnedVector<T> right) => throw new NotImplementedException();

    public IRowedVector<T> Multiply(IMatrix<T> right) => throw new NotImplementedException();

    public IColumnedVector<T> ToColumned() => new ColumnedVector<T>(this);
}