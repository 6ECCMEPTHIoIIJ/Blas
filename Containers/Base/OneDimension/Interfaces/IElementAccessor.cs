namespace Blas.Containers.Base.OneDimension;

public interface IElementAccessor<T>
{
    public T Last { get; set; }
    
    public T First { get; set; }
    
    public T At(Int32 index);

    public void Set(Int32 index, T value);
    
    public T this[Int32 index] { get; set; }
}