namespace WpfPanels.ViewModels
{
    public class MessageBoxVM : ViewModelBase
    {
        public string Message
        {
            get => GetVal<string>();
            set => SetVal(value);
        }
    }
}