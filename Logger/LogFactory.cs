using System.IO;
using System.Reflection;

namespace Logger;

public class LogFactory
{

    private string? FilePath { get; set; }

    public void ConfigureFileLogger()
    {
        string assemblyLocation = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) ?? string.Empty;
        FilePath = Path.Combine(assemblyLocation, "file.txt");
    }
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
