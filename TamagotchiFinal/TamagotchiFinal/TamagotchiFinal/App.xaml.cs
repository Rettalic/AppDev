using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Xamarin.Essentials;


namespace TamagotchiFinal
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new MainPage());
        }

        protected override void OnStart()
        {
            var wakeTime = DateTime.Now;
            var sleepTime = Preferences.Get("SleepTime", DateTime.Now);

            TimeSpan timeAsleep = wakeTime - sleepTime;
            int timeSlept = (int)timeAsleep.TotalMilliseconds;
            Preferences.Set("TimeSlept", timeSlept);
        }

        protected override void OnSleep()
        {
            var sleepTime = DateTime.UtcNow;
            Preferences.Set("SleepTime", sleepTime);

        }

        protected override void OnResume()
        {
            var sleepTime = Preferences.Get("SleepTime", DateTime.Now);
            var wakeTime = DateTime.Now;

            TimeSpan timeAsleep = wakeTime - sleepTime;
            int timeSlept = (int)timeAsleep.TotalMilliseconds;
            Preferences.Set("TimeSlept", timeSlept);
        }
    }
}
