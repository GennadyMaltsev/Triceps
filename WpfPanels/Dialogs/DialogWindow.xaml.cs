using WpfPanels.ViewModels;

namespace WpfPanels.Dialogs
{
    /// <summary>
    /// Interaction logic for DialogWindow.xaml
    /// </summary>
    public partial class DialogWindow 
    {
        public DialogWindow()
        {
            InitializeComponent();
            Loaded += (s, e) =>
            {
                MinWidth = ActualWidth;
                MinHeight = ActualHeight;
            };
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (!(Content is ViewModelBase) || ((ViewModelBase) Content).OnClose())
            {
                return;
            }
            e.Cancel = true;
        }
    }
}
