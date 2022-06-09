using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Resolute_App
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class HomePage : ContentPage
    {
        public HomePage()
        {
            InitializeComponent();
        }

        private void Friends_Tapped(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Friends());
        }

        private void Tasks_Tapped(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Tasks());
        }
    }
}