using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace WarehouseManegement.ViewModel
{
    public class MainViewModel : BaseViewModel
    {
        public bool isLoaded = false;
        public ICommand LoadedWindowCommand { get; set; }
        public MainViewModel()
        {
            LoadedWindowCommand = new RelayCommand<Window>((p) => { return p != null ? true : false; }, (p) =>
            {
                isLoaded = true;
                LoginWindow loginWd = new LoginWindow();
                loginWd.Topmost = true;
                loginWd.ShowDialog();
            });
        }        
    }
}
