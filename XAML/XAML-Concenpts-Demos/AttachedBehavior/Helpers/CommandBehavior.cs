using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace AttachedBehavior.Behaviors
{
    public static class CommandBehavior
    {
        public static ICommand GetCommand(DependencyObject obj)
        {
            return (ICommand)obj.GetValue(CommandProperty);
        }

        public static void SetCommand(DependencyObject obj, ICommand value)
        {
            obj.SetValue(CommandProperty, value);
        }

        public static readonly DependencyProperty CommandProperty =
            DependencyProperty.RegisterAttached("Command",
                typeof(ICommand),
                typeof(CommandBehavior),
                new PropertyMetadata(null,
                    new PropertyChangedCallback(HandleCommand)));

        private static void HandleCommand(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            var control = d as UIElement;
            if (control == null)
            {
                return;
            }
            if ((e.NewValue != null) && (e.OldValue == null))
            {
                control.MouseLeftButtonDown += (sender, args) =>
                {
                    var command = (sender as UIElement).GetValue(CommandBehavior.CommandProperty) as ICommand;
                    command.Execute(null);
                };
            }
        }
    }
}