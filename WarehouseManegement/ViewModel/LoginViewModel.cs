using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using WarehouseManegement.Model;

namespace WarehouseManegement.ViewModel
{
    public class LoginViewModel : BaseViewModel
    {       
        public bool IsLogin { get; set; }
        private string _username;
        public string Username { get=>_username; set { _username = value; OnPropertyChanged(); } }
        private string _password;
        public string Password { get=>_password; set { _password = value; OnPropertyChanged(); } }
        public ICommand LoginCommand { get; set; }       
        public ICommand PasswordChangedCommand { get; set; }       
        public ICommand CloseCommand { get; set; }       
        public LoginViewModel()
        {
            IsLogin= false;
            Password = "";
            Username = "";
            LoginCommand = new RelayCommand<Window>((p) => {return true; }, (p) =>
            {
                Login(p);
            });
            //password trên window không được phép binding do đó sử dụng command để cập nhật biến password theo sự thay đổi trên Window
            PasswordChangedCommand = new RelayCommand<PasswordBox>((p) => {return true; }, (p) =>
            {
                Password = p.Password;
            });
            CloseCommand = new RelayCommand<Window>((p) => {return true; }, (p) =>
            {
                IsLogin = false;
                p.Close();
            });            
        }
        void Login(Window wd)
        {
            if(wd == null) return;
            // check DB

            string password = CreateMD5(Base64Encode(Password));
            var accCount = DataProvider.Ins.DB.Users.Where(u => u.UserName == Username && u.Password == password).Count();
            if(accCount > 0)
            {
                IsLogin = true;
                wd.Close();
            }
            else
            {
                IsLogin = false;
                MessageBox.Show("Sai tài khoản mật khẩu");
            }
                
           
        }
        public static string Base64Encode(string plainText)
        {
            var plainTextBytes = System.Text.Encoding.UTF8.GetBytes(plainText);
            return System.Convert.ToBase64String(plainTextBytes);
        }
        public static string CreateMD5(string input)
        {
            // Use input string to calculate MD5 hash
            using (System.Security.Cryptography.MD5 md5 = System.Security.Cryptography.MD5.Create())
            {
                byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(input);
                byte[] hashBytes = md5.ComputeHash(inputBytes);
                 StringBuilder sb = new System.Text.StringBuilder();
                for (int i = 0; i < hashBytes.Length; i++)
                {
                    sb.Append(hashBytes[i].ToString("X2"));
                }
                return sb.ToString();
            }
        }
    }
}
