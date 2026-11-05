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

[LibraryMetaData(Author = "Dan", Version = "2.5.0")]
public class LibDan
{
}

[LibraryMetaData("Eve", "3.1.0")]
public class LibEve
{
}

public class NoLib2
{
}