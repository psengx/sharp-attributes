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

[LibraryMetaData(Author = "Mike", Version = "1.0.0")]
public class LibMike
{
}

[LibraryMetaData("John", "1.2.0")]
public class LibJohn
{
}

[LibraryMetaData("Alice", "2.0.0")]
public class LibAlice
{
}

public class NoLib3
{
}