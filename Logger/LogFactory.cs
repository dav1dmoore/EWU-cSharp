namespace Logger;

public class LogFactory
{

    private string? FilePath { get; set; }

    public BaseLogger? CreateLogger(string className)
    {
        if (string.IsNullOrEmpty(FilePath))
        {
            return null; //Testing FilePath to see if its Null.
        }
        return new FileLogger(FilePath){
            ClassName = className
        };
    }
}
