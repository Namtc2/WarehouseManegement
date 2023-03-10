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
using System.Windows.Navigation;
using System.Windows.Shapes;
using WarehouseManegement.ViewModel;

namespace WarehouseManegement.UserControlNamtc
{
    /// <summary>
    /// Interaction logic for CustomControlBar.xaml
    /// </summary>
    public partial class CustomControlBar : UserControl
    {
        public CustomControlBarViewModel ViewModel { get; set; }
        public CustomControlBar()
        {
            InitializeComponent();
            this.DataContext = ViewModel = new CustomControlBarViewModel();
        }
    }
}
