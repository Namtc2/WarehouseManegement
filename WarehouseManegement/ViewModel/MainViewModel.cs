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
        public ICommand UnitCommand { get; set; }
        public ICommand SuplierCommand { get; set; }
        public ICommand CustomersCommand { get; set; }
        public ICommand ObjectCommand { get; set; }
        public ICommand UserCommand { get; set; }
        public ICommand InputCommand { get; set; }
        public ICommand OutputCommand { get; set; }
        public MainViewModel()
        {
            LoadedWindowCommand = new RelayCommand<Window>((p) => { return p != null ? true : false; }, (p) =>
            {
                isLoaded = true;
                LoginWindow loginWd = new LoginWindow();
                loginWd.Topmost = true;
                loginWd.ShowDialog();
            });
            UnitCommand = new RelayCommand<Window>((p) => { return true; }, (p) =>
            {
                UnitWindow unitWd = new UnitWindow();
                unitWd.Topmost = true;
                unitWd.ShowDialog();
            });
            SuplierCommand = new RelayCommand<Window>((p) => { return true; }, (p) =>
            {
                SuplierWindow unitWd = new SuplierWindow();
                unitWd.Topmost = true;
                unitWd.ShowDialog();
            });
            CustomersCommand = new RelayCommand<Window>((p) => { return true; }, (p) =>
            {
                CustomersWindow cusWd = new CustomersWindow();
                cusWd.Topmost = true;
                cusWd.ShowDialog();
            });
            ObjectCommand = new RelayCommand<Window>((p) => { return true; }, (p) =>
            {
                ObjectWindow obWd = new ObjectWindow();
                obWd.Topmost = true;
                obWd.ShowDialog();
            });
            UserCommand = new RelayCommand<Window>((p) => { return true; }, (p) =>
            {
                UserWindow obWd = new UserWindow();
                obWd.Topmost = true;
                obWd.ShowDialog();
            });
            InputCommand = new RelayCommand<Window>((p) => { return true; }, (p) =>
            {
                InputWindow inputWd = new InputWindow();
                inputWd.Topmost = true;
                inputWd.ShowDialog();
            });
            OutputCommand = new RelayCommand<Window>((p) => { return true; }, (p) =>
            {
                OutputWindow opWd = new OutputWindow();
                opWd.Topmost = true;
                opWd.ShowDialog();
            });
        }        
    }
}
