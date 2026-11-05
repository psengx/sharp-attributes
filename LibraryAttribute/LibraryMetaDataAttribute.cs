namespace LibraryAttribute;

[AttributeUsage(AttributeTargets.Class)]
public class LibraryMetaDataAttribute : Attribute
{
    public string Author { get; set; }
    public string Version { get; set; }
    public LibraryMetaDataAttribute(string author = "Unknown", string version = "1.0.0")
    {
        Author = author;
        Version = version;
    }
    public LibraryMetaDataAttribute()
    {
        Author = "Unknown";
        Version = "1.0.0";
    }
    public override string ToString()
    {
        return $"Author: {Author}, Version: {Version}";
    }
}