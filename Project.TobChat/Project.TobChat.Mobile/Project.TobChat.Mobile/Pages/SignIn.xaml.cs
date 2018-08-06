using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Project.TobChat.Mobile.Pages
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class SignIn : ContentPage
	{
		public SignIn ()
		{
			InitializeComponent ();

		    switch (Device.RuntimePlatform)
		    {
                case Device.iOS:
                    Padding = new Thickness(0, 20, 0, 0);
                    break;

                case Device.Android:
                    Padding = new Thickness(0, 20, 0, 0);
                    break;

                case Device.WinPhone:
                    Padding = new Thickness(0, 20, 0, 0);
                    break;

                default:
                    Padding = new Thickness(0, 20, 0, 0);
                    break;
		    }
		}
	}
}