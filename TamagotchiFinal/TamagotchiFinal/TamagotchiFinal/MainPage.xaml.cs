using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using System.Timers;
using ProgressRingControl.Forms.Plugin;


namespace TamagotchiFinal
{
    public partial class MainPage : ContentPage
    {
        public float Mood { get; set; } = 1.0f;

        public float Hunger { get; set; }
        public float Thirst { get; set; }
        public float Boredom { get; set; }
        public float Programming { get; set; }
        public float Tired { get; set; }

        public string MoodImg => Mood switch
        {
            >= 0.9f => "Happy.png",
            >= 0.7f => "Oke.png",
            >= 0.4f => "NoGood.png",
            >= 0.0f => "Bad.png",
            _ => throw new Exception("Impossible")
        };


        public string test;
        public MainPage()
        {
            Hunger = player.Hunger;
            Thirst = player.Thirst;
            Boredom = player.Boredom;
            Programming = player.Programming;
            Tired = player.Tired;

            BindingContext = this;
            InitializeComponent();

            

            var timer = new Timer();
            timer.Interval = 1500;
            timer.AutoReset = true;
            timer.Elapsed += Timer_Elapsed;
            timer.Start();
        }

        private void Timer_Elapsed(object sender, ElapsedEventArgs e)
        {
            Console.WriteLine("Timer elapsed!");

            Device.BeginInvokeOnMainThread(() =>
            {
                Random rnd = new Random();
                int r = rnd.Next(1, 6);
                if(r == 6)
                {
                    Hunger -= 0.1f;
                    Thirst -= 0.1f;
                    Boredom -= 0.1f;
                    Programming -= 0.1f;
                    Tired -= 0.2f;

                    if (Hunger <= 0)  Hunger  = 0;
                    if (Thirst <= 0)  Thirst  = 0;
                    if (Boredom <= 0) Boredom = 0;
                    if (Programming <= 0) Programming = 0;
                    if (Tired <= 0)   Tired   = 0;
                }
                   
                if (r == 1) Hunger -= 0.1f;     if (Hunger <= 0)     Hunger = 0;
                if (r == 2) Thirst -= 0.1f;     if (Thirst <= 0)     Thirst = 0;
                if (r == 3) Boredom -= 0.1f;    if (Boredom <= 0)    Boredom= 0;
                if (r == 4) Programming-= 0.1f; if (Programming<= 0) Programming= 0;
                if (r == 5) Tired-= 0.1f;       if (Tired <= 0)      Tired = 0;

                Mood = (Hunger + Thirst + Boredom + Programming + Tired)/5.0f;

            });

        }
       



        public Nerd player { get; set; } = new Nerd
        {
            Hunger = 0.5f,
            Thirst = 0.5f,
            Boredom = 0.5f,
            Programming = 0.5f,
            Tired = 0.5f
        };
    
        public void ButtonKitchen(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Kitchen(player.Hunger, player.Thirst, player.Boredom, player.Programming, player.Tired));
        }

        public void ButtonBedroom(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Bedroom1(this));
        }

      


        public void ButtonThirst(object sender, EventArgs e)
        {
            Thirst += 0.1f;

            if (Thirst >= 1)
            {
                Thirst = 1;
            }
        }

        public void ButtonBoredom(object sender, EventArgs e)
        {
            Boredom += 0.1f;

            if (Boredom >= 1)
            {
                Boredom = 1;
            }
        }

        public void ButtonProgramm(object sender, EventArgs e)
        {
            Programming += 0.1f;

            if (Programming >= 1)
            {
                Programming = 1;
            }
        }

        public void ButtonTired(object sender, EventArgs e)
        {
            Tired += 0.1f;

            if (Tired >= 1)
            {
                Tired = 1;
            }
        }

        public void ButtonHunger(object sender, EventArgs e)
        {
            Hunger += 0.1f;

            if (Hunger >= 1)
            {
                Hunger = 1;
            }
        }
    }
}
