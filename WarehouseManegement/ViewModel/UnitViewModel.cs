using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using WarehouseManegement.Model;

namespace WarehouseManegement.ViewModel
{
    public class UnitViewModel:BaseViewModel
    {
        private ObservableCollection<Unit> _List;
        public ObservableCollection<Unit> List { get { return _List; }  set { _List = value; OnPropertyChanged(); } }
        private Unit _SelectedItem;
        public Unit SelectedItem { get => _SelectedItem; set {
                _SelectedItem = value;
                if(_SelectedItem!= null)
                    DisplayName = _SelectedItem.DisplayName;
                OnPropertyChanged(); 
            }
        }
        public ICommand AddCommand { get; set; }
        public ICommand EditCommand { get; set; }
        private string _DisplayName;
        public string DisplayName { get => _DisplayName; set { _DisplayName = value; OnPropertyChanged(); } }
        public UnitViewModel() { 
            List = new ObservableCollection<Unit>(DataProvider.Ins.DB.Units);
            AddCommand = new RelayCommand<object>((p) =>
            {
                if (string.IsNullOrEmpty(DisplayName))
                    return false;
                var a = DataProvider.Ins.DB.Units.Where(x => x.DisplayName == DisplayName);
                if (a == null || a.Count() == 0)
                {
                    return true;
                }
                return false;
            }
            , (p) =>
            {
                var unit = new Unit() { DisplayName = DisplayName };
                DataProvider.Ins.DB.Units.Add(unit);
                DataProvider.Ins.DB.SaveChanges();
                List.Add(unit);
            }) ;
            EditCommand = new RelayCommand<object>((p) =>
            {
                if (string.IsNullOrEmpty(DisplayName) || SelectedItem == null)
                    return false;
                var a = DataProvider.Ins.DB.Units.Where(x => x.DisplayName == DisplayName);
                if (a == null || a.Count() == 0)
                {
                    return true;
                }
                return false;
            }
            , (p) =>
            {
                var unit = DataProvider.Ins.DB.Units.Where(x => x.Id == SelectedItem.Id).SingleOrDefault();
                if (unit != null)
                {
                    unit.DisplayName = DisplayName;
                }
                DataProvider.Ins.DB.SaveChanges();

                //cách 1: cập nhật lại theo bảng đã cập nhật
                //List = new ObservableCollection<Unit>(DataProvider.Ins.DB.Units);
                // cách 2;  chuyển class Unit kế thừa  BaseViewModel và Onchangeproperties      
                //SelectedItem.DisplayName = DisplayName;        
                // cách 3: xóa hàng đó và insert lại
            }) ;
        }
    }   
}
