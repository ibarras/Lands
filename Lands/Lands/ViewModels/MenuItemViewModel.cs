namespace Lands.ViewModels
{
    using System.Windows.Input;
    using GalaSoft.MvvmLight.Command;
    using Helpers;
    using Views;
    using Xamarin.Forms;

    public class MenuItemViewModel
    {
        public string Title
        {
            get;
            set;
        }

        public string Icon
        {
            get;
            set;
        }

        public string PageName
        {
            get;
            set;
        }

        public ICommand NavigateCommand
        {
            get
            {
                return new RelayCommand(Navigate);
            }
        }

        private void Navigate()
        {
            App.Master.IsPresented = false;

            if (this.PageName == "LoginPage")
            {
                Settings.Token = string.Empty;
                Settings.TokenType = string.Empty;
                Settings.IsRemembered = string.Empty;
                Application.Current.MainPage = new NavigationPage(new LoginPage());
            }
            else if (this.PageName == "MyProfilePage")
            {
                MainViewModel.GetInstance().MyProfile = new MyProfileViewModel();
                App.Navigator.PushAsync(new MyProfilePage());
            }
        }
    }
}