using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace RelexationApplication
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void btnRead_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new CategoryPage());
        }
    }
}
