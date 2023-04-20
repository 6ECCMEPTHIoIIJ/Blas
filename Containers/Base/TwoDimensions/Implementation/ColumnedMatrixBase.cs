using System.Collections;
using System.Text;
using Blas.Containers.Base.OneDimension;

namespace Blas.Containers.Base.TwoDimensions;

public class ColumnedMatrixBase<TRow, TColumn, T> : 
    IColumnedMatrixBase<TRow, TColumn, T>
    where TColumn : class, IVectorBase<T>, new()
    where TRow : class, IVectorBase<T>, new()
{
    private readonly VectorBase<IVectorBase<T>> _data;
    private readonly ColumnMainAccessor<TColumn, T> _columnMainAccessor;
    private readonly RowSecondaryAccessor<TRow, T> _rowSecondaryAccessor;
    private readonly ColumnMainInserter<T> _columnMainInserter;
    private readonly RowSecondaryInserter<T> _rowSecondaryInserter;
    private readonly RowMainFormatter<T> _rowMainFormatter;
    private readonly ColumnedTwoDimensionsContainer<T> _columnedTwoDimensionsContainer;

    public ColumnedMatrixBase()
    {
        _data = new VectorBase<IVectorBase<T>>();
        _columnMainAccessor = new ColumnMainAccessor<TColumn, T>(_data);
        _rowSecondaryAccessor = new RowSecondaryAccessor<TRow, T>(_data);
        _columnMainInserter = new ColumnMainInserter<T>(_data);
        _rowSecondaryInserter = new RowSecondaryInserter<T>(_data);
        _rowMainFormatter = new RowMainFormatter<T>(_data);
        _columnedTwoDimensionsContainer = new ColumnedTwoDimensionsContainer<T>(_data);
    }

    public ColumnedMatrixBase(IEnumerable<IEnumerable<T>> enumerable) : this()
    {
        PushBackColumnsRange(enumerable);
    }

    public ColumnedMatrixBase(Int32 nColumns, Int32 nRows) : this()
    {
        Resize(nColumns, nRows);
    }

    public TColumn LastColumn
    {
        get => _columnMainAccessor.LastColumn;
        set => _columnMainAccessor.LastColumn = value;
    }

    public TColumn FirstColumn
    {
        get => _columnMainAccessor.FirstColumn;
        set => _columnMainAccessor.FirstColumn = value;
    }

    public TColumn ColumnAt(Int32 columnIndex) => _columnMainAccessor.ColumnAt(columnIndex);

    public void SetColumn(Int32 columnIndex, IEnumerable<T> column)
    {
        _columnMainAccessor.SetColumn(columnIndex, column);
    }

    public TRow LastRow
    {
        get => _rowSecondaryAccessor.LastRow;
        set => _rowSecondaryAccessor.LastRow = value;
    }

    public TRow FirstRow
    {
        get => _rowSecondaryAccessor.FirstRow;
        set => _rowSecondaryAccessor.FirstRow = value;
    }

    public TRow RowAt(Int32 rowIndex) => _rowSecondaryAccessor.RowAt(rowIndex);

    public void SetRow(Int32 rowIndex, IEnumerable<T> row)
    {
        _rowSecondaryAccessor.SetRow(rowIndex, row);
    }

    public void InsertColumn(Int32 columnIndex, IEnumerable<T> column)
    {
        _columnMainInserter.InsertColumn(columnIndex, column);
    }

    public void PushBackColumn(IEnumerable<T> column)
    {
        _columnMainInserter.PushBackColumn(column);
    }

    public void PushFrontColumn(IEnumerable<T> column)
    {
        _columnMainInserter.PushFrontColumn(column);
    }

    public void InsertColumnsRange(Int32 columnIndex, IEnumerable<IEnumerable<T>> columns)
    {
        _columnMainInserter.InsertColumnsRange(columnIndex, columns);
    }

    public void PushBackColumnsRange(IEnumerable<IEnumerable<T>> columns)
    {
        _columnMainInserter.PushBackColumnsRange(columns);
    }

    public void PushFrontColumnsRange(IEnumerable<IEnumerable<T>> columns)
    {
        _columnMainInserter.PushFrontColumnsRange(columns);
    }

    public void RemoveColumn(Int32 columnIndex)
    {
        _columnMainInserter.RemoveColumn(columnIndex);
    }

    public void PopBackColumn()
    {
        _columnMainInserter.PopBackColumn();
    }

    public void PopFrontColumn()
    {
        _columnMainInserter.PopFrontColumn();
    }

    public void RemoveColumnsRange(Int32 columnIndex, Int32 nColumns)
    {
        _columnMainInserter.RemoveColumnsRange(columnIndex, nColumns);
    }

    public void PopBackColumnsRange(Int32 nColumns)
    {
        _columnMainInserter.PopBackColumnsRange(nColumns);
    }

    public void PopFrontColumnsRange(Int32 nColumns)
    {
        _columnMainInserter.PopFrontColumnsRange(nColumns);
    }

    public void InsertRow(Int32 rowIndex, IEnumerable<T> row)
    {
        _rowSecondaryInserter.InsertRow(rowIndex, row);
    }

    public void PushBackRow(IEnumerable<T> row)
    {
        _rowSecondaryInserter.PushBackRow(row);
    }

    public void PushFrontRow(IEnumerable<T> row)
    {
        _rowSecondaryInserter.PushFrontRow(row);
    }

    public void InsertRowsRange(Int32 rowIndex, IEnumerable<IEnumerable<T>> rows)
    {
        _rowSecondaryInserter.InsertRowsRange(rowIndex, rows);
    }

    public void PushBackRowsRange(IEnumerable<IEnumerable<T>> rows)
    {
        _rowSecondaryInserter.PushBackRowsRange(rows);
    }

    public void PushFrontRowsRange(IEnumerable<IEnumerable<T>> rows)
    {
        _rowSecondaryInserter.PushFrontRowsRange(rows);
    }

    public void RemoveRow(Int32 rowIndex)
    {
        _rowSecondaryInserter.RemoveRow(rowIndex);
    }

    public void PopBackRow()
    {
        _rowSecondaryInserter.PopBackRow();
    }

    public void PopFrontRow()
    {
        _rowSecondaryInserter.PopFrontRow();
    }

    public void RemoveRowsRange(Int32 rowIndex, Int32 nRows)
    {
        _rowSecondaryInserter.RemoveRowsRange(rowIndex, nRows);
    }

    public void PopBackRowsRange(Int32 nRows)
    {
        _rowSecondaryInserter.PopBackRowsRange(nRows);
    }

    public void PopFrontRowsRange(Int32 nRows)
    {
        _rowSecondaryInserter.PopFrontRowsRange(nRows);
    }

    public OutputFormatter ColumnFormatter
    {
        get => _rowMainFormatter.ColumnFormatter;
        set => _rowMainFormatter.ColumnFormatter = value;
    }

    public OutputFormatter RowFormatter
    {
        get => _rowMainFormatter.RowFormatter;
        set => _rowMainFormatter.RowFormatter = value;
    }

    public Func<T, String> ElementDataFormatter
    {
        get => _rowMainFormatter.ElementDataFormatter;
        set => _rowMainFormatter.ElementDataFormatter = value;
    }

    public IEnumerator<IVectorBase<T>> GetEnumerator() => _columnedTwoDimensionsContainer.GetEnumerator();

    IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();

    public IRowedMatrixBase<TRow, TColumn, T> ToRowed() => new RowedMatrixBase<TRow, TColumn, T>(this);

    public TColumn this[Int32 columnIndex]
    {
        get => ColumnAt(columnIndex);
        set => SetColumn(columnIndex, value);
    }

    public T this[Int32 columnIndex, Int32 rowIndex]
    {
        get => At(columnIndex, rowIndex);
        set => Set(columnIndex, rowIndex, value);
    }

    public T At(Int32 columnIndex, Int32 rowIndex) => _data.At(columnIndex).At(rowIndex);

    public void Set(Int32 columnIndex, Int32 rowIndex, T value) => _data.At(columnIndex).Set(rowIndex, value);

    public void Resize(Int32 nColumns, Int32 nRows)
    {
        ResizeColumns(nColumns);
        ResizeRows(nRows);
    }

    public Int32 NRows => _columnedTwoDimensionsContainer.NRows;

    public Int32 NColumns => _columnedTwoDimensionsContainer.NColumns;

    public Int32 RowIndexLast => _columnedTwoDimensionsContainer.RowIndexLast;

    public Int32 RowIndexFirst => _columnedTwoDimensionsContainer.RowIndexFirst;

    public Int32 ColumnIndexLast => _columnedTwoDimensionsContainer.ColumnIndexLast;

    public Int32 ColumnIndexFirst => _columnedTwoDimensionsContainer.ColumnIndexFirst;

    public void ResizeColumns(Int32 nColumns)
    {
        _columnedTwoDimensionsContainer.ResizeColumns(nColumns);
    }

    public void ResizeRows(Int32 nRows)
    {
        _columnedTwoDimensionsContainer.ResizeRows(nRows);
    }
}