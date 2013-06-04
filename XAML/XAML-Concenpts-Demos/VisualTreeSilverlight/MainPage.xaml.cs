using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;

namespace VisualTreeSilverlight
{
    public partial class MainPage : UserControl
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Window_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            var visualTreeStackPanel = FindAncestor<StackPanel>(e.OriginalSource as DependencyObject);
            if (visualTreeStackPanel == null)
            {
                TextBlockVisualResult.Text = "No such Parent";
                return;
            }

            TextBlockVisualResult.Text = visualTreeStackPanel.Name;
        }

        private T FindAncestor<T>(DependencyObject source)
            where T : class
        {
            DependencyObject current = source;

            while (current != null && current.GetType() != typeof(T))
            {
                current = VisualTreeHelper.GetParent(current);
            }
            return current as T;
        }
    }
}