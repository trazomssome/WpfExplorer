using System.Collections.ObjectModel;
using CommunityToolkit.Mvvm.ComponentModel;
using WpfExplorer.Support.Local.Helpers;

namespace WpfExplorer.Support.Local.Models;

public partial class FolderInfo : FileInfoBase
{
    [ObservableProperty]
    private bool _isFolderExpanded;
    [ObservableProperty]
    private bool _isFolderSelected;

    public FolderInfo()
    {
        PropertyChanged += FolderInfo_PropertyChanged;
    }

    private void FolderInfo_PropertyChanged(object? sender, System.ComponentModel.PropertyChangedEventArgs e)
    {
        if (e.PropertyName == nameof(IsFolderExpanded) && IsFolderExpanded)
        {
            FileService.RefreshSubdirectories(this);
        }
    }

    public ObservableCollection<FolderInfo> Children { get; set; }
}
