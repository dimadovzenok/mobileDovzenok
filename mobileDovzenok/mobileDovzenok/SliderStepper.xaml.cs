using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace mobileDovzenok
{

    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SliderStepper : ContentPage
    {

        public SliderStepper()
        {
            InitializeComponent();
        }

    protected override void OnAppearing()
        {
            base.OnAppearing();
            
            Editor1.FontSize = Slider1.Value;
            Editor1.FontSize = Slider2.Value;
            Editor1.FontSize = Slider3.Value;
        }

        private void Slider1_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            if(e.NewValue > 0)
            {
                Editor1.FontSize = e.NewValue;
            }

        }
        private void Slider2_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            if (e.NewValue > 0)
            {
                Editor1.FontSize = e.NewValue;
            }

        }

        private void Slider3_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            if (e.NewValue > 0)
            {
                Editor1.FontSize = e.NewValue;
            }

        }
    }
}