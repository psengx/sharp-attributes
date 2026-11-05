using System.Reflection;
using LibraryAttribute;

public class Program
{
    public static void Main(string[] args)
    {
        LibraryManager libraryManager = new LibraryManager();
        Assembly assem = typeof(Program).Assembly;
        foreach (Type type in assem.GetTypes())
        {
            libraryManager.PrintLibraryInfo(type);
        }
    }
}

[LibraryMetaData()] 
public class LibDefault
{
}

