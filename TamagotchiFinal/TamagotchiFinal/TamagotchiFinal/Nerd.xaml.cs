using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System.ComponentModel;


namespace TamagotchiFinal
{
    [XamlCompilation(XamlCompilationOptions.Compile)]

    public partial class Nerd : ContentPage
    {
        //Nerd Stats

        public float Hunger { get; set; } = 0.5f;
        public float Thirst { get; set; } = 0.5f;
        public float Boredom { get; set; } = 0.5f;
        public float Programming { get; set; } = 0.5f;
        public float Tired { get; set; } = 0.5f;

        public Nerd()
        {
            InitializeComponent();
        }

    }
}