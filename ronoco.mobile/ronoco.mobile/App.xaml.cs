using ronoco.mobile.view;
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
        //private NavigationPage launchScreen = new LaunchScreen();
        public App()
        {
            InitializeComponent();
            App.Current.MainPage = new LaunchScreen();
            Timer timer = new Timer();
            timer.Interval = 4000;
            timer.Enabled = true;
            timer.AutoReset = false;

            timer.Elapsed += Timer_Elapsed;

            void Timer_Elapsed(object sender, ElapsedEventArgs e)
            {
                Current.MainPage = new Onboarding();
            }
        }

        //    timer.Elapsed += Timer_Elapsed();
        //    public ela ElapsedEventHandler ElapsedHandler;

        //}

        //private ElapsedEventHandler Timer_Elapsed(object sender, ElapsedEventArgs e)
        //{
        //    ElapsedEventHandler handler = sender.ElapsedHandler;
        //    launchScreen.Navigation.PopAsync();
        //    launchScreen.Navigation.PushAsync(new NavigationPage(new Onboarding()));

        //    if (handler != null)
        //    {
        //        return handler(this, e);
        //    }
        //}

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
