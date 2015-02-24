﻿using GitHub.UI.Helpers;
using System.Windows;
using System.Windows.Controls;

namespace GitHub.UI
{
    public partial class HorizontalShadowDivider : UserControl
    {
        public HorizontalShadowDivider()
        {
            Resources.MergedDictionaries.Add(SharedDictionaryManager.Load("GitHub.UI"));
            InitializeComponent();
        }
    }
}