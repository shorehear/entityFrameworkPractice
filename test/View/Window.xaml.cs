
using System.Windows;

namespace k11
{
    public partial class MainWindow : Window
    {
        private VM vm;
        public MainWindow()
        {
            vm = new VM();
            InitializeComponent();
            DataContext = vm;
        }
    }
}
