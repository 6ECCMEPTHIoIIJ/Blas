namespace Blas.Containers.Base;

public record struct OutputFormatter(String Prefix, String Separator, String Suffix)
{
    public OutputFormatter() : this("", "", "")
    {
    }
}