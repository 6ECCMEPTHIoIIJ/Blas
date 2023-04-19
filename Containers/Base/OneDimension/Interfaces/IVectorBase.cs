namespace Blas.Containers.Base.OneDimension;

public interface IVectorBase<T> : 
    IOneDimensionContainer<T>,
    IElementAccessor<T>,
    IElementFormatter<T>,
    IElementInserter<T>
{
    
}