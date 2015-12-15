using RxPropertyAndCommand.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace RxPropertyAndCommand
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void WpfPropertyandCommand_Click(object sender, RoutedEventArgs e)
        {
            Window window = new Window { Content = new UsingWpfPropertyCommandView() };
            window.Height = 400;
            window.Width = 500;
            window.ShowDialog();
        }

        private void ReactiveProperty_Click(object sender, RoutedEventArgs e)
        {
            Window window = new Window { Content = new UsingReactivePropertyView()};
            window.Height = 400;
            window.Width = 500;
            window.ShowDialog();
        }

        private void ReactiveCommand_Click(object sender, RoutedEventArgs e)
        {
            Window window = new Window { Content = new UsingReactiveCommandView() };
            window.Height = 400;
            window.Width = 500;
            window.ShowDialog();
        }
    }
}
