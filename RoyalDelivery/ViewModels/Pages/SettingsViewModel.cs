using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using RoyalDelivery.ViewModels.Base;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Media;

namespace RoyalDelivery.ViewModels.Pages
{
    public partial class SettingsViewModel : ViewModelBase
    {
        [ObservableProperty]
        private double fontSizeSetting = 16;

        [ObservableProperty]
        private bool highContrastEnabled;

        [ObservableProperty]
        private bool colorBlindModeEnabled;

        [ObservableProperty]
        private bool isResizable = true;

        partial void OnFontSizeSettingChanged(double value)
        {
            Application.Current.Resources["GlobalFontSize"] = value;
        }

        partial void OnHighContrastEnabledChanged(bool value)
        {
            Application.Current.Resources["PrimaryTextBrush"] =
                value ? new SolidColorBrush(Colors.Black)
                      : new SolidColorBrush(Color.FromRgb(47, 54, 64));
        }

        partial void OnIsResizableChanged(bool value)
        {
            Application.Current.MainWindow.ResizeMode =
                value ? ResizeMode.CanResize
                      : ResizeMode.NoResize;
        }

        [RelayCommand]
        private void SetLightTheme()
        {
            Application.Current.Resources["AppBackground"] =
                new SolidColorBrush(Color.FromRgb(245, 246, 250));
        }

        [RelayCommand]
        private void SetDarkTheme()
        {
            Application.Current.Resources["AppBackground"] =
                new SolidColorBrush(Color.FromRgb(30, 30, 30));

            Application.Current.Resources["PrimaryTextBrush"] =
                new SolidColorBrush(Colors.White);
        }

        [RelayCommand]
        private void SetBlueAccent()
        {
            Application.Current.Resources["AccentBrush"] =
                new SolidColorBrush(Color.FromRgb(9, 132, 227));
        }

        [RelayCommand]
        private void SetGreenAccent()
        {
            Application.Current.Resources["AccentBrush"] =
                new SolidColorBrush(Color.FromRgb(0, 184, 148));
        }
    }
}
