using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Netix.Jacar.Documents;
using Netix.Jacar.Windows;
using System.Windows.Forms.Integration;

namespace WpfPanels.UserControls
{
    /// <summary>
    /// Логика взаимодействия для WpfPaymentPanel.xaml
    /// </summary>
    public partial class WpfPaymentPanel : IDocumentPanel
    {
        public WpfPaymentPanel()
        {
            InitializeComponent();
            //DefaultStyleKeyProperty.OverrideMetadata(typeof(WpfPaymentPanel), new FrameworkPropertyMetadata(typeof(WpfPaymentPanel)));
        }

        public IDocument Document => null;

        public System.Drawing.Image SmallImage
        {
            get { return null; }
            set { }
        }

        public System.Drawing.Image LargeImage
        {
            get { return null; }
            set { }
        }

        public string Text => "Hello!!";

        public event EventHandler Activated;
        public event EventHandler Closed;
        public event EventHandler TextChanged;
        public event EventHandler ImageChanged;

        public bool Activate()
        {
            return true;
        }

        public bool CanClose(bool canSave)
        {
            return true;
        }

        public void Close()
        {
        }

        public System.Windows.Forms.Control GetControl()
        {
            // Create the ElementHost control for hosting the
            // WPF UserControl.
            ElementHost host = new ElementHost();
            host.Dock = DockStyle.Fill;

            // Assign the WPF UserControl to the ElementHost control's
            // Child property.
            host.Child = this;

            return host;
        }

        public void RestoredAfterCrush()
        {
        }
    }
}
