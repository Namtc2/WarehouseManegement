using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using WarehouseManegement.Model;

namespace WarehouseManegement.ViewModel
{
    public class MainViewModel : BaseViewModel
    {
        private ObservableCollection<TonKho> _TonKhoList; // sử dụng ObservableCollection nó sẽ raise lên giao diện ngày lập tức khi mà dữ liệu của nó có thay đổi
        public ObservableCollection<TonKho> TonKhoList { get => _TonKhoList; set { _TonKhoList = value; OnPropertyChanged(); } }
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
                if (p == null) return;
                p.Hide();
                LoginWindow loginWd = new LoginWindow();
                loginWd.Topmost = true;
                loginWd.ShowDialog();
                if (loginWd.DataContext == null) return;
                var loginVM = loginWd.DataContext as LoginViewModel;
                if (loginVM.IsLogin)
                {
                    p.Show();
                    LoadTonKhoData();
                }
                else
                {
                    p.Close();
                }                
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
        void LoadTonKhoData()
        {
            TonKhoList = new ObservableCollection<TonKho>();
            var objectList = DataProvider.Ins.DB.Objects;
            int i = 1;
            foreach(var item in objectList)
            {
                var inputList = DataProvider.Ins.DB.InputInfoes.Where(x => x.IdObject == item.Id);
                var outpurList = DataProvider.Ins.DB.OutputInfoes.Where(x => x.IdObject == item.Id);
                int sumInput = 0;
                int sumOutput = 0;
                if (inputList != null)
                {
                    sumInput = (int)inputList.Sum(p => p.Count);
                }
                if (outpurList != null)
                {
                    sumOutput = (int)outpurList.Sum(p => p.Count);
                }
                TonKho tonKho = new TonKho();
                tonKho.STT = i;
                tonKho.Count = sumInput - sumOutput;
                tonKho.Object = item;

                TonKhoList.Add(tonKho);
                i++;
            }

            
        }
    }
}
