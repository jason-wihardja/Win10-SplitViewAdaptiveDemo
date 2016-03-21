using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace SplitViewAdaptiveDemo {
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page {
        public MainPage() {
            InitializeComponent();
        }

        private void Page_Loaded(object sender, RoutedEventArgs e) {
            HomeNav.IsChecked = true;
        }

        private void HamburgerButton_Click(object sender, RoutedEventArgs e) {
            MySplitView.IsPaneOpen = !MySplitView.IsPaneOpen;
        }

        private void BackButton_Click(object sender, RoutedEventArgs e) {
            if (ContentFrame.CanGoBack) {
                ContentFrame.GoBack();

                if (ContentFrame.SourcePageType == typeof(HomePage)) HomeNav.IsChecked = true;
                else if (ContentFrame.SourcePageType == typeof(CarsPage)) CarsNav.IsChecked = true;
                else if (ContentFrame.SourcePageType == typeof(DevicesPage)) DevicesNav.IsChecked = true;
                else if (ContentFrame.SourcePageType == typeof(ProfilePage)) ProfileNav.IsChecked = true;
                else if (ContentFrame.SourcePageType == typeof(SettingsPage)) SettingsNav.IsChecked = true;
            }
        }

        private void HomeNav_Checked(object sender, RoutedEventArgs e) {
            if (ContentFrame.SourcePageType != typeof(HomePage)) {
                MySplitView.IsPaneOpen = MySplitView.DisplayMode == SplitViewDisplayMode.Inline;
                ContentFrame.Navigate(typeof(HomePage));
            }
        }

        private void CarsNav_Checked(object sender, RoutedEventArgs e) {
            if (ContentFrame.SourcePageType != typeof(CarsPage)) {
                MySplitView.IsPaneOpen = MySplitView.DisplayMode == SplitViewDisplayMode.Inline;
                ContentFrame.Navigate(typeof(CarsPage)); 
            }
        }

        private void DevicesNav_Checked(object sender, RoutedEventArgs e) {
            if (ContentFrame.SourcePageType != typeof(DevicesPage)) {
                MySplitView.IsPaneOpen = MySplitView.DisplayMode == SplitViewDisplayMode.Inline;
                ContentFrame.Navigate(typeof(DevicesPage)); 
            }
        }

        private void MyProfileNav_Checked(object sender, RoutedEventArgs e) {
            if (ContentFrame.SourcePageType != typeof(ProfilePage)) {
                MySplitView.IsPaneOpen = MySplitView.DisplayMode == SplitViewDisplayMode.Inline;
                ContentFrame.Navigate(typeof(ProfilePage)); 
            }
        }

        private void SettingsNav_Checked(object sender, RoutedEventArgs e) {
            if (ContentFrame.SourcePageType != typeof(SettingsPage)) {
                MySplitView.IsPaneOpen = MySplitView.DisplayMode == SplitViewDisplayMode.Inline;
                ContentFrame.Navigate(typeof(SettingsPage)); 
            }
        }
    }
}
