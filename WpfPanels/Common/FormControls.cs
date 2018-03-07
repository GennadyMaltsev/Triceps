using System;
using System.Windows;
using WpfPanels.Dialogs;
using WpfPanels.ViewModels;

namespace WpfPanels.Common
{
    public class FormControls 
    {
        public static Window GetParentWindow(FrameworkElement child)
        {
            var parentWin = child.TemplatedParent as FrameworkElement ?? child.Parent as FrameworkElement;
            while (!(parentWin is Window) && parentWin != null)
            {
                parentWin = parentWin.TemplatedParent as FrameworkElement ?? parentWin.Parent as FrameworkElement;
            }
            return parentWin as Window;
        }

        public static bool ShowContextedWindow(string caption, object dataContext, 
            double width = 300, double height = 300, 
            double maxWidth = double.PositiveInfinity, double maxHeight = double.PositiveInfinity,
            ResizeMode resizeMode = ResizeMode.CanResize)
        {
            var win = new DialogWindow()
            {
                Title = caption,
                Height = height,
                Width = width,
                MaxHeight = maxHeight,
                MaxWidth = maxWidth,
                Content = dataContext,
                ResizeMode = resizeMode,
                Owner = Application.Current?.MainWindow,
                DataContext = dataContext
            };
            return win.ShowDialog() == true;
        }

        public static bool ShowMessageBox(string caption, string text, double height = 150)
        {
            return ShowContextedWindow(caption, new MessageBoxVM() { Message = text }, height: height);
        }

    }
}
