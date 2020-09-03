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
    public partial class Valgusfoor : ContentPage
    {
        public Valgusfoor()
        {
            InitializeComponent();
        }
        Random rnd = new Random();
        private void btn_Clicked(object sender, EventArgs e)
        {
            int c=rnd.Next(1, 4);
            if (c == 1)
            {
                pun.BackgroundColor = Color.FromRgb(255, 0, 0);
                kol.BackgroundColor = Color.Gray;
                roh.BackgroundColor = Color.Gray;
            }
            else if(c==2)
            {
                pun.BackgroundColor = Color.Gray;
                kol.BackgroundColor = Color.FromRgb(255, 255, 0);
                roh.BackgroundColor = Color.Gray;
            }
            else if (c == 3)
            {
                pun.BackgroundColor = Color.Gray;
                kol.BackgroundColor = Color.Gray;
                roh.BackgroundColor = Color.FromRgb(0, 255, 0);
            }
            else if (c == 4)
            {
                pun.BackgroundColor = Color.FromRgb(255, 0, 0);
                kol.BackgroundColor = Color.FromRgb(255, 255, 0);
                roh.BackgroundColor = Color.FromRgb(0, 255, 0);
            }
        }

        private void btn1_Clicked(object sender, EventArgs e)
        {
            pun.BackgroundColor = Color.FromRgb(100, 100, 100);
            kol.BackgroundColor = Color.Gray;
            roh.BackgroundColor = Color.FromHex("#aaaaa");
        }
    }
}