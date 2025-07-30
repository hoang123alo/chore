using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using UsbComposite.Viewmodels;

namespace UsbComposite.Views
{
    /// <summary>
    /// Interaction logic for ConnectDeviceView.xaml
    /// </summary>
    public partial class ConnectDeviceView : UserControl
    {
        private MainViewModel _mainViewModel;
        public ConnectDeviceView()
        {
            InitializeComponent();
            _mainViewModel = (MainViewModel)((MainWindow)Application.Current.MainWindow).DataContext;
        }

        private void CmbComPorts_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
