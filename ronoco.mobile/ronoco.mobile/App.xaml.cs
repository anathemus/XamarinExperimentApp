using ronoco.mobile.view;
using ronoco.mobile.viewmodel;
using System;
using System.Diagnostics;
using System.Threading.Tasks;
using System.Timers;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System.Linq;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace ronoco.mobile
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
        
            if (Device.RuntimePlatform == Device.iOS)
            {
               Thickness padding = new Thickness(0, 20);
            }

            LaunchScreen launchScreen = new LaunchScreen();
            NavigationPage.SetHasNavigationBar(launchScreen, false);
            NavigationPage navigationPage = new NavigationPage(launchScreen);
            

            // MainPage must be of type NavigationPage to enable Navigation Stack
            MainPage = navigationPage;
        }

        protected override void OnStart()
        {
            // Handle when your app starts
            // DO NOT USE Timer CLASS for iOS. 
            // Use Device.StartTimer instead.
            Device.StartTimer(new TimeSpan(0, 0, 3), () => {
                // do something in 3 seconds
                if (Device.RuntimePlatform == Device.iOS)
                {
                    Thickness padding = new Thickness(0, 5);
                    Onboarding onboarding = new Onboarding();
                    onboarding.Padding = padding;
                    NavigationPage.SetHasNavigationBar(onboarding, false);
                    MainPage.Navigation.PushAsync(onboarding);
                }
                else
                {
                    Onboarding onboarding = new Onboarding();
                    NavigationPage.SetHasNavigationBar(onboarding, false);
                    MainPage.Navigation.PushAsync(onboarding);
                }

                return false; // true runs again, or false to stop
            });
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
