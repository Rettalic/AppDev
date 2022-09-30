using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using ProgressRingControl.Forms.Plugin;


namespace TamagotchiFinal
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Bedroom1 : ContentPage
    {
        float Tired = 1;
        public Bedroom1(MainPage player)
        {
            BindingContext = this;
            player.Tired = Tired;
            InitializeComponent();
        }

        public void ButtonTired(object sender, EventArgs e)
        {
           Tired += 0.1f;

            if (Tired >= 1)
            {
                Tired = 1;
            }
        }

    }
}