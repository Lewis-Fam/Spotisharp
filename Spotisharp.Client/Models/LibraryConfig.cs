namespace Spotisharp.Client.Models;

public sealed class LibraryConfig
{
    public string Filter { get; set; } = "*.*";
    public string[] Folders { get; set; }

    public IQueryable<string> AllFiles()
    {
        var files = new List<string>();

        foreach (var folder in Folders)
        {
            if (Directory.Exists(folder))
                files.AddRange(new DirectoryInfo(folder).GetFiles(Filter, SearchOption.AllDirectories).Select(s => s.Name.ToLowerInvariant()));
        }

        return files.AsQueryable();
    }

    public bool Exists(string name)
    {
        return AllFiles().Contains(name.ToLowerInvariant());
    }
}