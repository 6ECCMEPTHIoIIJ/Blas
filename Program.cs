using System.Drawing;
using System.Globalization;
using System.Numerics;
using Blas.Containers.Arithmetical.Base;
using Blas.Containers.Arithmetical.OneDimension;
using Blas.Containers.Arithmetical.TwoDimensions;
using Blas.Containers.Base;
using Blas.Containers.Base.OneDimension;
using Blas.Containers.Base.TwoDimensions;

namespace Blas;

internal static class Program
{
    public static void Main(String[] args)
    {
        // var v = new VerticalVector<int>(new []{1, 2, 3, 4, 5}).Resize(2).Set(0, 8);
        // Console.Write(v);
        // var m = (new VerticalVector<int>(v) * new HorizontalVector<int>(v))
        //     .PushBackColumnsRange(new RowedMatrix<int>(1, 2))
        //     .PushBackRowsRange(new RowedMatrix<int>(2, 3));
        // Console.Write(m);
        // m.RowAt(2).PopBack();
        // Console.Write(m.SwapColumns(1, 2));
        // var v = new ColumnedVector<Int32>(new[]{1, 2, 3});
        // var x = new ColumnedVector<Single>(new []{1f, 2.43f})
        // {
        //     [1] = 3
        // };
        // var m = new RowedMatrix<Int32>(5, 6);
        // Console.Write(m.ToColumned());
        // Console.Write(v);
        // Console.Write(x.ToRowed());

        var g = new ColumnedVector<Single>();
        g.PushBackRange(new[]{1.14124f, 2.235143f, 3.000f, 4.41324f});
        g.PushFront(7);
        Console.Write(g);
        Console.Write(g.ToRowed());
    }
}