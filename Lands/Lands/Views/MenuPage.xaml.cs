namespace Lands.Views
{
    using ViewModels;
    using Xamarin.Forms;
    using Xamarin.Forms.Xaml;

	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class MenuPage : ContentPage
	{
		public MenuPage ()
		{
			InitializeComponent ();
		}

		protected override void OnAppearing()
		{
			base.OnAppearing();
            MainViewModel.GetInstance().RefreshUser();
		}
	}
}