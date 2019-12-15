using BlazorMobile.Common;
using BlazorMobile.Components;
using Bronco.Helpers;
using BlazorMobile.Services;

namespace Bronco
{
	public partial class App : BlazorApplication
    {
        public App()
        {
            InitializeComponent();

            ServiceRegistrationHelper.RegisterServices();

            WebApplicationFactory.SetHttpPort(8888);

            MainPage = new MainPage();
        }
    }
}
