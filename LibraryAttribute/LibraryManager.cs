namespace LibraryAttribute;
using System.Reflection;
public class LibraryManager
{
    public void PrintLibraryInfo(Type type)
    {
        LibraryMetaDataAttribute? attribute = type.GetCustomAttribute<LibraryMetaDataAttribute>();
        if (attribute != null)
            Console.WriteLine(attribute.ToString());
        else
            Console.WriteLine($"Class {type.Name} is not a library.");
    }
    public void PrintLibraryInfo<T>() => PrintLibraryInfo(typeof(T));
    
    public void PrintLibrariesInfo()
    {
        Assembly assembly = Assembly.GetExecutingAssembly();
        PrintLibrariesInfo(assembly);
    }

    public void PrintLibrariesInfo<T>()
    {
        Assembly assembly = typeof(T).Assembly;
        foreach (Type type in assembly.GetTypes())
        {
            LibraryMetaDataAttribute? attribute = type.GetCustomAttribute<LibraryMetaDataAttribute>();
            if (attribute != null)
                Console.WriteLine($"Class: {type.Name} Attribute: {attribute}");
        }
    }

    public void PrintLibrariesInfo(Assembly assembly)
    {
        foreach (Type type in assembly.GetTypes())
        {
            LibraryMetaDataAttribute? attribute = type.GetCustomAttribute<LibraryMetaDataAttribute>();
            if (attribute != null)
                Console.WriteLine($"Class: {type.Name} Attribute: {attribute}");
        }
    }
}



