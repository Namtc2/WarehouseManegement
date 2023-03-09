using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using WarehouseManegement.Model;

namespace WarehouseManegement.ViewModel
{
    public class SuplierViewModel : BaseViewModel
    {
        private ObservableCollection<Suplier> _List;
        public ObservableCollection<Suplier> List { get { return _List; } set { _List = value; OnPropertyChanged(); } }
        private Suplier _SelectedItem;
        public Suplier SelectedItem
        {
            get => _SelectedItem; set
            {
                _SelectedItem = value;
                if (_SelectedItem != null)
                {
                    DisplayName = _SelectedItem.DisplayName;
                    Address = _SelectedItem.Address;
                    Phone = _SelectedItem.Phone;
                    Email = _SelectedItem.Email;
                    MoreInfo = _SelectedItem.MoreInfo;
                    ContractDate = _SelectedItem.ContractDate;
                }                    
                OnPropertyChanged();
            }
        }
        public ICommand AddCommand { get; set; }
        public ICommand EditCommand { get; set; }
        private string _DisplayName;
        public string DisplayName { get => _DisplayName; set { _DisplayName = value; OnPropertyChanged(); } } 
        
        private string _Address;
        public string Address { get => _Address; set { _Address = value; OnPropertyChanged(); } } 
        
        private string _Phone;
        public string Phone { get => _Phone; set { _Phone = value; OnPropertyChanged(); } }  
        
        private string _Email;
        public string Email { get => _Email; set { _Email = value; OnPropertyChanged(); } }
        
        private string _MoreInfo;
        public string MoreInfo { get => _MoreInfo; set { _MoreInfo = value; OnPropertyChanged(); } } 
        
        private DateTime? _ContractDate;
        public DateTime? ContractDate { get => _ContractDate; set { _ContractDate = value; OnPropertyChanged(); } }
        public SuplierViewModel()
        {
            List = new ObservableCollection<Suplier>(DataProvider.Ins.DB.Supliers);
            AddCommand = new RelayCommand<object>((p) =>
            {
                return true;
            }
            , (p) =>
            {
                var Suplier = new Suplier() { DisplayName = DisplayName, Phone=Phone, Address = Address, Email = Email, ContractDate = ContractDate, MoreInfo = MoreInfo };
                DataProvider.Ins.DB.Supliers.Add(Suplier);
                DataProvider.Ins.DB.SaveChanges();
                List.Add(Suplier);
            });
            EditCommand = new RelayCommand<object>((p) =>
            {
                if (string.IsNullOrEmpty(DisplayName) || SelectedItem == null)
                    return false;
                var a = DataProvider.Ins.DB.Supliers.Where(x => x.DisplayName == DisplayName);
                if (a == null || a.Count() == 0)
                {
                    return false;
                }
                return true;
            }
            , (p) =>
            {
                var Suplier = DataProvider.Ins.DB.Supliers.Where(x => x.Id == SelectedItem.Id).SingleOrDefault();
                if (Suplier != null)
                {
                    Suplier.DisplayName = DisplayName;
                    Suplier.Phone = Phone;
                    Suplier.Address = Address;
                    Suplier.Email = Email;
                    Suplier.ContractDate = ContractDate;
                    Suplier.MoreInfo = MoreInfo;
                }
                DataProvider.Ins.DB.SaveChanges();

                //cách 1: cập nhật lại theo bảng đã cập nhật
                List = new ObservableCollection<Suplier>(DataProvider.Ins.DB.Supliers);
                // cách 2;  chuyển class Suplier kế thừa  BaseViewModel và Onchangeproperties      
                SelectedItem.DisplayName = DisplayName;
            });
        }
    }
}