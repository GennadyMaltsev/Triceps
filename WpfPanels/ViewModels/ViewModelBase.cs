using System.Threading.Tasks;
using Netix.Common;

namespace WpfPanels.ViewModels
{
    public class ViewModelBase : ObservableObject
    {
        public virtual void OnLoad() { }
        public virtual bool OnClose() { return true; }
    }
}
