using ronoco.mobile.view;
using ronoco.mobile.viewmodel;
using System;
using System.Diagnostics;
using System.Threading.Tasks;
using System.Timers;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace ronoco.mobile
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            App.Current.MainPage = new LaunchScreen();
            Timer timer = new Timer();
            timer.Interval = 4000;
            timer.Enabled = true;
            timer.AutoReset = false;

            timer.Elapsed += Timer_Elapsed;            
        }

        void Timer_Elapsed(object sender, ElapsedEventArgs e)
        {
            OnboardingCarouselPage carousel = new OnboardingCarouselPage();
            // Onboarding onboarding = new Onboarding(0, carousel);
            App.Current.MainPage.Navigation.PushModalAsync(carousel, true);
        }

        protected override void OnStart()
        {
            // Handle when your app starts
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
