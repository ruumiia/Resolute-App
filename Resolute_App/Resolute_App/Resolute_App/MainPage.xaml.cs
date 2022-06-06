using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Resolute_App
{
    public partial class MainPage : TabbedPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        //navigation page buttons
        private async void LoginPage_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Login());
        }

        private async void MessagingUI_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Messaging());
        }
    }
}
