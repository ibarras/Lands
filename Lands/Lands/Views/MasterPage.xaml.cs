namespace Lands.Views
{
    using Xamarin.Forms;

    public partial class MasterPage : MasterDetailPage
    {
        public MasterPage()
        {
            InitializeComponent();
        }

		protected override void OnAppearing()
		{
			base.OnAppearing();
            App.Navigator = this.Navigator;
            App.Master = this;
		}
	}
}