namespace Spotisharp.Client.Models;

public sealed class OptionsConfig
{
    public bool ScanLibrary { get; set; }
    public bool IgnoreAlbums { get; set; }
    public LibraryConfig Library { get; set; }
    public Uri[] Requests { get; set; }
}