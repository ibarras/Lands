namespace Lands.ViewModels
{
    using Services;
    using Models;
    using Xamarin.Forms;
    using Plugin.Media.Abstractions;

    public class MyProfileViewModel : BaseViewModel
    {
        #region Services
        private ApiService apiService;
        #endregion

        #region Attributes
        private bool isRunning;
        private bool isEnabled;
        private ImageSource imageSource;
        private MediaFile file;
        #endregion

        #region Properties
        public UserLocal User
        {
            get;
            set;
        }

        public ImageSource ImageSource
        {
            get { return this.imageSource; }
            set { SetValue(ref this.imageSource, value); }
        }

        public bool IsEnabled
        {
            get { return this.isEnabled; }
            set { SetValue(ref this.isEnabled, value); }
        }

        public bool IsRunning
        {
            get { return this.isRunning; }
            set { SetValue(ref this.isRunning, value); }
        }
        #endregion

        #region Constructors
        public MyProfileViewModel()
        {
            this.User = MainViewModel.GetInstance().User;
            this.ImageSource = this.User.ImageFullPath;
        }
        #endregion
    }
}