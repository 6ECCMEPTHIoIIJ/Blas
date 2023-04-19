using System.Collections;
using Blas.Containers.Arithmetical.Base;
using Blas.Containers.Arithmetical.OneDimension;
using Blas.Containers.Base;
using Blas.Containers.Base.OneDimension;
using Blas.Containers.Base.TwoDimensions;

namespace Blas.Containers.Arithmetical.TwoDimensions;

public class ColumnedMatrix<T> : IColumnedMatrix<T>
    where T : System.Numerics.INumber<T>
{
    private readonly IColumnedMatrix<T> _implementation;

    #region Constructors

    public ColumnedMatrix() => _implementation = new ColumnedMatrixImplementation();

    public ColumnedMatrix(IEnumerable<IEnumerable<T>> enumerable)
        => _implementation = new ColumnedMatrixImplementation(enumerable);

    public ColumnedMatrix(Int32 nColumns, Int32 nRows)
        => _implementation = new ColumnedMatrixImplementation(nColumns, nRows);

    #endregion

    public Int32 NRows => _implementation.NRows;

    public Int32 NColumns => _implementation.NColumns;

    public Int32 LastRowIndex => _implementation.LastRowIndex;

    public Int32 LastColumnIndex => _implementation.LastColumnIndex;

    public Boolean IsEmpty => _implementation.IsEmpty;

    public OutputFormatter RowFormatter
    {
        get => _implementation.RowFormatter;
        set => _implementation.RowFormatter = value;
    }

    public OutputFormatter ColumnFormatter
    {
        get => _implementation.ColumnFormatter;
        set => _implementation.ColumnFormatter = value;
    }

    public Func<T, String>? CellDataFormatter
    {
        get => _implementation.CellDataFormatter;
        set => _implementation.CellDataFormatter = value;
    }

    public IVectorBase<T> FirstRow
    {
        get => _implementation.FirstRow;
        set => _implementation.FirstRow = value;
    }

    public IVectorBase<T> LastRow
    {
        get => _implementation.LastRow;
        set => _implementation.LastRow = value;
    }

    public IVectorBase<T> FirstColumn
    {
        get => _implementation.FirstColumn;
        set => _implementation.FirstColumn = value;
    }

    public IVectorBase<T> LastColumn
    {
        get => _implementation.LastColumn;
        set => _implementation.LastColumn = value;
    }

    public IMatrixBase<T> InsertRow(Int32 rowIndex, IEnumerable<T> row) => _implementation.InsertRow(rowIndex, row);

    public IMatrixBase<T> PushBackRow(IEnumerable<T> row) => _implementation.PushBackRow(row);

    public IMatrixBase<T> PushFrontRow(IEnumerable<T> row) => _implementation.PushFrontRow(row);

    public IMatrixBase<T> RemoveRow(Int32 rowIndex) => _implementation.RemoveRow(rowIndex);

    public IMatrixBase<T> PopBackRow() => _implementation.PopBackRow();

    public IMatrixBase<T> PopFrontRow() => _implementation.PopFrontRow();

    public IMatrixBase<T> InsertRowsRange(Int32 rowIndex, IEnumerable<IEnumerable<T>> rows) => _implementation.InsertRowsRange(rowIndex, rows);

    public IMatrixBase<T> PushBackRowsRange(IEnumerable<IEnumerable<T>> rows) => _implementation.PushBackRowsRange(rows);

    public IMatrixBase<T> PushFrontRowsRange(IEnumerable<IEnumerable<T>> rows) => _implementation.PushFrontRowsRange(rows);

    public IMatrixBase<T> RemoveRowsRange(Int32 rowIndex, Int32 nRows) => _implementation.RemoveRowsRange(rowIndex, nRows);

    public IMatrixBase<T> PopBackRowsRange(Int32 nRows) => _implementation.PopBackRowsRange(nRows);

    public IMatrixBase<T> PopFrontRowsRange(Int32 nRows) => _implementation.PopFrontRowsRange(nRows);

    public IMatrixBase<T> SetRow(Int32 rowIndex, IEnumerable<T> row) => _implementation.SetRow(rowIndex, row);

    public IVectorBase<T> RowAt(Int32 rowIndex) => _implementation.RowAt(rowIndex);

    public IMatrixBase<T> SwapRows(Int32 rowIndexLeft, Int32 rowIndexRight) => _implementation.SwapRows(rowIndexLeft, rowIndexRight);

    public IMatrixBase<T> InsertColumn(Int32 columnIndex, IEnumerable<T> column) => _implementation.InsertColumn(columnIndex, column);

    public IMatrixBase<T> PushBackColumn(IEnumerable<T> column) => _implementation.PushBackColumn(column);

    public IMatrixBase<T> PushFrontColumn(IEnumerable<T> column) => _implementation.PushFrontColumn(column);

    public IMatrixBase<T> RemoveColumn(Int32 columnIndex) => _implementation.RemoveColumn(columnIndex);

    public IMatrixBase<T> PopBackColumn() => _implementation.PopBackColumn();

    public IMatrixBase<T> PopFrontColumn() => _implementation.PopFrontColumn();

    public IMatrixBase<T> InsertColumnsRange(Int32 columnIndex, IEnumerable<IEnumerable<T>> columns) => _implementation.InsertColumnsRange(columnIndex, columns);

    public IMatrixBase<T> PushBackColumnsRange(IEnumerable<IEnumerable<T>> columns) => _implementation.PushBackColumnsRange(columns);

    public IMatrixBase<T> PushFrontColumnsRange(IEnumerable<IEnumerable<T>> columns) => _implementation.PushFrontColumnsRange(columns);

    public IMatrixBase<T> RemoveColumnsRange(Int32 columnIndex, Int32 nColumns) => _implementation.RemoveColumnsRange(columnIndex, nColumns);

    public IMatrixBase<T> PopBackColumnsRange(Int32 nColumns) => _implementation.PopBackColumnsRange(nColumns);

    public IMatrixBase<T> PopFrontColumnsRange(Int32 nColumns) => _implementation.PopFrontColumnsRange(nColumns);

    public IMatrixBase<T> SetColumn(Int32 columnIndex, IEnumerable<T> column) => _implementation.SetColumn(columnIndex, column);

    public IVectorBase<T> ColumnAt(Int32 columnIndex) => _implementation.ColumnAt(columnIndex);

    public IMatrixBase<T> SwapColumns(Int32 columnIndexLeft, Int32 columnIndexRight) => _implementation.SwapColumns(columnIndexLeft, columnIndexRight);

    public IMatrixBase<T> ResizeByRows(Int32 nRows) => _implementation.ResizeByRows(nRows);

    public IMatrixBase<T> ResizeByColumns(Int32 nColumns) => _implementation.ResizeByColumns(nColumns);

    public IMatrixBase<T> SetRowFormatter(OutputFormatter rowFormatter) => _implementation.SetRowFormatter(rowFormatter);

    public IMatrixBase<T> SetColumnFormatter(OutputFormatter columnFormatter) => _implementation.SetColumnFormatter(columnFormatter);

    public IArithmeticalContainer<T> Add(IArithmeticalContainer<T> right) => _implementation.Add(right);

    public IArithmeticalContainer<T> Subtract(IArithmeticalContainer<T> right) => _implementation.Subtract(right);

    public IArithmeticalContainer<T> Multiply(T right) => _implementation.Multiply(right);

    public IArithmeticalContainer<T> Divide(T right) => _implementation.Divide(right);

    public IArithmeticalContainer<T> MultiplyElementByElement(IArithmeticalContainer<T> right) => _implementation.MultiplyElementByElement(right);

    public IArithmeticalContainer<T> DivideElementByElement(IArithmeticalContainer<T> right) => _implementation.DivideElementByElement(right);

    public Int32 Rank => _implementation.Rank;

    public T Determinant => _implementation.Determinant;

    public IColumnedVector<T> Multiply(IColumnedVector<T> right) => _implementation.Multiply(right);

    public IMatrix<T> Multiply(IMatrix<T> right) => _implementation.Multiply(right);
    public IMatrix<T>? ToReversed() => _implementation.ToReversed();

    public IEnumerator<IVectorBase<T>> GetEnumerator() => _implementation.GetEnumerator();

    IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();

    public IRowedMatrixBase<T> ToRowed() => _implementation.ToRowed();

    public IVectorBase<T> this[Int32 columnIndex]
    {
        get => _implementation[columnIndex];
        set => _implementation[columnIndex] = value;
    }

    public T this[Int32 columnIndex, Int32 rowIndex]
    {
        get => _implementation[columnIndex, rowIndex];
        set => _implementation[columnIndex, rowIndex] = value;
    }

    public T At(Int32 columnIndex, Int32 rowIndex) => _implementation.At(columnIndex, rowIndex);

    public IColumnedMatrixBase<T> Set(Int32 columnIndex, Int32 rowIndex, T value) => _implementation.Set(columnIndex, rowIndex, value);

    public IColumnedMatrixBase<T> Resize(Int32 nColumns, Int32 nRows) => _implementation.Resize(nColumns, nRows);

    public override String? ToString() => _implementation.ToString();

    #region Implementation

    private class ColumnedMatrixImplementation : ColumnedMatrixBase<T>, IColumnedMatrix<T>
    {
        private static readonly OutputFormatter _rowFormatter = new("[ ", " | ", " ]\n");

        private static readonly OutputFormatter _columnFormatter = new("[ ", " ]\n[ ", " ]\n");

        public ColumnedMatrixImplementation() : base(_rowFormatter, _columnFormatter)
        {
        }

        public ColumnedMatrixImplementation(IEnumerable<IEnumerable<T>> enumerable)
            : base(enumerable, _rowFormatter, _columnFormatter)
        {
        }

        public ColumnedMatrixImplementation(Int32 nColumns, Int32 nRows)
            : base(nColumns, nRows, _rowFormatter, _columnFormatter)
        {
        }

        public IArithmeticalContainer<T> Add(IArithmeticalContainer<T> right) => throw new NotImplementedException();

        public IArithmeticalContainer<T> Subtract(IArithmeticalContainer<T> right) => throw new NotImplementedException();

        public IArithmeticalContainer<T> Multiply(T right) => throw new NotImplementedException();

        public IArithmeticalContainer<T> Divide(T right) => throw new NotImplementedException();

        public IArithmeticalContainer<T> MultiplyElementByElement(IArithmeticalContainer<T> right) => throw new NotImplementedException();

        public IArithmeticalContainer<T> DivideElementByElement(IArithmeticalContainer<T> right) => throw new NotImplementedException();

        public Int32 Rank { get; }
        public T Determinant { get; }
        public IColumnedVector<T> Multiply(IColumnedVector<T> right) => throw new NotImplementedException();

        public IMatrix<T> Multiply(IMatrix<T> right) => throw new NotImplementedException();
        public IMatrix<T>? ToReversed() => throw new NotImplementedException();

        public new IRowedMatrixBase<T> ToRowed() => new RowedMatrix<T>(this);
    }

    #endregion
}