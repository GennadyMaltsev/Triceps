using System.Windows;
using WpfPanels.Common;

namespace WpfPanels.Dialogs
{
    public partial class DialogMessageBox
    {
        public DialogMessageBox()
        {
            InitializeComponent();
        }

        private void ButtonOK_OnClick(object sender, RoutedEventArgs e)
        {
            FormControls.GetParentWindow(sender as FrameworkElement).DialogResult = true;
        }
    }
}
