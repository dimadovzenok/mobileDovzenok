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
    public partial class Valgusfoor2 : ContentPage
    {
        public Valgusfoor2()
        {
            //InitializeComponent();
            Label punane = new Label()
            {
                Text = "punane",
                TextColor = Color.White,
                FontSize = 30,
                FontAttributes = FontAttributes.Bold
            };
            Frame pun = new Frame()
            {
                BackgroundColor = Color.Red,
                Content = punane,
                CornerRadius = 90,
                Margin = new Thickness(80, 0, 80, 0)
            };

            Label kollane = new Label()
            {
                Text = "kollane",
                TextColor = Color.White,
                FontSize = 30,
                FontAttributes = FontAttributes.Bold
            };
            Frame kol = new Frame()
            {
                BackgroundColor = Color.Yellow,
                Content = kollane,
                CornerRadius = 90,
                Margin = new Thickness(80, 0, 80, 0)
            };
            Label roheline = new Label()
            {
                Text = "Roheline",
                TextColor = Color.White,
                FontSize = 30,
                FontAttributes = FontAttributes.Bold
            };
            Frame roh = new Frame()
            {
                BackgroundColor = Color.Green,
                Content = roheline,
                CornerRadius = 90,
                Margin = new Thickness(80, 0, 80, 0)
            };
            StackLayout stackLayout = new StackLayout()
            {
                Children = { pun, kol, roh }
            };
            //stackLayout.Orientation = StackOrientation.Horizontal;
            Content = stackLayout;
        }

        private void btn_Clicked(object sender, EventArgs e)
        {

        }

        private void btn1_Clicked(object sender, EventArgs e)
        {

        }
    }
}