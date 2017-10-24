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

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace HamburgerHeaven
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
            MyFrame.Navigate(typeof(Financial));
            SelectedItemTextBlock.Text = FinancialTextBlock.Text;
            FinancialListBoxItem.IsSelected = true;
        }


        private void HamburgerButton_Click(object sender, RoutedEventArgs e)
        {
            if (!HamburgerSplitView.IsPaneOpen)
                HamburgerSplitView.IsPaneOpen = !HamburgerSplitView.IsPaneOpen;
            BackButton.Visibility = Visibility.Collapsed;
        }

        private void FinancialListBoxItem_Tapped(object sender, TappedRoutedEventArgs e)
        {
            if (HamburgerSplitView.IsPaneOpen)
                HamburgerSplitView.IsPaneOpen = !HamburgerSplitView.IsPaneOpen;
            BackButton.Visibility = Visibility.Collapsed;
            MyFrame.Navigate(typeof(Financial));
            SelectedItemTextBlock.Text = FinancialTextBlock.Text;

        }

        private void FoodListBoxItem_Tapped(object sender, TappedRoutedEventArgs e)
        {
            if (HamburgerSplitView.IsPaneOpen)
                HamburgerSplitView.IsPaneOpen = !HamburgerSplitView.IsPaneOpen;
            MyFrame.Navigate(typeof(Food));
            BackButton.Visibility = Visibility.Visible;
            SelectedItemTextBlock.Text = FoodTextBlock.Text;
        }

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            if (MyFrame.CanGoBack)
                MyFrame.GoBack();
            SelectedItemTextBlock.Text = FinancialTextBlock.Text;
            FinancialListBoxItem.IsSelected = true;
            BackButton.Visibility = Visibility.Collapsed;
        }
    }
}
