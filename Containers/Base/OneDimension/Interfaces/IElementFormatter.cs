namespace Blas.Containers.Base.OneDimension;

public interface IElementFormatter<T>
{
    public OutputFormatter Formatter { get; set; }
    
    public Func<T, String> ElementDataFormatter { get; set; }
}