﻿using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace Ball
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        private readonly BaseballSimulator baseballSimulator;
        public MainPage()
        {
            DataContext = baseballSimulator = new BaseballSimulator();
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            baseballSimulator.PlayBall();
        }
    }
}