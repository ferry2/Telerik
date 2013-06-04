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

namespace TreesInWPF
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

        private void Window_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            var visualTree = GetVisualTree(e);
            var logicalTree = GetLogicalTree(e);
            TextBlockVisualResult.Text = visualTree;
            TextBlockLogicalResult.Text = logicalTree;
        }

        private string GetVisualTree(MouseButtonEventArgs e)
        {
            StringBuilder strBuilder = new StringBuilder();
            var control = e.Source as DependencyObject;
            do
            {
                strBuilder.Append(control.GetType() + "\n");
                control = VisualTreeHelper.GetParent(control);
            }
            while (control != null);
            return strBuilder.ToString();
        }

        private string GetLogicalTree(MouseButtonEventArgs e)
        {
            StringBuilder strBuilder = new StringBuilder();
            var control = e.Source as DependencyObject;
            do
            {
                strBuilder.Append(control.GetType() + "\n");
                control = LogicalTreeHelper.GetParent(control);
            }
            while (control != null);
            return strBuilder.ToString();
        }
    }
}