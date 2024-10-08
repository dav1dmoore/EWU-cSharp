using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Globalization;
using System.IO;
using System.Reflection;

namespace Logger.Tests;

[TestClass]
public class FileLoggerTests
{
    private string _logFilePath = string.Empty;

    [TestInitialize]
    public void Setup()
    {
        // Set up the log file path based on the assembly location
        string assemblyLocation = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) ?? string.Empty;
        _logFilePath = Path.Combine(assemblyLocation, "testlog.txt");

        // Ensure the log file is clean before each test
        if (File.Exists(_logFilePath))
        {
            File.Delete(_logFilePath);
            //
        }
    }

    
}
