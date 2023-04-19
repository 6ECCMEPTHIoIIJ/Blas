using System.Collections;

namespace Blas.Containers.Base.OneDimension;

public interface IOneDimensionContainer<out T> : IEnumerable<T>
{
    public Int32 NElements { get; }
    
    public Int32 IndexLast { get; }
    
    public Int32 IndexFirst { get; }

    public void Resize(Int32 nElements);
}