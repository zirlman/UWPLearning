using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Threading.Tasks;
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

namespace ControlsPart2
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {

        private string[] selectionItems = new string[] { "Ferdinand", "Frank", "Frida", "Nigel", "Tag", "Tanya", "Tanner", "Todd" };

        public MainPage()
        {
            this.InitializeComponent();
        }

        private void MilitaryFormat_Click(object sender, RoutedEventArgs e)
        {
            MyTimePicker.ClockIdentifier = "24HourClock";
        }

        private void AmericanFormat_Click(object sender, RoutedEventArgs e)
        {
            MyTimePicker.ClockIdentifier = "12HourClock";
        }

        private void OkButton_Click(object sender, RoutedEventArgs e)
        {
            MyFlyout.Hide();
        }

        private void MyAutoSuggestBox_TextChanged(AutoSuggestBox sender, AutoSuggestBoxTextChangedEventArgs args)
        {
            sender.ItemsSource = selectionItems.Where(s => s.StartsWith(sender.Text)).ToArray();
        }

        private async void StartProgressBarButton_ClickAsync(object sender, RoutedEventArgs e)
        {
            for (int i = 0; i < 100000001; ++i)
            {
                if (i % 1000000 == 0)
                {
                    MyProgressBar.Value = i / 1000000;
                    ProgressBarPercentage.Text = MyProgressBar.Value + ".00 %";
                    // Umjesto Thread.Sleep(), ovdje se koristi task, metoda mora biti async !
                    await Task.Delay(200);
                }
            }
        }
    }
}
