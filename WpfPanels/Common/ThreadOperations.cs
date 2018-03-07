using System;
using System.Windows;
using System.Windows.Threading;

namespace WpfPanels.Common
{
    public class ThreadOperations
    {
        public static void RunInMainThread(Action act, DispatcherPriority priority = DispatcherPriority.SystemIdle)
        {
            if (Application.Current != null)
            {
                Application.Current.Dispatcher.BeginInvoke(act, priority);
            }
            else
            {
                act.Invoke();
            }
        }
    }
}
