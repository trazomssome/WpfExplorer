﻿using CommunityToolkit.Mvvm.ComponentModel;
using Jamesnet.Wpf.Controls;

namespace WpfExplorer.Forms.Local.Models;

public abstract partial class FileInfoBase : ObservableObject
{
    [ObservableProperty]
    private bool _isDenied;

    public string Name { get; set; }
    public string FullPath { get; set; }
    public int Depth { get; set; }
    public long Length { get; set; }
    public IconType IconType { get; set; }
}
