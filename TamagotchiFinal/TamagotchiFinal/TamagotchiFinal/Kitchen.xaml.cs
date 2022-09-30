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
    public partial class Kitchen : ContentPage
    {
        public float Hunger;
        public float Thirst;
        public float Boredom;
        public float Programming;
        public float Tired;

        public Kitchen(float _hunger, float _thirst, float _boredom, float _programming, float _tired)
        {
            BindingContext = this;
            Hunger      = _hunger;
            Thirst      = _thirst;
            Boredom     = _boredom;
            Programming = _programming;
            Tired       = _tired;

            InitializeComponent();
        }

        public void ButtonFood(object sender, EventArgs e)
        {
            Hunger += 0.1f;
            if(Hunger >= 1.0f)
            {
                Hunger = 1.0f;
            }
        }
        public void ButtonThirst(object sender, EventArgs e)
        {
            Thirst += 0.1f;
            if (Thirst >= 1.0f)
            {
                Thirst = 1.0f;
            }
        }
    }
}