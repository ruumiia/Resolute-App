using Resolute_App.MessagingUI;
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
    public partial class Messaging : ContentPage
    {
        public Messaging()
        {
            InitializeComponent();
        }

        private async void ChatUser1_Tapped(object sender, EventArgs e)
        {
            //tap feedback animation
            const int _animationTime = 50;
            try
            {
                var layout = (StackLayout)sender;
                await layout.FadeTo(0.5, _animationTime);
                await layout.FadeTo(1, _animationTime);
            }
            catch (Exception)
            {

            }
            await Navigation.PushAsync(new Chatbox());
        }
    }
}